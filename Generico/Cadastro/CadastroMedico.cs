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
    public partial class CadastroMedico : CadastroBase
    {
        private readonly IBaseService<Medico> _medicoService;

        private List<MedicoModel>? medicos;

        public CadastroMedico(IBaseService<Medico> medicoService)
        {
            _medicoService = medicoService;
            InitializeComponent();
        }

        private void PreencheObjeto(Medico medico)
        {
            medico.Especialidade = txtEspecialidade.Text;
            medico.Nome = txtNome.Text;

            if (int.TryParse(txtCRM.Text, out int crm))
            {
                medico.CRM = crm;
            }
            else
            {
                Console.WriteLine("CRM inválido. Por favor, insira um número válido.");
            }

            medico.Email = txtEmail.Text;

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                medico.Numero = numero;
            }
            else
            {
                Console.WriteLine("Número inválido. Por favor, insira um número válido.");
            }

            medico.Endereco = txtEndereco.Text;

            medico.Bairro = txtBairro.Text;

            if (int.TryParse(txtTelefone.Text, out int telefone))
            {
                medico.Telefone = telefone;
            }
            else
            {
                Console.WriteLine("Telefone inválido. Por favor, insira um número válido.");
            }

        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var medico = _medicoService.GetById<Medico>(id);
                        PreencheObjeto(medico);
                        _medicoService.Update<Medico, Medico, MedicoValidator>(medico);
                    }
                }
                else
                {
                    var medico = new Medico();
                    PreencheObjeto(medico);
                    _medicoService.Add<Medico, Medico, MedicoValidator>(medico);

                }

                materialTabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Receitas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _medicoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Receitas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            medicos = _medicoService.Get<MedicoModel>().ToList();
            dataGridViewConsulta.DataSource = medicos;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            /*
            dataGridViewConsulta.DataSource = medicos;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewConsulta.Columns["Id"]!.Visible = false;
            */
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtEspecialidade.Text = linha?.Cells["Especialidade"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtCRM.Text = linha?.Cells["CRM"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtNumero.Text = linha?.Cells["Numero"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();   
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
        }

    }
}
