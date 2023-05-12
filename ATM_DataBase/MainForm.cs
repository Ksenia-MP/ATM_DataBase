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
using System.Threading;
using System.Net.NetworkInformation;

namespace ATM_DataBase
{
    public partial class MainForm : Form
    {
        DataBase dataBase = new DataBase();     //отвечает за подключение к бд
        BindingSource bindingSource = new BindingSource();  //связка sql запроса с таблицей
        
        public static int ID;   //ID выбранной записи в таблице 
        private bool f_modify_mode; //контроль выбранной записи в таблице

        Image img_on = new Bitmap(Environment.CurrentDirectory + "\\on.png");
        Image img_off = new Bitmap(Environment.CurrentDirectory + "\\off.png");

        EditATM editATM;
        EditATMProvider editProvider;
        EditATMNet editNet;
        EditATMModel editModel;
        EditATMEquip editEqiup;
        Journal journal;

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            dgvATM.DataSource = bindingSource;

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn(); 
            dgvATM.Columns.Add(imgColumn);

            InitGrid(); //инициализация таблицы ATM
            SetCurrentRow();    //установить текущий ряд
            RefreshTab();
        }

        /// <summary>
        /// Инициализация таблицы ATM
        /// </summary>
        private void InitGrid()
        {
            f_modify_mode = true;

            string querystring = "select id, bank_no '№ ATM', serial_no 'S/N', address 'Адрес' from ATM order by bank_no";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            dgvATM.RowEnter -= new DataGridViewCellEventHandler(this.dgvATM_RowEnter);
            bindingSource.DataSource = table;
            dgvATM.Columns["id"].Visible = false;  //скрываем столбец с таблицами
            dgvATM.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvATM.Columns[0].Width = 34;
            dgvATM.Columns["№ ATM"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvATM.Columns["№ ATM"].Width = 70;
            dgvATM.Columns["S/N"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvATM.Columns["S/N"].Width = 100;

            

            dgvATM.RowEnter += new DataGridViewCellEventHandler(this.dgvATM_RowEnter);
            f_modify_mode = false;
        }

        /// <summary>
        /// Переносит фокус на выбранную запись в таблице после модификаций записей
        /// </summary>
        public void SetCurrentRow()
        {
            int row = DBwork.RowByID(dgvATM, ID);   //Получаем индекс строки по ID записи

            if (ID > 0 && row >= 0)     //если индекс найден 
            {
                dgvATM.Rows[row].Selected = true;   //фокусинуемся на индексе row
            }
            else if (dgvATM.Rows.Count > 0)     //если записи с указанным ID нет
                ID = (int)dgvATM.Rows[0].Cells["id"].Value;    //ID присваивается значение ID первой записи
        }


        /// <summary>
        /// Открытие формы добавления новой записи в таблицу ATM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f_modify_mode = true;
            editATM = new EditATM();
            if (editATM.ShowDialog() == DialogResult.OK)
            {
                ID = editATM.Ret_ID;   //получаем ID созданной записи
                InitGrid();         //обновляем таблицу
                SetCurrentRow();    //фокусируемся на созданной записи
                RefreshTab();   //обновление полей
            }
            f_modify_mode = false;
        }

        /// <summary>
        /// Открытие формы модификации записи в таблице ATM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            f_modify_mode = true;
            if (dgvATM.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ID = (int)dgvATM.SelectedRows[0].Cells["id"].Value; //нулевой столбец содержит ID (Visible = false)
            editATM = new EditATM(ID);
            editATM.ShowDialog();
            InitGrid();         //обновляем таблицу
            SetCurrentRow();    //фокусируемся на созданной записи
            RefreshTab();   //обновление полей
            f_modify_mode = false;
        }

        /// <summary>
        /// Удаляет выбранную записть в таблице ATM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvATM.SelectedRows.Count == 0)
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

            ID = (int)dgvATM.SelectedRows[0].Cells["id"].Value;    //Получаем ID выбранной записи

            string querystring = $"delete from ATM where id = {ID}";    //строка запроса удаления записи

            DBwork.ExeCommand(querystring, dataBase);   //выполнение запроса

            bindingSource.DataSource = null;    //очистка таблицы
            bindingSource.Clear();
            ID = -1;

            InitGrid();     //обновление таблицы
            SetCurrentRow();
            RefreshTab();   //обновление полей
        }


