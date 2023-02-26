using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATM_DataBase
{
    public partial class EditATM : Form
    {
        private DataBase dataBase = new DataBase(); //подключение к БД
        private int ID;     //ID текущей записи
        public int Ret_ID { get; set; } //ID добавленной записи

        /// <summary>
        /// Форма создания/модификации записи ATM
        /// </summary>
        /// <param name="id">ID текущей записи; При добавлении пустое</param>
        public EditATM(int id = -1) //по умолчанию(создание), иначе изменение
        {
            ID = id;
            InitializeComponent();

            string querystring = $"select * from ATM where id = {id}";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);  //получаем текущую запись ATM

            if (table.Rows.Count == 1)
            {
                this.Text = "Изменить";
                this.buttonAdd.Visible = false; //скрываем кнопку добавления записи
                this.AcceptButton = buttonEdit;

                //указавыем значения полей
                tb_bank_no.Text = DBwork.FieldByName(table, "bank_no").ToString();
                tb_serial_no.Text = DBwork.FieldByName(table, "serial_no").ToString();
                tb_address.Text = DBwork.FieldByName(table, "address").ToString();
                tb_n.Text = DBwork.FieldByName(table, "n").ToString();
                tb_e.Text = DBwork.FieldByName(table, "e").ToString();
                tb_setting_date.Text = DateTime.TryParse(DBwork.FieldByName(table, "setting_date").ToString(), out DateTime dt) ? dt.ToShortDateString() : "";
                ch_ups.Checked = (bool)DBwork.FieldByName(table, "ups");
            }
            else
            {
                this.Text = "Добавить";
                this.buttonEdit.Visible = false;    //скрываем кнопку изменения записи
                this.AcceptButton = buttonAdd;
            }
        }

        /// <summary>
        /// Созраняет изменения параметров записи ATM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (tb_bank_no.Text == "")
            {
                MessageBox.Show("Не введены основные параметры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var (checkedups, s_n, s_e, s_date) = GetNormParams();

            string querystring = $"update ATM set bank_no = '{tb_bank_no.Text}', serial_no = '{tb_serial_no.Text}', " +
                $"address = '{tb_address.Text}', n = '{s_n}', e = '{s_e}', setting_date = {s_date}, " +
                $"ups = '{checkedups}' where id = {ID}";

            DBwork.ExeCommand(querystring, dataBase);

            this.Close();
        }

        /// <summary>
        /// Добавляет новую запись ATM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tb_bank_no.Text == "")
            {
                MessageBox.Show("Не введены основные параметры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var (checkedups, s_n, s_e, s_date) = GetNormParams();

            string querystring = $"insert into ATM (bank_no, serial_no, address, n, e, setting_date, ups) " +
                    $"values ('{tb_bank_no.Text}', '{tb_serial_no.Text}', '{tb_address.Text}', '{s_n}', '{s_e}', " +
                    $"{s_date}, '{checkedups}')";

            Ret_ID = DBwork.ExeScalar(querystring, dataBase); //получаем ID созданной записи
            this.DialogResult = DialogResult.OK;    //результат выполнения как флаг добавления новой записи
            this.Close();
        }

        /// <summary>
        /// Событие изменения даты в DateTimePicker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtp_setting_date_ValueChanged(object sender, EventArgs e)
        {
            tb_setting_date.Text = dtp_setting_date.Value.ToShortDateString(); //в текстбокс заносится дата
        }

        /// <summary>
        /// Приводит параметры к нормализованному виду перед сохранением
        /// </summary>
        /// <returns>Строковые переменные для параметров записи ATM</returns>
        private (int checkedups, string s_n, string s_e, string s_date) GetNormParams()
        {
            int checkedups = ch_ups.Checked ? 1 : 0;
            string s_n = tb_n.Text.Replace(",", ".");
            string s_e = tb_e.Text.Replace(",", ".");
            string s_date = tb_setting_date.Text == "  .  ." ? "NULL" : $"'{tb_setting_date.Text}'";
            return (checkedups, s_n, s_e, s_date);
        }

        /// <summary>
        /// При запуске формы переносит фокус на первое поле формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditATM_Shown(object sender, EventArgs e)
        {
            tb_bank_no.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
