
namespace Projeto_DuplinhaFeroz
{
    partial class FormAtualizarTurma
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Turma = new System.Windows.Forms.GroupBox();
            this.mtxtHoraAtualizar = new System.Windows.Forms.MaskedTextBox();
            this.txtModalidadeTurmaAtualizar = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtDiaSemanaTurmaAtualizar = new System.Windows.Forms.TextBox();
            this.txtProfTurmaAtualizar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNalunosTurmaAtualizar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Turma.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 182);
            this.dataGridView1.TabIndex = 3;
            // 
            // Turma
            // 
            this.Turma.Controls.Add(this.txtNalunosTurmaAtualizar);
            this.Turma.Controls.Add(this.label5);
            this.Turma.Controls.Add(this.mtxtHoraAtualizar);
            this.Turma.Controls.Add(this.txtModalidadeTurmaAtualizar);
            this.Turma.Controls.Add(this.btnAtualizar);
            this.Turma.Controls.Add(this.txtDiaSemanaTurmaAtualizar);
            this.Turma.Controls.Add(this.txtProfTurmaAtualizar);
            this.Turma.Controls.Add(this.label4);
            this.Turma.Controls.Add(this.label3);
            this.Turma.Controls.Add(this.label2);
            this.Turma.Controls.Add(this.label1);
            this.Turma.Location = new System.Drawing.Point(12, 14);
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(355, 203);
            this.Turma.TabIndex = 2;
            this.Turma.TabStop = false;
            this.Turma.Text = "groupBox1";
            // 
            // mtxtHoraAtualizar
            // 
            this.mtxtHoraAtualizar.Location = new System.Drawing.Point(108, 139);
            this.mtxtHoraAtualizar.Mask = "90:00";
            this.mtxtHoraAtualizar.Name = "mtxtHoraAtualizar";
            this.mtxtHoraAtualizar.Size = new System.Drawing.Size(100, 20);
            this.mtxtHoraAtualizar.TabIndex = 11;
            this.mtxtHoraAtualizar.ValidatingType = typeof(System.DateTime);
            // 
            // txtModalidadeTurmaAtualizar
            // 
            this.txtModalidadeTurmaAtualizar.Location = new System.Drawing.Point(108, 32);
            this.txtModalidadeTurmaAtualizar.Name = "txtModalidadeTurmaAtualizar";
            this.txtModalidadeTurmaAtualizar.Size = new System.Drawing.Size(208, 20);
            this.txtModalidadeTurmaAtualizar.TabIndex = 10;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(6, 174);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(343, 23);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // txtDiaSemanaTurmaAtualizar
            // 
            this.txtDiaSemanaTurmaAtualizar.Location = new System.Drawing.Point(108, 101);
            this.txtDiaSemanaTurmaAtualizar.Name = "txtDiaSemanaTurmaAtualizar";
            this.txtDiaSemanaTurmaAtualizar.Size = new System.Drawing.Size(208, 20);
            this.txtDiaSemanaTurmaAtualizar.TabIndex = 6;
            // 
            // txtProfTurmaAtualizar
            // 
            this.txtProfTurmaAtualizar.Location = new System.Drawing.Point(108, 66);
            this.txtProfTurmaAtualizar.Name = "txtProfTurmaAtualizar";
            this.txtProfTurmaAtualizar.Size = new System.Drawing.Size(208, 20);
            this.txtProfTurmaAtualizar.TabIndex = 5;
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
            // txtNalunosTurmaAtualizar
            // 
            this.txtNalunosTurmaAtualizar.Location = new System.Drawing.Point(293, 139);
            this.txtNalunosTurmaAtualizar.Name = "txtNalunosTurmaAtualizar";
            this.txtNalunosTurmaAtualizar.Size = new System.Drawing.Size(41, 20);
            this.txtNalunosTurmaAtualizar.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "N° de Alunos:";
            // 
            // FormAtualizarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 425);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Turma);
            this.Name = "FormAtualizarTurma";
            this.Text = "FormAtualizarTurma";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Turma.ResumeLayout(false);
            this.Turma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Turma;
        private System.Windows.Forms.MaskedTextBox mtxtHoraAtualizar;
        private System.Windows.Forms.TextBox txtModalidadeTurmaAtualizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtDiaSemanaTurmaAtualizar;
        private System.Windows.Forms.TextBox txtProfTurmaAtualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNalunosTurmaAtualizar;
        private System.Windows.Forms.Label label5;
    }
}