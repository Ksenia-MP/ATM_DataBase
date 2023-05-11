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
    public partial class EditATMEquip : Form
    {
        DataBase dataBase = new DataBase();     //база данных
        int ID;     //ID текущего банкомата
        int ATMeq_ID; //ID выбранного оборудования
        public int Ret_ID; //ID добавленной записи в ATM_Eq
        object[,] id_and_name;  //ID и наименование для comboBox

        /// <summary>
        /// Конструктор формы изменения/добавления оборудования к ATM
        /// </summary>
        /// <param name="atm_id">Идентификатор записи ATM</param>
        /// <param name="eq_id">Идентификатор оборудования, при добавлении пустрое</param>
        public EditATMEquip(int atm_id = -1, int atm_eq_id = -1)
        {
            ID = atm_id;
            ATMeq_ID = atm_eq_id;

            InitializeComponent();

            GetEquipment();

            if (atm_eq_id != -1)
            {
                this.Text = "Изменить";
                this.buttonAdd.Visible = false; //скрываем кнопку добавления записи
                this.AcceptButton = buttonEdit;

                string querystring = $"select sn, part_no, equipment_id from ATM_Eq where id = {atm_eq_id}";    // and atm_id = {ID}";
                DataTable table = DBwork.ExeSelect(querystring, dataBase);

                tb_sn.Text = DBwork.FieldByName(table, "sn").ToString();
                tb_part_no.Text = DBwork.FieldByName(table, "part_no").ToString();
                string eq_id = DBwork.FieldByName(table, "equipment_id").ToString();
                querystring = $"select * from Equipment where id = {eq_id}";
                table = DBwork.ExeSelect(querystring, dataBase);

                cb_name.SelectedItem = DBwork.FieldByName(table, "name") + " - " + DBwork.FieldByName(table, "type");
                FillParams(table);
            }
            else
            {
                this.Text = "Добавить";
                this.buttonEdit.Visible = false;    //скрываем кнопку изменения записи
                this.AcceptButton = buttonAdd;
            }
            
        }

        private void GetEquipment()
        {
            cb_name.Items.Clear();

            string querystring = "select id, name, type from Equipment";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            int r = table.Rows.Count;
            id_and_name = new object[r, 2];
            for (int i = 0; i < r; i++)
            {
                id_and_name[i, 0] = (int)table.Rows[i][0];
                id_and_name[i, 1] = table.Rows[i][1] + " - " + table.Rows[i][2];
                cb_name.Items.Add(id_and_name[i, 1]);
            }
        }

        private void FillParams(DataTable table)
        {
            tb_type.Text = DBwork.FieldByName(table, "type").ToString();
            bool.TryParse(DBwork.FieldByName(table, "usb").ToString(), out bool usb);
            ch_usb.Checked = usb;
            bool.TryParse(DBwork.FieldByName(table, "com").ToString(), out bool com);
            ch_com.Checked = com;
        }

        private void cb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cb_name.Text;
            int equip_id = 0;

            for (int i = 0; i < id_and_name.GetLength(0); i++)
            {
                if (name == id_and_name[i, 1].ToString())
                {
                    equip_id = (int)id_and_name[i, 0];
                    continue;
                }
            }

            if (equip_id == 0) return;

            string querystring = $"select * from Equipment where id = {equip_id}";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            FillParams(table);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            cb_name.SelectedIndex = -1;
            tb_type.Text = "";
            ch_com.Checked = false;
            ch_usb.Checked = false;
        }

        private void buttonAddEq_Click(object sender, EventArgs e)
        {
            EditEquip edit = new EditEquip();
            if (edit.ShowDialog() == DialogResult.OK)
            {
                ATMeq_ID = edit.Ret_ID;
                string querystring = $"select name, type from Equipment where id = {ATMeq_ID}";
                DataTable table = DBwork.ExeSelect(querystring, dataBase);

                GetEquipment();
                cb_name.SelectedItem = DBwork.FieldByName(table, "name") + " - " + DBwork.FieldByName(table, "type");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string eq_name = cb_name.Text;
            int eq_id = 0;
            for (int i = 0; i < id_and_name.GetLength(0); i++)
            {
                if (eq_name == id_and_name[i, 1].ToString())
                    eq_id = (int)id_and_name[i, 0];
            }

            if (eq_id == 0)
            {
                MessageBox.Show("Не выбрано оборудование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string s_eq_id = eq_id.ToString();
            string s_atm_id = ID == -1 ? "NULL" : ID.ToString();

            string querystring = $"update ATM_Eq set atm_id = {s_atm_id}, sn = '{tb_sn.Text}', " +
                $"part_no = '{tb_part_no.Text}', equipment_id = '{s_eq_id}' " +
                $"where id = {ATMeq_ID}"; //and atm_id = {ID}";
            
            DBwork.ExeCommand(querystring, dataBase);
            Ret_ID = ATMeq_ID;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string eq_name = cb_name.Text;
            int eq_id = 0;
            for (int i = 0; i < id_and_name.GetLength(0); i++)
            {
                if (eq_name == id_and_name[i, 1].ToString())
                    eq_id = (int)id_and_name[i, 0];
            }

            if (eq_id == 0)
            {
                MessageBox.Show("Не выбрано оборудование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string s_eq_id = eq_id.ToString();
            string s_atm_id = ID == -1 ? "NULL" : ID.ToString();

            string querystring = $"insert into ATM_Eq (atm_id, sn, part_no, equipment_id) " +
                $"values ({s_atm_id}, '{tb_sn.Text}', '{tb_part_no.Text}', {s_eq_id})";
            this.DialogResult = DialogResult.OK;
            Ret_ID = DBwork.ExeScalar(querystring, dataBase);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
