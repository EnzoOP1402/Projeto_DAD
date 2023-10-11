
namespace Projeto_DuplinhaFeroz
{
    partial class FormExcluirModalidade
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BoxExcluir = new System.Windows.Forms.ComboBox();
            this.btnExcluirModalidade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BoxExcluir);
            this.groupBox1.Controls.Add(this.btnExcluirModalidade);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(472, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidades";
            // 
            // BoxExcluir
            // 
            this.BoxExcluir.FormattingEnabled = true;
            this.BoxExcluir.Location = new System.Drawing.Point(95, 33);
            this.BoxExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.BoxExcluir.Name = "BoxExcluir";
            this.BoxExcluir.Size = new System.Drawing.Size(368, 24);
            this.BoxExcluir.TabIndex = 3;
            // 
            // btnExcluirModalidade
            // 
            this.btnExcluirModalidade.Location = new System.Drawing.Point(12, 76);
            this.btnExcluirModalidade.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirModalidade.Name = "btnExcluirModalidade";
            this.btnExcluirModalidade.Size = new System.Drawing.Size(452, 28);
            this.btnExcluirModalidade.TabIndex = 2;
            this.btnExcluirModalidade.Text = "Excluir";
            this.btnExcluirModalidade.UseVisualStyleBackColor = true;
            this.btnExcluirModalidade.Click += new System.EventHandler(this.btnExcluirModalidade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // FormExcluirModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 224);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormExcluirModalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcluirModalidade";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluirModalidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoxExcluir;
    }
}