        private void RefreshTab()
        {
            lb_bank_no.Text = "_____";
            lb_serial_no.Text = "__________";
            lb_address.Text = "______________________________\n______________________________";
            lb_n.Text = "_____";
            lb_e.Text = "_____";
            lb_setting_date.Text = "__________";
            ch_ups.Checked = false;

            lb_bank_ip.Text = "_______________";
            lb_bank_mask.Text = "_______________";
            lb_bank_gw.Text = "_______________";
            lb_ext_ip.Text = "_______________";
            lb_ext_mask.Text = "_______________";
            lb_ext_gw.Text = "_______________";
            ch_adsl.Checked = false;

            lb_pr_name.Text = "____________________";
            lb_pr_line_no.Text = "____________________";
            lb_pr_contract_no.Text = "____________________";
            lb_pr_contract_date.Text = "__________";
            lb_renter_company.Text = "_________________________";
            lb_renter_name.Text = "_________________________";

            lb_model_name.Text = "_______________";
            lb_weight.Text = "_______________";
            lb_height.Text = "_______________";
            lb_width.Text = "_______________";
            lb_depth.Text = "_______________";
            ch_cashin.Checked = false;

            string querystring = $"select * from ATM where id = {ID}";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            if (table.Rows.Count != 1) return;

            lb_bank_no.Text = DBwork.FieldByName(table, "bank_no").ToString();
            lb_serial_no.Text = DBwork.FieldByName(table, "serial_no").ToString();
            lb_address.Text = DBwork.FieldByName(table, "address").ToString();
            lb_n.Text = DBwork.FieldByName(table, "n").ToString();
            lb_e.Text = DBwork.FieldByName(table, "e").ToString();
            lb_setting_date.Text = DateTime.TryParse(DBwork.FieldByName(table, "setting_date").ToString(), out DateTime setdt) ? setdt.ToShortDateString() : "";
            ch_ups.Checked = (bool)DBwork.FieldByName(table, "ups");

            lb_bank_ip.Text = DBwork.FieldByName(table, "bank_ip").ToString();
            lb_bank_mask.Text = DBwork.FieldByName(table, "bank_mask").ToString();
            lb_bank_gw.Text = DBwork.FieldByName(table, "bank_gw").ToString();
            lb_ext_ip.Text = DBwork.FieldByName(table, "ext_ip").ToString();
            lb_ext_mask.Text = DBwork.FieldByName(table, "ext_mask").ToString();
            lb_ext_gw.Text = DBwork.FieldByName(table, "ext_gw").ToString();
            bool.TryParse(DBwork.FieldByName(table, "pr_adsl").ToString(), out bool adsl);
            ch_adsl.Checked = adsl;

            lb_pr_line_no.Text = DBwork.FieldByName(table, "pr_line_no").ToString();
            lb_pr_contract_no.Text = DBwork.FieldByName(table, "pr_contract_no").ToString();
            lb_pr_contract_date.Text = DateTime.TryParse(DBwork.FieldByName(table, "pr_contract_date").ToString(), out DateTime dt) ? dt.ToShortDateString() : "";
            lb_renter_company.Text = DBwork.FieldByName(table, "renter_company").ToString();
            lb_renter_name.Text = DBwork.FieldByName(table, "renter_name").ToString();
            lb_renter_phone.Text = DBwork.FieldByName(table, "renter_phone").ToString();

            if (int.TryParse(DBwork.FieldByName(table, "provider_id").ToString(), out int pr_id))
            {
                querystring = $"select id, name from Provider where id = {pr_id}";
                DataTable provider_table = DBwork.ExeSelect(querystring, dataBase);

                if (provider_table.Rows.Count == 1)
                    lb_pr_name.Text = DBwork.FieldByName(provider_table, "name").ToString();
            }


            int.TryParse(DBwork.FieldByName(table, "model_id").ToString(), out int model_id);
            querystring = $"select * from Model where id = {model_id}";
            DataTable model_table = DBwork.ExeSelect(querystring, dataBase);

            if (model_table.Rows.Count == 1)
            {
                lb_model_name.Text = DBwork.FieldByName(model_table, "name").ToString();
                lb_weight.Text = DBwork.FieldByName(model_table, "weight").ToString();
                lb_height.Text = DBwork.FieldByName(model_table, "height").ToString();
                lb_width.Text = DBwork.FieldByName(model_table, "width").ToString();
                lb_depth.Text = DBwork.FieldByName(model_table, "depth").ToString();
                bool.TryParse(DBwork.FieldByName(model_table, "cashin").ToString(), out bool cashin);
                ch_cashin.Checked = cashin;
            }

            RefreshEquipmetTable();
            RefreshEquipmentFields();
            RefreshJournalTable();
        }

