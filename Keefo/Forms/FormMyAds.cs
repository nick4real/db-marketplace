using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Amafun.Forms
{
    public partial class FormMyAds : Form
    {
        public FormMyAds()
        {
            InitializeComponent();
        }
        private void FormEnd_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadDataBase();
            SetColumnsOrder();
        }
        private void LoadDataBase()
        {
            DataBase bd = new DataBase();
            DataSet set = new DataSet();
            string sql = "SELECT * FROM `ads` WHERE `user_login` = '" + MainForm.userLogin + "'";

            bd.OpenConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, bd.getConnection());
            bd.CloseConnection();
            adapter.Fill(set, "ads");

            dgvEnd.DataSource = set.Tables["ads"];
            dgvEnd.ReadOnly = true;
        }
        private void SetColumnsOrder()
        {
            dgvEnd.Columns["id"].Visible = false;
            dgvEnd.Columns["status"].Visible = false;
            dgvEnd.Columns["user_login"].Visible = false;

            dgvEnd.Columns["category"].DisplayIndex = 0;
            dgvEnd.Columns["title"].DisplayIndex = 1;
            dgvEnd.Columns["description"].DisplayIndex = 2;
            dgvEnd.Columns["cost"].DisplayIndex = 3;
            dgvEnd.Columns["currency"].DisplayIndex = 4;

            dgvEnd.Columns["category"].Width = 120;
            dgvEnd.Columns["title"].Width = 200;
            dgvEnd.Columns["description"].Width = 200;
            dgvEnd.Columns["cost"].Width = 60;
            dgvEnd.Columns["currency"].Width = 60;

            dgvEnd.Columns[2].HeaderText = "Категория";
            dgvEnd.Columns[3].HeaderText = "Заголовок";
            dgvEnd.Columns[4].HeaderText = "Описание";
            dgvEnd.Columns[5].HeaderText = "Валюта";
            dgvEnd.Columns[6].HeaderText = "Цена";
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEnd.CurrentRow == null) { return; }
            int id = Convert.ToInt32(dgvEnd.CurrentRow.Cells[0].Value);

            DataBase db = new DataBase();

            string sql = "DELETE FROM ads WHERE id = @id; ";
            MySqlCommand command = new MySqlCommand(sql, db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            { }
            else MessageBox.Show("Ошибка");
            db.CloseConnection();
        }
        private void btnInactive_Click(object sender, EventArgs e)
        {
            if (dgvEnd.CurrentRow == null) { return; }
            int id = Convert.ToInt32(dgvEnd.CurrentRow.Cells[0].Value);

            DataBase db = new DataBase();

            string sql = "UPDATE ads SET status = 'inactive' WHERE id = @id; ";
            MySqlCommand command = new MySqlCommand(sql, db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            { }
            else MessageBox.Show("Ошибка");
            db.CloseConnection();
        }
        private void btnActive_Click(object sender, EventArgs e)
        {
            if (dgvEnd.CurrentRow == null) { return; }
            int id = Convert.ToInt32(dgvEnd.CurrentRow.Cells[0].Value);

            DataBase db = new DataBase();

            string sql = "UPDATE ads SET status = 'active' WHERE id = @id; ";
            MySqlCommand command = new MySqlCommand(sql, db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
            { }
            else MessageBox.Show("Ошибка");
            db.CloseConnection();
        }

        private void dgvEnd_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            var result = dgvEnd.CurrentCell.Value.ToString();
            messageBoxCS.AppendFormat(Convert.ToString(result));
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "Подробнее...");
        }
    }
}
