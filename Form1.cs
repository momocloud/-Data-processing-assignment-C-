using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 数据处理
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        public Data dataStore;
        public bool isFindBadValueHere;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddData_Click(object sender, EventArgs e)
        {
            if (dataShow.Items.Count >= 20)
            {
                writeInInfrmationLabel.Text = "目前最多支持20个数据~";
                return;
            }// 超出判断
            try
            {
                double dataWriteIn = Convert.ToDouble(writeData.Text);
                bool scroll = false;
                if (this.dataShow.TopIndex == this.dataShow.Items.Count - (int)(this.dataShow.Height / this.dataShow.ItemHeight))
                {
                    scroll = true;
                }
                dataShow.Items.Add(dataWriteIn);
                if (scroll)
                {
                    this.dataShow.TopIndex = this.dataShow.Items.Count - (int)(this.dataShow.Height / this.dataShow.ItemHeight);
                }
                writeData.Text = "";
                writeInInfrmationLabel.Text = "录入成功，目前已录入" + dataShow.Items.Count.ToString() + "个数据";
            }// 合法输入录入数据动作
            catch
            {
                writeData.Text = "";
                writeInInfrmationLabel.Text = "输入非法数据！请重新输入！";
            }// 非法输入异常处理
        }
        // 按下增加数据按钮时执行动作动作

        private void DelData_Click(object sender, EventArgs e)
        {
            if (dataShow.SelectedItem != null)
            {
                bool scroll = false;
                if (this.dataShow.TopIndex == this.dataShow.Items.Count - (int)(this.dataShow.Height / this.dataShow.ItemHeight))
                {
                    scroll = true;
                }
                dataShow.Items.RemoveAt(dataShow.SelectedIndex);
                if (scroll)
                {
                    this.dataShow.TopIndex = this.dataShow.Items.Count - (int)(this.dataShow.Height / this.dataShow.ItemHeight);
                }
                writeInInfrmationLabel.Text = "删除成功，目前已录入" + dataShow.Items.Count.ToString() + "个数据";
            }
        }
        // 按下删除数据按钮执行删除选定数据动作

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (dataShow.Items.Count < 3 && fiducialProbability.SelectedItem != null)
            {
                writeInInfrmationLabel.Text = "数据不足，请至少输入三个数据！";
                return;
            }
            else if (dataShow.Items.Count >= 3 && fiducialProbability.SelectedItem == null)
            {
                writeInInfrmationLabel.Text = "未选择置信概率！";
                return;
            }
            else if (dataShow.Items.Count < 3 && fiducialProbability.SelectedItem == null)
            {
                writeInInfrmationLabel.Text = "数据不足，请至少输入三个数据！且未选择置信概率！";
                return;
            }
            // 判断非法条件
            ChangeDataStore();// 数据存储实例化
        }
        // 按下开始判断按钮动作

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
            Application.Restart();
        }
        // 按下重启按钮重新启动程序实现重置属性

        private void WriteData_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AddData_Click(sender, e);
            }
        }
        // 文本输入框回车动作，调用增加数据按钮按下动作，实现回车录入数据

        public void ChangeDataStore()
        {
            List<double> dataWaitIn = new List<double>();
            foreach (double index in dataShow.Items)
            {
                dataWaitIn.Add(Convert.ToDouble(index));
            }
            dataStore = new Data(dataWaitIn, Convert.ToDouble(fiducialProbability.Text));
            aveShow.Text = Math.Round(dataStore.average, 4).ToString();
            seShow.Text = Math.Round(dataStore.se, 4).ToString();
        }
        // 实例化数据，实现数据存储处理，同时显示均值和偏差

        private void FindBadValue_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataStore.judgeBadValueHere)
                {
                    warnInformationLabel.Text = "存在坏值！是第" + Convert.ToString(dataStore.maximumPosition + 1) + "个数据，已选中！";
                    dataShow.SelectedIndex = (dataStore.maximumPosition); // 选中坏值
                }
                else
                {
                    warnInformationLabel.Text = "恭喜！不存在坏值了呢~~";
                }
                isFindBadValueHere = true;
            } // 合法条件坏值判断
            catch
            {
                warnInformationLabel.Text = "没有数据进入呢~是不是没有开始处理过？";
            } // 非法条件异常处理
        }
        // 寻找坏值

        private void RemoveBadValue_Click(object sender, EventArgs e)
        {
            if (dataStore != null)
            {
                if (isFindBadValueHere)
                {
                    if (dataStore.judgeBadValueHere)
                    {
                        if (dataShow.Items.Count > 3)
                        {
                            warnInformationLabel.Text = "坏值去除完成！请重新寻找坏值~";
                            try { dataShow.Items.RemoveAt(dataStore.maximumPosition); }
                            catch { warnInformationLabel.Text = "?异常操作哦！"; return; }
                            ChangeDataStore();
                            isFindBadValueHere = false;
                        }
                        else
                        {
                            warnInformationLabel.Text = "数据太少，已经不能再删除了~";
                        }
                    }
                    else
                    {
                        warnInformationLabel.Text = "没有坏值可以删呢~";
                    }
                }
                else
                {
                    warnInformationLabel.Text = "要重新寻找坏值哦~";
                }
            }
            else
            {
                warnInformationLabel.Text = "没有数据进入呢~是不是没有开始处理过？";
            }
        }
        // 判断合法条件与去除坏值

        private void JudgeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataStore.periodicity && dataStore.progressive)
                {
                    findInformationLabel.Text = "存在周期性误差，存在累进性误差";
                }
                else if (!dataStore.periodicity && dataStore.progressive)
                {
                    findInformationLabel.Text = "存在周期性误差，不存在累进性误差";
                }
                else if (dataStore.periodicity && !dataStore.progressive)
                {
                    findInformationLabel.Text = "不存在周期性误差，存在累进性误差";
                }
                else
                {
                    findInformationLabel.Text = "不存在周期性误差，不存在累进性误差";
                }
                confidenceInterval.Text = dataStore.standardDeviation[0].ToString("f3") + "~" + dataStore.standardDeviation[1].ToString("f3");
            } // 合法条件判断误差
            catch
            {
                findInformationLabel.Text = "没有数据哦~是不是没有处理过~";
            } // 非法条件处理异常
        }
        // 误差判断
    }


    public class Data
    {
        //data, sum, average
        private double[] _data;
        public double[] data
        {
            get { return _data; }

        }
        // 当前存储的数据表，只读属性


        public Data(List<Double> dataIn, double fiducialProbability)
        {
            _data = dataIn.ToArray();
            _fiducialProbabilityIn = fiducialProbability;
            _sum = 0;
            _average = 0;
            _se = 0;
            _absArray = new double[_data.Length];
            _disArray = new double[_data.Length];
            _standardDeviation = new double[2];

            for (int index = 0; index < _data.Length; index++)
            {
                _sum += _data[index];
            }
            //sum

            _average = _sum / _data.Length;
            //average

            double ave2 = 0;
            for (int index = 0; index < _data.Length; index++)
            {
                ave2 += Math.Pow(_data[index], 2);
            }
            _se = Math.Pow(((ave2) - _data.Length * Math.Pow(_average, 2)) / (_data.Length - 1), 0.5);
            //se

            for (int index = 0; index < _data.Length; index++)
            {
                _absArray[index] = Math.Abs(_data[index] - _average);
            }
            //abs

            for (int index = 0; index < _data.Length; index++)
            {
                _disArray[index] = _data[index] - _average;
            }
            //dis

            double perResult = 0;
            switch (_data.Length % 2)
            {
                case 0:
                    double leftSumEven = 0;
                    for (int index = 0; index <= (_data.Length / 2 - 1); index++)
                    {
                        leftSumEven += _disArray[index];
                    }

                    double rightsumEven = 0;
                    for (int index = _data.Length / 2; index <= _data.Length - 1; index++)
                    {
                        rightsumEven += _disArray[index];
                    }
                    perResult = Math.Abs(leftSumEven - rightsumEven);
                    break;

                case 1:
                    double leftSumOdd = 0;
                    for (int index = 0; index <= (_data.Length - 1) / 2; index++)
                    {
                        leftSumOdd += _disArray[index];
                    }

                    double rightSumOdd = 0;
                    for (int index = (_data.Length + 1) / 2; index <= _data.Length - 1; index++)
                    {
                        rightSumOdd += _disArray[index];
                    }
                    perResult = Math.Abs(leftSumOdd - rightSumOdd);
                    break;
            }
            if (perResult > _absArray[maximumPosition])
            {
                _periodicity = true;
            }
            else
            {
                _periodicity = false;
            }
            //per

            double proResult = 0;
            for (int index = 0; index < _disArray.Length - 1; index++)
            {
                proResult += Math.Abs(_disArray[index] * _disArray[index + 1]);
            }
            double proStand = Math.Pow(_disArray.Length - 1, 0.5) * Math.Pow(_se, 2);
            if (proResult > proStand)
            {
                _progressive = true;
            }
            else
            {
                _progressive = false;
            }
            //pro

            double standardDeviation = _se / Math.Pow(_data.Length, 0.5);
            double sStand;
            switch (fiducialProbability)
            {
                case 90:
                    sStand = Concrsis.concrisis900[getPosition(_data.Length)];
                    break;
                case 95:
                    sStand = Concrsis.concrisis950[getPosition(_data.Length)];
                    break;
                case 97.5:
                    sStand = Concrsis.concrisis975[getPosition(_data.Length)];
                    break;
                case 99:
                    sStand = Concrsis.concrisis990[getPosition(_data.Length)];
                    break;
                case 99.5:
                    sStand = Concrsis.concrisis995[getPosition(_data.Length)];
                    break;
                default:
                    sStand = 0;
                    break;
            }
            _standardDeviation[0] = _average - standardDeviation * sStand;
            _standardDeviation[1] = _average + standardDeviation * sStand;
        }
        // 实例初始化，传入数据计算各只读属性


        private double _fiducialProbabilityIn;
        // 置信概率，私有属性

        private double _sum;
        public double sum
        {
            get { return _sum; }
        }
        // 和，只读属性

        private double _average;
        public double average
        {
            get { return _average; }
        }
        // 均值，只读属性

        private double _se;
        public double se
        {
            get { return _se; }
        }
        // 标准偏差估计值，只读属性

        private double[] _absArray;

        private double[] absArray
        {
            get { return _absArray; }
        }
        // 与均值相减的绝对值，只读属性

        public int maximumPosition
        {
            get
            {
                int position = 0;
                for (int index = 0; index < _data.Length; index++)
                {
                    if (_absArray[index] >= _absArray[position])
                    {
                        position = index;
                    }
                }
                return position;
            }
        }
        // 均值偏差最大的数所在下标，只读属性

        public bool judgeBadValueHere
        {
            get
            {
                bool badValueHere = false;
                double gStand;
                switch (_fiducialProbabilityIn)
                {
                    case 90:
                        gStand = Crisis.crisis900[getPosition(_data.Length)];
                        break;
                    case 95:
                        gStand = Crisis.crisis950[getPosition(_data.Length)];
                        break;
                    case 97.5:
                        gStand = Crisis.crisis975[getPosition(_data.Length)];
                        break;
                    case 99:
                        gStand = Crisis.crisis990[getPosition(_data.Length)];
                        break;
                    case 99.5:
                        gStand = Crisis.crisis995[getPosition(_data.Length)];
                        break;
                    default:
                        gStand = 0;
                        break;
                }
                if (Math.Abs(_data[maximumPosition] - _average) > gStand * _se)
                {
                    badValueHere = true;
                }
                return badValueHere;
            }
        }
        // 是否存在坏值判断，只读属性

        private double[] _disArray;

        public double[] disArray
        {
            get { return _disArray; }
        }

        private bool _periodicity;
        // 与均值做差数组，只读属性

        public bool periodicity
        {
            get { return _periodicity; }
        }
        // 存在周期性误差标志，只读属性


        private bool _progressive;

        public bool progressive
        {
            get { return _progressive; }
        }
        // 存在累进性误差标志，只读属性

        private int getPosition(int original)
        {
            return original - 3;
        }
        // 数据数量转为判据下标，私有方法

        private double[] _standardDeviation;

        public double[] standardDeviation
        {
            get { return _standardDeviation; }
        }
        // 置信区间，两位数组，0存左1存右，只读属性

    }
    // 当前数据存储类
    // 公共类，需要实例化，只有一个可写数据


    public class Crisis
    {
        public static double[] crisis900 = new double[18] { 1.148, 1.425, 1.602, 1.729, 1.828, 1.909, 1.977, 2.036, 2.088, 2.134, 2.175, 2.213, 2.247, 2.279, 2.309, 2.335, 2.361, 2.385 };
        public static double[] crisis950 = new double[18] { 1.153, 1.463, 1.672, 1.822, 1.938, 2.032, 2.110, 2.176, 2.234, 2.285, 2.331, 2.371, 2.409, 2.443, 2.475, 2.501, 2.532, 2.557 };
        public static double[] crisis975 = new double[18] { 1.155, 1.481, 1.715, 1.887, 2.020, 2.126, 2.215, 2.290, 2.355, 2.412, 2.462, 2.507, 2.549, 2.585, 2.620, 2.651, 2.681, 2.709 };
        public static double[] crisis990 = new double[18] { 1.155, 1.481, 1.715, 1.887, 2.020, 2.126, 2.215, 2.290, 2.355, 2.412, 2.462, 2.507, 2.549, 2.585, 2.620, 2.650, 2.681, 2.709 };
        public static double[] crisis995 = new double[18] { 1.155, 1.496, 1.764, 1.973, 2.139, 2.274, 2.387, 2.482, 2.564, 2.636, 2.699, 2.755, 2.806, 2.852, 2.894, 2.932, 2.968, 3.001 };
    }
    // 数据表，格拉布斯准则表
    // 内部全局静态属性，不需要实例化

    public class Concrsis
    {
        public static double[] concrisis900 = new double[18] { 2.920, 2.353, 2.132, 1.943, 1.895, 1.860, 1.833, 1.812, 1.796, 1.782, 1.771, 1.761, 1.753, 1.746, 1.740, 1.734, 1.729, 1.725 };
        public static double[] concrisis950 = new double[18] { 4.303, 3.182, 2.776, 2.571, 2.447, 2.365, 2.306, 2.262, 2.228, 2.201, 2.179, 2.160, 2.145, 2.131, 2.120, 2.110, 2.101, 2.093 };
        public static double[] concrisis975 = new double[18] { 6.205, 4.177, 3.495, 3.163, 2.969, 2.841, 2.752, 2.685, 2.634, 2.593, 2.560, 2.533, 2.510, 2.490, 2.473, 2.458, 2.445, 2.433 };
        public static double[] concrisis990 = new double[18] { 9.925, 5.841, 4.604, 4.032, 3.707, 3.499, 3.355, 3.250, 3.169, 3.106, 3.055, 3.012, 2.977, 2.947, 2.921, 2.898, 2.878, 2.861 };
        public static double[] concrisis995 = new double[18] { 14.089, 7.453, 5.598, 4.773, 4.317, 4.029, 3.833, 3.690, 3.581, 3.497, 3.428, 3.372, 3.326, 3.286, 3.252, 3.222, 3.197, 3.174 };
    }
    // 数据表，马力科夫判据
    // 内部全局静态属性，不需要实例化
}
