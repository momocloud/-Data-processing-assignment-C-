namespace 数据处理
{
    partial class Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.dataShow = new System.Windows.Forms.ListBox();
            this.addData = new System.Windows.Forms.Button();
            this.delData = new System.Windows.Forms.Button();
            this.writeData = new System.Windows.Forms.TextBox();
            this.writeInInfrmationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fiducialProbability = new System.Windows.Forms.ComboBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.aveShow = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seShow = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.confidenceInterval = new System.Windows.Forms.Label();
            this.findInformationLabel = new System.Windows.Forms.Label();
            this.warnInformationLabel = new System.Windows.Forms.Label();
            this.removeBadValue = new System.Windows.Forms.Button();
            this.findBadValue = new System.Windows.Forms.Button();
            this.judgeBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataShow
            // 
            this.dataShow.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataShow.FormattingEnabled = true;
            this.dataShow.ItemHeight = 20;
            this.dataShow.Location = new System.Drawing.Point(55, 50);
            this.dataShow.Name = "dataShow";
            this.dataShow.Size = new System.Drawing.Size(306, 264);
            this.dataShow.TabIndex = 0;
            // 
            // addData
            // 
            this.addData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addData.Location = new System.Drawing.Point(55, 450);
            this.addData.Name = "addData";
            this.addData.Size = new System.Drawing.Size(91, 32);
            this.addData.TabIndex = 1;
            this.addData.Text = "增加数据";
            this.addData.UseVisualStyleBackColor = true;
            this.addData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // delData
            // 
            this.delData.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delData.Location = new System.Drawing.Point(270, 450);
            this.delData.Name = "delData";
            this.delData.Size = new System.Drawing.Size(91, 32);
            this.delData.TabIndex = 2;
            this.delData.Text = "删除数据";
            this.delData.UseVisualStyleBackColor = true;
            this.delData.Click += new System.EventHandler(this.DelData_Click);
            // 
            // writeData
            // 
            this.writeData.Location = new System.Drawing.Point(55, 399);
            this.writeData.Name = "writeData";
            this.writeData.Size = new System.Drawing.Size(306, 25);
            this.writeData.TabIndex = 3;
            this.writeData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WriteData_KeyUp);
            // 
            // writeInInfrmationLabel
            // 
            this.writeInInfrmationLabel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.writeInInfrmationLabel.Location = new System.Drawing.Point(55, 332);
            this.writeInInfrmationLabel.Name = "writeInInfrmationLabel";
            this.writeInInfrmationLabel.Size = new System.Drawing.Size(306, 50);
            this.writeInInfrmationLabel.TabIndex = 4;
            this.writeInInfrmationLabel.Text = "请在下面输入数据~";
            this.writeInInfrmationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(62, 513);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "置信概率：";
            // 
            // fiducialProbability
            // 
            this.fiducialProbability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fiducialProbability.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fiducialProbability.FormattingEnabled = true;
            this.fiducialProbability.Items.AddRange(new object[] {
            "90",
            "95",
            "97.5",
            "99",
            "99.5"});
            this.fiducialProbability.Location = new System.Drawing.Point(242, 510);
            this.fiducialProbability.Name = "fiducialProbability";
            this.fiducialProbability.Size = new System.Drawing.Size(119, 28);
            this.fiducialProbability.TabIndex = 6;
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startBtn.Location = new System.Drawing.Point(452, 399);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(309, 105);
            this.startBtn.TabIndex = 7;
            this.startBtn.Text = "开始处理";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(447, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "均值：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // aveShow
            // 
            this.aveShow.AutoSize = true;
            this.aveShow.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aveShow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aveShow.Location = new System.Drawing.Point(692, 50);
            this.aveShow.Name = "aveShow";
            this.aveShow.Size = new System.Drawing.Size(69, 25);
            this.aveShow.TabIndex = 9;
            this.aveShow.Text = "待处理";
            this.aveShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(447, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "标准偏差估计值：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // seShow
            // 
            this.seShow.AutoSize = true;
            this.seShow.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.seShow.Location = new System.Drawing.Point(692, 126);
            this.seShow.Name = "seShow";
            this.seShow.Size = new System.Drawing.Size(69, 25);
            this.seShow.TabIndex = 11;
            this.seShow.Text = "待处理";
            this.seShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(480, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 161);
            this.label5.TabIndex = 12;
            this.label5.Text = "请至少输入三个数据，最多只支持20个数据。";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restartBtn
            // 
            this.restartBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.restartBtn.Location = new System.Drawing.Point(1024, 495);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(123, 43);
            this.restartBtn.TabIndex = 13;
            this.restartBtn.Text = "重启";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.RestartBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(831, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "置信区间：";
            // 
            // confidenceInterval
            // 
            this.confidenceInterval.AutoSize = true;
            this.confidenceInterval.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confidenceInterval.Location = new System.Drawing.Point(1019, 50);
            this.confidenceInterval.Name = "confidenceInterval";
            this.confidenceInterval.Size = new System.Drawing.Size(69, 25);
            this.confidenceInterval.TabIndex = 15;
            this.confidenceInterval.Text = "待判断";
            this.confidenceInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // findInformationLabel
            // 
            this.findInformationLabel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findInformationLabel.Location = new System.Drawing.Point(836, 226);
            this.findInformationLabel.Name = "findInformationLabel";
            this.findInformationLabel.Size = new System.Drawing.Size(311, 91);
            this.findInformationLabel.TabIndex = 16;
            this.findInformationLabel.Text = "请去掉所有坏值后判断";
            this.findInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // warnInformationLabel
            // 
            this.warnInformationLabel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warnInformationLabel.Location = new System.Drawing.Point(836, 126);
            this.warnInformationLabel.Name = "warnInformationLabel";
            this.warnInformationLabel.Size = new System.Drawing.Size(311, 82);
            this.warnInformationLabel.TabIndex = 17;
            this.warnInformationLabel.Text = "点击下面按钮查找坏值";
            this.warnInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeBadValue
            // 
            this.removeBadValue.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.removeBadValue.Location = new System.Drawing.Point(1024, 399);
            this.removeBadValue.Name = "removeBadValue";
            this.removeBadValue.Size = new System.Drawing.Size(123, 43);
            this.removeBadValue.TabIndex = 18;
            this.removeBadValue.Text = "去除坏值";
            this.removeBadValue.UseVisualStyleBackColor = true;
            this.removeBadValue.Click += new System.EventHandler(this.RemoveBadValue_Click);
            // 
            // findBadValue
            // 
            this.findBadValue.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.findBadValue.Location = new System.Drawing.Point(846, 398);
            this.findBadValue.Name = "findBadValue";
            this.findBadValue.Size = new System.Drawing.Size(123, 44);
            this.findBadValue.TabIndex = 19;
            this.findBadValue.Text = "寻找坏值";
            this.findBadValue.UseVisualStyleBackColor = true;
            this.findBadValue.Click += new System.EventHandler(this.FindBadValue_Click);
            // 
            // judgeBtn
            // 
            this.judgeBtn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.judgeBtn.Location = new System.Drawing.Point(846, 495);
            this.judgeBtn.Name = "judgeBtn";
            this.judgeBtn.Size = new System.Drawing.Size(123, 43);
            this.judgeBtn.TabIndex = 20;
            this.judgeBtn.Text = "开始判断";
            this.judgeBtn.UseVisualStyleBackColor = true;
            this.judgeBtn.Click += new System.EventHandler(this.JudgeBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(522, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 27);
            this.label6.TabIndex = 21;
            this.label6.Text = "PoweredBy: 王鲲宇";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 592);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.judgeBtn);
            this.Controls.Add(this.findBadValue);
            this.Controls.Add(this.removeBadValue);
            this.Controls.Add(this.warnInformationLabel);
            this.Controls.Add(this.findInformationLabel);
            this.Controls.Add(this.confidenceInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aveShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.dataShow);
            this.Controls.Add(this.fiducialProbability);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.writeInInfrmationLabel);
            this.Controls.Add(this.writeData);
            this.Controls.Add(this.delData);
            this.Controls.Add(this.addData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox dataShow;
        private System.Windows.Forms.Button addData;
        private System.Windows.Forms.Button delData;
        private System.Windows.Forms.TextBox writeData;
        private System.Windows.Forms.Label writeInInfrmationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fiducialProbability;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aveShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label seShow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label confidenceInterval;
        private System.Windows.Forms.Label findInformationLabel;
        private System.Windows.Forms.Label warnInformationLabel;
        private System.Windows.Forms.Button removeBadValue;
        private System.Windows.Forms.Button findBadValue;
        private System.Windows.Forms.Button judgeBtn;
        private System.Windows.Forms.Label label6;
    }
}

