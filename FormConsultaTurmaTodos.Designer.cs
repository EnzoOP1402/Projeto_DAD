namespace Projeto_DuplinhaFeroz
{
    partial class FormConsultaTurmaTodos
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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.idTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDModalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeModalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaSemanaTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroAlunosTurma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 402);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(6, 353);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(843, 43);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTurma,
            this.IDModalidade,
            this.nomeModalidade,
            this.professorTurma,
            this.diaSemanaTurma,
            this.horaTurma,
            this.numeroAlunosTurma,
            this.ativa});
            this.dataGridView1.Location = new System.Drawing.Point(6, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(843, 308);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Consultar todas as Turmas";
            // 
            // idTurma
            // 
            this.idTurma.HeaderText = "ID Turma";
            this.idTurma.MinimumWidth = 6;
            this.idTurma.Name = "idTurma";
            this.idTurma.Width = 125;
            // 
            // IDModalidade
            // 
            this.IDModalidade.HeaderText = "ID Modalidade";
            this.IDModalidade.Name = "IDModalidade";
            // 
            // nomeModalidade
            // 
            this.nomeModalidade.HeaderText = "Nome da Modalidade";
            this.nomeModalidade.Name = "nomeModalidade";
            // 
            // professorTurma
            // 
            this.professorTurma.HeaderText = "Professor";
            this.professorTurma.MinimumWidth = 6;
            this.professorTurma.Name = "professorTurma";
            this.professorTurma.Width = 125;
            // 
            // diaSemanaTurma
            // 
            this.diaSemanaTurma.HeaderText = "Dia da Semana";
            this.diaSemanaTurma.MinimumWidth = 6;
            this.diaSemanaTurma.Name = "diaSemanaTurma";
            this.diaSemanaTurma.Width = 125;
            // 
            // horaTurma
            // 
            this.horaTurma.HeaderText = "Hora";
            this.horaTurma.Name = "horaTurma";
            // 
            // numeroAlunosTurma
            // 
            this.numeroAlunosTurma.HeaderText = "Num de Alunos matriculados";
            this.numeroAlunosTurma.Name = "numeroAlunosTurma";
            // 
            // ativa
            // 
            this.ativa.HeaderText = "Ativa";
            this.ativa.Name = "ativa";
            // 
            // FormConsultaTurmaTodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 423);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormConsultaTurmaTodos";
            this.Text = "FormConsultaTurmaTodos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDModalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeModalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn professorTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaSemanaTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroAlunosTurma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativa;
    }
}