using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;

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
    }
}
