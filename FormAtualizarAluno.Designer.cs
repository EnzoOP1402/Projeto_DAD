
namespace Projeto_DuplinhaFeroz
{
    partial class FormAtualizarAluno
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
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtCPFa = new System.Windows.Forms.MaskedTextBox();
            this.txtNuma = new System.Windows.Forms.TextBox();
            this.txtComplementoa = new System.Windows.Forms.TextBox();
            this.txtEstadoa = new System.Windows.Forms.TextBox();
            this.txtEmaila = new System.Windows.Forms.TextBox();
            this.txtCidadea = new System.Windows.Forms.TextBox();
            this.txtTela = new System.Windows.Forms.MaskedTextBox();
            this.txtCEPa = new System.Windows.Forms.MaskedTextBox();
            this.txtBairroa = new System.Windows.Forms.TextBox();
            this.txtEnderecoa = new System.Windows.Forms.TextBox();
            this.txtNomea = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 324);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(292, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Escolher foto";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(716, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 295);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.txtCPFa);
            this.groupBox1.Controls.Add(this.txtNuma);
            this.groupBox1.Controls.Add(this.txtComplementoa);
            this.groupBox1.Controls.Add(this.txtEstadoa);
            this.groupBox1.Controls.Add(this.txtEmaila);
            this.groupBox1.Controls.Add(this.txtCidadea);
            this.groupBox1.Controls.Add(this.txtTela);
            this.groupBox1.Controls.Add(this.txtCEPa);
            this.groupBox1.Controls.Add(this.txtBairroa);
            this.groupBox1.Controls.Add(this.txtEnderecoa);
            this.groupBox1.Controls.Add(this.txtNomea);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(693, 363);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Cadastrais";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(32, 313);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(617, 38);
            this.btnAtualizar.TabIndex = 22;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // txtCPFa
            // 
            this.txtCPFa.Location = new System.Drawing.Point(109, 37);
            this.txtCPFa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCPFa.Mask = "999-999-999-99";
            this.txtCPFa.Name = "txtCPFa";
            this.txtCPFa.Size = new System.Drawing.Size(124, 22);
            this.txtCPFa.TabIndex = 21;
            this.txtCPFa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPFa_KeyPress);
            // 
            // txtNuma
            // 
            this.txtNuma.Location = new System.Drawing.Point(576, 134);
            this.txtNuma.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuma.Name = "txtNuma";
            this.txtNuma.Size = new System.Drawing.Size(73, 22);
            this.txtNuma.TabIndex = 20;
            // 
            // txtComplementoa
            // 
            this.txtComplementoa.Location = new System.Drawing.Point(525, 178);
            this.txtComplementoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplementoa.Name = "txtComplementoa";
            this.txtComplementoa.Size = new System.Drawing.Size(124, 22);
            this.txtComplementoa.TabIndex = 19;
            // 
            // txtEstadoa
            // 
            this.txtEstadoa.Location = new System.Drawing.Point(529, 228);
            this.txtEstadoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstadoa.Name = "txtEstadoa";
            this.txtEstadoa.Size = new System.Drawing.Size(121, 22);
            this.txtEstadoa.TabIndex = 18;
            // 
            // txtEmaila
            // 
            this.txtEmaila.Location = new System.Drawing.Point(300, 271);
            this.txtEmaila.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmaila.Name = "txtEmaila";
            this.txtEmaila.Size = new System.Drawing.Size(349, 22);
            this.txtEmaila.TabIndex = 17;
            // 
            // txtCidadea
            // 
            this.txtCidadea.Location = new System.Drawing.Point(300, 228);
            this.txtCidadea.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidadea.Name = "txtCidadea";
            this.txtCidadea.Size = new System.Drawing.Size(155, 22);
            this.txtCidadea.TabIndex = 16;
            // 
            // txtTela
            // 
            this.txtTela.Location = new System.Drawing.Point(109, 274);
            this.txtTela.Margin = new System.Windows.Forms.Padding(4);
            this.txtTela.Mask = "(99)999999999";
            this.txtTela.Name = "txtTela";
            this.txtTela.Size = new System.Drawing.Size(113, 22);
            this.txtTela.TabIndex = 15;
            // 
            // txtCEPa
            // 
            this.txtCEPa.Location = new System.Drawing.Point(109, 228);
            this.txtCEPa.Margin = new System.Windows.Forms.Padding(4);
            this.txtCEPa.Mask = "99.999-999";
            this.txtCEPa.Name = "txtCEPa";
            this.txtCEPa.Size = new System.Drawing.Size(113, 22);
            this.txtCEPa.TabIndex = 14;
            // 
            // txtBairroa
            // 
            this.txtBairroa.Location = new System.Drawing.Point(109, 177);
            this.txtBairroa.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairroa.Name = "txtBairroa";
            this.txtBairroa.Size = new System.Drawing.Size(305, 22);
            this.txtBairroa.TabIndex = 13;
            // 
            // txtEnderecoa
            // 
            this.txtEnderecoa.Location = new System.Drawing.Point(109, 134);
            this.txtEnderecoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnderecoa.Name = "txtEnderecoa";
            this.txtEnderecoa.Size = new System.Drawing.Size(305, 22);
            this.txtEnderecoa.TabIndex = 12;
            // 
            // txtNomea
            // 
            this.txtNomea.Location = new System.Drawing.Point(109, 89);
            this.txtNomea.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomea.Name = "txtNomea";
            this.txtNomea.Size = new System.Drawing.Size(305, 22);
            this.txtNomea.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "nº";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 182);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Complemento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "CEP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bairro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // FormAtualizarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 448);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAtualizarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.MaskedTextBox txtCPFa;
        private System.Windows.Forms.TextBox txtNuma;
        private System.Windows.Forms.TextBox txtComplementoa;
        private System.Windows.Forms.TextBox txtEstadoa;
        private System.Windows.Forms.TextBox txtEmaila;
        private System.Windows.Forms.TextBox txtCidadea;
        private System.Windows.Forms.MaskedTextBox txtTela;
        private System.Windows.Forms.MaskedTextBox txtCEPa;
        private System.Windows.Forms.TextBox txtBairroa;
        private System.Windows.Forms.TextBox txtEnderecoa;
        private System.Windows.Forms.TextBox txtNomea;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}