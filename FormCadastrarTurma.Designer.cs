
namespace Projeto_DuplinhaFeroz
{
    partial class FormCadastrarTurma
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
            this.Turma = new System.Windows.Forms.GroupBox();
            this.BoxCadastrarTurma = new System.Windows.Forms.ComboBox();
            this.txtNalunosTurma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxtHoraTurma = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDiaSemanaTurma = new System.Windows.Forms.TextBox();
            this.txtProfTurma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetarTurma = new System.Windows.Forms.Button();
            this.Turma.SuspendLayout();
            this.SuspendLayout();
            // 
            // Turma
            // 
            this.Turma.Controls.Add(this.btnSetarTurma);
            this.Turma.Controls.Add(this.BoxCadastrarTurma);
            this.Turma.Controls.Add(this.txtNalunosTurma);
            this.Turma.Controls.Add(this.label5);
            this.Turma.Controls.Add(this.mtxtHoraTurma);
            this.Turma.Controls.Add(this.btnCadastrar);
            this.Turma.Controls.Add(this.txtDiaSemanaTurma);
            this.Turma.Controls.Add(this.txtProfTurma);
            this.Turma.Controls.Add(this.label4);
            this.Turma.Controls.Add(this.label3);
            this.Turma.Controls.Add(this.label2);
            this.Turma.Controls.Add(this.label1);
            this.Turma.Location = new System.Drawing.Point(16, 15);
            this.Turma.Margin = new System.Windows.Forms.Padding(4);
            this.Turma.Name = "Turma";
            this.Turma.Padding = new System.Windows.Forms.Padding(4);
            this.Turma.Size = new System.Drawing.Size(473, 290);
            this.Turma.TabIndex = 0;
            this.Turma.TabStop = false;
            this.Turma.Text = "Cadastro de Turma";
            // 
            // BoxCadastrarTurma
            // 
            this.BoxCadastrarTurma.FormattingEnabled = true;
            this.BoxCadastrarTurma.Location = new System.Drawing.Point(144, 39);
            this.BoxCadastrarTurma.Name = "BoxCadastrarTurma";
            this.BoxCadastrarTurma.Size = new System.Drawing.Size(276, 24);
            this.BoxCadastrarTurma.TabIndex = 14;
            this.BoxCadastrarTurma.SelectedIndexChanged += new System.EventHandler(this.BoxCadastrarTurma_SelectedIndexChanged);
            // 
            // txtNalunosTurma
            // 
            this.txtNalunosTurma.Location = new System.Drawing.Point(367, 171);
            this.txtNalunosTurma.Margin = new System.Windows.Forms.Padding(4);
            this.txtNalunosTurma.Name = "txtNalunosTurma";
            this.txtNalunosTurma.Size = new System.Drawing.Size(53, 22);
            this.txtNalunosTurma.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "N° de Alunos:";
            // 
            // mtxtHoraTurma
            // 
            this.mtxtHoraTurma.Location = new System.Drawing.Point(144, 171);
            this.mtxtHoraTurma.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtHoraTurma.Mask = "90:00";
            this.mtxtHoraTurma.Name = "mtxtHoraTurma";
            this.mtxtHoraTurma.Size = new System.Drawing.Size(60, 22);
            this.mtxtHoraTurma.TabIndex = 11;
            this.mtxtHoraTurma.ValidatingType = typeof(System.DateTime);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(8, 214);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(457, 28);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDiaSemanaTurma
            // 
            this.txtDiaSemanaTurma.Location = new System.Drawing.Point(144, 124);
            this.txtDiaSemanaTurma.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaSemanaTurma.Name = "txtDiaSemanaTurma";
            this.txtDiaSemanaTurma.Size = new System.Drawing.Size(276, 22);
            this.txtDiaSemanaTurma.TabIndex = 6;
            // 
            // txtProfTurma
            // 
            this.txtProfTurma.Location = new System.Drawing.Point(144, 81);
            this.txtProfTurma.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfTurma.Name = "txtProfTurma";
            this.txtProfTurma.Size = new System.Drawing.Size(276, 22);
            this.txtProfTurma.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia da Semana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // btnSetarTurma
            // 
            this.btnSetarTurma.Location = new System.Drawing.Point(9, 249);
            this.btnSetarTurma.Name = "btnSetarTurma";
            this.btnSetarTurma.Size = new System.Drawing.Size(457, 28);
            this.btnSetarTurma.TabIndex = 15;
            this.btnSetarTurma.Text = "Reativar Turma";
            this.btnSetarTurma.UseVisualStyleBackColor = true;
            this.btnSetarTurma.Click += new System.EventHandler(this.btnSetarTurma_Click);
            // 
            // FormCadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 318);
            this.Controls.Add(this.Turma);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadastrarTurma";
            this.Text = "Cadastrar Turma";
            this.Turma.ResumeLayout(false);
            this.Turma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Turma;
        private System.Windows.Forms.TextBox txtDiaSemanaTurma;
        private System.Windows.Forms.TextBox txtProfTurma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox mtxtHoraTurma;
        private System.Windows.Forms.TextBox txtNalunosTurma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox BoxCadastrarTurma;
        private System.Windows.Forms.Button btnSetarTurma;
    }
}