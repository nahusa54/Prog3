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
    public partial class Form7 : Form
    {
        DataSet dsNeptuno;

        string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Lis1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;

            //RecorrerControles();
            string ConsultaSQL = "Select Tratamiento,Apellidos from Empleados";
            dsNeptuno = new DataSet();

            AgregarLista(rutaNeptunoSQL, ConsultaSQL, ref dsNeptuno, ref Lis1);

        }


        private void AgregarLista(string ConexionBD, string ConsultaSQL,
                                     ref DataSet ds, ref ListBox lt)
        {

            SqlConnection cn = new SqlConnection(ConexionBD);
            SqlCommand comando = new SqlCommand(ConsultaSQL, cn);

            cn.Open();

            using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection))
            {
                while (reader.Read())
                {
                    string aux;
                    aux = (string)reader["Tratamiento"]+" " + (string)reader["Apellidos"];
                    lt.Items.Add(aux);


                }
            }


            cn.Close();

        }

        private void Lt1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lis1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lis2.Items.Clear();
            int i = 0;
            var value = Lis1.GetItemText(Lis1.SelectedItem);
            string aux=" ";
            String strItem;
            foreach (Object selecteditem in Lis1.SelectedItems)
            {
                i = 0;
                strItem = selecteditem as String;
                string[] words = strItem.Split(' ');

                foreach (string word in words)
                {

                    switch (i)
                    {

                        case 0:

                            aux = word;
                            i++;
                            break;
                        case 1:

                            aux =aux + " " + word;
                            break;

                            

                    }
                   
                }
                Lis2.Items.Add(aux);
                   
            }



        }
    }
}
