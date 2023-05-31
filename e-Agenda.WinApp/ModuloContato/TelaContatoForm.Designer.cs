namespace e_Agenda.WinApp.ModuloContato
{
    partial class TelaContatoForm
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
            btnGravar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtCargo = new TextBox();
            txtEmail = new TextBox();
            txtEmpresa = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTelefone = new MaskedTextBox();
            txtId = new Label();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.LightPink;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(300, 145);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightPink;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(381, 145);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 19);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 49);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(64, 45);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(395, 23);
            txtNome.TabIndex = 5;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(64, 103);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(129, 23);
            txtCargo.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(310, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(149, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(310, 103);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(149, 23);
            txtEmpresa.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 77);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 78);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 11;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 107);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 12;
            label5.Text = "Empresa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 107);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 13;
            label6.Text = "Cargo";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(64, 74);
            txtTelefone.Mask = "(99) 0000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(128, 23);
            txtTelefone.TabIndex = 14;
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(64, 19);
            txtId.Name = "txtId";
            txtId.Size = new Size(13, 15);
            txtId.TabIndex = 15;
            txtId.Text = "0";
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(468, 198);
            Controls.Add(txtId);
            Controls.Add(txtTelefone);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtEmpresa);
            Controls.Add(txtEmail);
            Controls.Add(txtCargo);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaContatoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Contatos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtCargo;
        private TextBox txtEmail;
        private TextBox txtEmpresa;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox txtTelefone;
        private Label txtId;
    }
}