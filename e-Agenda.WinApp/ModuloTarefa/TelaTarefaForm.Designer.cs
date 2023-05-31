namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            txtTitulo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbPrioridade = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtDataCriacao = new DateTimePicker();
            txtId = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightPink;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(225, 171);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(74, 41);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.LightPink;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(149, 171);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(70, 41);
            btnGravar.TabIndex = 2;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(91, 58);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(151, 23);
            txtTitulo.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 62);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Título:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 32);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 6;
            label1.Text = "Id:";
            // 
            // cmbPrioridade
            // 
            cmbPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrioridade.FormattingEnabled = true;
            cmbPrioridade.Location = new Point(91, 87);
            cmbPrioridade.Name = "cmbPrioridade";
            cmbPrioridade.Size = new Size(150, 23);
            cmbPrioridade.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 90);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 11;
            label3.Text = "Prioridade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 122);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 12;
            label4.Text = "Data:";
            // 
            // txtDataCriacao
            // 
            txtDataCriacao.Format = DateTimePickerFormat.Short;
            txtDataCriacao.Location = new Point(92, 116);
            txtDataCriacao.Name = "txtDataCriacao";
            txtDataCriacao.Size = new Size(150, 23);
            txtDataCriacao.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(92, 32);
            txtId.Name = "txtId";
            txtId.Size = new Size(13, 15);
            txtId.TabIndex = 14;
            txtId.Text = "0";
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(312, 224);
            Controls.Add(txtId);
            Controls.Add(txtDataCriacao);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbPrioridade);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaTarefaForm";
            Text = "Cadastro de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGravar;
        private TextBox txtTitulo;
        private Label label2;
        private Label label1;
        private ComboBox cmbPrioridade;
        private Label label3;
        private Label label4;
        private DateTimePicker txtDataCriacao;
        private Label txtId;
    }
}