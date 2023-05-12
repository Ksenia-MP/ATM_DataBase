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
    public partial class Provider : Form
    {
        DataBase dataBase = new DataBase();
        EditProvider edit;

        public Provider()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            string querystring = "select * from Provider order by name";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);
            
            dgvProvider.DataSource = table;
            dgvProvider.Columns[0].Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            edit = new EditProvider();
            if (edit.ShowDialog() == DialogResult.OK)
                InitGrid();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(dgvProvider.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ID = (int)dgvProvider.SelectedRows[0].Cells[0].Value;

            edit = new EditProvider(ID);
            if (edit.ShowDialog() == DialogResult.OK)
                InitGrid();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dgvProvider.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Вы действительно хотите \nудалить выбранную запись?",
                "Удалить?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            int ID = (int)dgvProvider.SelectedRows[0].Cells[0].Value;

            //Удаляем провайдера из справочника, предварительно очистив поля провайдера в ATM
            string querystring = $"update ATM set provider_id = NULL, pr_line_no = NULL, pr_contract_no = NULL, " +
                $"pr_contract_date = NULL where provider_id = {ID};" +
                $"delete from Provider where id = {ID}";

            DBwork.ExeCommand(querystring, dataBase);

            InitGrid();
        }
    }
}
