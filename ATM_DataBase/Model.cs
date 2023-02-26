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
    public partial class Model : Form
    {
        DataBase dataBase = new DataBase();

        public Model()
        {
            InitializeComponent();
            InitGrid();
        }

        private void InitGrid()
        {
            string querystring = "select * from Model order by name";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            dgvModel.DataSource = table;
            dgvModel.Columns[0].Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditModel edit = new EditModel();
            if (edit.ShowDialog() == DialogResult.OK)
                InitGrid();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(dgvModel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не выбрана строка для изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ID = (int)dgvModel.SelectedRows[0].Cells[0].Value;
            EditModel edit = new EditModel(ID);
            if (edit.ShowDialog() == DialogResult.OK)
                InitGrid();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dgvModel.SelectedRows.Count == 0)
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

            int ID = (int)dgvModel.SelectedRows[0].Cells[0].Value;

            string querystring = $"update ATM set model_id = NULL where model_id = {ID};" +
                $"delete from Model where id = {ID}";

            DBwork.ExeCommand(querystring, dataBase);

            InitGrid();
        }
    }
}
