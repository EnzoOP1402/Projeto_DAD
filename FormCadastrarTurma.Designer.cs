
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtDiaSemanaTurma = new System.Windows.Forms.TextBox();
            this.txtProfTurma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtModalidadeTurma = new System.Windows.Forms.TextBox();
            this.mtxtHoraTurma = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNalunosTurma = new System.Windows.Forms.TextBox();
            this.Turma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Turma
            // 
            this.Turma.Controls.Add(this.txtNalunosTurma);
            this.Turma.Controls.Add(this.label5);
            this.Turma.Controls.Add(this.mtxtHoraTurma);
            this.Turma.Controls.Add(this.txtModalidadeTurma);
            this.Turma.Controls.Add(this.btnCadastrar);
            this.Turma.Controls.Add(this.txtDiaSemanaTurma);
            this.Turma.Controls.Add(this.txtProfTurma);
            this.Turma.Controls.Add(this.label4);
            this.Turma.Controls.Add(this.label3);
            this.Turma.Controls.Add(this.label2);
            this.Turma.Controls.Add(this.label1);
            this.Turma.Location = new System.Drawing.Point(12, 12);
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(355, 203);
            this.Turma.TabIndex = 0;
            this.Turma.TabStop = false;
            this.Turma.Text = "groupBox1";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(6, 174);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(343, 23);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtDiaSemanaTurma
            // 
            this.txtDiaSemanaTurma.Location = new System.Drawing.Point(108, 101);
            this.txtDiaSemanaTurma.Name = "txtDiaSemanaTurma";
            this.txtDiaSemanaTurma.Size = new System.Drawing.Size(208, 20);
            this.txtDiaSemanaTurma.TabIndex = 6;
            // 
            // txtProfTurma
            // 
            this.txtProfTurma.Location = new System.Drawing.Point(108, 66);
            this.txtProfTurma.Name = "txtProfTurma";
            this.txtProfTurma.Size = new System.Drawing.Size(208, 20);
            this.txtProfTurma.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dia da Semana:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Professor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modalidade:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 182);
            this.dataGridView1.TabIndex = 1;
            // 
            // txtModalidadeTurma
            // 
            this.txtModalidadeTurma.Location = new System.Drawing.Point(108, 32);
            this.txtModalidadeTurma.Name = "txtModalidadeTurma";
            this.txtModalidadeTurma.Size = new System.Drawing.Size(208, 20);
            this.txtModalidadeTurma.TabIndex = 10;
            // 
            // mtxtHoraTurma
            // 
            this.mtxtHoraTurma.Location = new System.Drawing.Point(108, 139);
            this.mtxtHoraTurma.Mask = "90:00";
            this.mtxtHoraTurma.Name = "mtxtHoraTurma";
            this.mtxtHoraTurma.Size = new System.Drawing.Size(46, 20);
            this.mtxtHoraTurma.TabIndex = 11;
            this.mtxtHoraTurma.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "N° de Alunos:";
            // 
            // txtNalunosTurma
            // 
            this.txtNalunosTurma.Location = new System.Drawing.Point(292, 139);
            this.txtNalunosTurma.Name = "txtNalunosTurma";
            this.txtNalunosTurma.Size = new System.Drawing.Size(41, 20);
            this.txtNalunosTurma.TabIndex = 13;
            // 
            // FormCadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Turma);
            this.Name = "FormCadastrarTurma";
            this.Text = "FormCadastrarTurma";
            this.Turma.ResumeLayout(false);
            this.Turma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox mtxtHoraTurma;
        private System.Windows.Forms.TextBox txtModalidadeTurma;
        private System.Windows.Forms.TextBox txtNalunosTurma;
        private System.Windows.Forms.Label label5;
    }
}