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
    public partial class CadastroCategoriaMedicamento : CadastroBase
    {
        private readonly IBaseService<CategoriaMedicamento> _categoriamedicamentoService;

        private List<CategoriaMedicamentoModel>? categorias;
        public CadastroCategoriaMedicamento(IBaseService<CategoriaMedicamento> categoriamedicamentoService)
        {
            _categoriamedicamentoService = categoriamedicamentoService;
            InitializeComponent();
        }

        private void PreencheObjeto(CategoriaMedicamento categoria)
        {
            categoria.Categoria = txtCategoria.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var categoriamedicamento = _categoriamedicamentoService.GetById<CategoriaMedicamento>(id);
                        PreencheObjeto(categoriamedicamento);
                        categoriamedicamento = _categoriamedicamentoService.Update<CategoriaMedicamento, CategoriaMedicamento, CategoriaMedicamentoValidator>(categoriamedicamento);
                    }
                }
                else
                {
                    var categoriamedicamento = new CategoriaMedicamento();
                    PreencheObjeto(categoriamedicamento);
                    _categoriamedicamentoService.Add<CategoriaMedicamento, CategoriaMedicamento, CategoriaMedicamentoValidator>(categoriamedicamento);

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
                _categoriamedicamentoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Receitas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            categorias = _categoriamedicamentoService.Get<CategoriaMedicamentoModel>().ToList();
            dataGridViewConsulta.DataSource = categorias;
            dataGridViewConsulta.Columns["Categoria"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtCategoria.Text = linha?.Cells["Categoria"].Value.ToString();
        }

    }
}
