namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaFiltroForm
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
            rdbTarefasPendentes = new RadioButton();
            rdbTarefasFinalizadas = new RadioButton();
            rdbMostrarTodas = new RadioButton();
            btnCancelar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // rdbTarefasPendentes
            // 
            rdbTarefasPendentes.AutoSize = true;
            rdbTarefasPendentes.Location = new Point(22, 32);
            rdbTarefasPendentes.Name = "rdbTarefasPendentes";
            rdbTarefasPendentes.Size = new Size(149, 19);
            rdbTarefasPendentes.TabIndex = 25;
            rdbTarefasPendentes.TabStop = true;
            rdbTarefasPendentes.Text = "filtrar tarefas pendentes";
            rdbTarefasPendentes.UseVisualStyleBackColor = true;
            // 
            // rdbTarefasFinalizadas
            // 
            rdbTarefasFinalizadas.AutoSize = true;
            rdbTarefasFinalizadas.Location = new Point(22, 67);
            rdbTarefasFinalizadas.Name = "rdbTarefasFinalizadas";
            rdbTarefasFinalizadas.Size = new Size(149, 19);
            rdbTarefasFinalizadas.TabIndex = 26;
            rdbTarefasFinalizadas.TabStop = true;
            rdbTarefasFinalizadas.Text = "filtrar tarefas finalizadas";
            rdbTarefasFinalizadas.UseVisualStyleBackColor = true;
            // 
            // rdbMostrarTodas
            // 
            rdbMostrarTodas.AutoSize = true;
            rdbMostrarTodas.Location = new Point(22, 102);
            rdbMostrarTodas.Name = "rdbMostrarTodas";
            rdbMostrarTodas.Size = new Size(150, 19);
            rdbMostrarTodas.TabIndex = 29;
            rdbMostrarTodas.TabStop = true;
            rdbMostrarTodas.Text = "Mostrar todas as tarefas";
            rdbMostrarTodas.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AccessibleName = "";
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.OK;
            btnCancelar.Location = new Point(232, 148);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.AccessibleName = "";
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(151, 148);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 30;
            btnGravar.Text = "Filtrar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // TelaTarefaFiltroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 201);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(rdbMostrarTodas);
            Controls.Add(rdbTarefasFinalizadas);
            Controls.Add(rdbTarefasPendentes);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTarefaFiltroForm";
            ShowIcon = false;
            Text = "Filtro de Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton rdbTarefasPendentes;
        private RadioButton rdbTarefasFinalizadas;
        private RadioButton rdbMostrarTodas;
        private Button btnCancelar;
        private Button btnGravar;
    }
}