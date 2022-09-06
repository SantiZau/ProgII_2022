using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMC_Carrera.Presentacion
{
    public partial class FrmReporteCarrera : Form
    {
        public FrmReporteCarrera()
        {
            InitializeComponent();
        }
        public int Carrera { get; set; }
        private void FrmReporteCarrera_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCarrera.paReporteCarreraDetalle' Puede moverla o quitarla según sea necesario.
            this.paReporteCarreraDetalleTableAdapter.Fill(this.dataSetCarrera.paReporteCarreraDetalle,Carrera);

            this.reportViewer1.RefreshReport();
        }
    }
}
