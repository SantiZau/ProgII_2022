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
    public partial class FrmAsignatura : Form
    {
        public FrmAsignatura()
        {
            InitializeComponent();
        }

        private void FrmAsignatura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetAsignaturas.pa_MostrarGrupoAsignatura' Puede moverla o quitarla según sea necesario.
            this.pa_MostrarGrupoAsignaturaTableAdapter.Fill(this.dataSetAsignaturas.pa_MostrarGrupoAsignatura);

            this.reportViewer1.RefreshReport();
        }
    }
}
