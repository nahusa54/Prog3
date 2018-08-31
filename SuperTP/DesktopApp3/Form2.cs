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
    public partial class Form2 : Form
    {
        DataSet dsNeptuno;
        DataSet dsNeptunoaux;
        string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            
            
            comboBox1.DataSource=dsNeptunoaux.Tables[0];
            comboBox1.DisplayMember = "NombreCategoría";




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
        private void CargarCategoriasEnGrilla(string ConexionBD, string ConsultaSQL,
                                     string NombreDebusq, ref DataSet ds)
        {
            SqlConnection cn = new SqlConnection(ConexionBD);

            SqlDataAdapter adaptador = new SqlDataAdapter(ConsultaSQL, cn);
            adaptador.SelectCommand.Parameters.AddWithValue("data", NombreDebusq);

            cn.Open();
            

           
            
            adaptador.TableMappings.Add("Table", "categoría");
            adaptador.TableMappings.Add("Table1", "[Productos por categoría]");
            adaptador.TableMappings.Add("Table2", "Productos");

            adaptador.Fill(ds);
            
            cn.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AceptarBt_Click(object sender, EventArgs e)
        {

            dsNeptunoaux.Tables.Clear();
            string buscar = comboBox1.Text;


            
            string Skere = "select dbo.Productos.NombreProducto from Categorías inner join [Productos por categoría] on Categorías.NombreCategoría = [Productos por categoría].NombreCategoría  inner join Productos on [Productos por categoría].NombreProducto = Productos.NombreProducto where Categorías.NombreCategoría=@data";
            


            CargarCategoriasEnGrilla(rutaNeptunoSQL,Skere,buscar,ref dsNeptunoaux);

            
            Grilla.DataSource = dsNeptunoaux.Tables[0];


        }

        private void Grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
