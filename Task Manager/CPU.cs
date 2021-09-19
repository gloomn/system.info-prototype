using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class CPU : UserControl
    {
        private Thread cpuThread;
        private double[] cpuArray = new double[30];

        public CPU()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        //live update cpu usage
        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            cpuUsagePb.Value = (int)fcpu;
            cpuUsageLabel.Text = string.Format("{0:0.00}%", fcpu);
            chartCPU.Series["CPU"].Points.AddY(fcpu);
        }

        //load all the cpu information
        private void CPU_Load(object sender, EventArgs e)
        {
            timer1.Start();
            cpu_core_number();
            cpu_name();
            cpu_processor_number();
            logical_processor_number();
            startCpuThread();
            currentClockSpeed();
        }





        //live update cpu usage chart not accumulate, floating chart
        private void getPerformanceCounters()
        {
            var cpuPerfCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            while(true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPerfCounter.NextValue(), 0);
                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);
                if(chartCPU.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
                }
                else
                {

                }
                Thread.Sleep(1000);//thread 1 second
            }
        }

        private void UpdateCpuChart()
        {
            chartCPU.Series["CPU"].Points.Clear();
            for(int i = 0; i < cpuArray.Length -1; ++i)
            {
                chartCPU.Series["CPU"].Points.AddY(cpuArray[i]);
            }
        }

        //start live chart thread
        private void startCpuThread()
        {
            cpuThread = new Thread(new ThreadStart(this.getPerformanceCounters));
            cpuThread.IsBackground= true;
            cpuThread.Start();
        }

        //get cpu name
        private void cpu_name()
        {
            ManagementObjectSearcher win32Proc = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj in win32Proc.Get())
            {
                string procName = obj["name"].ToString();
                cpu_main_name.Text = procName;
            }
        }

        //get cpu core number
        private void cpu_core_number()
        {
            int coreCount = 0;
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
            {
                coreCount += int.Parse(item["NumberOfCores"].ToString());
            }
            core_number.Text = Convert.ToString(coreCount) + " Core";
        }

        //get cpu processor number
        private void cpu_processor_number()
        {
            Process[] allProc = Process.GetProcesses();
            processor_number.Text = Convert.ToString(allProc.Length);
        }

        //get cpu logical processor number
        private void logical_processor_number()
        {
            logic_pro_num.Text = Convert.ToString(Environment.ProcessorCount);
        }

        //CPU Max Clock Speed
        uint currentsp, Maxsp;

        private void cpuTempTimer_Tick(object sender, EventArgs e)
        {

        }

        private void currentClockSpeed()
        {
            var searcher = new ManagementObjectSearcher(
            "select MaxClockSpeed from Win32_Processor");
            foreach (var item in searcher.Get())
            {
                var clockSpeed = 0.001f * (uint)item["MaxClockSpeed"];
                ClockSpeed.Text = Convert.ToString(clockSpeed) + " GHz";
            }
        }
    }
}
