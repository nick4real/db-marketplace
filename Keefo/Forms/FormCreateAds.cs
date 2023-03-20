using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Amafun.Forms
{
    public partial class FormCreateAds : Form
    {
        public FormCreateAds()
        {
            InitializeComponent();
        }
        private void FormSettings_Load(object sender, EventArgs e)
        {
            LoadTheme();

            cmbCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
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
        // Color control
        public void UpdateCombo()
        {
            for (int i = 0; i < Lists.Category.Count; i++)
            {
                cmbCat.Items.Add(Lists.Category[i]);
            }
            cmbCat.Text = Lists.Category[0];

            for (int i = 0; i < Lists.Currency.Count; i++)
            {
                cmbCurrency.Items.Add(Lists.Currency[i]);
            }
            cmbCurrency.Text = Lists.Currency[0];
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (checkData()) return;

            MySqlCommand command = new MySqlCommand(
                "INSERT INTO `ads`" +
                "(`user_login`, `category`, `title`, `description`, `currency`, `cost`, `status`)" +
                "VALUES " +
                "(@user_login, @category, @title, @description, @currency, @cost, @status); ", db.getConnection());

            command.Parameters.Add("@user_login", MySqlDbType.VarChar).Value = MainForm.userLogin;
            command.Parameters.Add("@category", MySqlDbType.VarChar).Value = cmbCat.Text;
            command.Parameters.Add("@title", MySqlDbType.VarChar).Value = txtTitle.Text;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = rchDesciption.Text;
            command.Parameters.Add("@currency", MySqlDbType.VarChar).Value = cmbCurrency.Text;
            command.Parameters.Add("@cost", MySqlDbType.VarChar).Value = txtCost.Text;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = "moderate";

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Объявление создано!");
                ClearBoxes();
            }
            else MessageBox.Show("Ошибка");
            db.CloseConnection();
        }
        private void ClearBoxes()
        {
            txtTitle.Text = "";
            rchDesciption.Text = "";
            txtCost.Text = "";
        }
        public bool checkData()
        {
            if (String.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Заполните заголовок.");
                return true;
            }
            if (String.IsNullOrWhiteSpace(rchDesciption.Text))
            {
                MessageBox.Show("Заполните описание.");
                return true;
            }
            if (String.IsNullOrWhiteSpace(txtCost.Text))
            {
                MessageBox.Show("Введите цену.");
                return true;
            }
            return false;
        }
        private void TextBoxNumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
