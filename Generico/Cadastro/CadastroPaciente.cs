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
    public partial class CadastroPaciente : CadastroBase
    {
        private readonly IBaseService<Paciente> _pacienteService;

        private List<PacienteModel>? pacientes;
        public CadastroPaciente(IBaseService<Paciente> pacienteService)
        {
            _pacienteService = pacienteService;
            InitializeComponent();
        }

        private void PreencheObjeto(Paciente paciente)
        {
            paciente.Nome = txtNome.Text;
            paciente.Email = txtEmail.Text;
            paciente.Endereco = txtEndereco.Text;

            if (int.TryParse(txtNumero.Text, out int numero))
            {
                paciente.Numero = numero;
            }
            else
            {
                Console.WriteLine("Número inválido. Por favor, insira um número válido.");
            }

            paciente.Bairro = txtBairro.Text;

            if (int.TryParse(txtTelefone.Text, out int telefone))
            {
                paciente.Telefone = telefone;
            }
            else
            {
                Console.WriteLine("Telefone inválido. Por favor, insira um número válido.");
            }

            paciente.Convenio = txtConvenio.Text;

            if (int.TryParse(txtNumConvenio.Text, out int numconvenio))
            {
                paciente.NumeroConvenio = numconvenio;
            }
            else
            {
                Console.WriteLine("Número do Convênio inválido. Por favor, insira um número válido.");
            }

             if (int.TryParse(txtCPF.Text, out int cpf))
             {
                 paciente.CPF = cpf;
             }
             else
             {
                 Console.WriteLine("CPF inválido. Por favor, insira um número válido.");
             }
            

            //paciente.CPF = txtCPF.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var paciente = _pacienteService.GetById<Paciente>(id);
                        PreencheObjeto(paciente);
                        _pacienteService.Update<Paciente, Paciente, PacienteValidator>(paciente);
                    }
                }
                else
                {
                    var paciente = new Paciente();
                    PreencheObjeto(paciente);
                    _pacienteService.Add<Paciente, Paciente, PacienteValidator>(paciente);

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
                _pacienteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Receitas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            pacientes = _pacienteService.Get<PacienteModel>().ToList();
            dataGridViewConsulta.DataSource = pacientes;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtNumero.Text = linha?.Cells["Numero"].Value.ToString();
            txtBairro.Text = linha?.Cells["Bairro"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtConvenio.Text = linha?.Cells["Convenio"].Value.ToString();
            txtNumConvenio.Text = linha?.Cells["NumeroConvenio"].Value.ToString();
            txtCPF.Text = linha?.Cells["CPF"].Value.ToString();
        }

    }
}
