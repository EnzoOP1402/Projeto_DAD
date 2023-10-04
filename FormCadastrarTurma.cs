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
    public partial class FormCadastrarTurma : Form
    {
        public FormCadastrarTurma()
        {
            InitializeComponent();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Turma t = new Turma();
            int idmodalidade = t.retornaIdmodalidade(txtModalidadeTurma.Text);
            Turma t2 = new Turma(txtProfTurma.Text, txtDiaSemanaTurma.Text, mtxtHoraTurma.Text, idmodalidade);
            try
            {
                int qtd = int.Parse(txtNalunosTurma.Text);
                t2.cadastrarTurma(qtd);
                MessageBox.Show("Cadastrado com sucesso");
            }catch(Exception ex)
            {
                MessageBox.Show("Erro no cadastro");
            }
        }
    }
}
