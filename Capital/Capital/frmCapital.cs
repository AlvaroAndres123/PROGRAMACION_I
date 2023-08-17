using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capital
{
    public partial class frmCapital : Form
    {
        public frmCapital()
        {
            InitializeComponent();
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            try
            {
                double F_Hermano = double.Parse(txtPrimer.Text);
                double S_Hermano = double.Parse(txtSegundo.Text);
                double T_Hermano = double.Parse(txtTercero.Text);

                double montoTotal = F_Hermano + S_Hermano + T_Hermano;

                double porcentajeF = (F_Hermano / montoTotal) * 100;
                double porcentajeS = (S_Hermano / montoTotal) * 100;
                double porcentajeT = (T_Hermano / montoTotal) * 100;

                MessageBox.Show(
                    $"Monto total del capital formado: {montoTotal:C}\n" +
                    $"Porcentaje del primer hermano: {porcentajeF:F2}%\n" +
                    $"Porcentaje del segundo hermano: {porcentajeS:F2}%\n" +
                    $"Porcentaje del tercer hermano: {porcentajeT:F2}%"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
    }
}
