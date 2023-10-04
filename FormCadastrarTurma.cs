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
            int modalidade = int.Parse(txtModalidadeTurma.Text);
            Turma t = new Turma(txtProfTurma.Text, txtDiaSemanaTurma.Text, txtNalunosTurma.Text, modalidade);
            
        }
    }
}
