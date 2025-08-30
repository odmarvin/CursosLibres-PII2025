using CursosLibres.Views;
using CursosLibres.Views.Docentes;

namespace CursosLibres
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nuevoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoCursoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmCursos { MdiParent = this }.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void docentesActualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDocentes { MdiParent = this }.Show();
        }
    }
}
