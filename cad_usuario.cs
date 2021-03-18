using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cad_alunos_04_2d2
{
    public partial class cad_usuario : Form
    {
        public cad_usuario()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu();
            menu.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            frm_menu menu = new frm_menu();
            menu.ShowDialog();
        }
    }
}
