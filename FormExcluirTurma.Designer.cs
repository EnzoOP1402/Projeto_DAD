
namespace Projeto_DuplinhaFeroz
{
    partial class FormExcluirTurma
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
            this.btnExcluirTurma = new System.Windows.Forms.Button();
            this.boxHoraExcluir = new System.Windows.Forms.ComboBox();
            this.boxDiaSemanaExcluir = new System.Windows.Forms.ComboBox();
            this.BoxModalidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluirTurma);
            this.groupBox1.Controls.Add(this.boxHoraExcluir);
            this.groupBox1.Controls.Add(this.boxDiaSemanaExcluir);
            this.groupBox1.Controls.Add(this.BoxModalidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turma";
            // 
            // btnExcluirTurma
            // 
            this.btnExcluirTurma.Location = new System.Drawing.Point(9, 137);
            this.btnExcluirTurma.Name = "btnExcluirTurma";
            this.btnExcluirTurma.Size = new System.Drawing.Size(343, 23);
            this.btnExcluirTurma.TabIndex = 6;
            this.btnExcluirTurma.Text = "Excluir";
            this.btnExcluirTurma.UseVisualStyleBackColor = true;
            this.btnExcluirTurma.Click += new System.EventHandler(this.btnExcluirTurma_Click);
            // 
            // boxHoraExcluir
            // 
            this.boxHoraExcluir.FormattingEnabled = true;
            this.boxHoraExcluir.Location = new System.Drawing.Point(97, 95);
            this.boxHoraExcluir.Name = "boxHoraExcluir";
            this.boxHoraExcluir.Size = new System.Drawing.Size(121, 21);
            this.boxHoraExcluir.TabIndex = 5;
            this.boxHoraExcluir.SelectedIndexChanged += new System.EventHandler(this.boxHoraExcluir_SelectedIndexChanged);
            // 
            // boxDiaSemanaExcluir
            // 
            this.boxDiaSemanaExcluir.FormattingEnabled = true;
            this.boxDiaSemanaExcluir.Location = new System.Drawing.Point(97, 66);
            this.boxDiaSemanaExcluir.Name = "boxDiaSemanaExcluir";
            this.boxDiaSemanaExcluir.Size = new System.Drawing.Size(121, 21);
            this.boxDiaSemanaExcluir.TabIndex = 4;
            this.boxDiaSemanaExcluir.SelectedIndexChanged += new System.EventHandler(this.boxDiaSemanaExcluir_SelectedIndexChanged);
            // 
            // BoxModalidade
            // 
            this.BoxModalidade.FormattingEnabled = true;
            this.BoxModalidade.Location = new System.Drawing.Point(97, 39);
            this.BoxModalidade.Name = "BoxModalidade";
            this.BoxModalidade.Size = new System.Drawing.Size(121, 21);
            this.BoxModalidade.TabIndex = 3;
            this.BoxModalidade.SelectedIndexChanged += new System.EventHandler(this.BoxModalidade_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dia da Semana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // FormExcluirTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 214);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormExcluirTurma";
            this.Text = "FormExcluirTurma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluirTurma;
        private System.Windows.Forms.ComboBox boxHoraExcluir;
        private System.Windows.Forms.ComboBox boxDiaSemanaExcluir;
        private System.Windows.Forms.ComboBox BoxModalidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}