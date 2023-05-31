namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            lblIdCompromisso = new Label();
            lblTituloCompromisso = new Label();
            lblDataCompromisso = new Label();
            txtTitulo = new TextBox();
            DTPData = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            rdbRemoto = new RadioButton();
            rdbPresencial = new RadioButton();
            btnGravar = new Button();
            btnCancelar = new Button();
            comboBoxContato = new ComboBox();
            txtLocalizacao = new TextBox();
            ckbAdicionarContato = new CheckBox();
            dtpInicio = new DateTimePicker();
            dtpTermino = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtId = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblIdCompromisso
            // 
            lblIdCompromisso.AutoSize = true;
            lblIdCompromisso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdCompromisso.Location = new Point(35, 19);
            lblIdCompromisso.Name = "lblIdCompromisso";
            lblIdCompromisso.Size = new Size(17, 15);
            lblIdCompromisso.TabIndex = 0;
            lblIdCompromisso.Text = "Id";
            // 
            // lblTituloCompromisso
            // 
            lblTituloCompromisso.AutoSize = true;
            lblTituloCompromisso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloCompromisso.Location = new Point(15, 48);
            lblTituloCompromisso.Name = "lblTituloCompromisso";
            lblTituloCompromisso.Size = new Size(37, 15);
            lblTituloCompromisso.TabIndex = 1;
            lblTituloCompromisso.Text = "Titulo";
            // 
            // lblDataCompromisso
            // 
            lblDataCompromisso.AutoSize = true;
            lblDataCompromisso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataCompromisso.Location = new Point(21, 109);
            lblDataCompromisso.Name = "lblDataCompromisso";
            lblDataCompromisso.Size = new Size(31, 15);
            lblDataCompromisso.TabIndex = 2;
            lblDataCompromisso.Text = "Data";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(59, 45);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(349, 23);
            txtTitulo.TabIndex = 3;
            // 
            // DTPData
            // 
            DTPData.Format = DateTimePickerFormat.Short;
            DTPData.Location = new Point(59, 103);
            DTPData.Name = "DTPData";
            DTPData.Size = new Size(109, 23);
            DTPData.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 78);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 8;
            label1.Text = "Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(244, 78);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 9;
            label2.Text = "Termino";
            // 
            // rdbRemoto
            // 
            rdbRemoto.AutoSize = true;
            rdbRemoto.Location = new Point(6, 23);
            rdbRemoto.Name = "rdbRemoto";
            rdbRemoto.Size = new Size(67, 19);
            rdbRemoto.TabIndex = 11;
            rdbRemoto.TabStop = true;
            rdbRemoto.Text = "Remoto";
            rdbRemoto.UseVisualStyleBackColor = true;
            // 
            // rdbPresencial
            // 
            rdbPresencial.AutoSize = true;
            rdbPresencial.Location = new Point(6, 48);
            rdbPresencial.Name = "rdbPresencial";
            rdbPresencial.Size = new Size(78, 19);
            rdbPresencial.TabIndex = 12;
            rdbPresencial.TabStop = true;
            rdbPresencial.Text = "Presencial";
            rdbPresencial.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.AccessibleName = "btnGaravarCompromisso";
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.BackColor = Color.LightPink;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(250, 209);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 14;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AccessibleName = "btnCancelarTarefa";
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.LightPink;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(333, 209);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // comboBoxContato
            // 
            comboBoxContato.BackColor = Color.LightPink;
            comboBoxContato.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxContato.Enabled = false;
            comboBoxContato.FormattingEnabled = true;
            comboBoxContato.Location = new Point(21, 159);
            comboBoxContato.Name = "comboBoxContato";
            comboBoxContato.Size = new Size(168, 23);
            comboBoxContato.TabIndex = 16;
            // 
            // txtLocalizacao
            // 
            txtLocalizacao.Location = new Point(90, 33);
            txtLocalizacao.Name = "txtLocalizacao";
            txtLocalizacao.Size = new Size(101, 23);
            txtLocalizacao.TabIndex = 19;
            // 
            // ckbAdicionarContato
            // 
            ckbAdicionarContato.AutoSize = true;
            ckbAdicionarContato.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ckbAdicionarContato.Location = new Point(21, 134);
            ckbAdicionarContato.Name = "ckbAdicionarContato";
            ckbAdicionarContato.Size = new Size(123, 19);
            ckbAdicionarContato.TabIndex = 20;
            ckbAdicionarContato.Text = "Adicionar Contato";
            ckbAdicionarContato.UseVisualStyleBackColor = true;
            ckbAdicionarContato.CheckedChanged += ckbAdicionarContato_CheckedChanged;
            // 
            // dtpInicio
            // 
            dtpInicio.CustomFormat = "HH:mm";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(60, 74);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(109, 23);
            dtpInicio.TabIndex = 21;
            // 
            // dtpTermino
            // 
            dtpTermino.CustomFormat = "HH:mm";
            dtpTermino.Format = DateTimePickerFormat.Custom;
            dtpTermino.Location = new Point(299, 74);
            dtpTermino.Name = "dtpTermino";
            dtpTermino.Size = new Size(109, 23);
            dtpTermino.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLocalizacao);
            groupBox1.Controls.Add(rdbRemoto);
            groupBox1.Controls.Add(rdbPresencial);
            groupBox1.Location = new Point(208, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 78);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "localização";
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(60, 19);
            txtId.Name = "txtId";
            txtId.Size = new Size(13, 15);
            txtId.TabIndex = 20;
            txtId.Text = "0";
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(424, 262);
            Controls.Add(txtId);
            Controls.Add(groupBox1);
            Controls.Add(dtpTermino);
            Controls.Add(dtpInicio);
            Controls.Add(ckbAdicionarContato);
            Controls.Add(comboBoxContato);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DTPData);
            Controls.Add(txtTitulo);
            Controls.Add(lblDataCompromisso);
            Controls.Add(lblTituloCompromisso);
            Controls.Add(lblIdCompromisso);
            Name = "TelaCompromissoForm";
            ShowIcon = false;
            Text = "Cadastro de Compromissos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdCompromisso;
        private Label lblTituloCompromisso;
        private Label lblDataCompromisso;
        private TextBox txtTitulo;
        private DateTimePicker DTPData;
        private Label label1;
        private Label label2;
        private RadioButton rdbRemoto;
        private RadioButton rdbPresencial;
        private Button btnGravar;
        private Button btnCancelar;
        private ComboBox comboBoxContato;
        private TextBox txtLocalizacao;
        private CheckBox ckbAdicionarContato;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpTermino;
        private GroupBox groupBox1;
        private Label txtId;
    }
}