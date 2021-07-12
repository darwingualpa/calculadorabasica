using calculadorabasica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorabasica
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        double memoria1;
        double memoria2;
        String operador;
        public Form1()
        {
            InitializeComponent();
        }
        clasesuma objsuma = new clasesuma();
        claseresta objresta = new claseresta();
        clasedivicion objdivicion = new clasedivicion();
        clasemultiplicacion objmultiplicacion = new clasemultiplicacion();
        porcentaje obporcentaje = new porcentaje();



        private void Form1_Load(object sender, EventArgs e)
        {
            lb1.Text = "";
            SkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
        }


        private void btnigual_Click(object sender, EventArgs e)
        {
            btnpunto.Enabled = true;

            if (!string.IsNullOrEmpty(txtpantalla.Text))
                memoria2 = double.Parse(txtpantalla.Text);
            double OPsuma, OPresta, OPdivicion, OPmultiplicacion, OPporcentaje;

            switch (operador)
            {
                case "+":
                    OPsuma = objsuma.Sumas(memoria1, memoria2);
                    txtpantalla.Text = OPsuma.ToString();
                    break;
                case "-":
                    OPresta = objresta.Restas((memoria1), (memoria2));
                    txtpantalla.Text = OPresta.ToString();
                    break;
                case "÷":
                    OPdivicion = objdivicion.Diviciones((memoria1), (memoria2));
                    txtpantalla.Text = OPdivicion.ToString();
                    break;
                case "x":
                    OPmultiplicacion = objmultiplicacion.Multiplicaciones((memoria1), (memoria2));
                    txtpantalla.Text = OPmultiplicacion.ToString();
                    break;
                case "%":
                    OPporcentaje = obporcentaje.Porcentaje((memoria1), (memoria2)/100);
                    txtpantalla.Text = OPporcentaje.ToString();
                    break;

            }
            lb1.Text = "=" + memoria1 + operador + memoria2;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtpantalla.Text = txtpantalla.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpantalla.Text))
            {
                txtpantalla.Text = txtpantalla.Text + "0";
            }
            else
            {
                txtpantalla.Text = "";
                btn0.Enabled = true;
            }
            

        }
        private void btnsuma_Click(object sender, EventArgs e)
        {
            btnpunto.Enabled = true;
            operador = "+";
            if (!string.IsNullOrEmpty(txtpantalla.Text))
                memoria1 = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
            btnpunto.Enabled = true;
            lb1.Text = operador + memoria1  ;
        }


        private void btnresta_Click(object sender, EventArgs e)
        {
            btnpunto.Enabled = true;
            operador = "-";
            if (!string.IsNullOrEmpty(txtpantalla.Text))
                memoria1 = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
            btnpunto.Enabled = true;
            lb1.Text = operador+ memoria1 ;
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            btnpunto.Enabled = true;
            operador = "x";
            if (!string.IsNullOrEmpty(txtpantalla.Text))
                memoria1 = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
            lb1.Text = operador + memoria1 ;

        }

        private void btndivicion_Click(object sender, EventArgs e)
        {
            btnpunto.Enabled = true;
            operador = "÷";
            if (!string.IsNullOrEmpty(txtpantalla.Text))
                memoria1 = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
            lb1.Text = operador + memoria1;

        }
        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            operador = "%";
            if (!string.IsNullOrEmpty(txtpantalla.Text))
                memoria1 = double.Parse(txtpantalla.Text);
            txtpantalla.Clear();
            lb1.Text = operador + memoria1;
        }

        private void bntborrarderecha_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text.Length > 0)
                txtpantalla.Text = txtpantalla.Text.Remove(txtpantalla.Text.Length - 1);


        }

        private void btnpunto_Click(object sender, EventArgs e)
        {

            txtpantalla.Text = txtpantalla.Text + ",";
            btnpunto.Enabled = false;

        }




        private void btnelevado_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpantalla.Text))
            {
                double n = double.Parse(txtpantalla.Text);
                n = (n * n);
                txtpantalla.Text = n.ToString();

            }
        }

        private void btnmasmenos_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpantalla.Text))
            {
                double n = double.Parse(txtpantalla.Text);
                n = ((n) * (-1));
                txtpantalla.Text = n.ToString();
            }

        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpantalla.Text))
            {
                double n = double.Parse(txtpantalla.Text);
                n = Math.Sqrt(n);
                txtpantalla.Text = n.ToString();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            btnpunto.Enabled = true;
            txtpantalla.Text = "";
            memoria1 = 0;
            memoria2 = 0;
            lb1.Text = "";
        }

        private void btninversa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpantalla.Text))
            {
                double n = double.Parse(txtpantalla.Text);
                n = ((1) / (n));
                txtpantalla.Text = n.ToString();
            }

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Asistencia tecnica comunicarse al celular: 0985779717 \n Correo: darwinmds@hotmail.com", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
