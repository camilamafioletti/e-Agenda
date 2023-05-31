namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaCadastroItensTarefaForm
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
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnGravar = new Button();
            listItens = new ListBox();
            txtTituloItem = new TextBox();
            label3 = new Label();
            btnAdicionar = new Button();
            txtId = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(87, 47);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(216, 23);
            txtTitulo.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 51);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 12;
            label2.Text = "Título:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 18);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 10;
            label1.Text = "Id:";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightPink;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(228, 262);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.LightPink;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(147, 262);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            // 
            // listItens
            // 
            listItens.BackColor = Color.LightPink;
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 15;
            listItens.Location = new Point(23, 110);
            listItens.Name = "listItens";
            listItens.Size = new Size(280, 139);
            listItens.TabIndex = 16;
            // 
            // txtTituloItem
            // 
            txtTituloItem.Location = new Point(87, 81);
            txtTituloItem.Name = "txtTituloItem";
            txtTituloItem.Size = new Size(135, 23);
            txtTituloItem.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 85);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 17;
            label3.Text = "Descrição:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.LightPink;
            btnAdicionar.Location = new Point(228, 81);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 19;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(87, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(13, 15);
            txtId.TabIndex = 20;
            txtId.Text = "0";
            // 
            // TelaCadastroItensTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(315, 315);
            Controls.Add(txtId);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTituloItem);
            Controls.Add(label3);
            Controls.Add(listItens);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastroItensTarefaForm";
            Text = "Cadastro de Subtarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private ListBox listItens;
        private TextBox txtTituloItem;
        private Label label3;
        private Button btnAdicionar;
        private Label txtId;
    }
}