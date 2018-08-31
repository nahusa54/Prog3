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


namespace DesktopApp3
{
    public partial class Form1 : Form
    {
        DataSet dsNeptuno;
        string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //RecorrerControles();
            string ConsultaSQLProductos = "Select * from Productos";
            dsNeptuno = new DataSet();

            AgregarTablaDataSetSQLServer(rutaNeptunoSQL, ConsultaSQLProductos,
                                         "Productos", ref dsNeptuno);
            Grilla.DataSource = dsNeptuno.Tables[0];


            CargarComboTexto(ref comboBox2);
            CargarComboTexto(ref comboBox1);
        }

        private void AgregarTablaDataSetSQLServer(string ConexionBD, string ConsultaSQL,
                                        string NombreTabla, ref DataSet ds)
        {
            SqlConnection cn = new SqlConnection(ConexionBD);
            SqlDataAdapter adaptador = new SqlDataAdapter(ConsultaSQL, cn);
            cn.Open();
            adaptador.Fill(ds, NombreTabla);
            cn.Close();
        }

        private void CargarComboTexto(ref ComboBox NombreCombo)
        {
            NombreCombo.Items.Add("Comienza con:");
            NombreCombo.Items.Add("Termina en:");
            NombreCombo.Items.Add("Contiene:");
            NombreCombo.Items.Add("Es igual a:");
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConstruirClausulaSQL(string NombreCampo,
                                          string Operador,
                                          string Valor,
                                          ref string Clausula)
        {
            string d1 = "";  //Delimitador 1
            string d2 = ""; //Delimitador 2
            if (Clausula == "")
                Clausula = Clausula + " WHERE ";
            else
                Clausula = Clausula + " AND ";
            switch (Operador)
            {
                case "Igual a:":
                    d1 = " = ";
                    d2 = "";
                    break;
                case "Mayor a:":
                    d1 = " > ";
                    d2 = "";
                    break;
                case "Menor a:":
                    d1 = " < ";
                    d2 = "";
                    break;
                case "Comienza con:":
                    d1 = " LIKE '";
                    d2 = "%'";
                    break;
                case "Termina en:":
                    d1 = " LIKE '%";
                    d2 = "'";
                    break;
                case "Contiene:":
                    d1 = " LIKE '%";
                    d2 = "%'";
                    break;
                case "Es igual a:":
                    d1 = " ='";
                    d2 = "'";
                    break;
            }
            Clausula =
                Clausula + NombreCampo + d1 + Valor + d2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string ClausulaSQLProductos = "";
                if (comboBox1.Text != "" && textBox1.Text != "")
                    ConstruirClausulaSQL("IdProducto",
                                         comboBox1.Text,
                                         textBox1.Text,
                                         ref ClausulaSQLProductos);


                if (comboBox2.Text != "" && textBox2.Text != "")
                    ConstruirClausulaSQL("IdProveedor",
                                         comboBox2.Text,
                                         textBox2.Text,
                                         ref ClausulaSQLProductos);
             

                //MessageBox.Show(ClausulaSQLProductos);
                dsNeptuno.Tables.Clear();
                MessageBox.Show(ClausulaSQLProductos);
                AgregarTablaDataSetSQLServer(rutaNeptunoSQL,
                      "Select * from productos" + ClausulaSQLProductos,
                                    "Consulta",
                                    ref dsNeptuno);
                Grilla.DataSource = dsNeptuno.Tables["Consulta"];

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dsNeptuno.Tables.Clear();
            AgregarTablaDataSetSQLServer(rutaNeptunoSQL,
                                "Select * from Productos",
                                "Productos",
                                ref dsNeptuno);
            Grilla.DataSource = dsNeptuno.Tables["Productos"];
        }

   


        private void RecorrerControles()
        {
            foreach (Control c in this.Controls)
            {
                //MessageBox.Show(c.GetType().ToString());
                if (c.GetType().ToString().Contains("ComboBox"))
                    MessageBox.Show(c.Name.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
