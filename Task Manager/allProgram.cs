using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Task_Manager
{
    public partial class allProgram : UserControl
    {
        public allProgram()
        {
            InitializeComponent();
            get_programs();
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

        private void get_programs()
        {
            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {

                            var displayName = sk.GetValue("DisplayName");
                            var size = sk.GetValue("EstimatedSize");

                            ListViewItem item;
                            if (displayName != null)
                            {
                                if (size != null)
                                    item = new ListViewItem(new string[] {displayName.ToString(),
                                                       size.ToString()});
                                else
                                    item = new ListViewItem(new string[] { displayName.ToString() });
                                lstDisplayHardware.Items.Add(item);
                            }
                        }
                        catch (Exception ex)
                        { }
                    }
                }
                label1.Text += " (" + lstDisplayHardware.Items.Count.ToString() + ")";
            }
        }
    }
}
