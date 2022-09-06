using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABMC_Carrera.Presentacion;

namespace ABMC_Carrera.Presentacion
{
    public partial class FrmMostrarReporteCarrera : Form
    {
        public FrmMostrarReporteCarrera()
        {
            InitializeComponent();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteCarrera carreraDetalle = new FrmReporteCarrera();
            carreraDetalle.Carrera =Convert.ToInt32(txtCarrera.Text);
            carreraDetalle.ShowDialog();
        }

        private void FrmMostrarReporteCarrera_Load(object sender, EventArgs e)
        {

        }
    }
}
