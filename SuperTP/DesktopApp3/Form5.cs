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
    public partial class Form5 : Form

    {
        
        DataSet dsNeptuno;
        string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //RecorrerControles();
            string ConsultaSQLProductos = "Select idProducto,nombreproducto,unidadesenexistencia,cantidadporunidad from Productos";
            dsNeptuno = new DataSet();

            AgregarTablaDataSetSQLServer(rutaNeptunoSQL, ConsultaSQLProductos,
                                         "Productos", ref dsNeptuno);
            Grilla.DataSource = dsNeptuno.Tables[0];
            
            int are;

            foreach (DataGridViewRow row in Grilla.Rows)
            {
                
               

                
                    
                
                if (row.Cells["UnidadesEnExistencia"].Value != null)
                {

                    are = Int32.Parse(row.Cells["UnidadesEnExistencia"].Value.ToString());



                




                    if (are > 30)
                    {

                        row.Cells["NombreProducto"].Style.BackColor = Color.Green;


                    }
                    else if (are > 20 && are < 30)
                    {

                        row.Cells["NombreProducto"].Style.BackColor = Color.Yellow;


                    }
                    else if (are < 20)
                    {

                        row.Cells["NombreProducto"].Style.BackColor = Color.Red;


                    }
                }
                
            }


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

      











    }
}
