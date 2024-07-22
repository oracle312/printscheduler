using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;
using System.Net;
using System.Net.Http;
using System.IO;

namespace PrintScheduler
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_setup_Click(object sender, EventArgs e)
        {
            try
            {
                using (TaskService ts = new TaskService())
                {
                    TaskDefinition td = ts.NewTask();

                    //일반
                    td.Principal.DisplayName = "디오시스템";
                    td.RegistrationInfo.Description = "잉크 막힘 방지를 위한 주기적 인쇄";
                    LogonTrigger login = new LogonTrigger();
                    td.Principal.UserId = String.Concat(Environment.UserDomainName, "\\", Environment.UserName);
                    td.Principal.LogonType = TaskLogonType.InteractiveToken;
                    td.Principal.RunLevel = TaskRunLevel.Highest;
                    td.Triggers.Add(login);
                    
                    

                    //조건
                    td.Settings.MultipleInstances = TaskInstancesPolicy.IgnoreNew;
                    td.Settings.DisallowStartIfOnBatteries = false;
                    td.Settings.StopIfGoingOnBatteries = false;
                    td.Settings.AllowHardTerminate = false;
                    td.Settings.StartWhenAvailable = false;
                    td.Settings.RunOnlyIfNetworkAvailable = false;
                    td.Settings.IdleSettings.StopOnIdleEnd = false;
                    td.Settings.IdleSettings.RestartOnIdle = false;

                    //설정
                    td.Settings.AllowDemandStart = false;
                    td.Settings.Enabled = true;
                    td.Settings.Hidden = false;
                    td.Settings.RunOnlyIfIdle = false;
                    td.Settings.ExecutionTimeLimit = TimeSpan.Zero;
                    td.Settings.Priority = System.Diagnostics.ProcessPriorityClass.High;
                    td.Settings.StartWhenAvailable = true;

                    //동작
                    td.Actions.Add(new ExecAction(@"mspaint"));

                    //등록
                    ts.RootFolder.RegisterTaskDefinition("오토 프린트", td);

                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            string taskName = "DIOSYSTEMprint";
            string executablePath = @"C:\DIO-SYSTEM\PrintJob.exe";
            string schedule = "WEEKLY";
            string startDay = "MON";
            string startTime = "13:38"; 

            string schtasksCommand = $"/create /tn \"{taskName}\" /tr \"{executablePath}\" /sc {schedule} /d {startDay} /st {startTime} /f";

            try
            {
                ProcessStartInfo processInfo = new ProcessStartInfo("schtasks", schtasksCommand);
                processInfo.RedirectStandardOutput = true;
                processInfo.UseShellExecute = false;
                processInfo.CreateNoWindow = true;

                Process process = new Process();
                process.StartInfo = processInfo;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                
                MessageBox.Show(output);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                
            }
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            string folder_path = @"C:\DIO-SYSTEM";
            DirectoryInfo di = new DirectoryInfo(folder_path);

            if(di.Exists == false)
            {
                di.Create();
            }
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://oracle312.dothome.co.kr/print_ver.txt");
            StreamReader reader = new StreamReader(stream);
            string readText = reader.ReadToEnd();

            String url = "http://oracle312.dothome.co.kr/PrintJob.exe";
            String url2 = "http://oracle312.dothome.co.kr/print.jpg";
            string content;
            string content2;
            using (HttpClient clients = new HttpClient())
            {
                content = clients.GetStringAsync(url).Result;
                //content2 = clients.GetStringAsync(url2).Result;
            }

            string dest = @"C:\DIO-SYSTEM\PrintJob.exe";
            string dest2 = @"C:\DIO-SYSTEM\print.jpg";
            File.WriteAllText(dest, content);
            //File.WriteAllText(dest2, content2);
            MessageBox.Show("세팅 완료 !!");
        }
    }
}
