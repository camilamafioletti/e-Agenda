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
            txtTitulo = new TextBox();
            label1 = new Label();
            lblPrioridade = new Label();
            txtIdTarefa = new TextBox();
            lblIdTarefas = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtPrioridade = new ComboBox();
            label2 = new Label();
            dateTimeCriacao = new DateTimePicker();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.AccessibleName = "txtTitulo";
            txtTitulo.Location = new Point(81, 59);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(143, 23);
            txtTitulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AccessibleName = "lblTitulo";
            label1.AutoSize = true;
            label1.Location = new Point(38, 62);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Titulo";
            // 
            // lblPrioridade
            // 
            lblPrioridade.AccessibleName = "lblPrioridade";
            lblPrioridade.AutoSize = true;
            lblPrioridade.Location = new Point(14, 91);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(61, 15);
            lblPrioridade.TabIndex = 3;
            lblPrioridade.Text = "Prioridade";
            // 
            // txtIdTarefa
            // 
            txtIdTarefa.AccessibleName = "txtIdTarefas";
            txtIdTarefa.Location = new Point(81, 30);
            txtIdTarefa.Name = "txtIdTarefa";
            txtIdTarefa.Size = new Size(30, 23);
            txtIdTarefa.TabIndex = 4;
            txtIdTarefa.Text = "0";
            // 
            // lblIdTarefas
            // 
            lblIdTarefas.AccessibleDescription = "lblIdTarefas";
            lblIdTarefas.AutoSize = true;
            lblIdTarefas.Location = new Point(58, 33);
            lblIdTarefas.Name = "lblIdTarefas";
            lblIdTarefas.Size = new Size(17, 15);
            lblIdTarefas.TabIndex = 5;
            lblIdTarefas.Text = "Id";
            // 
            // btnGravar
            // 
            btnGravar.AccessibleName = "btnGaravarTarefa";
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(99, 160);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AccessibleName = "btnCancelarTarefa";
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(180, 160);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtPrioridade
            // 
            txtPrioridade.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPrioridade.FormattingEnabled = true;
            txtPrioridade.Location = new Point(81, 88);
            txtPrioridade.Name = "txtPrioridade";
            txtPrioridade.Size = new Size(143, 23);
            txtPrioridade.TabIndex = 20;
            // 
            // label2
            // 
            label2.AccessibleName = "lblPrioridade";
            label2.AutoSize = true;
            label2.Location = new Point(38, 124);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 21;
            label2.Text = "Data";
            // 
            // dateTimeCriacao
            // 
            dateTimeCriacao.Format = DateTimePickerFormat.Short;
            dateTimeCriacao.Location = new Point(81, 118);
            dateTimeCriacao.Name = "dateTimeCriacao";
            dateTimeCriacao.Size = new Size(143, 23);
            dateTimeCriacao.TabIndex = 22;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 213);
            Controls.Add(dateTimeCriacao);
            Controls.Add(label2);
            Controls.Add(txtPrioridade);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lblIdTarefas);
            Controls.Add(txtIdTarefa);
            Controls.Add(lblPrioridade);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Name = "TelaTarefaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label label1;
        private Label lblPrioridade;
        private TextBox txtIdTarefa;
        private Label lblIdTarefas;
        private Button btnGravar;
        private Button btnCancelar;
        private ComboBox txtPrioridade;
        private Label label2;
        private DateTimePicker dateTimeCriacao;
    }
}