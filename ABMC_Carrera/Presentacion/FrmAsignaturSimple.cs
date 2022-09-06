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
    public partial class FrmAsignaturSimple : Form
    {
        public FrmAsignaturSimple()
        {
            InitializeComponent();
        }

        private void FrmAsignaturSimple_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetAsignaturaSimple.Asignatura' Puede moverla o quitarla según sea necesario.
            this.asignaturaTableAdapter.Fill(this.dataSetAsignaturaSimple.Asignatura);

            this.reportViewer1.RefreshReport();
        }
    }
}
