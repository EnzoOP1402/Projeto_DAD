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
    public partial class FormConsultaTurma : Form
    {
        public FormConsultaTurma()
        {
            InitializeComponent();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            FormConsultaTurmaTodos f = new FormConsultaTurmaTodos();
            f.Show();
        }

        private void btnMostrarID_Click(object sender, EventArgs e)
        {
            FormConsultaTurmaID f = new FormConsultaTurmaID();
            f.Show();
        }
    }
}
