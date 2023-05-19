namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoFiltroForm
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
            rdbTodosCompromissos = new RadioButton();
            rdbCompromissosPassados = new RadioButton();
            rdbCompromissosFuturos = new RadioButton();
            GroupBoxFiltroFuturo = new GroupBox();
            txtDataFinal = new DateTimePicker();
            txtDataInicial = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            btnGravar = new Button();
            button1 = new Button();
            GroupBoxFiltroFuturo.SuspendLayout();
            SuspendLayout();
            // 
            // rdbTodosCompromissos
            // 
            rdbTodosCompromissos.AutoSize = true;
            rdbTodosCompromissos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbTodosCompromissos.Location = new Point(18, 29);
            rdbTodosCompromissos.Name = "rdbTodosCompromissos";
            rdbTodosCompromissos.Size = new Size(231, 21);
            rdbTodosCompromissos.TabIndex = 0;
            rdbTodosCompromissos.TabStop = true;
            rdbTodosCompromissos.Text = "Visualizar Todos os Compromissos";
            rdbTodosCompromissos.UseVisualStyleBackColor = true;
            rdbTodosCompromissos.CheckedChanged += rdbTodosCompromissos_CheckedChanged;
            // 
            // rdbCompromissosPassados
            // 
            rdbCompromissosPassados.AutoSize = true;
            rdbCompromissosPassados.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbCompromissosPassados.Location = new Point(18, 74);
            rdbCompromissosPassados.Name = "rdbCompromissosPassados";
            rdbCompromissosPassados.Size = new Size(232, 21);
            rdbCompromissosPassados.TabIndex = 1;
            rdbCompromissosPassados.TabStop = true;
            rdbCompromissosPassados.Text = "Visualizar Compromissos Passados";
            rdbCompromissosPassados.UseVisualStyleBackColor = true;
            rdbCompromissosPassados.CheckedChanged += rdbCompromissosPassados_CheckedChanged;
            // 
            // rdbCompromissosFuturos
            // 
            rdbCompromissosFuturos.AutoSize = true;
            rdbCompromissosFuturos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rdbCompromissosFuturos.Location = new Point(18, 118);
            rdbCompromissosFuturos.Name = "rdbCompromissosFuturos";
            rdbCompromissosFuturos.Size = new Size(220, 21);
            rdbCompromissosFuturos.TabIndex = 2;
            rdbCompromissosFuturos.TabStop = true;
            rdbCompromissosFuturos.Text = "Visualizar Compromissos Futuros";
            rdbCompromissosFuturos.UseVisualStyleBackColor = true;
            rdbCompromissosFuturos.CheckedChanged += rdbCompromissosFuturos_CheckedChanged;
            // 
            // GroupBoxFiltroFuturo
            // 
            GroupBoxFiltroFuturo.Controls.Add(txtDataFinal);
            GroupBoxFiltroFuturo.Controls.Add(txtDataInicial);
            GroupBoxFiltroFuturo.Controls.Add(label2);
            GroupBoxFiltroFuturo.Controls.Add(label1);
            GroupBoxFiltroFuturo.Location = new Point(12, 181);
            GroupBoxFiltroFuturo.Name = "GroupBoxFiltroFuturo";
            GroupBoxFiltroFuturo.Size = new Size(475, 105);
            GroupBoxFiltroFuturo.TabIndex = 3;
            GroupBoxFiltroFuturo.TabStop = false;
            GroupBoxFiltroFuturo.Text = "Filtro Para Compromissos Futuros";
            // 
            // txtDataFinal
            // 
            txtDataFinal.CustomFormat = "";
            txtDataFinal.Format = DateTimePickerFormat.Short;
            txtDataFinal.Location = new Point(303, 39);
            txtDataFinal.Name = "txtDataFinal";
            txtDataFinal.Size = new Size(153, 23);
            txtDataFinal.TabIndex = 23;
            // 
            // txtDataInicial
            // 
            txtDataInicial.CustomFormat = "";
            txtDataInicial.Format = DateTimePickerFormat.Short;
            txtDataInicial.Location = new Point(73, 39);
            txtDataInicial.Name = "txtDataInicial";
            txtDataInicial.Size = new Size(147, 23);
            txtDataInicial.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(235, 43);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Data Final:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Data Inicial:";
            // 
            // btnGravar
            // 
            btnGravar.AccessibleName = "btnGaravarCompromisso";
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(312, 299);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 15;
            btnGravar.Text = "Filtrar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AccessibleName = "btnGaravarCompromisso";
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(409, 299);
            button1.Name = "button1";
            button1.Size = new Size(75, 41);
            button1.TabIndex = 16;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // TelaCompromissoFiltroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 346);
            Controls.Add(button1);
            Controls.Add(btnGravar);
            Controls.Add(GroupBoxFiltroFuturo);
            Controls.Add(rdbCompromissosFuturos);
            Controls.Add(rdbCompromissosPassados);
            Controls.Add(rdbTodosCompromissos);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCompromissoFiltroForm";
            ShowIcon = false;
            Text = "TelaCompromissoFiltroForm";
            GroupBoxFiltroFuturo.ResumeLayout(false);
            GroupBoxFiltroFuturo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdbTodosCompromissos;
        private RadioButton rdbCompromissosPassados;
        private RadioButton rdbCompromissosFuturos;
        private GroupBox GroupBoxFiltroFuturo;
        private Label label2;
        private Label label1;
        private Button btnGravar;
        private Button button1;
        private DateTimePicker txtDataFinal;
        private DateTimePicker txtDataInicial;
    }
}