using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_DataBase
{
    public partial class Journal : Form
    {
        DataBase dataBase = new DataBase();
        int ID; //ID ATM
        int Journal_ID;
        int Ret_ID;
        bool edit_mode;

        public Journal(int id_atm, int id_journal = -1)
        {
            ID = id_atm;
            Journal_ID = id_journal;
            InitializeComponent();

            if (id_journal != -1) 
            { 
                edit_mode = true;
                this.Text = "Изменить";
                btnAdd.Text = "Изменить";

                string querystring = $"select * from History where id = {id_journal}";
                DataTable table = DBwork.ExeSelect(querystring, dataBase);
                if (table.Rows.Count == 1)
                {
                    tb_coment.Text = DBwork.FieldByName(table, "comments").ToString();
                    tb_date.Text = DBwork.FieldByName(table, "date").ToString();
                }
            }
            else
            {
                edit_mode = false;
                this.Text = "Добавить";
                dtp_journal_date.Value = DateTime.Today;
            }

            btnAdd.Enabled = false;
        }

        private void dtp_journal_date_ValueChanged(object sender, EventArgs e)
        {
            tb_date.Text = dtp_journal_date.Value.ToShortDateString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((tb_coment.Text == "") || (tb_date.Text == ""))
            {
                MessageBox.Show("Не введены основные параметры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string s_date = tb_date.Text == "  .  ." ? "NULL" : $"'{tb_date.Text}'";

            string querystring;
            if (edit_mode)
            {
                querystring = $"update History set comments = '{tb_coment.Text}', date = {s_date}" +
                    $"where id = {Journal_ID} and atm_id = {ID}";
                DBwork.ExeCommand(querystring, dataBase);
            }
            else
            {
                querystring = $"insert into History (atm_id, comments, date) " +
                   $"values ('{ID}', '{tb_coment.Text}', {s_date})";
                Ret_ID = DBwork.ExeScalar(querystring, dataBase);
            }

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void EnableOK(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
        }
    }
}
