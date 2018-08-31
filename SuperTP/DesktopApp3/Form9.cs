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
using System.Text.RegularExpressions;


namespace DesktopApp3
{

    public partial class Form9 : Form
    {
        DataSet dsNeptuno;

        string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";

        public Form9()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)

        {
            

            //RecorrerControles();
            string ConsultaSQL = "Select NombreCategoría from Categorías";
            dsNeptuno = new DataSet();

            AgregarLista(rutaNeptunoSQL, ConsultaSQL, ref dsNeptuno, ref ltsBox);

        }
        private void AgregarLista(string ConexionBD, string ConsultaSQL,
                                    ref DataSet ds, ref CheckedListBox lt)
        {

            SqlConnection cn = new SqlConnection(ConexionBD);
            SqlCommand comando = new SqlCommand(ConsultaSQL, cn);

            cn.Open();

            using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection))
            {
                while (reader.Read())
                {
                    string aux;
                    aux = (string)reader["NombreCategoría"];
                    lt.Items.Add(aux);


                }
            }


            cn.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ltsBox.Items.Count; i++)
            {
                if (ltsBox.GetItemChecked(i))
                {
                    string str = (string)ltsBox.Items[i];
                    listBox1.Items.Add(str);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

