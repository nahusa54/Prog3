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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        DataSet dsNeptuno;
        DataSet dsNeptunoaux;
        string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";
        int cont = 1;
        




        private void button1_Click(object sender, EventArgs e)
        {
            cont++;
            dsNeptuno = new DataSet();
            bool temp = false;
            SqlConnection con = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
            con.Open();
            string asd=cont.ToString();
            SqlCommand cmd = new SqlCommand("select  IdEmpleado,Apellidos,Nombre,Ciudad from Empleados where IdEmpleado="+asd, con);
           
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read()) {
                
                 
                ID.Text = dr["IdEmpleado"].ToString();

                Ape.Text = dr["Apellidos"].ToString();
                Nombre.Text = dr["Nombre"].ToString();
                Ciudad.Text = dr["Ciudad"].ToString();
                 

               
                
            }
          

            con.Close();
            
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //RecorrerControles();
            
            dsNeptuno = new DataSet();
            bool temp = false;
            SqlConnection con = new SqlConnection( "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Empleados", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) { 
                ID.Text = dr["IdEmpleado"].ToString();
                
                Ape.Text = dr["Apellidos"].ToString();
                Nombre.Text = dr["Nombre"].ToString();
                Ciudad.Text = dr["Ciudad"].ToString();
                
               
                temp = true;
            }
            if (temp == false)
                MessageBox.Show("not found");
            con.Close();




        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ciudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            dsNeptuno = new DataSet();
            bool temp = false;
            SqlConnection con = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
            con.Open();
            string asd = "9";
            SqlCommand cmd = new SqlCommand("select  IdEmpleado,Apellidos,Nombre,Ciudad from Empleados where IdEmpleado=" + asd, con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {


                ID.Text = dr["IdEmpleado"].ToString();

                Ape.Text = dr["Apellidos"].ToString();
                Nombre.Text = dr["Nombre"].ToString();
                Ciudad.Text = dr["Ciudad"].ToString();
                



            }


            con.Close();
            cont = 9;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            dsNeptuno = new DataSet();
            bool temp = false;
            SqlConnection con = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
            con.Open();
            string asd = "1";
            SqlCommand cmd = new SqlCommand("select  IdEmpleado,Apellidos,Nombre,Ciudad from Empleados where IdEmpleado=" + asd, con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {


                ID.Text = dr["IdEmpleado"].ToString();

                Ape.Text = dr["Apellidos"].ToString();
                Nombre.Text = dr["Nombre"].ToString();
                Ciudad.Text = dr["Ciudad"].ToString();
                



            }


            con.Close();
            cont = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cont == 1)
            {
                return;
            }
            else
            {
                cont--;
                dsNeptuno = new DataSet();
                bool temp = false;
                SqlConnection con = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
                con.Open();
                string asd = cont.ToString();
                SqlCommand cmd = new SqlCommand("select  IdEmpleado,Apellidos,Nombre,Ciudad from Empleados where IdEmpleado=" + asd, con);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {


                    ID.Text = dr["IdEmpleado"].ToString();

                    Ape.Text = dr["Apellidos"].ToString();
                    Nombre.Text = dr["Nombre"].ToString();
                    Ciudad.Text = dr["Ciudad"].ToString();




                }


                con.Close();

            }

        }
    }

  






}
