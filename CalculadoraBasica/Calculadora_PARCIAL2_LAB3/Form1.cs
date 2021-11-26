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
                var result = Evaluar(cadena);
                
                textBoxRESULTADO.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("ERROR EN LA EXPRESION");
            }
        }
              
        
        public bool analizar(String cadena)
        {
           
            //Analizar
            if (analisisOperadores(cadena) && analisisParentesis(cadena) && analizarDivCero(cadena))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool analizarDivCero(String cadena)
        {
            bool ver = true;
            //Analizar Div 0
            for (int i = 0; i < cadena.Length; i++)
            {

                //Analizar parentesis
                if (cadena[i] == '0' )
                {
                    if (cadena[i-1] == '/')
                    {
                        ver = false;
                        MessageBox.Show("DIV CERO");
                    }

                }

            }

            return ver;
        }

        public bool analisisOperadores(String cadena)
        {
            bool ver = true;

            for (int i = 0; i<cadena.Length; i++)
            {
                if(cadena[i] == '/' || cadena[i] == '*' || cadena[i] == '+' || cadena[i] == '-')
                {
                    if(i == 0)
                    {
                        ver = false;

                    }else if(i == cadena.Length - 1){
                        
                        ver = false;
                    }
                    else if(cadena[i-1] == '/' || cadena[i - 1] == '*' || cadena[i - 1] == '+' || cadena[i - 1] == '-')
                    {
                        ver = false;
                    }
                    else if(cadena[i+1] == '/' || cadena[i + 1] == '*' || cadena[i + 1] == '+' || cadena[i + 1] == '-')
                    {
                        ver = false;
                    }
                }
            }

            return ver;
        }

        public bool analisisParentesis(String cadena)
        {
            bool verpar = true;

            for (int i = 0; i < cadena.Length; i++)
            {
                if (cadena[i] == ')')
                {
                    if (i == 0)
                    {
                        verpar = false;

                    }
                    else if (cadena[i - 1] == '/' || cadena[i - 1] == '*' || cadena[i - 1] == '+' || cadena[i - 1] == '-')
                    {
                        verpar = false;
                    }
                    else if (cadena[i + 1] == '(')
                    {
                        verpar = false;
                    }
                }

                if (cadena[i] == '(')
                {
                    if (i == cadena.Length-1)
                    {
                        verpar = false;

                    }
                    else if (cadena[i + 1] == '/' || cadena[i + 1] == '*' || cadena[i + 1] == '+' || cadena[i + 1] == '-')
                    {
                        verpar = false;
                    }
                    else if (cadena[i + 1] == ')')
                    {
                        verpar = false;
                    }
                }
            }

            return verpar;
        }

        
        public static double Evaluar(String cadena)

        {
            String expr = "(" + cadena + ")";
            Stack<String> ops = new Stack<String>();
            Stack<Double> vals = new Stack<Double>();

            for (int i = 0; i < expr.Length; i++)
            {
                String s = expr.Substring(i, 1);
                if (s.Equals("(")) { }
                else if (s.Equals("+")) ops.Push(s);
                else if (s.Equals("-")) ops.Push(s);
                else if (s.Equals("*")) ops.Push(s);
                else if (s.Equals("/")) ops.Push(s);
                else if (s.Equals(")"))
                {
                    int count = ops.Count;
                    while (count > 0)
                    {
                        String op = ops.Pop();
                        double v = vals.Pop();
                        if (op.Equals("+")) v = vals.Pop() + v;
                        else if (op.Equals("-")) v = vals.Pop() - v;
                        else if (op.Equals("*")) v = vals.Pop() * v;
                        else if (op.Equals("/")) v = vals.Pop() / v;
                        vals.Push(v);

                        count--;
                    }
                }
                else vals.Push(Double.Parse(s));
            }
            return vals.Pop();
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
