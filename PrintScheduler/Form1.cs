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
using System.Runtime.InteropServices;
using WinHttp;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

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
            groupBox2.Enabled = false;
            btn_schedule.Enabled = false;
            btn_schedule.Text = "초기화를 먼저 눌러주세요 !!";
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
            DirectoryInfo folder = new DirectoryInfo(folder_path);
            if(folder.Exists == false)
            {
                folder.Create();
            }
            string url = "";
            string image_url = "";
            string outputPath = "C:\\DIO-SYSTEM\\PrintJob.exe";
            string imageOutputPath = "c:\\DIO-SYSTEM\\print.jpg";

            try
            {
                DownloadFile(url, outputPath);
                DownloadFile(image_url, imageOutputPath);
                groupBox2.Enabled = true;
                btn_schedule.Enabled = true;
                btn_schedule.Text = "등록하기";
                btn_init.Enabled = false;
                MessageBox.Show("세팅 완료 !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                //Console.WriteLine("Error downloading file: " + ex.Message);
            }


            /*string folder_path = @"C:\DIO-SYSTEM";
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
        }*/
        }

        static void DownloadFile(string url, string outputPath)
        {
            WinHttpRequest request = new WinHttpRequest();
            request.Open("GET", url, false);
            request.Send();

            if (request.Status == 200)
            {
                byte[] responseBody = (byte[])request.ResponseBody;
                File.WriteAllBytes(outputPath, responseBody);
            }
            else
            {
                throw new Exception("HTTP error: " + request.Status);
            }
        }

        static void CreateTask(string taskName, string executablePath, TaskCompatibility compatibility)
        {  
            using (TaskService ts = new TaskService())
            {
                
                // 작업 정의 생성
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "잉크막힘을 방지하기위한 주기적 인쇄 스케쥴러";

                // 매주 실행 트리거 설정 (여기서는 일요일 오전 9시에 실행)
                WeeklyTrigger weeklyTrigger = new WeeklyTrigger
                {
                    StartBoundary = DateTime.Today + TimeSpan.FromHours(10) + TimeSpan.FromMinutes(10), // 9 AM
                    DaysOfWeek = DaysOfTheWeek.Monday
                };
                td.Triggers.Add(weeklyTrigger);

                // 작업 설정
                td.Actions.Add(new ExecAction(executablePath, null, null));

                // Windows 버전에 따른 호환성 설정
                td.Settings.Compatibility = compatibility;

                // 작업 생성 또는 업데이트
                ts.RootFolder.RegisterTaskDefinition(taskName, td);
                Console.WriteLine($"Task '{taskName}' has been created or updated.");
            }
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            string taskName = "DIOSYSTEM";
            string executablePath = "C:\\DIO-SYSTEM\\PrintJob.exe";
            if (rbtn_xp.Checked)
            {
                CreateTask(taskName, executablePath, TaskCompatibility.V1);
                MessageBox.Show("등록완료 !!");
            }
            else if (rbtn_vista.Checked)
            {
                CreateTask(taskName, executablePath, TaskCompatibility.V2);
                MessageBox.Show("등록완료 !!");
            }
            else if (rbtn_seven.Checked)
            {
                CreateTask(taskName, executablePath, TaskCompatibility.V2_1);
                MessageBox.Show("등록완료 !!");
            }
            else if (rbtn_eight.Checked)
            {
                CreateTask(taskName, executablePath, TaskCompatibility.V2_2);
                MessageBox.Show("등록완료 !!");
            }
            else if (rbtn_ten.Checked)
            {
                CreateTask(taskName, executablePath, TaskCompatibility.V2_3);
                MessageBox.Show("등록완료 !!");
            }
        }

        private void 프로그램정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void 수동업데이트하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("현재 사용 불가");
        }
    }
}
