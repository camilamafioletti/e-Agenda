namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaAtualizacaoItensTarefaForm
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
            listItensTarefa = new CheckedListBox();
            txtId = new Label();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(77, 52);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.ReadOnly = true;
            txtTitulo.Size = new Size(226, 23);
            txtTitulo.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 56);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 12;
            label2.Text = "Título:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 23);
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
            btnCancelar.Location = new Point(228, 268);
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
            btnGravar.Location = new Point(147, 268);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            // 
            // listItensTarefa
            // 
            listItensTarefa.BackColor = Color.LightPink;
            listItensTarefa.FormattingEnabled = true;
            listItensTarefa.Location = new Point(31, 94);
            listItensTarefa.Name = "listItensTarefa";
            listItensTarefa.Size = new Size(272, 166);
            listItensTarefa.TabIndex = 17;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(77, 23);
            txtId.Name = "txtId";
            txtId.Size = new Size(13, 15);
            txtId.TabIndex = 18;
            txtId.Text = "0";
            // 
            // TelaAtualizacaoItensTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(315, 321);
            Controls.Add(txtId);
            Controls.Add(listItensTarefa);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaAtualizacaoItensTarefaForm";
            Text = "Atualização de Itens da Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private CheckedListBox listItensTarefa;
        private Label txtId;
    }
}