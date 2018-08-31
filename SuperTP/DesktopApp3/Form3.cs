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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        DataSet dsNeptuno;
        DataSet dsNeptunoaux;
        string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";
        

        private void Form3_Load(object sender, EventArgs e)
        {
            //RecorrerControles();
            string ConsultaSQLProductos = "Select * from Productos";
            dsNeptuno = new DataSet();
            dsNeptunoaux = new DataSet();


            AgregarTablaDataSetSQLServer(rutaNeptunoSQL, ConsultaSQLProductos,
                                         "Productos", ref dsNeptuno);
            Grilla.DataSource = dsNeptuno.Tables[0];

            string LLenarCategoria = "Select NombreCategoría from Categorías";
            CargarCategorias(rutaNeptunoSQL, LLenarCategoria,
                                         "Categorías", ref dsNeptunoaux);

           



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
        private void CargarCategorias(string ConexionBD, string ConsultaSQL,
                                       string NombreTabla, ref DataSet ds)
        {
            SqlConnection cn = new SqlConnection(ConexionBD);
            SqlDataAdapter adaptador = new SqlDataAdapter(ConsultaSQL, cn);
            cn.Open();
            adaptador.Fill(ds, NombreTabla);
            cn.Close();

        }

        private void Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Grilla_CellBorderStyleChanged(object sender, EventArgs e)
        {
            
           
        }

        private void Grilla_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            IDProducto.Text = Grilla.Rows[e.RowIndex].Cells["IdProducto"].Value.ToString();
            IDprove.Text = Grilla.Rows[e.RowIndex].Cells["IdProveedor"].Value.ToString();
            IDCategoria.Text = Grilla.Rows[e.RowIndex].Cells["IdCategoría"].Value.ToString();
            NombreP.Text = Grilla.Rows[e.RowIndex].Cells["NombreProducto"].Value.ToString();
            CantXuni.Text = Grilla.Rows[e.RowIndex].Cells["CantidadPorUnidad"].Value.ToString();
            PrecioUni.Text = Grilla.Rows[e.RowIndex].Cells["PrecioUnidad"].Value.ToString();
            UnidadesEx.Text = Grilla.Rows[e.RowIndex].Cells["UnidadesEnExistencia"].Value.ToString();
            UnidadesEnPe.Text = Grilla.Rows[e.RowIndex].Cells["UnidadesEnPedido"].Value.ToString();
        }
    }


}
