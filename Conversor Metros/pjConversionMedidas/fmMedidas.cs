using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjConversionMedidas
{
    public partial class fmMedidas : Form
    {
        public fmMedidas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Capturando el valor en metros
            double metros = double.Parse(txtMetros.Text);

            //Realizando conversiones
            double centimetros = metros * 100;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12;
            double yardas = pies / 3;

            // Mostrar en el listbox
            lstR.Items.Add("1) Resumen de Conversiones");
            lstR.Items.Add("2) Medida en Metros " + metros.ToString("0.00"));
            lstR.Items.Add("3) Medida en Centimetros " + centimetros.ToString("0.00"));
            lstR.Items.Add("4) Medida en pulgadas " + pulgadas.ToString("0.00"));
            lstR.Items.Add("5) Medida en Pies " + pies.ToString("0.00"));
            lstR.Items.Add("6) Medida en Yardas " + yardas.ToString("0.00"));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            lstR.Items.Clear();
            txtMetros.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Te quieres Salir?", "Medidas", MessageBoxButtons.YesNo , MessageBoxIcon.Question
          );

            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
