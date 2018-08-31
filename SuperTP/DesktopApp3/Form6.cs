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
    public partial class Form6 : Form
    {
        DataSet dsNeptuno;
        
        string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
            //RecorrerControles();
            string ConsultaSQL = "Select Cargo,Nombre,Apellidos from Empleados";
            dsNeptuno = new DataSet();
        
            AgregarLista(rutaNeptunoSQL, ConsultaSQL,ref dsNeptuno,ref Lt1);


          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void AgregarLista(string ConexionBD, string ConsultaSQL,
                                      ref DataSet ds,ref ListBox lt)
        {
            
            SqlConnection cn = new SqlConnection(ConexionBD);
            SqlCommand comando = new  SqlCommand(ConsultaSQL, cn);

            cn.Open();

            using (SqlDataReader reader = comando.ExecuteReader(CommandBehavior.SingleResult | CommandBehavior.CloseConnection))
            {
                while (reader.Read())
                {
                    string aux;
                    aux = (string)reader["Cargo"] + "-" + (string)reader["Nombre"] + "-" + (string)reader["Apellidos"];
                    lt.Items.Add(aux);


                }
            }


            cn.Close();

        }

        private void Lt1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            var value = Lt1.GetItemText(Lt1.SelectedItem);
            string[] words = value.Split('-');
            foreach (string word in words)
            {

                switch (i) {

                 case 0:
                        
                Cargo.Text = word;

                        break;
                    case 1:
                        Nombre.Text = word;
                        break;

                case 2:
                Apellido.Text = word;
                break;
                
                }
                i++;
        }
        }
    }
}
