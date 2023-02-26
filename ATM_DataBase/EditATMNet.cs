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
    public partial class EditATMNet : Form
    {
        DataBase dataBase = new DataBase();
        int ID;

        public EditATMNet(int id = -1)
        {
            ID = id;
            InitializeComponent();

            string querystring = $"select * from ATM where id = {id}";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            if (table.Rows.Count == 1)
            {
                this.Text = "Изменить";
                this.buttonOK.Text = "Изменить";

                tb_bank_ip.Text = DBwork.FieldByName(table, "bank_ip").ToString();
                tb_bank_mask.Text = DBwork.FieldByName(table, "bank_mask").ToString();
                tb_bank_gw.Text = DBwork.FieldByName(table, "bank_gw").ToString();
                tb_ext_ip.Text = DBwork.FieldByName(table, "ext_ip").ToString();
                tb_ext_mask.Text = DBwork.FieldByName(table, "ext_mask").ToString();
                tb_ext_gw.Text = DBwork.FieldByName(table, "ext_gw").ToString();
                bool.TryParse(DBwork.FieldByName(table, "pr_adsl").ToString(), out bool adsl);
                ch_adsl.Checked = adsl;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int checkedadsl = ch_adsl.Checked ? 1 : 0;

            string querystring = $"update ATM set bank_ip = '{tb_bank_ip.Text.Replace(",",".")}', bank_mask = '{tb_bank_mask.Text.Replace(",", ".")}', " +
                $"bank_gw = '{tb_bank_gw.Text.Replace(",", ".")}', ext_ip = '{tb_ext_ip.Text.Replace(",", ".")}', ext_mask = '{tb_ext_mask.Text.Replace(",", ".")}', " +
                $"ext_gw = '{tb_ext_gw.Text.Replace(",", ".")}', pr_adsl = '{checkedadsl}' where id = {ID}";

            DBwork.ExeCommand(querystring, dataBase);

            this.Hide();
        }
    }
}
