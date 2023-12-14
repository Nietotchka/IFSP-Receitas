namespace IFSPReceitas.App.Cadastro
{
    partial class CadastroReceita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboPaciente = new ReaLTaiizor.Controls.MaterialComboBox();
            cboMedico = new ReaLTaiizor.Controls.MaterialComboBox();
            txtValidade = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDataPrescricao = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboNomeMed = new ReaLTaiizor.Controls.MaterialComboBox();
            tabPageCadastro.SuspendLayout();
            materialTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboNomeMed);
            tabPageCadastro.Controls.Add(txtDataPrescricao);
            tabPageCadastro.Controls.Add(txtValidade);
            tabPageCadastro.Controls.Add(cboMedico);
            tabPageCadastro.Controls.Add(cboPaciente);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(578, 246);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboPaciente, 0);
            tabPageCadastro.Controls.SetChildIndex(cboMedico, 0);
            tabPageCadastro.Controls.SetChildIndex(txtValidade, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataPrescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(cboNomeMed, 0);
            // 
            // materialTabControl
            // 
            materialTabControl.Size = new Size(586, 274);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(6, 6);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(280, 48);
            txtId.TabIndex = 16;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboPaciente
            // 
            cboPaciente.AutoResize = false;
            cboPaciente.BackColor = Color.FromArgb(255, 255, 255);
            cboPaciente.Depth = 0;
            cboPaciente.DrawMode = DrawMode.OwnerDrawVariable;
            cboPaciente.DropDownHeight = 174;
            cboPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaciente.DropDownWidth = 121;
            cboPaciente.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPaciente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPaciente.FormattingEnabled = true;
            cboPaciente.Hint = "Nome do Paciente";
            cboPaciente.IntegralHeight = false;
            cboPaciente.ItemHeight = 43;
            cboPaciente.Location = new Point(292, 114);
            cboPaciente.MaxDropDownItems = 4;
            cboPaciente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPaciente.Name = "cboPaciente";
            cboPaciente.Size = new Size(280, 49);
            cboPaciente.StartIndex = 0;
            cboPaciente.TabIndex = 24;
            // 
            // cboMedico
            // 
            cboMedico.AutoResize = false;
            cboMedico.BackColor = Color.FromArgb(255, 255, 255);
            cboMedico.Depth = 0;
            cboMedico.DrawMode = DrawMode.OwnerDrawVariable;
            cboMedico.DropDownHeight = 174;
            cboMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMedico.DropDownWidth = 121;
            cboMedico.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboMedico.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboMedico.FormattingEnabled = true;
            cboMedico.Hint = "Nome do Médico";
            cboMedico.IntegralHeight = false;
            cboMedico.ItemHeight = 43;
            cboMedico.Location = new Point(292, 60);
            cboMedico.MaxDropDownItems = 4;
            cboMedico.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboMedico.Name = "cboMedico";
            cboMedico.Size = new Size(280, 49);
            cboMedico.StartIndex = 0;
            cboMedico.TabIndex = 25;
            // 
            // txtValidade
            // 
            txtValidade.AllowPromptAsInput = true;
            txtValidade.AnimateReadOnly = false;
            txtValidade.AsciiOnly = false;
            txtValidade.BackgroundImageLayout = ImageLayout.None;
            txtValidade.BeepOnError = false;
            txtValidade.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtValidade.Depth = 0;
            txtValidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValidade.HidePromptOnLeave = false;
            txtValidade.HideSelection = true;
            txtValidade.Hint = "Validade";
            txtValidade.InsertKeyMode = InsertKeyMode.Default;
            txtValidade.LeadingIcon = null;
            txtValidade.Location = new Point(292, 6);
            txtValidade.Mask = "99/99/9999";
            txtValidade.MaxLength = 32767;
            txtValidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValidade.Name = "txtValidade";
            txtValidade.PasswordChar = '\0';
            txtValidade.PrefixSuffixText = null;
            txtValidade.PromptChar = '_';
            txtValidade.ReadOnly = false;
            txtValidade.RejectInputOnFirstFailure = false;
            txtValidade.ResetOnPrompt = true;
            txtValidade.ResetOnSpace = true;
            txtValidade.RightToLeft = RightToLeft.No;
            txtValidade.SelectedText = "";
            txtValidade.SelectionLength = 0;
            txtValidade.SelectionStart = 0;
            txtValidade.ShortcutsEnabled = true;
            txtValidade.Size = new Size(280, 48);
            txtValidade.SkipLiterals = true;
            txtValidade.TabIndex = 26;
            txtValidade.TabStop = false;
            txtValidade.Text = "  /  /";
            txtValidade.TextAlign = HorizontalAlignment.Center;
            txtValidade.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtValidade.TrailingIcon = null;
            txtValidade.UseSystemPasswordChar = false;
            txtValidade.ValidatingType = null;
            // 
            // txtDataPrescricao
            // 
            txtDataPrescricao.AllowPromptAsInput = true;
            txtDataPrescricao.AnimateReadOnly = false;
            txtDataPrescricao.AsciiOnly = false;
            txtDataPrescricao.BackgroundImageLayout = ImageLayout.None;
            txtDataPrescricao.BeepOnError = false;
            txtDataPrescricao.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataPrescricao.Depth = 0;
            txtDataPrescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataPrescricao.HidePromptOnLeave = false;
            txtDataPrescricao.HideSelection = true;
            txtDataPrescricao.Hint = "Data de Prescrição";
            txtDataPrescricao.InsertKeyMode = InsertKeyMode.Default;
            txtDataPrescricao.LeadingIcon = null;
            txtDataPrescricao.Location = new Point(6, 115);
            txtDataPrescricao.Mask = "99/99/9999";
            txtDataPrescricao.MaxLength = 32767;
            txtDataPrescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataPrescricao.Name = "txtDataPrescricao";
            txtDataPrescricao.PasswordChar = '\0';
            txtDataPrescricao.PrefixSuffixText = null;
            txtDataPrescricao.PromptChar = '_';
            txtDataPrescricao.ReadOnly = false;
            txtDataPrescricao.RejectInputOnFirstFailure = false;
            txtDataPrescricao.ResetOnPrompt = true;
            txtDataPrescricao.ResetOnSpace = true;
            txtDataPrescricao.RightToLeft = RightToLeft.No;
            txtDataPrescricao.SelectedText = "";
            txtDataPrescricao.SelectionLength = 0;
            txtDataPrescricao.SelectionStart = 0;
            txtDataPrescricao.ShortcutsEnabled = true;
            txtDataPrescricao.Size = new Size(280, 48);
            txtDataPrescricao.SkipLiterals = true;
            txtDataPrescricao.TabIndex = 27;
            txtDataPrescricao.TabStop = false;
            txtDataPrescricao.Text = "  /  /";
            txtDataPrescricao.TextAlign = HorizontalAlignment.Center;
            txtDataPrescricao.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataPrescricao.TrailingIcon = null;
            txtDataPrescricao.UseSystemPasswordChar = false;
            txtDataPrescricao.ValidatingType = null;
            // 
            // cboNomeMed
            // 
            cboNomeMed.AutoResize = false;
            cboNomeMed.BackColor = Color.FromArgb(255, 255, 255);
            cboNomeMed.Depth = 0;
            cboNomeMed.DrawMode = DrawMode.OwnerDrawVariable;
            cboNomeMed.DropDownHeight = 174;
            cboNomeMed.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNomeMed.DropDownWidth = 121;
            cboNomeMed.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboNomeMed.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNomeMed.FormattingEnabled = true;
            cboNomeMed.Hint = "Nome do Medicamento";
            cboNomeMed.IntegralHeight = false;
            cboNomeMed.ItemHeight = 43;
            cboNomeMed.Location = new Point(6, 60);
            cboNomeMed.MaxDropDownItems = 4;
            cboNomeMed.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboNomeMed.Name = "cboNomeMed";
            cboNomeMed.Size = new Size(280, 49);
            cboNomeMed.StartIndex = 0;
            cboNomeMed.TabIndex = 28;
            cboNomeMed.SelectedIndexChanged += materialComboBox1_SelectedIndexChanged;
            // 
            // CadastroReceita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 341);
            Location = new Point(0, 0);
            Name = "CadastroReceita";
            Text = "Cadastro de Receita";
            tabPageCadastro.ResumeLayout(false);
            materialTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialComboBox cboPaciente;
        private ReaLTaiizor.Controls.MaterialComboBox cboMedico;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtValidade;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataPrescricao;
        private ReaLTaiizor.Controls.MaterialComboBox cboNomeMed;
    }
}