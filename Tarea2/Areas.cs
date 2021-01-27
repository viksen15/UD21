using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2
{
    public partial class Areas : Form
    {
        public Areas()
        {
            InitializeComponent();
        }
        // LE DECIMOS QUE HACER AL BOTON CALCULAR
        private void calcular_Click(object sender, EventArgs e)
        {
            // CALCULA EL AREA DEL CUADRADO 
            if (areaCuadrado.Checked)
            {
                try
                {
                    // A=Lado^2
                    resultado.Text = (Math.Pow(double.Parse(textBox1.Text),2)).ToString();
                }
                catch (Exception ex)
                { MessageBox.Show("Debe introducir un número"); }
            }

            // CALCULA EL AREA DEL CIRCULO
            if (areaCirculo.Checked)
            {
                try
                {
                    // A=Pi*radio^2
                    resultado.Text = ((double)(Math.PI * Math.Pow(double.Parse(textBox1.Text),2))).ToString() ;
                }
                catch (Exception ex)
                { MessageBox.Show("Debe introducir un número"); }
            }

            // CALCULA EL AREA DEL TRIANGULO
            if (areaTriangulo.Checked)
            {
                try
                {
                    // A=(Base*Altura)/2
                    resultado.Text = (double.Parse(textBox1.Text)*double.Parse(textBox2.Text)/ 2).ToString();
                }
                catch (Exception ex)
                { MessageBox.Show("Debe introducir un número"); }
            }

            // CALCULA EL AREA DEL RECTANGULO
            if (areaRectangulo.Checked)
            {
                try
                {
                    // A=Base*Altura
                    resultado.Text = (double.Parse(textBox1.Text)* double.Parse(textBox2.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe introducir un número");
                }
            }

            // CALCULA EL AREA DEL PENTAGONO
            if (areaPentagono.Checked)
            {
                try
                {
                    // A=(Perimetro*Apotema)/2
                    resultado.Text = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text) / 2).ToString();
                }
                catch (Exception ex)
                { MessageBox.Show("Debe introducir un número"); }
            }

            // CALCULA EL AREA DEL ROMBO
            if (areaRombo.Checked)
            {
                try
                {
                    // A=(Diagonal*diagonal)/2
                    resultado.Text = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text) / 2).ToString();
                }
                catch (Exception ex)
                { MessageBox.Show("Debe introducir un número"); }
            }

            // CALCULA EL AREA DEL ROMBOIDE
            if (areaRomboide.Checked)
            {
                try
                {
                    // A=Base*Altura
                    resultado.Text = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)).ToString();
                }
                catch (Exception ex)
                { MessageBox.Show("Debe introducir un número"); }
            }

            // CALCULA EL AREA DEL TRAPECIO
            if (areaTrapecio.Checked)
            {
                try
                {
                    // A=((base+base)/2)*h;
                    resultado.Text = ((double.Parse(textBox1.Text) + double.Parse(textBox2.Text) /2) * double.Parse(textBox3.Text)).ToString();
                }
                catch (Exception ex)
                { MessageBox.Show("Debe introducir un número"); }
            }
            
        }

        // ABRIMOS O CERRAMOS LOS TEXTBOX DEPENDIENDO DE LA OPERACION

        
        private void CheckedChanged(object sender, EventArgs e)
        { textBox1.Visible = false; textBox2.Visible = false; textBox3.Visible = false;

            if (areaCuadrado.Checked)
            {
                num1.Text = "Lado";
                num2.Text = "";
                num3.Text = "";
                textBox1.Visible = true;
            }
            if (areaCirculo.Checked)
            {
                num1.Text = "Diametro";
                num2.Text = "";
                num3.Text = "";
                textBox1.Visible = true;
            }
            if (areaTriangulo.Checked)
            {
                num1.Text = "Altura";
                num2.Text = "Base";
                num3.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            if (areaRectangulo.Checked)
            {
                num1.Text = "Base";
                num2.Text = "Altura";
                num3.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            if (areaPentagono.Checked)
            {
                num1.Text = "Perimetro";
                num2.Text = "Apotema";
                num3.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            if (areaRombo.Checked)
            {
                num1.Text = "Diagonal";
                num2.Text = "diagonal";
                num3.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            if (areaRomboide.Checked)
            {
                num1.Text = "Base";
                num2.Text = "Altura";
                num3.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            if (areaTrapecio.Checked)
            {
                num1.Text = "Base";
                num2.Text = "base";
                num3.Text = "Altura";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
            }


        }
    }
}
