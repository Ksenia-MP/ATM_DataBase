using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace ATM_DataBase
{
    class DataBase
    {
        private SqlConnection connection;

        public DataBase()
        {
            string ini_str;
            using (StreamReader reader = new StreamReader(@".\ATM_DataBase"))  //в файле прописан адрес сервера
            {
                ini_str = reader.ReadToEnd();
            }

            connection = new SqlConnection(ini_str);

            try     //пробуем выполнить тестовый запрос, чтобы проверить выполнение подключения
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string querystring = "select id from ATM";

                SqlCommand command = new SqlCommand(querystring, GetConnection);

                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            catch (Exception ex)    //если подключение не удалось
            {
                MessageBox.Show(ex.Message);
                SetConnection setcnn = new SetConnection(ini_str);  //форма модификации строки подключения
                setcnn.ShowDialog();
            }
            //connection = new SqlConnection(@"Data Source=DESKTOP-NQL9ME9\SQLEXPRESS; Initial Catalog=ATM; Integrated Security=True");
        }


        public SqlConnection GetConnection
        {
            get => connection;
        }

        //устанавливает подключение к бд
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        //завершает подключение к бд
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
