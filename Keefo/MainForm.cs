using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Amafun
{
    public partial class MainForm : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public static string userName;
        public static string userLogin;
        public static string userPhone;
        public static string userTheme;
        public static bool moder;

        //Constructor
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            btnCloseDesktop.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            ThemeColor.GenerateTheme();
            lblTitle.Text = "Добро пожаловать!";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            BtnShow(false);
            panelReg.Visible = false;

            nameReg.MaxLength = 30;
            loginReg.MaxLength = 30;
            passReg.MaxLength = 30;
            phoneReg.MaxLength = 20;

            loginAuth.MaxLength = 30;
            passAuth.MaxLength = 30;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods: UI
        private Color SelectThemeColor()
        {
            if (String.IsNullOrWhiteSpace(userTheme) || userTheme == "Random")
            {
                int index = random.Next(ThemeColor.ColorList.Count);
                while (tempIndex == index)
                {
                    index = random.Next(ThemeColor.ColorList.Count);
                }
                tempIndex = index;
                string color = ThemeColor.ColorList[index];
                return ColorTranslator.FromHtml(color);
            }
            return ColorTranslator.FromHtml(userTheme);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseDesktop.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        #region Menu
        private void btnCreateAds_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCreateAds(), sender);
        }
        private void btnAds_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAds(), sender);
        }
        private void btnMods_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMods(), sender);
        }
        private void btnMyAds_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMyAds(), sender);
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
        }
        public static void PerformClickFromSettings()
        {
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnCloseDesktop_Click(sender, e);
            BtnShow(false);
            lblTitle.Text = "Добро пожаловать!";
            panelAuth.Visible = true;
        }
        #endregion
        private void btnCloseDesktop_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        public void Reset()
        {
            DisableButton();
            lblTitle.Text = userLogin;
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseDesktop.Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void bntHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void labelChange_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Font = new Font(label.Font.Name, label.Font.Size, FontStyle.Underline);
            label.ForeColor = Color.Blue;
        }
        private void labelChange_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Font = new Font(label.Font.Name, label.Font.Size, FontStyle.Regular);
            label.ForeColor = Color.Black;
        }
        private void labelChange_Click(object sender, EventArgs e)
        {
            if (panelAuth.Visible == true)
            {
                panelAuth.Visible = false;
                panelReg.Visible = true;
            }
            else
            {
                panelReg.Visible = false;
                panelAuth.Visible = true;
            }
        }
        public void BtnShow(bool val)
        {
            btnCreateAds.Visible = val;
            btnAds.Visible = val;
            btnMods.Visible = val;
            btnEnd.Visible = val;
            btnSettings.Visible = val;
            btnLogout.Visible = val;
        }
        private void MainForm_Activated(object sender, EventArgs e)
        {
            Repaint(false);
            Repaint(true);
            void Repaint(bool val)
            {
                panelLogo.Visible = val;
                lblLogoName.Visible = val;
                panelTitleBar.Visible = val;
                btnHide.Visible = val;
                btnFullscreen.Visible = val;
                btnClose.Visible = val;
            }
        }
        // Auth panel
        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameReg.Text;
                string login = loginReg.Text;
                string pass = passReg.Text;
                string phone = phoneReg.Text;

                DataBase db = new DataBase();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                if (checkData()) return;
                if (checkLogin()) return;

                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`name`, `login`, `pass`, `phone`) VALUES ( @name, @login, @pass, @phone); ", db.getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
                MySqlCommand command2 = new MySqlCommand("SELECT `user_login` FROM `admin` WHERE `user_login` = @L ", db.getConnection());
                command2.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;

                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    userLogin = login;
                    userPhone = phone;
                    string user_admin = (string)command2.ExecuteScalar();
                    MessageBox.Show("Аккаунт создан");
                    panelReg.Visible = false;
                    CompletedLogin();
                }
                else MessageBox.Show("Ошибка");

                db.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
        }
        private void btnAuth_Click(object sender, EventArgs e)
        {
            try
            {
                string login = loginAuth.Text;
                string pass = passAuth.Text;

                DataBase db = new DataBase();
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @L AND `pass` = @P ", db.getConnection());

                command.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@P", MySqlDbType.VarChar).Value = pass;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    MySqlCommand command2 = new MySqlCommand("SELECT `login` FROM `users` WHERE `login` = @L AND `pass` = @P ", db.getConnection());
                    command2.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
                    command2.Parameters.Add("@P", MySqlDbType.VarChar).Value = pass;
                    MySqlCommand command3 = new MySqlCommand("SELECT `phone` FROM `users` WHERE `login` = @L AND `pass` = @P ", db.getConnection());
                    command3.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
                    command3.Parameters.Add("@P", MySqlDbType.VarChar).Value = pass;
                    MySqlCommand command4 = new MySqlCommand("SELECT `user_login` FROM `admin` WHERE `user_login` = @L ", db.getConnection());
                    command4.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;

                    db.OpenConnection();
                    userLogin = (string)command2.ExecuteScalar();
                    userPhone = (string)command3.ExecuteScalar();
                    string user_admin = (string)command4.ExecuteScalar();
                    db.CloseConnection();

                    if (user_admin == userLogin)
                    {
                        moder = true;
                        MessageBox.Show("Здравствуйте, модератор " + userLogin + "!");
                    }
                    else moder = false;
                    panelAuth.Visible = false;
                    CompletedLogin();
                }
                else MessageBox.Show("Ошибка");
                ThemeColor.UpdateColor();
            }
            catch { MessageBox.Show("Ошибка соединения"); }
        }

        private void CompletedLogin()
        {
            BtnShow(true);
            Reset();
        }
        public Boolean checkLogin()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @L ", db.getConnection());

            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = loginReg.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть");
                return true;
            }
            else return false;
        }
        public Boolean checkData()
        {
            if (string.IsNullOrWhiteSpace(nameReg.Text) == true)
            {
                MessageBox.Show("Введите имя");
                return true;
            }
            if (string.IsNullOrWhiteSpace(loginReg.Text) == true)
            {
                MessageBox.Show("Введите логин");
                return true;
            }
            if (string.IsNullOrWhiteSpace(passReg.Text) == true)
            {
                MessageBox.Show("Введите пароль");
                return true;
            }
            if (string.IsNullOrWhiteSpace(phoneReg.Text) == true)
            {
                MessageBox.Show("Введите номер телефона");
                return true;
            }
            return false;
        }
        // WndProc override
        protected override void WndProc(ref Message m)
        {
            #region Resize
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            #region Maximize & Minimize
            const int WM_NCCALCSIZE = 0x0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
            #endregion
        }
    }
}