        private void RefreshEquipmetTable()
        {
            string querystring = $"select a.id, type, name, usb, com from ATM_Eq as a join Equipment as b on equipment_id = b.id where atm_id = {ID}";
            
            DataTable equip_table = DBwork.ExeSelect(querystring, dataBase);

            dgv_atm_equip.DataSource = equip_table;
            dgv_atm_equip.Columns[0].Visible = false;
        }

        private void RefreshJournalTable()
        {
            string querystring = $"select id, date 'Дата', comments 'Комментарии' from History where atm_id = {ID} order by date DESC, id DESC";

            DataTable journal_table = DBwork.ExeSelect(querystring, dataBase);

            dgv_journal.DataSource = journal_table;
            dgv_journal.Columns[0].Visible = false; //убираем ID

            dgv_journal.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgv_journal.Columns[1].Width = 80;

        }

        private void RefreshEquipmentFields()
        {
            
            if (dgv_atm_equip.SelectedRows.Count != 0)
            {
                int atm_eq_id = (int)dgv_atm_equip.SelectedRows[0].Cells[0].Value;
                string querystring = $"select sn, part_no from ATM_Eq where id = {atm_eq_id} and atm_id = {ID}";
                DataTable table = DBwork.ExeSelect(querystring, dataBase);

                lb_eq_sn.Text = DBwork.FieldByName(table, "sn").ToString();
                lb_eq_part_no.Text = DBwork.FieldByName(table, "part_no").ToString();
            }
            else
            {
                lb_eq_sn.Text = "";
                lb_eq_part_no.Text = "";
            }
        }

