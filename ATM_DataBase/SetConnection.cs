using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_DataBase
{
    public partial class SetConnection : Form
    {
        public SetConnection(string s)
        {
            InitializeComponent();
            tb_cnn_string.Text = s;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = new StreamWriter(new FileStream(@".\ATM_DataBase", FileMode.Create, FileAccess.Write)))
            {
                writer.Write(tb_cnn_string.Text);
            }
            Application.Restart();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
