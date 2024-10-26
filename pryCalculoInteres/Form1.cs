using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalculoInteres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal meses = (int)numMeses.Value;

            decimal interes = (int)numInteres.Value;

            decimal monto = int.Parse(txtMonto.Text);
            
            if (meses > 0 && interes > 0 && monto > 0) {
                decimal R = 0;
                if (meses <= 3) {
                    R = monto;
                }
                else { 
                    R = ((monto * interes) / 100) + monto;
                }
                lblValorCuota.Text = "$" + (R / meses).ToString("F2");
                txtTotal.Text = "$" + (R + monto).ToString("F2");
                lblError.Text = "";
            } else {
                lblError.Text = "Error, se deben colocar valores mayores a 0";
            }
        }
    }
}
