namespace e_Agenda.WinApp.ModuloCategoria
{
    partial class TelaVisualizarCategoriaForm
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
            lblCategoria = new Label();
            groupBox1 = new GroupBox();
            listDespesas = new ListBox();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.Location = new Point(79, 35);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(28, 15);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "CAT";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listDespesas);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 214);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Despesas";
            // 
            // listDespesas
            // 
            listDespesas.FormattingEnabled = true;
            listDespesas.ItemHeight = 15;
            listDespesas.Location = new Point(6, 22);
            listDespesas.Name = "listDespesas";
            listDespesas.Size = new Size(377, 184);
            listDespesas.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(326, 290);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaVisualizarCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 343);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(lblCategoria);
            Controls.Add(label1);
            Name = "TelaVisualizarCategoriaForm";
            Text = "TelaVisualizarCategoria";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCategoria;
        private GroupBox groupBox1;
        private ListBox listDespesas;
        private Button btnCancelar;
    }
}