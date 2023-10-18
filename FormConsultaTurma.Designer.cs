namespace Projeto_DuplinhaFeroz
{
    partial class FormConsultaTurma
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
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnMostrarModalidade = new System.Windows.Forms.Button();
            this.btnMostrarID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(12, 135);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(235, 56);
            this.btnMostrarTodos.TabIndex = 7;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnMostrarModalidade
            // 
            this.btnMostrarModalidade.Location = new System.Drawing.Point(12, 73);
            this.btnMostrarModalidade.Name = "btnMostrarModalidade";
            this.btnMostrarModalidade.Size = new System.Drawing.Size(235, 56);
            this.btnMostrarModalidade.TabIndex = 6;
            this.btnMostrarModalidade.Text = "Buscar por modalidade";
            this.btnMostrarModalidade.UseVisualStyleBackColor = true;
            // 
            // btnMostrarID
            // 
            this.btnMostrarID.Location = new System.Drawing.Point(12, 11);
            this.btnMostrarID.Name = "btnMostrarID";
            this.btnMostrarID.Size = new System.Drawing.Size(235, 56);
            this.btnMostrarID.TabIndex = 4;
            this.btnMostrarID.Text = "Buscar por ID";
            this.btnMostrarID.UseVisualStyleBackColor = true;
            this.btnMostrarID.Click += new System.EventHandler(this.btnMostrarID_Click);
            // 
            // FormConsultaTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 204);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnMostrarModalidade);
            this.Controls.Add(this.btnMostrarID);
            this.Name = "FormConsultaTurma";
            this.Text = "FormConsultaTurma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnMostrarModalidade;
        private System.Windows.Forms.Button btnMostrarID;
    }
}