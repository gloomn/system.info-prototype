
namespace Task_Manager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.formControlPanel = new System.Windows.Forms.Panel();
            this.exit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.navBarPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.allProgramBtn = new Guna.UI2.WinForms.Guna2Button();
            this.developerBtn = new Guna.UI2.WinForms.Guna2Button();
            this.licenseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.howToUseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ATLabel = new System.Windows.Forms.Label();
            this.PMLabel = new System.Windows.Forms.Label();
            this.memoryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.gpuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cpuBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dashBoardBtn = new Guna.UI2.WinForms.Guna2Button();
            this.systemLabel = new System.Windows.Forms.Label();
            this.programMainTitle = new System.Windows.Forms.Label();
            this.statiticsPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cpuTempPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.cpuClockLabel = new System.Windows.Forms.Label();
            this.batteryPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.statistics_betteryLeft_subtitle = new System.Windows.Forms.Label();
            this.statistics_battery_subtitle = new System.Windows.Forms.Label();
            this.statistics_battery = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.statitics_batterySize = new System.Windows.Forms.Label();
            this.statisticsTabMainTitle = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.mainFormTimer = new System.Windows.Forms.Timer(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.cpuClockTimer = new System.Windows.Forms.Timer(this.components);
            this.developer1 = new Task_Manager.Developer();
            this.dashboard1 = new Task_Manager.dashboard();
            this.cpu1 = new Task_Manager.CPU();
            this.gpu1 = new Task_Manager.GPU();
            this.license1 = new Task_Manager.License();
            this.howToUse1 = new Task_Manager.HowToUse();
            this.allProgram1 = new Task_Manager.allProgram();
            this.formControlPanel.SuspendLayout();
            this.navBarPanel.SuspendLayout();
            this.statiticsPanel.SuspendLayout();
            this.cpuTempPanel.SuspendLayout();
            this.guna2CircleProgressBar1.SuspendLayout();
            this.batteryPanel.SuspendLayout();
            this.statistics_battery.SuspendLayout();
            this.SuspendLayout();
            // 
            // formControlPanel
            // 
            this.formControlPanel.BackColor = System.Drawing.Color.White;
            this.formControlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formControlPanel.BackgroundImage")));
            this.formControlPanel.Controls.Add(this.exit);
            this.formControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formControlPanel.Location = new System.Drawing.Point(0, 0);
            this.formControlPanel.Name = "formControlPanel";
            this.formControlPanel.Size = new System.Drawing.Size(1234, 32);
            this.formControlPanel.TabIndex = 0;
            this.formControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.formControlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.formControlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // exit
            // 
            this.exit.CheckedState.Parent = this.exit;
            this.exit.CustomImages.Parent = this.exit;
            this.exit.FillColor = System.Drawing.Color.White;
            this.exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.HoverState.Parent = this.exit;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1201, 2);
            this.exit.Name = "exit";
            this.exit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exit.ShadowDecoration.Parent = this.exit;
            this.exit.Size = new System.Drawing.Size(30, 30);
            this.exit.TabIndex = 16;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // navBarPanel
            // 
            this.navBarPanel.BackColor = System.Drawing.Color.White;
            this.navBarPanel.Controls.Add(this.versionLabel);
            this.navBarPanel.Controls.Add(this.allProgramBtn);
            this.navBarPanel.Controls.Add(this.developerBtn);
            this.navBarPanel.Controls.Add(this.licenseBtn);
            this.navBarPanel.Controls.Add(this.howToUseBtn);
            this.navBarPanel.Controls.Add(this.ATLabel);
            this.navBarPanel.Controls.Add(this.PMLabel);
            this.navBarPanel.Controls.Add(this.memoryBtn);
            this.navBarPanel.Controls.Add(this.gpuBtn);
            this.navBarPanel.Controls.Add(this.cpuBtn);
            this.navBarPanel.Controls.Add(this.dashBoardBtn);
            this.navBarPanel.Controls.Add(this.systemLabel);
            this.navBarPanel.Controls.Add(this.programMainTitle);
            this.navBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarPanel.Location = new System.Drawing.Point(0, 32);
            this.navBarPanel.Name = "navBarPanel";
            this.navBarPanel.ShadowDecoration.Parent = this.navBarPanel;
            this.navBarPanel.Size = new System.Drawing.Size(179, 679);
            this.navBarPanel.TabIndex = 1;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.versionLabel.Location = new System.Drawing.Point(12, 659);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(140, 15);
            this.versionLabel.TabIndex = 27;
            this.versionLabel.Text = "V 1.3.56 Syntaxack Team";
            // 
            // allProgramBtn
            // 
            this.allProgramBtn.BorderRadius = 15;
            this.allProgramBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.allProgramBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.allProgramBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.allProgramBtn.CheckedState.Parent = this.allProgramBtn;
            this.allProgramBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allProgramBtn.CustomImages.Parent = this.allProgramBtn;
            this.allProgramBtn.FillColor = System.Drawing.Color.Transparent;
            this.allProgramBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allProgramBtn.ForeColor = System.Drawing.Color.Black;
            this.allProgramBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.allProgramBtn.HoverState.Parent = this.allProgramBtn;
            this.allProgramBtn.Image = ((System.Drawing.Image)(resources.GetObject("allProgramBtn.Image")));
            this.allProgramBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.allProgramBtn.Location = new System.Drawing.Point(35, 348);
            this.allProgramBtn.Name = "allProgramBtn";
            this.allProgramBtn.ShadowDecoration.Parent = this.allProgramBtn;
            this.allProgramBtn.Size = new System.Drawing.Size(141, 32);
            this.allProgramBtn.TabIndex = 26;
            this.allProgramBtn.Text = "All Program";
            this.allProgramBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.allProgramBtn.Click += new System.EventHandler(this.allProgramBtn_Click);
            // 
            // developerBtn
            // 
            this.developerBtn.BorderRadius = 15;
            this.developerBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.developerBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.developerBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.developerBtn.CheckedState.Parent = this.developerBtn;
            this.developerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.developerBtn.CustomImages.Parent = this.developerBtn;
            this.developerBtn.FillColor = System.Drawing.Color.Transparent;
            this.developerBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerBtn.ForeColor = System.Drawing.Color.Black;
            this.developerBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.developerBtn.HoverState.Parent = this.developerBtn;
            this.developerBtn.Image = ((System.Drawing.Image)(resources.GetObject("developerBtn.Image")));
            this.developerBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.developerBtn.Location = new System.Drawing.Point(35, 524);
            this.developerBtn.Name = "developerBtn";
            this.developerBtn.ShadowDecoration.Parent = this.developerBtn;
            this.developerBtn.Size = new System.Drawing.Size(141, 32);
            this.developerBtn.TabIndex = 25;
            this.developerBtn.Text = "Developer";
            this.developerBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.developerBtn.Click += new System.EventHandler(this.developerBtn_Click);
            // 
            // licenseBtn
            // 
            this.licenseBtn.BorderRadius = 15;
            this.licenseBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.licenseBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.licenseBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.licenseBtn.CheckedState.Parent = this.licenseBtn;
            this.licenseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.licenseBtn.CustomImages.Parent = this.licenseBtn;
            this.licenseBtn.FillColor = System.Drawing.Color.Transparent;
            this.licenseBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseBtn.ForeColor = System.Drawing.Color.Black;
            this.licenseBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.licenseBtn.HoverState.Parent = this.licenseBtn;
            this.licenseBtn.Image = ((System.Drawing.Image)(resources.GetObject("licenseBtn.Image")));
            this.licenseBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.licenseBtn.Location = new System.Drawing.Point(35, 486);
            this.licenseBtn.Name = "licenseBtn";
            this.licenseBtn.ShadowDecoration.Parent = this.licenseBtn;
            this.licenseBtn.Size = new System.Drawing.Size(141, 32);
            this.licenseBtn.TabIndex = 24;
            this.licenseBtn.Text = "License";
            this.licenseBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.licenseBtn.Click += new System.EventHandler(this.licenseBtn_Click);
            // 
            // howToUseBtn
            // 
            this.howToUseBtn.BorderRadius = 15;
            this.howToUseBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.howToUseBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.howToUseBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.howToUseBtn.CheckedState.Parent = this.howToUseBtn;
            this.howToUseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.howToUseBtn.CustomImages.Parent = this.howToUseBtn;
            this.howToUseBtn.FillColor = System.Drawing.Color.Transparent;
            this.howToUseBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToUseBtn.ForeColor = System.Drawing.Color.Black;
            this.howToUseBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.howToUseBtn.HoverState.Parent = this.howToUseBtn;
            this.howToUseBtn.Image = ((System.Drawing.Image)(resources.GetObject("howToUseBtn.Image")));
            this.howToUseBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.howToUseBtn.Location = new System.Drawing.Point(35, 448);
            this.howToUseBtn.Name = "howToUseBtn";
            this.howToUseBtn.ShadowDecoration.Parent = this.howToUseBtn;
            this.howToUseBtn.Size = new System.Drawing.Size(141, 32);
            this.howToUseBtn.TabIndex = 23;
            this.howToUseBtn.Text = "How To Use";
            this.howToUseBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.howToUseBtn.Click += new System.EventHandler(this.howToUseBtn_Click);
            // 
            // ATLabel
            // 
            this.ATLabel.AutoSize = true;
            this.ATLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATLabel.ForeColor = System.Drawing.Color.DimGray;
            this.ATLabel.Location = new System.Drawing.Point(32, 430);
            this.ATLabel.Name = "ATLabel";
            this.ATLabel.Size = new System.Drawing.Size(95, 15);
            this.ATLabel.TabIndex = 22;
            this.ATLabel.Text = "ADDITIONAL TAB";
            // 
            // PMLabel
            // 
            this.PMLabel.AutoSize = true;
            this.PMLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PMLabel.ForeColor = System.Drawing.Color.DimGray;
            this.PMLabel.Location = new System.Drawing.Point(32, 330);
            this.PMLabel.Name = "PMLabel";
            this.PMLabel.Size = new System.Drawing.Size(113, 15);
            this.PMLabel.TabIndex = 21;
            this.PMLabel.Text = "PROGRAM MANAGE";
            // 
            // memoryBtn
            // 
            this.memoryBtn.BorderRadius = 15;
            this.memoryBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.memoryBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.memoryBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.memoryBtn.CheckedState.Parent = this.memoryBtn;
            this.memoryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memoryBtn.CustomImages.Parent = this.memoryBtn;
            this.memoryBtn.FillColor = System.Drawing.Color.Transparent;
            this.memoryBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryBtn.ForeColor = System.Drawing.Color.Black;
            this.memoryBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.memoryBtn.HoverState.Parent = this.memoryBtn;
            this.memoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("memoryBtn.Image")));
            this.memoryBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.memoryBtn.Location = new System.Drawing.Point(35, 274);
            this.memoryBtn.Name = "memoryBtn";
            this.memoryBtn.ShadowDecoration.Parent = this.memoryBtn;
            this.memoryBtn.Size = new System.Drawing.Size(141, 32);
            this.memoryBtn.TabIndex = 20;
            this.memoryBtn.Text = "Memory(Add Soon)";
            this.memoryBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gpuBtn
            // 
            this.gpuBtn.BorderRadius = 15;
            this.gpuBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.gpuBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.gpuBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.gpuBtn.CheckedState.Parent = this.gpuBtn;
            this.gpuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gpuBtn.CustomImages.Parent = this.gpuBtn;
            this.gpuBtn.FillColor = System.Drawing.Color.Transparent;
            this.gpuBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuBtn.ForeColor = System.Drawing.Color.Black;
            this.gpuBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.gpuBtn.HoverState.Parent = this.gpuBtn;
            this.gpuBtn.Image = ((System.Drawing.Image)(resources.GetObject("gpuBtn.Image")));
            this.gpuBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gpuBtn.Location = new System.Drawing.Point(35, 236);
            this.gpuBtn.Name = "gpuBtn";
            this.gpuBtn.ShadowDecoration.Parent = this.gpuBtn;
            this.gpuBtn.Size = new System.Drawing.Size(141, 32);
            this.gpuBtn.TabIndex = 19;
            this.gpuBtn.Text = "GPU(Add Soon)";
            this.gpuBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gpuBtn.Click += new System.EventHandler(this.gpuBtn_Click);
            // 
            // cpuBtn
            // 
            this.cpuBtn.BorderRadius = 15;
            this.cpuBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.cpuBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.cpuBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.cpuBtn.CheckedState.Parent = this.cpuBtn;
            this.cpuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpuBtn.CustomImages.Parent = this.cpuBtn;
            this.cpuBtn.FillColor = System.Drawing.Color.Transparent;
            this.cpuBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuBtn.ForeColor = System.Drawing.Color.Black;
            this.cpuBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.cpuBtn.HoverState.Parent = this.cpuBtn;
            this.cpuBtn.Image = ((System.Drawing.Image)(resources.GetObject("cpuBtn.Image")));
            this.cpuBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cpuBtn.Location = new System.Drawing.Point(35, 198);
            this.cpuBtn.Name = "cpuBtn";
            this.cpuBtn.ShadowDecoration.Parent = this.cpuBtn;
            this.cpuBtn.Size = new System.Drawing.Size(141, 32);
            this.cpuBtn.TabIndex = 18;
            this.cpuBtn.Text = "CPU";
            this.cpuBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cpuBtn.Click += new System.EventHandler(this.cpuBtn_Click);
            // 
            // dashBoardBtn
            // 
            this.dashBoardBtn.BorderRadius = 15;
            this.dashBoardBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.dashBoardBtn.Checked = true;
            this.dashBoardBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.dashBoardBtn.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.dashBoardBtn.CheckedState.Parent = this.dashBoardBtn;
            this.dashBoardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashBoardBtn.CustomImages.Parent = this.dashBoardBtn;
            this.dashBoardBtn.FillColor = System.Drawing.Color.Transparent;
            this.dashBoardBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoardBtn.ForeColor = System.Drawing.Color.Black;
            this.dashBoardBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.dashBoardBtn.HoverState.Parent = this.dashBoardBtn;
            this.dashBoardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashBoardBtn.Image")));
            this.dashBoardBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashBoardBtn.Location = new System.Drawing.Point(35, 160);
            this.dashBoardBtn.Name = "dashBoardBtn";
            this.dashBoardBtn.ShadowDecoration.Parent = this.dashBoardBtn;
            this.dashBoardBtn.Size = new System.Drawing.Size(141, 32);
            this.dashBoardBtn.TabIndex = 17;
            this.dashBoardBtn.Text = "Dashboard";
            this.dashBoardBtn.Click += new System.EventHandler(this.dashBoardBtn_Click);
            // 
            // systemLabel
            // 
            this.systemLabel.AutoSize = true;
            this.systemLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemLabel.ForeColor = System.Drawing.Color.DimGray;
            this.systemLabel.Location = new System.Drawing.Point(32, 129);
            this.systemLabel.Name = "systemLabel";
            this.systemLabel.Size = new System.Drawing.Size(48, 15);
            this.systemLabel.TabIndex = 13;
            this.systemLabel.Text = "SYSTEM";
            // 
            // programMainTitle
            // 
            this.programMainTitle.AutoSize = true;
            this.programMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.programMainTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(124)))), ((int)(((byte)(206)))));
            this.programMainTitle.Location = new System.Drawing.Point(30, 22);
            this.programMainTitle.Name = "programMainTitle";
            this.programMainTitle.Size = new System.Drawing.Size(113, 26);
            this.programMainTitle.TabIndex = 12;
            this.programMainTitle.Text = "system.info";
            this.programMainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statiticsPanel
            // 
            this.statiticsPanel.BackColor = System.Drawing.Color.White;
            this.statiticsPanel.Controls.Add(this.cpuTempPanel);
            this.statiticsPanel.Controls.Add(this.batteryPanel);
            this.statiticsPanel.Controls.Add(this.statisticsTabMainTitle);
            this.statiticsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.statiticsPanel.Location = new System.Drawing.Point(968, 32);
            this.statiticsPanel.Name = "statiticsPanel";
            this.statiticsPanel.ShadowDecoration.Parent = this.statiticsPanel;
            this.statiticsPanel.Size = new System.Drawing.Size(266, 679);
            this.statiticsPanel.TabIndex = 2;
            // 
            // cpuTempPanel
            // 
            this.cpuTempPanel.BackColor = System.Drawing.Color.Transparent;
            this.cpuTempPanel.BorderRadius = 20;
            this.cpuTempPanel.Controls.Add(this.label1);
            this.cpuTempPanel.Controls.Add(this.label2);
            this.cpuTempPanel.Controls.Add(this.guna2CircleProgressBar1);
            this.cpuTempPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.cpuTempPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.cpuTempPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.cpuTempPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.cpuTempPanel.Location = new System.Drawing.Point(15, 160);
            this.cpuTempPanel.Name = "cpuTempPanel";
            this.cpuTempPanel.ShadowDecoration.Parent = this.cpuTempPanel;
            this.cpuTempPanel.Size = new System.Drawing.Size(239, 62);
            this.cpuTempPanel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(197, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "CPU\r\nTemperature";
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Animated = true;
            this.guna2CircleProgressBar1.AnimationSpeed = 0.1F;
            this.guna2CircleProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar1.Controls.Add(this.cpuClockLabel);
            this.guna2CircleProgressBar1.FillThickness = 5;
            this.guna2CircleProgressBar1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(108, 1);
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.RoyalBlue;
            this.guna2CircleProgressBar1.ProgressThickness = 5;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(60, 60);
            this.guna2CircleProgressBar1.TabIndex = 0;
            // 
            // cpuClockLabel
            // 
            this.cpuClockLabel.AutoSize = true;
            this.cpuClockLabel.BackColor = System.Drawing.Color.Transparent;
            this.cpuClockLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuClockLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cpuClockLabel.Location = new System.Drawing.Point(16, 23);
            this.cpuClockLabel.Name = "cpuClockLabel";
            this.cpuClockLabel.Size = new System.Drawing.Size(28, 15);
            this.cpuClockLabel.TabIndex = 11;
            this.cpuClockLabel.Text = "000";
            // 
            // batteryPanel
            // 
            this.batteryPanel.BackColor = System.Drawing.Color.Transparent;
            this.batteryPanel.BorderRadius = 20;
            this.batteryPanel.Controls.Add(this.statistics_betteryLeft_subtitle);
            this.batteryPanel.Controls.Add(this.statistics_battery_subtitle);
            this.batteryPanel.Controls.Add(this.statistics_battery);
            this.batteryPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.batteryPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.batteryPanel.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.batteryPanel.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.batteryPanel.Location = new System.Drawing.Point(15, 82);
            this.batteryPanel.Name = "batteryPanel";
            this.batteryPanel.ShadowDecoration.Parent = this.batteryPanel;
            this.batteryPanel.Size = new System.Drawing.Size(239, 62);
            this.batteryPanel.TabIndex = 14;
            // 
            // statistics_betteryLeft_subtitle
            // 
            this.statistics_betteryLeft_subtitle.AutoSize = true;
            this.statistics_betteryLeft_subtitle.BackColor = System.Drawing.Color.Transparent;
            this.statistics_betteryLeft_subtitle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics_betteryLeft_subtitle.ForeColor = System.Drawing.Color.DimGray;
            this.statistics_betteryLeft_subtitle.Location = new System.Drawing.Point(167, 25);
            this.statistics_betteryLeft_subtitle.Name = "statistics_betteryLeft_subtitle";
            this.statistics_betteryLeft_subtitle.Size = new System.Drawing.Size(67, 15);
            this.statistics_betteryLeft_subtitle.TabIndex = 11;
            this.statistics_betteryLeft_subtitle.Text = "battery left";
            // 
            // statistics_battery_subtitle
            // 
            this.statistics_battery_subtitle.AutoSize = true;
            this.statistics_battery_subtitle.BackColor = System.Drawing.Color.Transparent;
            this.statistics_battery_subtitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics_battery_subtitle.Location = new System.Drawing.Point(5, 21);
            this.statistics_battery_subtitle.Name = "statistics_battery_subtitle";
            this.statistics_battery_subtitle.Size = new System.Drawing.Size(59, 19);
            this.statistics_battery_subtitle.TabIndex = 11;
            this.statistics_battery_subtitle.Text = "Battery";
            // 
            // statistics_battery
            // 
            this.statistics_battery.Animated = true;
            this.statistics_battery.AnimationSpeed = 0.1F;
            this.statistics_battery.BackColor = System.Drawing.Color.Transparent;
            this.statistics_battery.Controls.Add(this.statitics_batterySize);
            this.statistics_battery.FillThickness = 5;
            this.statistics_battery.ImageSize = new System.Drawing.Size(50, 50);
            this.statistics_battery.Location = new System.Drawing.Point(106, 1);
            this.statistics_battery.Name = "statistics_battery";
            this.statistics_battery.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.statistics_battery.ProgressColor2 = System.Drawing.Color.RoyalBlue;
            this.statistics_battery.ProgressThickness = 5;
            this.statistics_battery.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.statistics_battery.ShadowDecoration.Parent = this.statistics_battery;
            this.statistics_battery.Size = new System.Drawing.Size(60, 60);
            this.statistics_battery.TabIndex = 0;
            // 
            // statitics_batterySize
            // 
            this.statitics_batterySize.AutoSize = true;
            this.statitics_batterySize.BackColor = System.Drawing.Color.Transparent;
            this.statitics_batterySize.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statitics_batterySize.ForeColor = System.Drawing.Color.RoyalBlue;
            this.statitics_batterySize.Location = new System.Drawing.Point(12, 23);
            this.statitics_batterySize.Name = "statitics_batterySize";
            this.statitics_batterySize.Size = new System.Drawing.Size(37, 15);
            this.statitics_batterySize.TabIndex = 11;
            this.statitics_batterySize.Text = "000%";
            // 
            // statisticsTabMainTitle
            // 
            this.statisticsTabMainTitle.AutoSize = true;
            this.statisticsTabMainTitle.BackColor = System.Drawing.Color.Transparent;
            this.statisticsTabMainTitle.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsTabMainTitle.Location = new System.Drawing.Point(13, 43);
            this.statisticsTabMainTitle.Name = "statisticsTabMainTitle";
            this.statisticsTabMainTitle.Size = new System.Drawing.Size(88, 26);
            this.statisticsTabMainTitle.TabIndex = 12;
            this.statisticsTabMainTitle.Text = "Statistics";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // mainFormTimer
            // 
            this.mainFormTimer.Interval = 1000;
            this.mainFormTimer.Tick += new System.EventHandler(this.mainFormTimer_Tick);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 20;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // developer1
            // 
            this.developer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.developer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.developer1.Location = new System.Drawing.Point(179, 32);
            this.developer1.Name = "developer1";
            this.developer1.Size = new System.Drawing.Size(789, 679);
            this.developer1.TabIndex = 6;
            // 
            // dashboard1
            // 
            this.dashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.dashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard1.Location = new System.Drawing.Point(179, 32);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(789, 679);
            this.dashboard1.TabIndex = 3;
            // 
            // cpu1
            // 
            this.cpu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.cpu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpu1.Location = new System.Drawing.Point(0, 0);
            this.cpu1.Name = "cpu1";
            this.cpu1.Size = new System.Drawing.Size(1234, 711);
            this.cpu1.TabIndex = 4;
            // 
            // gpu1
            // 
            this.gpu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.gpu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpu1.Location = new System.Drawing.Point(0, 0);
            this.gpu1.Name = "gpu1";
            this.gpu1.Size = new System.Drawing.Size(1234, 711);
            this.gpu1.TabIndex = 5;
            // 
            // license1
            // 
            this.license1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.license1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.license1.Location = new System.Drawing.Point(179, 32);
            this.license1.Name = "license1";
            this.license1.Size = new System.Drawing.Size(789, 679);
            this.license1.TabIndex = 7;
            // 
            // howToUse1
            // 
            this.howToUse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.howToUse1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.howToUse1.Location = new System.Drawing.Point(179, 32);
            this.howToUse1.Name = "howToUse1";
            this.howToUse1.Size = new System.Drawing.Size(789, 679);
            this.howToUse1.TabIndex = 8;
            // 
            // allProgram1
            // 
            this.allProgram1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.allProgram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allProgram1.Location = new System.Drawing.Point(179, 32);
            this.allProgram1.Name = "allProgram1";
            this.allProgram1.Size = new System.Drawing.Size(789, 679);
            this.allProgram1.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1234, 711);
            this.Controls.Add(this.allProgram1);
            this.Controls.Add(this.howToUse1);
            this.Controls.Add(this.license1);
            this.Controls.Add(this.developer1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.statiticsPanel);
            this.Controls.Add(this.navBarPanel);
            this.Controls.Add(this.formControlPanel);
            this.Controls.Add(this.cpu1);
            this.Controls.Add(this.gpu1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "system.info";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formControlPanel.ResumeLayout(false);
            this.navBarPanel.ResumeLayout(false);
            this.navBarPanel.PerformLayout();
            this.statiticsPanel.ResumeLayout(false);
            this.statiticsPanel.PerformLayout();
            this.cpuTempPanel.ResumeLayout(false);
            this.cpuTempPanel.PerformLayout();
            this.guna2CircleProgressBar1.ResumeLayout(false);
            this.guna2CircleProgressBar1.PerformLayout();
            this.batteryPanel.ResumeLayout(false);
            this.batteryPanel.PerformLayout();
            this.statistics_battery.ResumeLayout(false);
            this.statistics_battery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientPanel statiticsPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel navBarPanel;
        private System.Windows.Forms.Panel formControlPanel;
        private System.Windows.Forms.Label statisticsTabMainTitle;
        private System.Windows.Forms.Label programMainTitle;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel batteryPanel;
        private System.Windows.Forms.Label statistics_betteryLeft_subtitle;
        private System.Windows.Forms.Label statistics_battery_subtitle;
        private Guna.UI2.WinForms.Guna2CircleProgressBar statistics_battery;
        private System.Windows.Forms.Label statitics_batterySize;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer mainFormTimer;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel cpuTempPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.Label cpuClockLabel;
        private System.Windows.Forms.Label systemLabel;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label PMLabel;
        private Guna.UI2.WinForms.Guna2Button memoryBtn;
        private Guna.UI2.WinForms.Guna2Button gpuBtn;
        private Guna.UI2.WinForms.Guna2Button cpuBtn;
        private Guna.UI2.WinForms.Guna2Button dashBoardBtn;
        private Guna.UI2.WinForms.Guna2CircleButton exit;
        private dashboard dashboard1;
        private CPU cpu1;
        private GPU gpu1;
        private System.Windows.Forms.Timer cpuClockTimer;
        private System.Windows.Forms.Label versionLabel;
        private Guna.UI2.WinForms.Guna2Button allProgramBtn;
        private Guna.UI2.WinForms.Guna2Button developerBtn;
        private Guna.UI2.WinForms.Guna2Button licenseBtn;
        private Guna.UI2.WinForms.Guna2Button howToUseBtn;
        private System.Windows.Forms.Label ATLabel;
        private Developer developer1;
        private License license1;
        private HowToUse howToUse1;
        private allProgram allProgram1;
    }
}

