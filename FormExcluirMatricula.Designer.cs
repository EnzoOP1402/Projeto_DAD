namespace Projeto_DuplinhaFeroz
{
    partial class FormExcluirMatricula
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.mskCPFMatricula = new System.Windows.Forms.MaskedTextBox();
            this.idTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idModalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfessorTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasemanaTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomeAluno);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mskCPFMatricula);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Aluno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Turmas em que o aluno está cadastrado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do Aluno";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Enabled = false;
            this.txtNomeAluno.Location = new System.Drawing.Point(23, 96);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(100, 20);
            this.txtNomeAluno.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(628, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Desmatricular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTurma,
            this.idModalidade,
            this.ProfessorTurma,
            this.diasemanaTurma,
            this.horaTurma});
            this.dataGridView1.Location = new System.Drawing.Point(144, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 97);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF do Aluno";
            // 
            // mskCPFMatricula
            // 
            this.mskCPFMatricula.Location = new System.Drawing.Point(23, 52);
            this.mskCPFMatricula.Mask = "000-000-000-00";
            this.mskCPFMatricula.Name = "mskCPFMatricula";
            this.mskCPFMatricula.Size = new System.Drawing.Size(95, 20);
            this.mskCPFMatricula.TabIndex = 2;
            this.mskCPFMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskCPFMatricula_KeyPress);
            // 
            // idTurma
            // 
            this.idTurma.HeaderText = "idTurma";
            this.idTurma.MaxInputLength = 32764;
            this.idTurma.MinimumWidth = 10;
            this.idTurma.Name = "idTurma";
            this.idTurma.ReadOnly = true;
            // 
            // idModalidade
            // 
            this.idModalidade.HeaderText = "idModalidade";
            this.idModalidade.Name = "idModalidade";
            this.idModalidade.ReadOnly = true;
            // 
            // ProfessorTurma
            // 
            this.ProfessorTurma.HeaderText = "Professor";
            this.ProfessorTurma.Name = "ProfessorTurma";
            this.ProfessorTurma.ReadOnly = true;
            // 
            // diasemanaTurma
            // 
            this.diasemanaTurma.HeaderText = "Dia";
            this.diasemanaTurma.Name = "diasemanaTurma";
            this.diasemanaTurma.ReadOnly = true;
            // 
            // horaTurma
            // 
            this.horaTurma.HeaderText = "Hora";
            this.horaTurma.Name = "horaTurma";
            this.horaTurma.ReadOnly = true;
            // 
            // FormExcluirMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 240);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormExcluirMatricula";
            this.Text = "FormExcluirMatricula";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskCPFMatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfessorTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasemanaTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaTurma;
    }
}