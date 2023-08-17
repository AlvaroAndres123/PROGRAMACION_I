using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double N1 = double.Parse(txtN1.Text);
                double N2 = double.Parse(txtN2.Text);
                double N3 = double.Parse(txtN3.Text);

                double promedio = (N1 + N2 + N3) / 3;

                MessageBox.Show($"El promedio de las notas es: {promedio:F2}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
