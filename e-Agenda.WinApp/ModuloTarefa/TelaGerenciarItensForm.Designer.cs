namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaGerenciarItensForm
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
            btnRemoverSub = new Button();
            btnAdicionarSub = new Button();
            label4 = new Label();
            txtSubtarefa = new TextBox();
            chListSubtarefa = new CheckedListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // btnRemoverSub
            // 
            btnRemoverSub.Location = new Point(239, 41);
            btnRemoverSub.Name = "btnRemoverSub";
            btnRemoverSub.Size = new Size(61, 23);
            btnRemoverSub.TabIndex = 30;
            btnRemoverSub.Text = "Deletar";
            btnRemoverSub.UseVisualStyleBackColor = true;
            btnRemoverSub.Click += btnRemoverSub_Click_1;
            // 
            // btnAdicionarSub
            // 
            btnAdicionarSub.Location = new Point(160, 41);
            btnAdicionarSub.Name = "btnAdicionarSub";
            btnAdicionarSub.Size = new Size(73, 23);
            btnAdicionarSub.TabIndex = 29;
            btnAdicionarSub.Text = "Adicionar";
            btnAdicionarSub.UseVisualStyleBackColor = true;
            btnAdicionarSub.Click += btnAdicionarSub_Click_1;
            // 
            // label4
            // 
            label4.AccessibleName = "lblPrioridade";
            label4.AutoSize = true;
            label4.Location = new Point(12, 23);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 28;
            label4.Text = "adicionar sub tarefa";
            // 
            // txtSubtarefa
            // 
            txtSubtarefa.Location = new Point(12, 41);
            txtSubtarefa.Name = "txtSubtarefa";
            txtSubtarefa.Size = new Size(141, 23);
            txtSubtarefa.TabIndex = 27;
            // 
            // chListSubtarefa
            // 
            chListSubtarefa.FormattingEnabled = true;
            chListSubtarefa.Location = new Point(12, 69);
            chListSubtarefa.Name = "chListSubtarefa";
            chListSubtarefa.Size = new Size(288, 94);
            chListSubtarefa.TabIndex = 26;
            // 
            // btnCancelar
            // 
            btnCancelar.AccessibleName = "";
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(230, 179);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.AccessibleName = "";
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(149, 179);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 24;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // TelaSubTarefasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 232);
            Controls.Add(btnRemoverSub);
            Controls.Add(btnAdicionarSub);
            Controls.Add(label4);
            Controls.Add(txtSubtarefa);
            Controls.Add(chListSubtarefa);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Name = "TelaSubTarefasForm";
            ShowIcon = false;
            Text = "Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemoverSub;
        private Button btnAdicionarSub;
        private Label label4;
        private TextBox txtSubtarefa;
        private CheckedListBox chListSubtarefa;
        private Button btnCancelar;
        private Button btnGravar;
    }
}