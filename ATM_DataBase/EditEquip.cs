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
    public partial class EditEquip : Form
    {
        DataBase dataBase = new DataBase();
        int ID;
        public int Ret_ID;
        bool edit_mode;

        public EditEquip(int id = -1)
        {
            ID = id;
            InitializeComponent();

            string querystring = $"select * from Equipment where id = {id}";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            if (table.Rows.Count == 1)
            {
                edit_mode = true;
                cb_type.SelectedItem = DBwork.FieldByName(table, "type").ToString();
                tb_name.Text = DBwork.FieldByName(table, "name").ToString();
                ch_usb.Checked = (bool)DBwork.FieldByName(table, "usb");
                ch_com.Checked = (bool)DBwork.FieldByName(table, "com");
            }
            else
                edit_mode = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string querystring;
            int checkedusb = ch_usb.Checked ? 1 : 0;
            int checkedcom = ch_com.Checked ? 1 : 0;

            if (edit_mode)
            {
                //измменение записи
                querystring = $"update Equipment set type = '{cb_type.SelectedItem}', " +
                    $"name = '{tb_name.Text}', usb = {checkedusb}, com = {checkedcom}  where id = {ID}";

                DBwork.ExeCommand(querystring, dataBase);
            }
            else
            {
                //добавление оборудования
                querystring = $"insert into Equipment (type, name, usb, com) values ('{cb_type.SelectedItem}', '{tb_name.Text}', {checkedusb}, {checkedcom})";
                Ret_ID = DBwork.ExeScalar(querystring, dataBase);   //получаем ID созданной записи
                this.DialogResult = DialogResult.OK;    //результат выполнения как флаг добавления новой записи
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