        private void dgvATM_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!f_modify_mode)
                ID = (int)dgvATM.Rows[e.RowIndex].Cells["id"].Value;
            RefreshTab();
        }

        private void EquipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            equipment.ShowDialog();
            RefreshTab();
        }

        private void ProviderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provider provider = new Provider();
            provider.ShowDialog();
            RefreshTab();
        }

        private void ModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            model.ShowDialog();
            RefreshTab();
        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditToolStripMenuItem_Click(sender, e);
        }

        private void buttonEdit_provider_Click(object sender, EventArgs e)
        {
            f_modify_mode = true;
            if (dgvATM.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            editProvider= new EditATMProvider(ID);
            editProvider.ShowDialog();
            RefreshTab();
            f_modify_mode = false;
        }

        private void buttonEdit_net_Click(object sender, EventArgs e)
        {

            f_modify_mode = true;
            if (dgvATM.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            editNet = new EditATMNet(ID);
            editNet.ShowDialog();
            RefreshTab();
            f_modify_mode = false;
        }

        private void buttonEdit_model_Click(object sender, EventArgs e)
        {
            f_modify_mode = true;
            if (dgvATM.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            editModel = new EditATMModel(ID);
            editModel.ShowDialog();
            RefreshTab();
            f_modify_mode = false;
        }

        private void dgv_atm_equip_SelectionChanged(object sender, EventArgs e)
        {
            RefreshEquipmentFields();
        }

        //операции с оборудованием 
        private void buttonCreateEquip_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                editEqiup = new EditATMEquip(ID);
                if (editEqiup.ShowDialog() == DialogResult.OK)
                {
                    RefreshEquipmetTable();
                    RefreshEquipmentFields();
                }
            }
        }

        private void buttonEditEquip_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                if (dgv_atm_equip.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выбрана строка для изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int atm_eq_id = (int)dgv_atm_equip.SelectedRows[0].Cells[0].Value;
                editEqiup = new EditATMEquip(ID, atm_eq_id);
                if (editEqiup.ShowDialog() == DialogResult.OK)
                {
                    RefreshEquipmetTable();
                    RefreshEquipmentFields();
                }
            }
        }

        private void btnDelEquip_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                if (dgv_atm_equip.SelectedRows.Count == 0)
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

                int atm_eq_id = (int)dgv_atm_equip.SelectedRows[0].Cells[0].Value;

                string querystring = $"delete from ATM_Eq where id = {atm_eq_id}";
                DBwork.ExeCommand(querystring, dataBase);   //выполнение запроса

                RefreshEquipmetTable();
                RefreshEquipmentFields();
                
            }
        }


        //операции со складом
        private void buttonAddEquip_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                Storage storage = new Storage(ID);
                if (storage.ShowDialog() == DialogResult.OK)
                {
                    RefreshEquipmetTable();
                    RefreshEquipmentFields();
                }
            }
        }

        private void buttonRetEquip_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                if (dgv_atm_equip.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Вы действительно хотите \nвернуть оборудование на склад?",
                    "Удалить?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No) return;

                int id = (int)dgv_atm_equip.SelectedRows[0].Cells[0].Value;

                string querystring = $"update ATM_Eq set atm_id = NULL where id = {id}";

                DBwork.ExeCommand(querystring, dataBase);

                RefreshEquipmetTable();
                RefreshEquipmentFields();
            }
        }

        private void storageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage();
            storage.ShowDialog();
        }

        
        //операции с журналом
        private void buttonAddJournal_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                journal = new Journal(ID);
                if (journal.ShowDialog() == DialogResult.OK)
                {
                    RefreshJournalTable();
                }
            }
        }

        private void buttonEditJournal_Click(object sender, EventArgs e)
        {
            if(dgv_journal.SelectedRows.Count == 0) return;
            if (ID == -1) return;

            int j_id = (int)dgv_journal.SelectedRows[0].Cells[0].Value;
            journal = new Journal(ID, j_id);
            if (journal.ShowDialog() == DialogResult.OK)
            {
                RefreshJournalTable();
            }
            
        }

        private void buttonDelJournal_Click(object sender, EventArgs e)
        {
            if (dgv_journal.SelectedRows.Count == 0)
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

            int j_id = (int)dgv_journal.SelectedRows[0].Cells[0].Value;    //Получаем ID выбранной записи

            string querystring = $"delete from History where id = {j_id}";    //строка запроса удаления записи

            DBwork.ExeCommand(querystring, dataBase);   //выполнение запроса

            RefreshJournalTable();
        }


        //мониторинг
        private string GetIP(int id)
        {
            string querystring = $"select bank_ip from ATM where id = {id}";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);
            return table.Rows[0][0].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvATM.RowCount; i++)
            {
                string ATM_IP = GetIP((int)dgvATM.Rows[i].Cells["id"].Value);
                ATM_IP = ATM_IP.Replace(" ", "");
                if (ATM_IP == "") { ATM_IP = "...."; }
                if (PingHost(ATM_IP)) { dgvATM.Rows[i].Cells[0].Value = img_on; }
                else { dgvATM.Rows[i].Cells[0].Value = img_off; }
            }
        }

        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }

    }
}
