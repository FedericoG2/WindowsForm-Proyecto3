using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclos
{
    public partial class Form1 : Form
    {
        int desde;
        int hasta;
        int resultado = 0;
        float promedio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDesde.Text = "";
            txtHasta.Text = "";
            txtResultado.Text = "";
            optTodo.Checked = true;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
           //Valor desde que pone el usuario
            desde = int.Parse(txtDesde.Text);

           //Valor hasta que pone el usuario
            hasta = int.Parse(txtHasta.Text);

            if(desde != 0 && hasta != 0) {
               
                //Si esta seleccionado todo
                if(optTodo.Checked)
                {
                    for(int i = desde; i <= hasta; i++)
                    {
                        resultado += i;
                    }
                    promedio = (float)resultado / hasta;

                }
                //Si esta seleccionado pares
                if (optPares.Checked)
                {
                    for (int i = desde; i <= hasta; i++)
                    {
                        //Antes de sumar se pregunta si el valor de i que va cambiando es par
                        if(i%2 == 0)
                        {
                            resultado += i;
                        }
                        
                    }
                    promedio = (float)resultado / hasta;

                }
                //Si esta seleccionado impares
                if (optImpares.Checked)
                {
                    for (int i = desde; i <= hasta; i++)
                    {
                        //Antes de sumar se pregunta si el valor de i que va cambiando es impar
                        if ( i % 2 != 0)
                        {
                            resultado += i;
                        }

                    }
                    promedio = (float)resultado / hasta;

                }
            }

            txtResultado.Text = resultado.ToString();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            MessageBox.Show(promedio.ToString()); 
        }
    }
}
