using Guna.UI2.WinForms;
using NativeWifi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            GetDriveSize();
            GetPCInfo();
            GetWifiInfo();
            GetRamStorage();
            GetDisplayInfo();
        }

        public void GetDriveSize()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Fixed)
                {
                    if (drive.Name.Contains("C"))
                    {
                        SetDriveSize(drive, uiPgb_CDrive, UiLb_CDrive_Title, uiLb_CDrive);
                    }
                    else
                    {
                        SetDriveSize(drive, uiPgb_DDrive, UiLb_DDrive_Title, uiLb_DDrive);
                    }
                }
            }
            Console.WriteLine("The drive size has been loaded successfully.\n");
        }

        public void SetDriveSize(DriveInfo drive, Guna2ProgressBar pb, Label title, Label lb)
        {
            string driveName = string.Empty;
            string totalSize = string.Empty;
            string freeSize = string.Empty;
            string usage = string.Empty;

            try
            {
                driveName = drive.Name.Substring(0, 1).ToString();
                totalSize = Convert.ToInt32(drive.TotalSize / 1024 / 1024 / 1024).ToString();
                freeSize = Convert.ToInt32(drive.AvailableFreeSpace / 1024 / 1024 / 1024).ToString();
                usage = (Convert.ToInt32(totalSize) - Convert.ToInt32(freeSize)).ToString();

                pb.Maximum = Convert.ToInt32(totalSize);
                pb.Value = Convert.ToInt32(usage);

                title.Text = string.Format("Disk ({0}:)", driveName);
                title.AutoSize = true;

                lb.Text = string.Format("{0}GB of {1}GB available.", totalSize, freeSize);
                lb.AutoSize = true;

            }
            catch { }
            Console.WriteLine("You have successfully set the drive size.\n");
        }

        public void GetPCInfo()
        {
            string ComputerName = Environment.MachineName;
            computerName.Text = ComputerName;
            Console.WriteLine("Computer name has been loaded successfully.\n");

            string UserName = Environment.UserName;
            userName.Text = UserName;
            Console.WriteLine("User name has been loaded successfully.\n");

            string OS = Environment.OSVersion.ToString();
            os_name.Text = OS;
            Console.WriteLine("Operating System has been loaded successfully.\n");

            string OS_Platform = Environment.OSVersion.Platform.ToString();
            os_platform_name.Text = OS_Platform;
            Console.WriteLine("OS Platform has been loaded successfully.\n");

            string OS_Version = Environment.OSVersion.Version.ToString();
            os_version_version.Text = OS_Version;
            Console.WriteLine("OS Version has been loaded successfully.\n");

            if (Environment.Is64BitOperatingSystem == true)
            {
                os_bit_name.Text = "64 Bit";
                Console.WriteLine("[64 bit]OS BIT has been loaded successfully.\n");
            }
            else
            {
                os_bit_name.Text = "32 Bit";
                Console.WriteLine("[32 bit]OS BIT has been loaded successfully.\n");
            }

            ManagementObjectSearcher win32Proc = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj in win32Proc.Get())
            {
                string procName = obj["name"].ToString();
                label11.Text = procName;
                Console.WriteLine("CPU model name has been loaded successfully.\n");
            }

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            string graphicsCard = string.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        graphicsCard = property.Value.ToString();
                        graphic_card_name.Text = graphicsCard;
                        Console.WriteLine("The graphic card model name has been imported successfully.\n");
                    }
                }
            }


        }
        public void GetWifiInfo()
        {
            var wlanClient = new WlanClient();
            foreach (WlanClient.WlanInterface wlanInterface in wlanClient.Interfaces)
            {
                Wlan.WlanBssEntry[] wlanBssEntries = wlanInterface.GetNetworkBssList();
                foreach (Wlan.WlanBssEntry wlanBssEntry in wlanBssEntries)
                {
                    int rss = wlanBssEntry.rssi;
                    byte[] macAddr = wlanBssEntry.dot11Bssid;
                    var macAddrLen = (uint)macAddr.Length;

                    var str = new String[(int)macAddrLen];
                    for (int i = 0; i < macAddrLen; i++)
                    {
                        if (i == macAddrLen - 1)
                            str[i] = macAddr[i].ToString("X2");
                        else
                            str[i] = macAddr[i].ToString("X2") + ":";
                    }
                   
                    string mac = string.Join("", str);
                    label6.Text = string.Format("{0}", System.Text.ASCIIEncoding.ASCII.GetString(wlanBssEntry.dot11Ssid.SSID));
                    Console.WriteLine("WIFI information has been successfully loaded.\n");
                }
            }
        }
        //Error
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);
        public void GetRamStorage()
        {
            long memKb;
            GetPhysicallyInstalledSystemMemory(out memKb);
            label2.Text = ((memKb / 1024 / 1024) + "GB");
            Console.WriteLine("The RAM level has been successfully loaded.\n");
        }

        //Error
        public void GetDisplayInfo()
        {
            string screenWidth = Screen.PrimaryScreen.Bounds.Width.ToString();
            string screenHeight = Screen.PrimaryScreen.Bounds.Height.ToString();
            label4.Text = (screenWidth + "X" + screenHeight);
            foreach (var target in WindowsDisplayAPI.DisplayConfig.PathDisplayTarget.GetDisplayTargets())
            {
                label10.Text = (target.FriendlyName);
                Console.WriteLine("Display information was successfully loaded.\n");
            }

        }
    }
}
