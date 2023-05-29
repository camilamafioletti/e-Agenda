namespace e_Agenda.WinApp.ModuloDespesas
{
    partial class TelaDespesaForm
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
            txtDataCriacao = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            cmbTipoPagamento = new ComboBox();
            txtDescricao = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            txtValor = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            chCategorias = new CheckedListBox();
            txtId = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDataCriacao
            // 
            txtDataCriacao.Format = DateTimePickerFormat.Short;
            txtDataCriacao.Location = new Point(93, 125);
            txtDataCriacao.Name = "txtDataCriacao";
            txtDataCriacao.Size = new Size(111, 23);
            txtDataCriacao.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 131);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 22;
            label4.Text = "Data:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 100);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 21;
            label3.Text = "Pagamento:";
            // 
            // cmbTipoPagamento
            // 
            cmbTipoPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoPagamento.FormattingEnabled = true;
            cmbTipoPagamento.Location = new Point(287, 97);
            cmbTipoPagamento.Name = "cmbTipoPagamento";
            cmbTipoPagamento.Size = new Size(99, 23);
            cmbTipoPagamento.TabIndex = 20;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(93, 67);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(293, 23);
            txtDescricao.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 70);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 18;
            label2.Text = "Descrição:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 42);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 16;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(311, 342);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(230, 342);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(93, 96);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(111, 23);
            txtValor.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 100);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 24;
            label5.Text = "Valor:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chCategorias);
            groupBox1.Location = new Point(17, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 182);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categorias";
            // 
            // chCategorias
            // 
            chCategorias.FormattingEnabled = true;
            chCategorias.Location = new Point(6, 22);
            chCategorias.Name = "chCategorias";
            chCategorias.Size = new Size(363, 148);
            chCategorias.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(93, 38);
            txtId.Name = "txtId";
            txtId.Size = new Size(26, 23);
            txtId.TabIndex = 8;
            txtId.Text = "0";
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 395);
            Controls.Add(txtId);
            Controls.Add(groupBox1);
            Controls.Add(txtValor);
            Controls.Add(label5);
            Controls.Add(txtDataCriacao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbTipoPagamento);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaDespesaForm";
            Text = "TelaDespesaForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker txtDataCriacao;
        private Label label4;
        private Label label3;
        private ComboBox cmbTipoPagamento;
        private TextBox txtDescricao;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtValor;
        private Label label5;
        private GroupBox groupBox1;
        private CheckedListBox chCategorias;
        private TextBox txtId;
    }
}