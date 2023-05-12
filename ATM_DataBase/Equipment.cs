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
    public partial class Equipment : Form
    {
        DataBase dataBase = new DataBase();
        EditEquip edit;

        public Equipment()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            string querystring = "select * from Equipment order by type";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            dgvEquip.DataSource = table;
            dgvEquip.Columns[0].Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            edit = new EditEquip();
            edit.ShowDialog();
            InitGrid();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dgvEquip.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ID = (int)dgvEquip.SelectedRows[0].Cells[0].Value;
            edit = new EditEquip(ID);
            edit.ShowDialog();
            InitGrid();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dgvEquip.SelectedRows.Count == 0)
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

            int ID = (int)dgvEquip.SelectedRows[0].Cells[0].Value;

            string querystring = $"delete from Equipment where id = {ID}";

            DBwork.ExeCommand(querystring, dataBase);

            InitGrid();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
