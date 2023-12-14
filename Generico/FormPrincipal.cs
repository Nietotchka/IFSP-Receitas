using IFSPReceitas.App.Cadastro;
using IFSPReceitas.App.Outros;
using IFSPStore.App.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPReceitas
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroReceita>();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroPaciente>();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroMedico>();
        }

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroMedicamento>();
        }

        private void categoriaMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCategoriaMedicamento>();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }

    }
}
