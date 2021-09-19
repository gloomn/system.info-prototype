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
    public partial class GPU : UserControl
    {
        private Thread gpuThread;
        private double[] gpuArray = new double[30];
        public GPU()
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
        private void GPU_Load(object sender, EventArgs e)
        {
            GPUName();
            GPU_Device_ID();
        }
        
        private void GPUName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            string graphicsCard = string.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        graphicsCard = property.Value.ToString();
                        graphic_main_name.Text = graphicsCard;
                        Console.WriteLine("The graphic card model name has been imported successfully.\n");
                    }
                }
            }
        }

        private void GPU_Device_ID()
        {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    device_id.Text = obj["Name"]+"";
                }
            }
        }

        private void GPU_Driver_Version()
        {
            using (var searcher = new ManagementObjectSearcher("select * from Win32_VideoController"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    driver_version.Text = obj["DriverVersion"] + "";
                }
            }
        }


    }
}
