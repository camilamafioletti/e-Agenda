namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaCadastroItensForm
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
            btnAdicionar = new Button();
            label4 = new Label();
            txtTituloItem = new TextBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            listItens = new ListBox();
            lblIdTarefas = new Label();
            txtIdTarefa = new TextBox();
            label1 = new Label();
            txtTitulo = new TextBox();
            btnRemoverSub = new Button();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(207, 90);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(73, 23);
            btnAdicionar.TabIndex = 36;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AccessibleName = "lblPrioridade";
            label4.AutoSize = true;
            label4.Location = new Point(20, 90);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 40;
            label4.Text = "Itens";
            // 
            // txtTituloItem
            // 
            txtTituloItem.Location = new Point(58, 90);
            txtTituloItem.Name = "txtTituloItem";
            txtTituloItem.Size = new Size(143, 23);
            txtTituloItem.TabIndex = 34;
            // 
            // btnCancelar
            // 
            btnCancelar.AccessibleName = "";
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(270, 269);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.AccessibleName = "";
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(189, 269);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 31;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // listItens
            // 
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 15;
            listItens.Location = new Point(58, 119);
            listItens.Name = "listItens";
            listItens.Size = new Size(288, 139);
            listItens.TabIndex = 38;
            // 
            // lblIdTarefas
            // 
            lblIdTarefas.AccessibleDescription = "lblIdTarefas";
            lblIdTarefas.AutoSize = true;
            lblIdTarefas.Location = new Point(35, 35);
            lblIdTarefas.Name = "lblIdTarefas";
            lblIdTarefas.Size = new Size(17, 15);
            lblIdTarefas.TabIndex = 42;
            lblIdTarefas.Text = "Id";
            // 
            // txtIdTarefa
            // 
            txtIdTarefa.AccessibleName = "txtIdTarefas";
            txtIdTarefa.Location = new Point(58, 32);
            txtIdTarefa.Name = "txtIdTarefa";
            txtIdTarefa.ReadOnly = true;
            txtIdTarefa.Size = new Size(30, 23);
            txtIdTarefa.TabIndex = 41;
            txtIdTarefa.Text = "0";
            // 
            // label1
            // 
            label1.AccessibleName = "lblTitulo";
            label1.AutoSize = true;
            label1.Location = new Point(15, 64);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 40;
            label1.Text = "Titulo";
            // 
            // txtTitulo
            // 
            txtTitulo.AccessibleName = "txtTitulo";
            txtTitulo.Location = new Point(58, 61);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(143, 23);
            txtTitulo.TabIndex = 39;
            // 
            // btnRemoverSub
            // 
            btnRemoverSub.Location = new Point(285, 90);
            btnRemoverSub.Name = "btnRemoverSub";
            btnRemoverSub.Size = new Size(61, 23);
            btnRemoverSub.TabIndex = 43;
            btnRemoverSub.Text = "Deletar";
            btnRemoverSub.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroItensForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 322);
            Controls.Add(btnRemoverSub);
            Controls.Add(lblIdTarefas);
            Controls.Add(txtIdTarefa);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Controls.Add(listItens);
            Controls.Add(btnAdicionar);
            Controls.Add(label4);
            Controls.Add(txtTituloItem);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaCadastroItensForm";
            Text = "TelaCadastroItensForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Label label4;
        private TextBox txtTituloItem;
        private Button btnCancelar;
        private Button btnGravar;
        private ListBox listItens;
        private Label lblIdTarefas;
        private TextBox txtIdTarefa;
        private Label label1;
        private TextBox txtTitulo;
        private Button btnRemoverSub;
    }
}