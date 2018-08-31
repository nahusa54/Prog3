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
    public partial class Form8 : Form
    {

        DataSet dsNeptuno;

        string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";


        public Form8()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //RecorrerControles();
            string ConsultaSQLProductos = "Select IdProducto,NombreProducto,CantidadPorUnidad,PrecioUnidad from Productos where PrecioUnidad BETWEEN 20 and 40";
            dsNeptuno = new DataSet();

            AgregarTablaDataSetSQLServer(rutaNeptunoSQL, ConsultaSQLProductos,
                                         "Productos", ref dsNeptuno);
            Grilla.DataSource = dsNeptuno.Tables[0];
            int count = dsNeptuno.Tables[0].Rows.Count;
            Cant.Text = count.ToString();
        }

        private void Form8_Load(object sender, EventArgs e)
        
            {
            //RecorrerControles();.
            radioButton3.Checked = true;
            string ConsultaSQLProductos = "Select IdProducto,NombreProducto,CantidadPorUnidad,PrecioUnidad from Productos where PrecioUnidad < 20";
            dsNeptuno = new DataSet();

            AgregarTablaDataSetSQLServer(rutaNeptunoSQL, ConsultaSQLProductos,
                                         "Productos", ref dsNeptuno);
            Grilla.DataSource = dsNeptuno.Tables[0];
            int count = dsNeptuno.Tables[0].Rows.Count;
            Cant.Text = count.ToString();




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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //RecorrerControles();
            string ConsultaSQLProductos = "Select IdProducto,NombreProducto,CantidadPorUnidad,PrecioUnidad from Productos where PrecioUnidad < 20";
            dsNeptuno = new DataSet();

            AgregarTablaDataSetSQLServer(rutaNeptunoSQL, ConsultaSQLProductos,
                                         "Productos", ref dsNeptuno);
            Grilla.DataSource = dsNeptuno.Tables[0];
            int count = dsNeptuno.Tables[0].Rows.Count;
            Cant.Text = count.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //RecorrerControles();
            string ConsultaSQLProductos = "Select IdProducto,NombreProducto,CantidadPorUnidad,PrecioUnidad from Productos where PrecioUnidad > 40";
            dsNeptuno = new DataSet();

            AgregarTablaDataSetSQLServer(rutaNeptunoSQL, ConsultaSQLProductos,
                                         "Productos", ref dsNeptuno);
            Grilla.DataSource = dsNeptuno.Tables[0];
            int count = dsNeptuno.Tables[0].Rows.Count;
            Cant.Text = count.ToString();

         

        }
    }


}
