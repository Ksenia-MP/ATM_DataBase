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
    public partial class EditATMModel : Form
    {
        DataBase dataBase = new DataBase();
        int ID;
        public static int added_model_id;
        object[,] id_and_name;

        public EditATMModel(int id)
        {
            ID = id;
            InitializeComponent();

            GetModels();

            string querystring = $"select ATM.id, model_id, Model.id, name, cashin, weight, height, width, depth " +
                 $"from ATM left join Model " +
                 $"on model_id = Model.id where ATM.id = {id}";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);


            this.Text = "Изменить";
            this.buttonOK.Text = "Изменить";

            if (DBwork.FieldByName(table, "model_id") != DBNull.Value)
            {
                cb_name.SelectedItem = DBwork.FieldByName(table, "name").ToString();
                FillParams(table);
            }
            else cb_name.SelectedIndex = -1;
        }

        private void GetModels()
        {
            cb_name.Items.Clear();

            string querystring = "select id, name from Model";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            int r = table.Rows.Count;
            id_and_name = new object[r, 2];
            for (int i = 0; i < r; i++)
            {
                id_and_name[i, 0] = (int)table.Rows[i][0];
                id_and_name[i, 1] = table.Rows[i][1].ToString();
                cb_name.Items.Add(id_and_name[i, 1]);
            }
        }


        private void cb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cb_name.Text;
            int model_id = 0;

            for (int i = 0; i < id_and_name.GetLength(0); i++)
            {
                if (name == id_and_name[i, 1].ToString())
                    model_id = (int)id_and_name[i, 0];
            }

            if (model_id == 0)
                return;
            
            string querystring = $"select * from Model where id = {model_id}";
            DataTable table = DBwork.ExeSelect(querystring, dataBase);

            FillParams(table);
        }

        private void cb_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                buttonClear_Click(sender, e);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            cb_name.SelectedIndex = -1;
            tb_weight.Clear();
            tb_height.Clear();
            tb_width.Clear();
            tb_depth.Clear();
            ch_cashin.Checked = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EditModel edit = new EditModel();
            if(edit.ShowDialog() == DialogResult.OK)
            {
                added_model_id = edit.Ret_ID;
                string querystring = $"select * from Model where id = {added_model_id}";
                DataTable table = DBwork.ExeSelect(querystring, dataBase);

                GetModels();
                cb_name.SelectedItem = DBwork.FieldByName(table, "name").ToString();
                FillParams(table);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string name = cb_name.Text;
            int model_id = 0;

            for (int i = 0; i < id_and_name.GetLength(0); i++)
            {
                if (name == id_and_name[i, 1].ToString())
                    model_id = (int)id_and_name[i, 0];
            }

            string s_id = model_id == 0 ? "NULL" : model_id.ToString();
            string querystring = $"update ATM set model_id = {s_id} where id = {ID}";

            DBwork.ExeCommand(querystring, dataBase);

            this.Hide();
        }

        private void FillParams(DataTable table)
        {
            tb_weight.Text = DBwork.FieldByName(table, "weight").ToString();
            tb_height.Text = DBwork.FieldByName(table, "height").ToString();
            tb_width.Text = DBwork.FieldByName(table, "width").ToString();
            tb_depth.Text = DBwork.FieldByName(table, "depth").ToString();
            bool.TryParse(DBwork.FieldByName(table, "cashin").ToString(), out bool cashin);
            ch_cashin.Checked = cashin;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
