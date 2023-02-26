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
    public partial class EditModel : Form
    {
        DataBase dataBase = new DataBase();
        int ID;
        bool edit_mode;
        public int Ret_ID;

        public EditModel(int id = -1)
        {
            ID = id;
            InitializeComponent();

            string querystring = $"select * from Model where id = {id}";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            if (table.Rows.Count == 1)
            {
                edit_mode = true;
                this.Text = "Изменить";
                this.buttonOK.Text = "Изменить";

                tb_name.Text = DBwork.FieldByName(table, "name").ToString();
                tb_weight.Text = DBwork.FieldByName(table, "weight").ToString();
                tb_height.Text = DBwork.FieldByName(table, "height").ToString();
                tb_width.Text = DBwork.FieldByName(table, "width").ToString();
                tb_depth.Text = DBwork.FieldByName(table, "depth").ToString();
                bool.TryParse(DBwork.FieldByName(table, "cashin").ToString(), out bool cashin);
                ch_cashin.Checked = cashin;
            }
            else
            {
                edit_mode = false;
                this.Text = "Добавить";
                this.buttonOK.Text = "Добавить";
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("Не введены основные параметры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int checkcashin = ch_cashin.Checked ? 1 : 0;

            string querystring;
            if (edit_mode)
            {
                querystring = $"update Model set name = '{tb_name.Text}', weight = '{tb_weight.Text}', " +
                      $"height = '{tb_height.Text}', width = '{tb_width.Text}', " +
                      $"depth = '{tb_depth.Text}', cashin = {checkcashin}  where id = {ID}";
                DBwork.ExeCommand(querystring, dataBase);
            }
            else
            {
                querystring = $"insert into Model (name, cashin, weight, height, width, depth) " +
                   $"values ('{tb_name.Text}', {checkcashin}, '{tb_weight.Text}', '{tb_height.Text}', " +
                   $"'{tb_width.Text}', '{tb_depth.Text}')";
                Ret_ID = DBwork.ExeScalar(querystring, dataBase);
            }

            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
