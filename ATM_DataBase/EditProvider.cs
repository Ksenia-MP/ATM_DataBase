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
    public partial class EditProvider : Form
    {
        DataBase dataBase = new DataBase();
        int ID;
        public int Ret_ID;

        public EditProvider(int id = -1)
        {
            ID = id;
            InitializeComponent();

            string querystring = $"select * from Provider where id = {id}";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            this.AcceptButton = buttonEdit;

            if (table.Rows.Count == 1)
            {
                this.Text = "Изменить";
                this.buttonAdd.Visible = false; //скрываем кнопку добавления записи
                this.AcceptButton = buttonEdit;

                tb_name.Text = DBwork.FieldByName(table, "name").ToString();
                tb_dns1.Text = DBwork.FieldByName(table, "dns1").ToString();
                tb_dns2.Text = DBwork.FieldByName(table, "dns2").ToString();
            }
            else
            {
                this.Text = "Добавить";
                this.buttonEdit.Visible = false;    //скрываем кнопку изменения записи
                this.AcceptButton = buttonAdd;
            }

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("Не введены основные параметры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string querystring = $"update Provider set name = '{tb_name.Text}', " +
                    $"dns1 = '{tb_dns1.Text}', dns2 = '{tb_dns2.Text}'  where id = {ID}";
            DBwork.ExeCommand(querystring, dataBase);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                MessageBox.Show("Не введены основные параметры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string querystring = $"insert into Provider (name, dns1, dns2) values ('{tb_name.Text}', '{tb_dns1.Text}', '{tb_dns2.Text}')";
            Ret_ID = DBwork.ExeScalar(querystring, dataBase);   //получаем ID созданной записи
            this.DialogResult = DialogResult.OK;    //результат выполнения как флаг добавления новой записи
            this.Close();
        }
    }
}
