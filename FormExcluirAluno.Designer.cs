
namespace Projeto_DuplinhaFeroz
{
    partial class FormExcluirAluno
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
            this.lblCPFExcluir = new System.Windows.Forms.Label();
            this.mskCPFExcluir = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCPFExcluir
            // 
            this.lblCPFExcluir.AutoSize = true;
            this.lblCPFExcluir.Location = new System.Drawing.Point(112, 112);
            this.lblCPFExcluir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPFExcluir.Name = "lblCPFExcluir";
            this.lblCPFExcluir.Size = new System.Drawing.Size(36, 16);
            this.lblCPFExcluir.TabIndex = 0;
            this.lblCPFExcluir.Text = "CPF:";
            // 
            // mskCPFExcluir
            // 
            this.mskCPFExcluir.Location = new System.Drawing.Point(160, 109);
            this.mskCPFExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskCPFExcluir.Mask = "999-999-999-99";
            this.mskCPFExcluir.Name = "mskCPFExcluir";
            this.mskCPFExcluir.Size = new System.Drawing.Size(119, 22);
            this.mskCPFExcluir.TabIndex = 1;
            this.mskCPFExcluir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCPFExcluir_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Excluir Aluno";
            // 
            // FormExcluirAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskCPFExcluir);
            this.Controls.Add(this.lblCPFExcluir);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormExcluirAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCPFExcluir;
        private System.Windows.Forms.MaskedTextBox mskCPFExcluir;
        private System.Windows.Forms.Label label1;
    }
}