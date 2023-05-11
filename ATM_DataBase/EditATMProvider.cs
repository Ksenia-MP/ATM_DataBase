using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_DataBase
{
    public partial class EditATMProvider : Form
    {
        DataBase dataBase = new DataBase();
        int ID;
        public static int added_provider_id;
        object[,] pr_id_and_name;

        public EditATMProvider(int id)
        {
            ID = id;
            InitializeComponent();

            GetProviders();

            string querystring = $"select ATM.id, provider_id, pr_line_no, pr_contract_no, pr_contract_date, Provider.id, name " +
                $"from ATM left join Provider " +
                $"on provider_id = Provider.id where ATM.id = {id}";
            DataTable table = DBwork.ExeSelect(querystring,dataBase);

            this.Text = "Изменить";
            this.buttonOK.Text= "Изменить";

            if (DBwork.FieldByName(table, "provider_id") != DBNull.Value)
            {
                cb_name.SelectedItem = DBwork.FieldByName(table, "name").ToString();
            }
            else cb_name.SelectedIndex = -1;
            tb_pr_line_no.Text = DBwork.FieldByName(table, "pr_line_no").ToString();
            tb_contract_no.Text = DBwork.FieldByName(table, "pr_contract_no").ToString();
            tb_date.Text = DateTime.TryParse(DBwork.FieldByName(table, "pr_contract_date").ToString(), out DateTime dt) ? dt.ToShortDateString() : "";
            //заполнение полей сделай!!!(>-<)!!!
        }

        private void GetProviders()
        {
            cb_name.Items.Clear();

            string querystring = "select id, name from Provider";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            int r = table.Rows.Count;
            pr_id_and_name = new object[r, 2];
            for (int i = 0; i < r; i++)
            {
                pr_id_and_name[i, 0] = (int)table.Rows[i][0];
                pr_id_and_name[i, 1] = table.Rows[i][1].ToString();
                cb_name.Items.Add(pr_id_and_name[i, 1]);
            }
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            string pr_name = cb_name.Text;

            int pr_id = 0;
            for (int i = 0; i < pr_id_and_name.GetLength(0); i++)
            {
                if (pr_name == pr_id_and_name[i, 1].ToString())
                    pr_id = (int)pr_id_and_name[i, 0];
            }

            string s_id = pr_id == 0 ? "NULL" : pr_id.ToString();
            string s_date = tb_date.Text == "  .  ." ? "NULL" : $"'{tb_date.Text}'";
            string querystring = $"update ATM set provider_id = {s_id}, pr_line_no = '{tb_pr_line_no.Text}', " +
                $"pr_contract_no = '{tb_contract_no.Text}', pr_contract_date = {s_date}, " +
                $"renter_company = '{tb_company.Text}', renter_name = '{tb_renter_name.Text}', renter_phone = '{tb_phone.Text}' " +
                $"where id = {ID}";

            DBwork.ExeCommand(querystring, dataBase);

            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditProvider edit = new EditProvider();
            if (edit.ShowDialog() == DialogResult.OK)
            {
                added_provider_id = edit.Ret_ID;
                string querystring = $"select name from Provider where id = {added_provider_id}";
                DataTable table = DBwork.ExeSelect(querystring, dataBase);

                GetProviders();
                cb_name.SelectedItem = DBwork.FieldByName(table, "name").ToString();
            }
        }

        private void cb_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                cb_name.SelectedIndex = -1;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            cb_name.SelectedIndex = -1;
        }

        private void dtp_contract_date_ValueChanged(object sender, EventArgs e)
        {
            tb_date.Text = dtp_contract_date.Value.ToShortDateString();
        }

    }
}
