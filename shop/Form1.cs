using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop
{
    public partial class Form1 : Form
    {

        private SqlDataReader reader;
        private DataTable table;
        private SqlConnection conn;
        string cs = "";
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection();
            cs = ConfigurationManager.
            ConnectionStrings["connectionStr"].
            ConnectionString;
            conn.ConnectionString = cs;
        }

        //private void loadData()
        //{
        //    string connectString = "Data Source=localhost;Initial Catalog=shop; Integrated Security=True";

        //    SqlConnection sqlConnection = new SqlConnection(connectString);

        //    sqlConnection.Open();

        //    string query = "SELECT * FROM byers";

        //    SqlCommand command = new SqlCommand(query, sqlConnection);

        //    SqlDataReader reader = command.ExecuteReader();

        //    List<string[]> data = new List<string[]>();

        //    while (reader.Read())
        //    {
        //        data.Add(new string[3]);

        //        data[data.Count - 1][0] = reader[0].ToString();
        //        data[data.Count - 1][1] = reader[1].ToString();
        //        data[data.Count - 1][2] = reader[2].ToString();

        //    }

        //    reader.Close();
        //    sqlConnection.Close();

        //    foreach(string[] s in data)
        //    {
        //        Console.WriteLine(s);
        //        dataGridView1.Rows.Add(s);
        //    }

        //}

        

        private void showAllByers_Click(object sender, EventArgs e)
        {
            showQuery("SELECT * FROM byers");

            //Console.WriteLine("clic all");
            //string connectString = "Data Source=localhost;Initial Catalog=shop; Integrated Security=True";

            //SqlConnection sqlConnection = new SqlConnection(connectString);

            //sqlConnection.Open();

            //string query = "SELECT * FROM byers";

            //SqlCommand command = new SqlCommand(query, sqlConnection);

            //SqlDataReader reader = command.ExecuteReader();

            //List<string[]> data = new List<string[]>();

            //while (reader.Read())
            //{
            //    data.Add(new string[3]);

            //    data[data.Count - 1][0] = reader[0].ToString();
            //    data[data.Count - 1][1] = reader[1].ToString();
            //    data[data.Count - 1][2] = reader[2].ToString();

            //}

            //reader.Close();
            //sqlConnection.Close();

            //foreach (string[] s in data)
            //{
            //    Console.WriteLine(s);
            //    dataGridView1.Rows.Add(s);
            //}
        }

        private void showQuery(string query)
        {
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = query;
                
                comm.Connection = conn;
                dataGridView1.DataSource = null;
                conn.Open();
                table = new DataTable();
                reader = comm.ExecuteReader();
                int line = 0;
                do
                {
                    while (reader.Read())
                    {
                        if (line == 0)
                        {
                            for (int i = 0; i <
                            reader.FieldCount; i++)
                            {
                                table.Columns.Add(reader.
                                GetName(i));
                            }
                            line++;
                        }
                        DataRow row = table.NewRow();
                        for (int i = 0; i <
                        reader.FieldCount; i++)
                        {
                            row[i] = reader[i];
                        }
                        table.Rows.Add(row);
                    }
                } while (reader.NextResult());
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Probably wrong request syntax");
            }
            finally
            {
                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private void showAllSellers_Click(object sender, EventArgs e)
        {
            showQuery("SELECT * FROM sellers");
        }

        private void showAllSales_Click(object sender, EventArgs e)
        {
            showQuery("SELECT sl.ID , s.NAME SELLER_NAME, s.LASTNAME SELLER_LASTNAME , " +
                "b.NAME BYER_NAME , b.LASTNAME BYER_LASTNAME , SUMM , DATE_SELES " +
                "FROM sales sl, sellers s, byers b " +
                "where sl.ID_BYER = b.ID   " +
                "AND sl.ID_SELLER = s.ID");
        }
    }
}
    
