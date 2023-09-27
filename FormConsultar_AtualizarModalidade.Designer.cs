
namespace Projeto_DuplinhaFeroz
{
    partial class FormCadastrar_AtualizarModalidade
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BoxDescricaoCA = new System.Windows.Forms.ComboBox();
            this.btnMostrar_AtualizarModalidade = new System.Windows.Forms.Button();
            this.txtQtdeAulasCA = new System.Windows.Forms.TextBox();
            this.txtQtdeAlunosCA = new System.Windows.Forms.TextBox();
            this.txtPrecoCA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtivar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAtivar);
            this.groupBox2.Controls.Add(this.BoxDescricaoCA);
            this.groupBox2.Controls.Add(this.btnMostrar_AtualizarModalidade);
            this.groupBox2.Controls.Add(this.txtQtdeAulasCA);
            this.groupBox2.Controls.Add(this.txtQtdeAlunosCA);
            this.groupBox2.Controls.Add(this.txtPrecoCA);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(595, 327);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modalidades";
            // 
            // BoxDescricaoCA
            // 
            this.BoxDescricaoCA.FormattingEnabled = true;
            this.BoxDescricaoCA.Location = new System.Drawing.Point(107, 42);
            this.BoxDescricaoCA.Margin = new System.Windows.Forms.Padding(4);
            this.BoxDescricaoCA.Name = "BoxDescricaoCA";
            this.BoxDescricaoCA.Size = new System.Drawing.Size(444, 24);
            this.BoxDescricaoCA.TabIndex = 9;
            this.BoxDescricaoCA.SelectedIndexChanged += new System.EventHandler(this.BoxDescricaoCA_SelectedIndexChanged);
            // 
            // btnMostrar_AtualizarModalidade
            // 
            this.btnMostrar_AtualizarModalidade.Location = new System.Drawing.Point(25, 235);
            this.btnMostrar_AtualizarModalidade.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrar_AtualizarModalidade.Name = "btnMostrar_AtualizarModalidade";
            this.btnMostrar_AtualizarModalidade.Size = new System.Drawing.Size(527, 28);
            this.btnMostrar_AtualizarModalidade.TabIndex = 8;
            this.btnMostrar_AtualizarModalidade.Text = "Consultar/Atualizar";
            this.btnMostrar_AtualizarModalidade.UseVisualStyleBackColor = true;
            this.btnMostrar_AtualizarModalidade.Click += new System.EventHandler(this.btnCadastrarModalidadeCA_Click);
            // 
            // txtQtdeAulasCA
            // 
            this.txtQtdeAulasCA.Location = new System.Drawing.Point(129, 188);
            this.txtQtdeAulasCA.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdeAulasCA.Name = "txtQtdeAulasCA";
            this.txtQtdeAulasCA.Size = new System.Drawing.Size(421, 22);
            this.txtQtdeAulasCA.TabIndex = 7;
            // 
            // txtQtdeAlunosCA
            // 
            this.txtQtdeAlunosCA.Location = new System.Drawing.Point(129, 139);
            this.txtQtdeAlunosCA.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdeAlunosCA.Name = "txtQtdeAlunosCA";
            this.txtQtdeAlunosCA.Size = new System.Drawing.Size(421, 22);
            this.txtQtdeAlunosCA.TabIndex = 6;
            // 
            // txtPrecoCA
            // 
            this.txtPrecoCA.Location = new System.Drawing.Point(80, 91);
            this.txtPrecoCA.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoCA.Name = "txtPrecoCA";
            this.txtPrecoCA.Size = new System.Drawing.Size(471, 22);
            this.txtPrecoCA.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Qtde de Aulas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Qtde de Alunos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço:";
            // 
            // btnAtivar
            // 
            this.btnAtivar.Location = new System.Drawing.Point(25, 271);
            this.btnAtivar.Name = "btnAtivar";
            this.btnAtivar.Size = new System.Drawing.Size(525, 23);
            this.btnAtivar.TabIndex = 10;
            this.btnAtivar.Text = "Reativar";
            this.btnAtivar.UseVisualStyleBackColor = true;
            this.btnAtivar.Click += new System.EventHandler(this.btnAtivar_Click);
            // 
            // FormCadastrar_AtualizarModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 355);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadastrar_AtualizarModalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConsultar_Atualizar";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrar_AtualizarModalidade;
        private System.Windows.Forms.TextBox txtQtdeAulasCA;
        private System.Windows.Forms.TextBox txtQtdeAlunosCA;
        private System.Windows.Forms.TextBox txtPrecoCA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BoxDescricaoCA;
        private System.Windows.Forms.Button btnAtivar;
    }
}