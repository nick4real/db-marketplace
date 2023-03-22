using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Amafun.Forms
{
    public partial class FormAds : Form
    {
        public FormAds()
        {
            InitializeComponent();
        }
        private void FormAds_Load(object sender, EventArgs e)
        {
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadTheme();
            DataGrid_Load();
            UpdateCombo();
            SetColumnsOrder();
        }
        private void DataGrid_Load()
        {
            DataBase bd = new DataBase();
            DataSet set = new DataSet();

            string sql = "SELECT * FROM `ads` WHERE `status` = 'active' ";
            bd.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, bd.getConnection());
            bd.CloseConnection();
            adapter.Fill(set, "ads");

            dgvAds.DataSource = set.Tables["ads"];
            dgvAds.ReadOnly = true;
        }
        private void SetColumnsOrder()
        {
            dgvAds.Columns[2].HeaderText = "Категория";
            dgvAds.Columns[3].HeaderText = "Заголовок";
            dgvAds.Columns[4].HeaderText = "Описание";
            dgvAds.Columns[5].HeaderText = "Валюта";
            dgvAds.Columns[6].HeaderText = "Цена";

            dgvAds.Columns["id"].Visible = false;
            dgvAds.Columns["status"].Visible = false;
            dgvAds.Columns["user_login"].Visible = false;

            dgvAds.Columns["title"].DisplayIndex = 2;
            dgvAds.Columns["description"].DisplayIndex = 3;
            dgvAds.Columns["category"].DisplayIndex = 4;
            dgvAds.Columns["cost"].DisplayIndex = 5;
            dgvAds.Columns["currency"].DisplayIndex = 6;

            dgvAds.Columns["title"].Width = 200;
            dgvAds.Columns["description"].Width = 200;
            dgvAds.Columns["category"].Width = 120;
            dgvAds.Columns["cost"].Width = 80;
            dgvAds.Columns["currency"].Width = 60;

            dgvAds.Columns["title"].HeaderText = "Заголовок";
            dgvAds.Columns["description"].HeaderText = "Описание";
            dgvAds.Columns["category"].HeaderText = "Категория";
            dgvAds.Columns["cost"].HeaderText = "Цена";
            dgvAds.Columns["currency"].HeaderText = "Валюта";
        }
        private void UpdateCombo()
        {
            for (int i = 0; i < Lists.Category.Count; i++)
            {
                cmbFilter.Items.Add(Lists.Category[i]);
            }
            cmbFilter.Items.Add("Все категории");
            cmbFilter.Text = "Все категории";
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (dgvAds.CurrentRow == null) { return; }
            string id = Convert.ToString(dgvAds.CurrentRow.Cells[0].Value.ToString());
            string login = Convert.ToString(dgvAds.CurrentRow.Cells[1].Value.ToString());
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command1 = new MySqlCommand("SELECT `name` FROM `users` WHERE `login` = @L ", db.getConnection());
            command1.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;
            MySqlCommand command2 = new MySqlCommand("SELECT `phone` FROM `users` WHERE `login` = @L ", db.getConnection());
            command2.Parameters.Add("@L", MySqlDbType.VarChar).Value = login;

            db.OpenConnection();
            string userName = (string)command1.ExecuteScalar();
            string userPhone = (string)command2.ExecuteScalar();
            db.CloseConnection();

            MessageBox.Show($"Имя продавца: {userName}\nНомер продавца:{userPhone}", "Данные о продавце");
        }
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvAds_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            var result = dgvAds.CurrentCell.Value.ToString();
            messageBoxCS.AppendFormat(Convert.ToString(result));
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "Подробнее...");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataBase bd = new DataBase();
            DataSet set = new DataSet();
            string sql = cmbFilter.Text != "Все категории"
                ? "SELECT * FROM `ads` WHERE `status` = 'active' AND `category` = '" + cmbFilter.Text + "'"
                : "SELECT * FROM `ads` WHERE `status` = 'active'";

            sql = !String.IsNullOrWhiteSpace(txtSearch.Text)
                ? sql + " AND `title` LIKE '%" + txtSearch.Text + "%'"
                : sql;

            bd.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, bd.getConnection());
            bd.CloseConnection();
            adapter.Fill(set, "ads");

            dgvAds.DataSource = set.Tables["ads"];
            dgvAds.ReadOnly = true;
        }
    }
}
