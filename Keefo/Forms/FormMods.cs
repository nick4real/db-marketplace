using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Amafun.Forms
{
    public partial class FormMods : Form
    {
        public FormMods()
        {
            InitializeComponent();
        }
        private void FormMods_Load(object sender, EventArgs e)
        {
            LoadTheme();
            DataGrid_Load();
            SetColumnsOrder();
        }
        private void DataGrid_Load()
        {
            DataBase bd = new DataBase();
            DataSet set = new DataSet();
            string sql = "";

            if (MainForm.moder) 
            { 
                sql = "SELECT * FROM `ads` WHERE `status` = 'moderate' "; 
                btnSend.Visible = true; 
            }
            else sql = "SELECT * FROM `ads` WHERE `status` = 'moderate' AND `user_login` = '" + MainForm.userLogin + "'";

            bd.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, bd.getConnection());
            bd.CloseConnection();
            adapter.Fill(set, "ads");

            dgvMode.DataSource = set.Tables["ads"];
            dgvMode.ReadOnly = true;
        }
        private void SetColumnsOrder()
        {
            dgvMode.Columns["id"].Visible = false;
            
            dgvMode.Columns["status"].Visible = false;

            dgvMode.Columns["category"].DisplayIndex = 0;
            dgvMode.Columns["title"].DisplayIndex = 1;
            dgvMode.Columns["description"].DisplayIndex = 2;
            dgvMode.Columns["cost"].DisplayIndex = 3;
            dgvMode.Columns["currency"].DisplayIndex = 4;

            dgvMode.Columns["category"].Width = 120;
            dgvMode.Columns["title"].Width = 120;
            dgvMode.Columns["description"].Width = 150;
            dgvMode.Columns["cost"].Width = 60;
            dgvMode.Columns["currency"].Width = 60;
            dgvMode.Columns["user_login"].Width = 100;

            dgvMode.Columns[2].HeaderText = "Категория";
            dgvMode.Columns[3].HeaderText = "Заголовок";
            dgvMode.Columns[4].HeaderText = "Описание";
            dgvMode.Columns[5].HeaderText = "Валюта";
            dgvMode.Columns[6].HeaderText = "Цена";
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
        private void btnSend_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dgvMode.CurrentRow.Cells[0].Value.ToString());

            DataBase db = new DataBase();

            string sql = "UPDATE ads SET status = 'active' WHERE id = @ul; ";
            MySqlCommand command = new MySqlCommand(sql, db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = id;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            { }
            else MessageBox.Show("Ошибка");
            db.CloseConnection();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dgvMode.CurrentRow.Cells[0].Value.ToString());

            DataBase db = new DataBase();

            string sql = "DELETE FROM ads WHERE id = @ul; ";
            MySqlCommand command = new MySqlCommand(sql, db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = id;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            { }
            else MessageBox.Show("Ошибка");
            db.CloseConnection();
        }
        private void dgvMode_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            var result = dgvMode.CurrentCell.Value.ToString();
            messageBoxCS.AppendFormat(Convert.ToString(result));
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "Подробнее...");
        }
    }
}
