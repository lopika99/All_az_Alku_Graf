using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using MessageBox = System.Windows.MessageBox;
using TextBox = System.Windows.Controls.TextBox;
using ListBox = System.Windows.Controls.ListBox;
using MySql.Data.MySqlClient;

namespace graf_All_Az_Alku
{
    class Connection
    {
        private static MySqlConnection conn = new MySqlConnection("SERVER=localhost; UID=root; PWD=; DATABASE=test");

        public static void Connect()
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void Close()
        {
            conn.Close();
        }
        
        public static void Insert(TextBox tb, int nyeremeny)
        {
            string cmd = string.Format("INSERT INTO allazalku(nev, nyeremeny) VALUES('{0}', '{1}')", tb.Text, nyeremeny);
            MySqlCommand co = new MySqlCommand(cmd, conn);
            try
            {
                co.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public static void FillListBox(ListBox lb)
        {
            string cmd = string.Format("SELECT CONCAT_WS(nev, nyeremeny) as ossz FROM allazalku");
            MySqlDataAdapter da = new MySqlDataAdapter(cmd, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            lb.ItemsSource = ds.Tables[0].DefaultView;
            lb.DisplayMemberPath = ds.Tables[0].Columns[0].ToString();
            lb.SelectedValuePath = ds.Tables[0].Columns[0].ToString();
        }

    }
}
