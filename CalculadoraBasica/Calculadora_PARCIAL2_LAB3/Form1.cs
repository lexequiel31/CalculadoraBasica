using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Calculadora_PARCIAL2_LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private void buttonIGUAL_Click(object sender, EventArgs e)
        {
            String cadena = textBoxFORMULA.Text;

            if (analizarParentesis(cadena))
            {
                MessageBox.Show("PARENTESIS CORRECTOS");
            }
            else
            {
                MessageBox.Show("PARENTESIS INCORRECTOS");
            }

            //Analizar formula
                        
            var operation = new System.Data.DataTable();
            double result = Convert.ToDouble(new DataTable().Compute(cadena, null));
            MessageBox.Show(result.ToString());


        }
        
        public bool analizarParentesis(String cadena)
        {
            //Decalaracion de variables
            int cantINIP = 0;
            int cantFINP = 0;

            //Bucle que recorre el String
            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena.Substring(i).Equals("("))
                {
                    cantINIP++;

                }
                else if (cadena.Substring(i).Equals(")"))
                {
                    cantFINP++;
                }
            }

            if (cantFINP == cantINIP)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "0";
        }

        private void buttonPUNTO_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + ",";
        }

        private void buttonINIP_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "(";
        }

        private void buttonFINP_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + ")";
        }

        private void buttonSUMA_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "+";
        }

        private void buttonRESTA_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "-";
        }

        private void buttonDIVISION_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "/";
        }

        private void buttonPRODUCTO_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = textBoxFORMULA.Text + "*";
        }

        
    }
}
