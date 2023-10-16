using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DuplinhaFeroz
{
    public partial class FormCadastrarModalidade : Form
    {
        public FormCadastrarModalidade()
        {
            InitializeComponent();
        }

        private void btnCadastrarModalidade_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text != "" && txtPreco.Text != "" && txtQtdeAlunos.Text != "" && txtQtdeAulas.Text != "")
            {
                float preco = float.Parse(txtPreco.Text);
                int qtdeAulas = int.Parse(txtQtdeAulas.Text);
                int qtdeAlunos = int.Parse(txtQtdeAlunos.Text);
                Modalidade m = new Modalidade(txtDescricao.Text, preco, qtdeAlunos, qtdeAulas);
                if (m.verificaModalidade(txtDescricao.Text) == false)
                {
                    if (m.cadastrarModalidade())
                    {
                        MessageBox.Show("Cadastro realizado com Sucesso");
                        txtDescricao.Text = "";
                        txtPreco.Text = "";
                        txtQtdeAlunos.Text = "";
                        txtQtdeAulas.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Erro no cadastro");
                    }
                }
                else
                {
                    MessageBox.Show("Modalidade já cadastrada");
                }
            }
            else
            {
                MessageBox.Show("Nenhum campo pode estar vazio. \nPreencha todos os campos para continuar.");
            }
        }
    }
}
