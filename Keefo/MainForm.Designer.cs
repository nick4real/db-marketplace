namespace Amafun
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnAds = new System.Windows.Forms.Button();
            this.btnMods = new System.Windows.Forms.Button();
            this.btnCreateAds = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogoName = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnFullscreen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseDesktop = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelReg = new System.Windows.Forms.Panel();
            this.labelChange2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passReg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.loginReg = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneReg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameReg = new System.Windows.Forms.TextBox();
            this.labelReg = new System.Windows.Forms.Label();
            this.panelAuth = new System.Windows.Forms.Panel();
            this.labelChange = new System.Windows.Forms.Label();
            this.btnAuth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.passAuth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginAuth = new System.Windows.Forms.TextBox();
            this.labelAuth = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelReg.SuspendLayout();
            this.panelAuth.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnEnd);
            this.panelMenu.Controls.Add(this.btnMods);
            this.panelMenu.Controls.Add(this.btnCreateAds);
            this.panelMenu.Controls.Add(this.btnAds);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 496);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 436);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 60);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "   Выход из аккаунта";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 320);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "   Настройки";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnd.FlatAppearance.BorderSize = 0;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnEnd.Image")));
            this.btnEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnd.Location = new System.Drawing.Point(0, 260);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnEnd.Size = new System.Drawing.Size(220, 60);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "   Мои объявления";
            this.btnEnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnMyAds_Click);
            // 
            // btnAds
            // 
            this.btnAds.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAds.FlatAppearance.BorderSize = 0;
            this.btnAds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAds.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAds.Image = ((System.Drawing.Image)(resources.GetObject("btnAds.Image")));
            this.btnAds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAds.Location = new System.Drawing.Point(0, 80);
            this.btnAds.Name = "btnAds";
            this.btnAds.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAds.Size = new System.Drawing.Size(220, 60);
            this.btnAds.TabIndex = 1;
            this.btnAds.Text = "   Объявления";
            this.btnAds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAds.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAds.UseVisualStyleBackColor = true;
            this.btnAds.Click += new System.EventHandler(this.btnAds_Click);
            // 
            // btnMods
            // 
            this.btnMods.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMods.FlatAppearance.BorderSize = 0;
            this.btnMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMods.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMods.Image = ((System.Drawing.Image)(resources.GetObject("btnMods.Image")));
            this.btnMods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMods.Location = new System.Drawing.Point(0, 200);
            this.btnMods.Name = "btnMods";
            this.btnMods.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMods.Size = new System.Drawing.Size(220, 60);
            this.btnMods.TabIndex = 2;
            this.btnMods.Text = "   На модерации";
            this.btnMods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMods.UseVisualStyleBackColor = true;
            this.btnMods.Click += new System.EventHandler(this.btnMods_Click);
            // 
            // btnCreateAds
            // 
            this.btnCreateAds.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateAds.FlatAppearance.BorderSize = 0;
            this.btnCreateAds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAds.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCreateAds.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAds.Image")));
            this.btnCreateAds.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAds.Location = new System.Drawing.Point(0, 140);
            this.btnCreateAds.Name = "btnCreateAds";
            this.btnCreateAds.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCreateAds.Size = new System.Drawing.Size(220, 60);
            this.btnCreateAds.TabIndex = 8;
            this.btnCreateAds.Text = "   Создать\r\n   объявление\r\n";
            this.btnCreateAds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAds.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateAds.UseVisualStyleBackColor = true;
            this.btnCreateAds.Click += new System.EventHandler(this.btnCreateAds_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblLogoName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogoName
            // 
            this.lblLogoName.AutoSize = true;
            this.lblLogoName.Font = new System.Drawing.Font("NoirPro-Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogoName.ForeColor = System.Drawing.Color.White;
            this.lblLogoName.Location = new System.Drawing.Point(64, 24);
            this.lblLogoName.Name = "lblLogoName";
            this.lblLogoName.Size = new System.Drawing.Size(90, 30);
            this.lblLogoName.TabIndex = 0;
            this.lblLogoName.Text = "Amafun";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnHide);
            this.panelTitleBar.Controls.Add(this.btnFullscreen);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseDesktop);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(222, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(676, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Font = new System.Drawing.Font("NoirPro-Regular", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHide.ForeColor = System.Drawing.Color.Cyan;
            this.btnHide.Location = new System.Drawing.Point(574, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(30, 30);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "O";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.bntHide_Click);
            // 
            // btnFullscreen
            // 
            this.btnFullscreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullscreen.BackColor = System.Drawing.Color.Transparent;
            this.btnFullscreen.FlatAppearance.BorderSize = 0;
            this.btnFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullscreen.Font = new System.Drawing.Font("NoirPro-Regular", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFullscreen.ForeColor = System.Drawing.Color.Yellow;
            this.btnFullscreen.Location = new System.Drawing.Point(610, 0);
            this.btnFullscreen.Name = "btnFullscreen";
            this.btnFullscreen.Size = new System.Drawing.Size(30, 29);
            this.btnFullscreen.TabIndex = 3;
            this.btnFullscreen.Text = "O";
            this.btnFullscreen.UseVisualStyleBackColor = false;
            this.btnFullscreen.Click += new System.EventHandler(this.btnFullscreen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("NoirPro-Regular", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(646, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseDesktop
            // 
            this.btnCloseDesktop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseDesktop.FlatAppearance.BorderSize = 0;
            this.btnCloseDesktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseDesktop.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseDesktop.Image")));
            this.btnCloseDesktop.Location = new System.Drawing.Point(0, 0);
            this.btnCloseDesktop.Name = "btnCloseDesktop";
            this.btnCloseDesktop.Size = new System.Drawing.Size(75, 80);
            this.btnCloseDesktop.TabIndex = 1;
            this.btnCloseDesktop.UseVisualStyleBackColor = true;
            this.btnCloseDesktop.Click += new System.EventHandler(this.btnCloseDesktop_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("NoirPro-Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(104, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(464, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.panelReg);
            this.panelDesktop.Controls.Add(this.panelAuth);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(222, 82);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(676, 416);
            this.panelDesktop.TabIndex = 2;
            // 
            // panelReg
            // 
            this.panelReg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelReg.BackColor = System.Drawing.Color.Transparent;
            this.panelReg.Controls.Add(this.labelChange2);
            this.panelReg.Controls.Add(this.label5);
            this.panelReg.Controls.Add(this.passReg);
            this.panelReg.Controls.Add(this.label6);
            this.panelReg.Controls.Add(this.loginReg);
            this.panelReg.Controls.Add(this.btnReg);
            this.panelReg.Controls.Add(this.label3);
            this.panelReg.Controls.Add(this.phoneReg);
            this.panelReg.Controls.Add(this.label4);
            this.panelReg.Controls.Add(this.nameReg);
            this.panelReg.Controls.Add(this.labelReg);
            this.panelReg.Location = new System.Drawing.Point(20, 32);
            this.panelReg.Name = "panelReg";
            this.panelReg.Size = new System.Drawing.Size(636, 353);
            this.panelReg.TabIndex = 2;
            // 
            // labelChange2
            // 
            this.labelChange2.AutoSize = true;
            this.labelChange2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChange2.Location = new System.Drawing.Point(40, 210);
            this.labelChange2.Name = "labelChange2";
            this.labelChange2.Size = new System.Drawing.Size(146, 15);
            this.labelChange2.TabIndex = 7;
            this.labelChange2.Text = "Учётная запись уже есть?";
            this.labelChange2.Click += new System.EventHandler(this.labelChange_Click);
            this.labelChange2.MouseEnter += new System.EventHandler(this.labelChange_MouseEnter);
            this.labelChange2.MouseLeave += new System.EventHandler(this.labelChange_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(316, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Пароль:";
            // 
            // passReg
            // 
            this.passReg.Location = new System.Drawing.Point(316, 165);
            this.passReg.Name = "passReg";
            this.passReg.Size = new System.Drawing.Size(232, 23);
            this.passReg.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(316, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Логин:";
            // 
            // loginReg
            // 
            this.loginReg.Location = new System.Drawing.Point(316, 114);
            this.loginReg.Name = "loginReg";
            this.loginReg.Size = new System.Drawing.Size(232, 23);
            this.loginReg.TabIndex = 11;
            // 
            // btnReg
            // 
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnReg.Location = new System.Drawing.Point(40, 228);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(179, 41);
            this.btnReg.TabIndex = 10;
            this.btnReg.Text = "Зарегестрироваться";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер телефона:";
            // 
            // phoneReg
            // 
            this.phoneReg.Location = new System.Drawing.Point(40, 165);
            this.phoneReg.Name = "phoneReg";
            this.phoneReg.Size = new System.Drawing.Size(232, 23);
            this.phoneReg.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя:";
            // 
            // nameReg
            // 
            this.nameReg.Location = new System.Drawing.Point(40, 114);
            this.nameReg.Name = "nameReg";
            this.nameReg.Size = new System.Drawing.Size(232, 23);
            this.nameReg.TabIndex = 6;
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.labelReg.Location = new System.Drawing.Point(40, 40);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(171, 37);
            this.labelReg.TabIndex = 1;
            this.labelReg.Text = "Регистрация";
            // 
            // panelAuth
            // 
            this.panelAuth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelAuth.BackColor = System.Drawing.Color.Transparent;
            this.panelAuth.Controls.Add(this.labelChange);
            this.panelAuth.Controls.Add(this.btnAuth);
            this.panelAuth.Controls.Add(this.label2);
            this.panelAuth.Controls.Add(this.passAuth);
            this.panelAuth.Controls.Add(this.label1);
            this.panelAuth.Controls.Add(this.loginAuth);
            this.panelAuth.Controls.Add(this.labelAuth);
            this.panelAuth.Location = new System.Drawing.Point(20, 32);
            this.panelAuth.Name = "panelAuth";
            this.panelAuth.Size = new System.Drawing.Size(636, 353);
            this.panelAuth.TabIndex = 1;
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChange.Location = new System.Drawing.Point(40, 210);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(121, 15);
            this.labelChange.TabIndex = 6;
            this.labelChange.Text = "Нет учётной записи?";
            this.labelChange.Click += new System.EventHandler(this.labelChange_Click);
            this.labelChange.MouseEnter += new System.EventHandler(this.labelChange_MouseEnter);
            this.labelChange.MouseLeave += new System.EventHandler(this.labelChange_MouseLeave);
            // 
            // btnAuth
            // 
            this.btnAuth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAuth.Location = new System.Drawing.Point(40, 228);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(179, 41);
            this.btnAuth.TabIndex = 5;
            this.btnAuth.Text = "Войти";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль:";
            // 
            // passAuth
            // 
            this.passAuth.Location = new System.Drawing.Point(40, 165);
            this.passAuth.Name = "passAuth";
            this.passAuth.Size = new System.Drawing.Size(232, 23);
            this.passAuth.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // loginAuth
            // 
            this.loginAuth.Location = new System.Drawing.Point(40, 114);
            this.loginAuth.Name = "loginAuth";
            this.loginAuth.Size = new System.Drawing.Size(232, 23);
            this.loginAuth.TabIndex = 1;
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.labelAuth.Location = new System.Drawing.Point(40, 40);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(179, 37);
            this.labelAuth.TabIndex = 0;
            this.labelAuth.Text = "Авторизация";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelReg.ResumeLayout(false);
            this.panelReg.PerformLayout();
            this.panelAuth.ResumeLayout(false);
            this.panelAuth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnMods;
        private System.Windows.Forms.Label lblLogoName;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnCloseDesktop;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnFullscreen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAds;
        private System.Windows.Forms.Panel panelReg;
        private System.Windows.Forms.Label labelChange2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox loginReg;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameReg;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Panel panelAuth;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginAuth;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCreateAds;
    }
}
