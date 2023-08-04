using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvPolizas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void altaInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario frm = new Inventario();
            frm.Show();
        }

        private void altaEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados frm = new Empleados();
            frm.Show();
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Polizas frm = new Polizas();
            frm.Show();
        }
    }
}
