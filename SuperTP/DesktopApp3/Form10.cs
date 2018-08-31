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
    public partial class Form10 : Form
    {
        DataSet dsNeptuno;
        string aux;
        string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";

        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {


            //RecorrerControles();
            string ConsultaSQL = "Select Apellidos,Nombre from Empleados";
            dsNeptuno = new DataSet();

            AgregarLista(rutaNeptunoSQL, ConsultaSQL, ref dsNeptuno, ref Lt1);

        }
        private void AgregarLista(string ConexionBD, string ConsultaSQL,
                                    ref DataSet ds, ref CheckedListBox Lt1)
        {

            SqlConnection cn = new SqlConnection(ConexionBD);
            SqlCommand comando = new SqlCommand(ConsultaSQL, cn);

            cn.Open();

            using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection))
            {
                while (reader.Read())
                {
                    string aux;
                    aux = (string)reader["Apellidos"] +" " + (string)reader["Nombre"];
                    Lt1.Items.Add(aux);


                }
            }


            cn.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label2.Text = "";
           

            if (Fem.Checked)
            {

                aux = "Femenino";

            }
            if (Mas.Checked)
            {
                aux = "Masculino";




            }
            aux=aux + " /" + (string)Lt1.Items[Lt1.SelectedIndex];

            



            if (Cas.Checked)
            {
                aux = aux + " /" + "Casado";



            }
            if (Sol.Checked)
            {

                aux = aux + " /" + "Soltero";

            }

            label2.Text = aux;

        }
    }
}
