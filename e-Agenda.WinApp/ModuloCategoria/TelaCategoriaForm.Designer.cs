namespace e_Agenda.WinApp.ModuloCategoria
{
    partial class TelaCategoriaForm
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
            label1 = new Label();
            label2 = new Label();
            txtId = new Label();
            textBox1 = new TextBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 65);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Titulo";
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(92, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(13, 15);
            txtId.TabIndex = 2;
            txtId.Text = "0";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 23);
            textBox1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(317, 116);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(236, 116);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 16;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // TelaCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 169);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(textBox1);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCategoriaForm";
            Text = "TelaCategoriaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label txtId;
        private TextBox textBox1;
        private Button btnCancelar;
        private Button btnGravar;
    }
}