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

            if (analizar(cadena))
            {
                var result = calcular(cadena);
                textBoxRESULTADO.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("ERROR EN LA EXPRESION");
            }

            //Analizar formula
                        
            


        }
              
        
        public bool analizar(String cadena)
        {
            //Decalaracion de variables
            int cantINIP = 0;
            int cantFINP = 0;
            bool verEspacio = true;
            

            //Bucle que recorre el String
            for (int i = 0; i < cadena.Length; i++)
            {
                //Analizar parentesis
                if (cadena.Substring(i).Equals("("))
                {
                    cantINIP++;
                    if (cadena.Substring(i + 1).Equals(")"))
                    {
                        verEspacio = false;
                    }

                }
                else if (cadena.Substring(i).Equals(")"))
                {
                    cantFINP++;
                }

                
            }

            //Analizar Div 0
            for (int i = 0; i < cadena.Length; i++)
            {
                
                //Analizar parentesis
                if (cadena.Substring(i).Equals("0"))
                {

                    
                    if (cadena.Substring(i - 1).Equals("/0"))
                    {
                        verEspacio = false;
                        MessageBox.Show("DIV CERO");
                    }

                }
                
            }

            if (cantFINP == cantINIP && verEspacio )
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double calcular(String cadena)
        {
            var operation = new System.Data.DataTable();
            double result = Convert.ToDouble(new DataTable().Compute(cadena, null));

            return result;
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

        private void buttonBORRAR_Click(object sender, EventArgs e)
        {
            textBoxFORMULA.Text = null;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
