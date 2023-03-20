using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Amafun.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }
        private void FormSettings_Load(object sender, EventArgs e)
        {
            LoadTheme();

            cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateCombo();
        }
        private void LoadTheme()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                {
                    Button btn = (Button)ctrl;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                if (ctrl.GetType() == typeof(Label))
                {
                    Label lbl = (Label)ctrl;
                    lbl.ForeColor = ThemeColor.PrimaryColor;
                }
            }
        }
        // Account delete
        private void lblDelete_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Font = new Font(label.Font.Name, label.Font.Size, FontStyle.Underline);
            label.ForeColor = Color.Red;
        }
        private void lblDelete_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.Font = new Font(label.Font.Name, label.Font.Size, FontStyle.Regular);
            label.ForeColor = ThemeColor.PrimaryColor;
        }
        private void lblDelete_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            string sql = "DELETE FROM users WHERE login = @ul; ";
            MySqlCommand command = new MySqlCommand(sql, db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = MainForm.userLogin;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("'До скорых встреч!' ПС Amafun");
                Application.Exit();
            }
            else MessageBox.Show("Ошибка");
            db.CloseConnection();
        }
        // Color control
        public void UpdateCombo()
        {
            cmbColor.Items.Add("Random");
            for (int i = 0; i < ThemeColor.ColorList.Count; i++)
            {
                cmbColor.Items.Add(ThemeColor.ColorList[i]);
            }
            cmbColor.Text = MainForm.userTheme;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectedColor = cmbColor.Text;
            string sql = "";

            if (CheckDataBaseSettings())
            {
                sql = "UPDATE settings SET color_theme = @ct WHERE user_login = @ul; ";
            }
            else
            {
                sql = "INSERT INTO `settings` (`user_login`, `color_theme`) VALUES ( @ul, @ct); ";
            }
            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand(sql, db.getConnection());

            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = MainForm.userLogin;
            command.Parameters.Add("@ct", MySqlDbType.VarChar).Value = selectedColor;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Настройки применены.");
            }
            else MessageBox.Show("Ошибка");
            db.CloseConnection();

            ThemeColor.UpdateColor();
        }
        public bool CheckDataBaseSettings()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `settings` WHERE `user_login` = @L ", db.getConnection());

            command.Parameters.Add("@L", MySqlDbType.VarChar).Value = MainForm.userLogin;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColor.Text != "Random")
                pnlColorShow.BackColor = ColorTranslator.FromHtml(cmbColor.Text);
        }
    }
}
