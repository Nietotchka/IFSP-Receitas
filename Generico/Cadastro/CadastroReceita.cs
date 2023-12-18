using IFSPReceita.Domain.Base;
using IFSPReceita.Domain.Entities;
using IFSPReceita.Service.Validators;
using IFSPReceitas.App.Base;
using IFSPReceitas.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPReceitas.App.Cadastro
{
    public partial class CadastroReceita : CadastroBase
    {
        private readonly IBaseService<Receita> _receitaService;
        private readonly IBaseService<Medico> _medicoService;
        private readonly IBaseService<Paciente> _pacienteService;
        private readonly IBaseService<Medicamento> _medicamentoService;

        private List<ReceitaModel>? receitas;
        public CadastroReceita(IBaseService<Receita> receitaService,
            IBaseService<Medico> medicoService,
            IBaseService<Paciente> pacienteService,
            IBaseService<Medicamento> medicamentoService)
        {
            _receitaService = receitaService;
            _medicoService = medicoService;
            _pacienteService = pacienteService;
            _medicamentoService = medicamentoService;
            InitializeComponent();
            CarregarCombo();
            
        }

        private void PreencheObjeto(Receita receita)
        {
            if (int.TryParse(cboNomeMed.SelectedValue.ToString(), out var idNomeMed))
            {
                var medicamento = _medicamentoService.GetById<Medicamento>(idNomeMed);
                receita.Medicamento = medicamento;
            }
            if (DateTime.TryParse(txtValidade.Text, out var validade))
            {
                receita.Validade = validade;
            }

            if (DateTime.TryParse(txtDataPrescricao.Text, out var dataPrescricao))
            {
                receita.Data = dataPrescricao;
            }

            if (int.TryParse(cboMedico.SelectedValue.ToString(), out var idMedico))
            {
                var medico = _medicoService.GetById<Medico>(idMedico);
                receita.Medico = medico;
            }

            if (int.TryParse(cboPaciente.SelectedValue.ToString(), out var idPaciente))
            {
                var paciente = _pacienteService.GetById<Paciente>(idPaciente);
                receita.Paciente = paciente;
            }

        }

        private void CarregarCombo()
        {
            cboMedico.ValueMember = "Id";
            cboMedico.DisplayMember = "Nome";
            cboMedico.DataSource = _medicoService.Get<Medico>().ToList();

            cboPaciente.ValueMember = "Id";
            cboPaciente.DisplayMember = "Nome";
            cboPaciente.DataSource = _pacienteService.Get<Paciente>().ToList();

            cboNomeMed.ValueMember = "Id";
            cboNomeMed.DisplayMember = "Nome";
            cboNomeMed.DataSource = _medicamentoService.Get<Medicamento>().ToList();

        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var receita = _receitaService.GetById<Receita>(id);
                        PreencheObjeto(receita);
                        receita = _receitaService.Update<Receita, Receita, ReceitaValidator>(receita);
                    }
                }
                else
                {
                    var receita = new Receita();
                    PreencheObjeto(receita);
                    _receitaService.Add<Receita, Receita, ReceitaValidator>(receita);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Receita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _receitaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Receita", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            receitas = _receitaService.Get<ReceitaModel>(new[] { "Medico","Paciente","Medicamento" }).ToList();
            dataGridViewConsulta.DataSource = receitas;

        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtValidade.Text = linha?.Cells["Validade"].Value.ToString();
            //cboMedico.SelectedValue = linha?.Cells["MedicoId"].Value;
            //cboPaciente.SelectedValue = linha?.Cells["PacienteId"].Value;
            txtValidade.Text = DateTime.TryParse(linha?.Cells["Validade"].Value.ToString(), out var dataC)
              ? dataC.ToString("g")
              : "";
            /* txtDataPrescricao.Text = DateTime.TryParse(linha?.Cells["Data de Prescrição"].Value.ToString(), out var dataP)
               ? dataP.ToString("g")
               : "";*/
        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
