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
            txtPrioridade = new TextBox();
            label1 = new Label();
            lblPrioridade = new Label();
            txtIdTarefa = new TextBox();
            lblIdTarefas = new Label();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.AccessibleName = "txtTitulo";
            txtTitulo.Location = new Point(75, 41);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(254, 23);
            txtTitulo.TabIndex = 0;
            // 
            // txtPrioridade
            // 
            txtPrioridade.AccessibleName = "txtPrioridade";
            txtPrioridade.Location = new Point(75, 70);
            txtPrioridade.Name = "txtPrioridade";
            txtPrioridade.Size = new Size(254, 23);
            txtPrioridade.TabIndex = 1;
            // 
            // label1
            // 
            label1.AccessibleName = "lblTitulo";
            label1.AutoSize = true;
            label1.Location = new Point(32, 44);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Titulo";
            // 
            // lblPrioridade
            // 
            lblPrioridade.AccessibleName = "lblPrioridade";
            lblPrioridade.AutoSize = true;
            lblPrioridade.Location = new Point(8, 73);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(61, 15);
            lblPrioridade.TabIndex = 3;
            lblPrioridade.Text = "Prioridade";
            // 
            // txtIdTarefa
            // 
            txtIdTarefa.AccessibleName = "txtIdTarefas";
            txtIdTarefa.Location = new Point(75, 12);
            txtIdTarefa.Name = "txtIdTarefa";
            txtIdTarefa.Size = new Size(30, 23);
            txtIdTarefa.TabIndex = 4;
            txtIdTarefa.Text = "0";
            // 
            // lblIdTarefas
            // 
            lblIdTarefas.AccessibleDescription = "lblIdTarefas";
            lblIdTarefas.AutoSize = true;
            lblIdTarefas.Location = new Point(52, 15);
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
            btnGravar.Location = new Point(173, 106);
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
            btnCancelar.Location = new Point(254, 106);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 159);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(lblIdTarefas);
            Controls.Add(txtIdTarefa);
            Controls.Add(lblPrioridade);
            Controls.Add(label1);
            Controls.Add(txtPrioridade);
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
        private TextBox txtPrioridade;
        private Label label1;
        private Label lblPrioridade;
        private TextBox txtIdTarefa;
        private Label lblIdTarefas;
        private Button btnGravar;
        private Button btnCancelar;
    }
}