using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int cont = 1;


            string aux;
            aux = textBox1.Text;

            if (string.IsNullOrWhiteSpace(aux) != true)

            {

                foreach (var item in ltm.Items)
                {

                    if (aux == item.ToString())
                    {
                        cont = 0;

                    }

                }
                if (cont != 0)
                {



                    ltm.Items.Add(aux);

                }
                else { textBox1.Text = ""; }
                textBox1.Text = "";



            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            int cont = 1;


            string aux;
            aux = textBox1.Text;

            if (string.IsNullOrWhiteSpace(aux) != true)

            {

                foreach (var item in ltf.Items)
                {

                    if (aux == item.ToString())
                    {
                        cont = 0;

                    }

                }
                if (cont != 0)
                {



                    ltf.Items.Add(aux);

                }
                else { textBox1.Text = ""; }
                textBox1.Text = "";



            }
        }
    

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            label1.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = true; ;

        }

        private void ltm_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltm.Items.Remove(ltm.SelectedItem);
            //
        }

        private void ltf_SelectedIndexChanged(object sender, EventArgs e)
        {
            ltf.Items.Remove(ltf.SelectedItem);
        }
    }



}
