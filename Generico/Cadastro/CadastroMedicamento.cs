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
    public partial class CadastroMedicamento : CadastroBase
    {

        private readonly IBaseService<Medicamento> _medicamentoService;
        private readonly IBaseService<CategoriaMedicamento> _categoriaService;

        private List<MedicamentoModel>? medicamentos;
        public CadastroMedicamento(IBaseService<Medicamento> medicamentoService, IBaseService<CategoriaMedicamento> categoriaService)
        {
            _medicamentoService = medicamentoService;
            _categoriaService = categoriaService;
            InitializeComponent();
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            cboCategoria.ValueMember = "Id";
            cboCategoria.DisplayMember = "Categoria";
            cboCategoria.DataSource = _categoriaService.Get<CategoriaMedicamento>().ToList();

        }

        private void PreencheObjeto(Medicamento medicamento)
        {
            medicamento.Nome = txtNome.Text;

            
            if (int.TryParse(cboCategoria.SelectedValue.ToString(), out var idCategoria))
            {
                var categoria = _categoriaService.GetById<CategoriaMedicamento>(idCategoria);
                medicamento.Categoria = categoria.Categoria;
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
                        var medicamento = _medicamentoService.GetById<Medicamento>(id);
                        PreencheObjeto(medicamento);
                        medicamento = _medicamentoService.Update<Medicamento, Medicamento, MedicamentoValidator>(medicamento);
                    }
                }
                else
                {
                    var medicamento = new Medicamento();
                    PreencheObjeto(medicamento);
                    _medicamentoService.Add<Medicamento, Medicamento, MedicamentoValidator>(medicamento);

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
                _medicamentoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Receitas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            medicamentos = _medicamentoService.Get<MedicamentoModel>().ToList();
            dataGridViewConsulta.DataSource = medicamentos;
            dataGridViewConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            //cboCategoria.Text = linha?.Cells["Categoria"].Value.ToString();
        }
    }
}
