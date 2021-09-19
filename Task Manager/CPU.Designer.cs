
namespace Task_Manager
{
    partial class CPU
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.storage_main_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cpuUsagePb = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.cpuUsageLabel = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ClockSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logic_pro_num = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.processor_number = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.core_number = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cpu_main_name = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.cpuTempTimer = new System.Windows.Forms.Timer(this.components);
            this.cpuUsagePb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.guna2CircleProgressBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // storage_main_title
            // 
            this.storage_main_title.AutoSize = true;
            this.storage_main_title.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storage_main_title.Location = new System.Drawing.Point(27, 27);
            this.storage_main_title.Name = "storage_main_title";
            this.storage_main_title.Size = new System.Drawing.Size(156, 26);
            this.storage_main_title.TabIndex = 3;
            this.storage_main_title.Text = "CPU Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPU Usage";
            // 
            // cpuUsagePb
            // 
            this.cpuUsagePb.BackColor = System.Drawing.Color.White;
            this.cpuUsagePb.Controls.Add(this.cpuUsageLabel);
            this.cpuUsagePb.FillThickness = 10;
            this.cpuUsagePb.Location = new System.Drawing.Point(306, 22);
            this.cpuUsagePb.Name = "cpuUsagePb";
            this.cpuUsagePb.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(124)))), ((int)(((byte)(206)))));
            this.cpuUsagePb.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(124)))), ((int)(((byte)(206)))));
            this.cpuUsagePb.ProgressThickness = 10;
            this.cpuUsagePb.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cpuUsagePb.ShadowDecoration.Parent = this.cpuUsagePb;
            this.cpuUsagePb.Size = new System.Drawing.Size(129, 128);
            this.cpuUsagePb.TabIndex = 6;
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuUsageLabel.Location = new System.Drawing.Point(37, 57);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(57, 19);
            this.cpuUsageLabel.TabIndex = 10;
            this.cpuUsageLabel.Text = "00:00%";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(17, 446);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(750, 26);
            this.guna2Separator1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 20;
            this.guna2CustomGradientPanel2.Controls.Add(this.ClockSpeed);
            this.guna2CustomGradientPanel2.Controls.Add(this.label5);
            this.guna2CustomGradientPanel2.Controls.Add(this.logic_pro_num);
            this.guna2CustomGradientPanel2.Controls.Add(this.label9);
            this.guna2CustomGradientPanel2.Controls.Add(this.processor_number);
            this.guna2CustomGradientPanel2.Controls.Add(this.label6);
            this.guna2CustomGradientPanel2.Controls.Add(this.core_number);
            this.guna2CustomGradientPanel2.Controls.Add(this.label7);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(17, 68);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(191, 384);
            this.guna2CustomGradientPanel2.TabIndex = 18;
            // 
            // ClockSpeed
            // 
            this.ClockSpeed.AutoSize = true;
            this.ClockSpeed.BackColor = System.Drawing.Color.Transparent;
            this.ClockSpeed.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockSpeed.Location = new System.Drawing.Point(11, 214);
            this.ClockSpeed.Name = "ClockSpeed";
            this.ClockSpeed.Size = new System.Drawing.Size(53, 23);
            this.ClockSpeed.TabIndex = 22;
            this.ClockSpeed.Text = "name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Basic Speed";
            // 
            // logic_pro_num
            // 
            this.logic_pro_num.AutoSize = true;
            this.logic_pro_num.BackColor = System.Drawing.Color.Transparent;
            this.logic_pro_num.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logic_pro_num.Location = new System.Drawing.Point(11, 150);
            this.logic_pro_num.Name = "logic_pro_num";
            this.logic_pro_num.Size = new System.Drawing.Size(53, 23);
            this.logic_pro_num.TabIndex = 20;
            this.logic_pro_num.Text = "name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Logical Processor";
            // 
            // processor_number
            // 
            this.processor_number.AutoSize = true;
            this.processor_number.BackColor = System.Drawing.Color.Transparent;
            this.processor_number.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processor_number.Location = new System.Drawing.Point(11, 91);
            this.processor_number.Name = "processor_number";
            this.processor_number.Size = new System.Drawing.Size(53, 23);
            this.processor_number.TabIndex = 16;
            this.processor_number.Text = "name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Process";
            // 
            // core_number
            // 
            this.core_number.AutoSize = true;
            this.core_number.BackColor = System.Drawing.Color.Transparent;
            this.core_number.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.core_number.Location = new System.Drawing.Point(11, 33);
            this.core_number.Name = "core_number";
            this.core_number.Size = new System.Drawing.Size(53, 23);
            this.core_number.TabIndex = 14;
            this.core_number.Text = "name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Core Number";
            // 
            // cpu_main_name
            // 
            this.cpu_main_name.AutoSize = true;
            this.cpu_main_name.BackColor = System.Drawing.Color.Transparent;
            this.cpu_main_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpu_main_name.Location = new System.Drawing.Point(243, 30);
            this.cpu_main_name.Name = "cpu_main_name";
            this.cpu_main_name.Size = new System.Drawing.Size(53, 23);
            this.cpu_main_name.TabIndex = 12;
            this.cpu_main_name.Text = "name";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 20;
            this.guna2CustomGradientPanel1.Controls.Add(this.chartCPU);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(227, 68);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(540, 384);
            this.guna2CustomGradientPanel1.TabIndex = 19;
            // 
            // chartCPU
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCPU.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCPU.Legends.Add(legend1);
            this.chartCPU.Location = new System.Drawing.Point(3, 10);
            this.chartCPU.Name = "chartCPU";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            this.chartCPU.Series.Add(series1);
            this.chartCPU.Size = new System.Drawing.Size(534, 362);
            this.chartCPU.TabIndex = 20;
            this.chartCPU.Text = "chart1";
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderRadius = 20;
            this.guna2CustomGradientPanel3.Controls.Add(this.guna2CircleProgressBar1);
            this.guna2CustomGradientPanel3.Controls.Add(this.label2);
            this.guna2CustomGradientPanel3.Controls.Add(this.cpuUsagePb);
            this.guna2CustomGradientPanel3.Controls.Add(this.label1);
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(17, 470);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.ShadowDecoration.Parent = this.guna2CustomGradientPanel3;
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(750, 192);
            this.guna2CustomGradientPanel3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPU Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "0";
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.BackColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Controls.Add(this.label3);
            this.guna2CircleProgressBar1.FillThickness = 10;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(90, 22);
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(124)))), ((int)(((byte)(206)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(124)))), ((int)(((byte)(206)))));
            this.guna2CircleProgressBar1.ProgressThickness = 10;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(129, 128);
            this.guna2CircleProgressBar1.TabIndex = 11;
            // 
            // cpuTempTimer
            // 
            this.cpuTempTimer.Tick += new System.EventHandler(this.cpuTempTimer_Tick);
            // 
            // CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.cpu_main_name);
            this.Controls.Add(this.storage_main_title);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Name = "CPU";
            this.Size = new System.Drawing.Size(789, 679);
            this.Load += new System.EventHandler(this.CPU_Load);
            this.cpuUsagePb.ResumeLayout(false);
            this.cpuUsagePb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            this.guna2CircleProgressBar1.ResumeLayout(false);
            this.guna2CircleProgressBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storage_main_title;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cpuUsagePb;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label cpuUsageLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Diagnostics.PerformanceCounter pCPU;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label core_number;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cpu_main_name;
        private System.Windows.Forms.Label processor_number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label logic_pro_num;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private System.Windows.Forms.Label ClockSpeed;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer cpuTempTimer;
    }
}
