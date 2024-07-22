namespace PrintScheduler
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_ten = new System.Windows.Forms.RadioButton();
            this.rbtn_eight = new System.Windows.Forms.RadioButton();
            this.rbtn_seven = new System.Windows.Forms.RadioButton();
            this.rbtn_vista = new System.Windows.Forms.RadioButton();
            this.rbtn_xp = new System.Windows.Forms.RadioButton();
            this.cbox_time = new System.Windows.Forms.ComboBox();
            this.cbox_day = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_setup = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프로그램정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.업데이트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_init = new System.Windows.Forms.Button();
            this.lbl_version = new System.Windows.Forms.Label();
            this.수동업데이트하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_schedule);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(4, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_schedule
            // 
            this.btn_schedule.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_schedule.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_schedule.Location = new System.Drawing.Point(8, 172);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(328, 26);
            this.btn_schedule.TabIndex = 10;
            this.btn_schedule.Text = "등록";
            this.btn_schedule.UseVisualStyleBackColor = true;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_ten);
            this.groupBox2.Controls.Add(this.rbtn_eight);
            this.groupBox2.Controls.Add(this.rbtn_seven);
            this.groupBox2.Controls.Add(this.rbtn_vista);
            this.groupBox2.Controls.Add(this.rbtn_xp);
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 154);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Window 세팅";
            // 
            // rbtn_ten
            // 
            this.rbtn_ten.AutoSize = true;
            this.rbtn_ten.Location = new System.Drawing.Point(13, 123);
            this.rbtn_ten.Name = "rbtn_ten";
            this.rbtn_ten.Size = new System.Drawing.Size(228, 19);
            this.rbtn_ten.TabIndex = 4;
            this.rbtn_ten.TabStop = true;
            this.rbtn_ten.Text = "Windows 10 && Windows Server 2016";
            this.rbtn_ten.UseVisualStyleBackColor = true;
            // 
            // rbtn_eight
            // 
            this.rbtn_eight.AutoSize = true;
            this.rbtn_eight.Location = new System.Drawing.Point(13, 98);
            this.rbtn_eight.Name = "rbtn_eight";
            this.rbtn_eight.Size = new System.Drawing.Size(230, 19);
            this.rbtn_eight.TabIndex = 3;
            this.rbtn_eight.TabStop = true;
            this.rbtn_eight.Text = "Windows 8.x && Windows Server 2012";
            this.rbtn_eight.UseVisualStyleBackColor = true;
            // 
            // rbtn_seven
            // 
            this.rbtn_seven.AutoSize = true;
            this.rbtn_seven.Location = new System.Drawing.Point(13, 73);
            this.rbtn_seven.Name = "rbtn_seven";
            this.rbtn_seven.Size = new System.Drawing.Size(239, 19);
            this.rbtn_seven.TabIndex = 2;
            this.rbtn_seven.TabStop = true;
            this.rbtn_seven.Text = "Windows 7 && Windows Server 2008 R2";
            this.rbtn_seven.UseVisualStyleBackColor = true;
            // 
            // rbtn_vista
            // 
            this.rbtn_vista.AutoSize = true;
            this.rbtn_vista.Location = new System.Drawing.Point(13, 48);
            this.rbtn_vista.Name = "rbtn_vista";
            this.rbtn_vista.Size = new System.Drawing.Size(240, 19);
            this.rbtn_vista.TabIndex = 1;
            this.rbtn_vista.TabStop = true;
            this.rbtn_vista.Text = "Windows Vista && Windows Server 2008";
            this.rbtn_vista.UseVisualStyleBackColor = true;
            // 
            // rbtn_xp
            // 
            this.rbtn_xp.AutoSize = true;
            this.rbtn_xp.Location = new System.Drawing.Point(13, 23);
            this.rbtn_xp.Name = "rbtn_xp";
            this.rbtn_xp.Size = new System.Drawing.Size(305, 19);
            this.rbtn_xp.TabIndex = 0;
            this.rbtn_xp.TabStop = true;
            this.rbtn_xp.Text = "Windows XP, Windows 2000, Windows Server 2003";
            this.rbtn_xp.UseVisualStyleBackColor = true;
            // 
            // cbox_time
            // 
            this.cbox_time.FormattingEnabled = true;
            this.cbox_time.Items.AddRange(new object[] {
            "09시",
            "10시",
            "11시",
            "12시",
            "13시",
            "14시",
            "15시",
            "16시"});
            this.cbox_time.Location = new System.Drawing.Point(944, 296);
            this.cbox_time.Name = "cbox_time";
            this.cbox_time.Size = new System.Drawing.Size(87, 23);
            this.cbox_time.TabIndex = 9;
            // 
            // cbox_day
            // 
            this.cbox_day.FormattingEnabled = true;
            this.cbox_day.Items.AddRange(new object[] {
            "월요일",
            "화요일",
            "수요일",
            "목요일",
            "금요일"});
            this.cbox_day.Location = new System.Drawing.Point(769, 296);
            this.cbox_day.Name = "cbox_day";
            this.cbox_day.Size = new System.Drawing.Size(87, 23);
            this.cbox_day.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(872, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "시간 설정 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(703, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "요일 설정 :";
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_start.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_start.Location = new System.Drawing.Point(689, 363);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(328, 26);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "등록";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_setup
            // 
            this.btn_setup.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_setup.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_setup.Location = new System.Drawing.Point(689, 195);
            this.btn_setup.Name = "btn_setup";
            this.btn_setup.Size = new System.Drawing.Size(328, 26);
            this.btn_setup.TabIndex = 0;
            this.btn_setup.Text = "등록";
            this.btn_setup.UseVisualStyleBackColor = true;
            this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.업데이트ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(356, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프로그램정보ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 프로그램정보ToolStripMenuItem
            // 
            this.프로그램정보ToolStripMenuItem.Name = "프로그램정보ToolStripMenuItem";
            this.프로그램정보ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.프로그램정보ToolStripMenuItem.Text = "프로그램 정보";
            this.프로그램정보ToolStripMenuItem.Click += new System.EventHandler(this.프로그램정보ToolStripMenuItem_Click);
            // 
            // 업데이트ToolStripMenuItem
            // 
            this.업데이트ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.수동업데이트하기ToolStripMenuItem});
            this.업데이트ToolStripMenuItem.Name = "업데이트ToolStripMenuItem";
            this.업데이트ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.업데이트ToolStripMenuItem.Text = "업데이트";
            // 
            // btn_init
            // 
            this.btn_init.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_init.ForeColor = System.Drawing.Color.Red;
            this.btn_init.Location = new System.Drawing.Point(4, 239);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(345, 25);
            this.btn_init.TabIndex = 2;
            this.btn_init.Text = "초기화";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(609, 76);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(39, 15);
            this.lbl_version.TabIndex = 3;
            this.lbl_version.Text = "label1";
            // 
            // 수동업데이트하기ToolStripMenuItem
            // 
            this.수동업데이트하기ToolStripMenuItem.Name = "수동업데이트하기ToolStripMenuItem";
            this.수동업데이트하기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.수동업데이트하기ToolStripMenuItem.Text = "수동 업데이트 하기";
            this.수동업데이트하기ToolStripMenuItem.Click += new System.EventHandler(this.수동업데이트하기ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(356, 273);
            this.Controls.Add(this.cbox_time);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.cbox_day);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_setup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "프린트 스케줄러";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_setup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프로그램정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 업데이트ToolStripMenuItem;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_ten;
        private System.Windows.Forms.RadioButton rbtn_eight;
        private System.Windows.Forms.RadioButton rbtn_seven;
        private System.Windows.Forms.RadioButton rbtn_vista;
        private System.Windows.Forms.RadioButton rbtn_xp;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox_time;
        private System.Windows.Forms.ComboBox cbox_day;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.ToolStripMenuItem 수동업데이트하기ToolStripMenuItem;
    }
}

