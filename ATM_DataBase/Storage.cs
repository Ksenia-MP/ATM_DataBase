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
    public partial class Storage : Form
    {
        DataBase dataBase = new DataBase();     //отвечает за подключение к бд
        BindingSource bindingSource = new BindingSource();  //связка sql запроса с таблицей

        public static int ID;   //ID выбранной записи в таблице 
        public static int ATM_ID;   //ID банкомата при выборе оборудования со склада

        public Storage()
        {
            InitializeComponent();

            dgvEquipStorage.DataSource = bindingSource;
            InitEqTable();
        }

        public Storage(int atm_id)
        {
            InitializeComponent();

            dgvEquipStorage.DataSource = bindingSource;
            buttonAddEq.Visible = false;
            buttonEditEq.Visible = false;
            buttonDeleteEq.Visible = false;
            ATM_ID = atm_id;

            InitEqTable();
        }

        /// <summary>
        /// Инициализация таблицы оборудования
        /// </summary>
        private void InitEqTable()
        {
            string querystring = "select a.id, a.sn 'SN', type 'Тип', name 'Наименование', a.part_no, com, usb " +
                "from ATM_Eq as a join Equipment as b on equipment_id = b.id " +
                "where atm_id is NULL order by type";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);
            this.dgvEquipStorage.SelectionChanged -= new System.EventHandler(this.dgvEquipStorage_SelectionChanged);
            bindingSource.DataSource = table;
            dgvEquipStorage.Columns[0].Visible = false;     //скрываем столбец с id
            dgvEquipStorage.Columns[4].Visible = false;     //скрываем столбец номера партии (part_no)
            dgvEquipStorage.Columns[5].Visible = false;     //скрываем столбец com подключения (com)
            dgvEquipStorage.Columns[6].Visible = false;     //скрываем столбец usb подключения (usb)
            this.dgvEquipStorage.SelectionChanged += new System.EventHandler(this.dgvEquipStorage_SelectionChanged);
        }

        private void dgvEquipStorage_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEquipStorage.SelectedRows.Count != 0)
            {
                ID = (int)dgvEquipStorage.SelectedRows[0].Cells[0].Value;
            }
            else ID = -1;

            RefreshEquipmentFields();
        }

        /// <summary>
        /// Переносит фокус на выбранную запись в таблице после модификаций записей
        /// </summary>
        public void SetCurrentRow(DataGridView dgv)
        {
            int row = DBwork.RowByID(dgv, ID);   //Получаем индекс строки по ID записи

            if (ID > 0 && row >= 0)     //если индекс найден 
                dgv.Rows[row].Selected = true;   //фокусинуемся на индексе row
            else
            {
                if (dgv.Rows.Count != 0)
                    dgv.Rows[0].Selected = true;
            }

            RefreshEquipmentFields();
        }

        private void RefreshEquipmentFields()
        {
            int index = dgvEquipStorage.SelectedRows.Count != 0? dgvEquipStorage.SelectedRows[0].Index: -1;
            if (index != -1)
            {
                lb_eq_part_no.Text = dgvEquipStorage.Rows[index].Cells[4].Value.ToString();
                checkBoxCom.Checked = dgvEquipStorage.Rows[index].Cells[5].Value.ToString().Equals("True");
                checkBoxUsb.Checked = dgvEquipStorage.Rows[index].Cells[6].Value.ToString().Equals("True");
            }
            else
            {
                lb_eq_part_no.Text = "";
                checkBoxCom.Checked = false;
                checkBoxUsb.Checked = false;
            }
            
        }

        private void buttonAddEq_Click(object sender, EventArgs e)
        {
            EditATMEquip edit = new EditATMEquip();
            if (edit.ShowDialog() == DialogResult.OK)
            {
                ID = edit.Ret_ID;   //получаем ID созданной записи
                InitEqTable();      //обновляем таблицу
                SetCurrentRow(dgvEquipStorage); //фокусируемся на новой записи
            }
        }

        private void buttonDeleteEq_Click(object sender, EventArgs e)
        {
            if (dgvEquipStorage.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы действительно хотите \nудалить выбранную запись?",
                "Удалить?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;  //если нажата отмена, не удаляем

            ID = (int)dgvEquipStorage.SelectedRows[0].Cells[0].Value;    //Получаем ID выбранной записи

            string querystring = $"delete from ATM_Eq where id = {ID}";    //строка запроса удаления записи

            DBwork.ExeCommand(querystring, dataBase);   //выполнение запроса

            ID = -1;    //сброс ID 
            InitEqTable();      //обновляем таблицу
            SetCurrentRow(dgvEquipStorage); //фокусируемся на первой записи
        }

        private void buttonEditEq_Click(object sender, EventArgs e)
        {
            if (dgvEquipStorage.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ID = (int)dgvEquipStorage.SelectedRows[0].Cells[0].Value;
            EditATMEquip edit = new EditATMEquip(-1, ID);
            if (edit.ShowDialog() == DialogResult.OK)
            {
                ID = edit.Ret_ID;   //получаем ID созданной записи
                InitEqTable();      //обновляем таблицу
                SetCurrentRow(dgvEquipStorage); //фокусируемся на новой записи
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (dgvEquipStorage.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для добавления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ID = (int)dgvEquipStorage.SelectedRows[0].Cells[0].Value;
            string querystring = $"update ATM_Eq set atm_id = {ATM_ID} where id = {ID}"; 
            DBwork.ExeCommand(querystring, dataBase);

            DialogResult = DialogResult.OK;
            InitEqTable();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
