using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_DataBase
{
    static class DBwork
    {
        /// <summary>
        /// Метод возвращающий индекс строки таблицы по ID записи
        /// </summary>
        /// <param name="dgv">таблица</param>
        /// <param name="id">ID</param>
        /// <returns>индекс строки записи, если не найден возвращает -1</returns>
        public static int RowByID(DataGridView dgv, int id)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if ((int)dgv.Rows[i].Cells[0].Value == id)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Метод,возвращающий содержимое ячейки 
        /// </summary>
        /// <param name="dt">таблица</param>
        /// <param name="row">индекс ряда</param>
        /// <param name="col_name">наименование столбца</param>
        /// <returns>Возвращает строки, содержащиеся в ячейке</returns>
        public static object FieldByName(DataTable dt, int row, string col_name)
        {
            int col = dt.Columns[col_name].Ordinal;
            return dt.Rows[row][col];
        }

        /// <summary>
        /// Возращвет первое значения в столбце с указанным наименованием
        /// </summary>
        /// <param name="dt">таблица</param>
        /// <param name="col_name">наименование столбца</param>
        /// <returns>первое значение в указанном столбце</returns>
        public static object FieldByName(DataTable dt, string col_name)
        {
            return FieldByName(dt, 0, col_name);
        }

        /// <summary>
        /// Выполняет Transact-SQL инструкцию (Update, Insert, Delete)
        /// </summary>
        /// <param name="querystring">строка sql-запроса</param>
        /// <param name="dataBase">подключенная база данных</param>
        public static void ExeCommand(string querystring, DataBase dataBase)
        {
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection); //создаем команду

            dataBase.OpenConnection(); //открывам подключение
            try
            {
                command.ExecuteNonQuery(); //выполнение команды
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);    //сообщение об ошибке
            }
            dataBase.CloseConnection(); //закрываем подключение
        }

        /// <summary>
        /// Выполняет запрос и возвращает первый столбец первой строки результируещего набора
        /// </summary>
        /// <param name="querystring">строка запроса</param>
        /// <param name="dataBase">база данных</param>
        /// <returns>Возвращает ID записи</returns>
        public static int ExeScalar(string querystring, DataBase dataBase)
        {
            querystring += "; SELECT CAST(scope_identity() AS int)";
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection);
            int id = -1;
            dataBase.OpenConnection();
            try
            {
                id = (Int32)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataBase.CloseConnection();
            return id;
        }

        /// <summary>
        /// Выполняет выборку записей по select запросу
        /// </summary>
        /// <param name="querystring">строка запроса</param>
        /// <param name="dataBase">подключенная база данных</param>
        /// <returns>Воззвращает таблицу с выборкой по запросу</returns>
        public static DataTable ExeSelect(string querystring, DataBase dataBase)
        {
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}
