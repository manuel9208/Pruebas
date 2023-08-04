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
    public partial class Inventario : CL_Generales.frmCatalogo
    {
        Conexion conexion = new Conexion();
        public Inventario()
        {
            InitializeComponent();
            _bFuncionaSimple = true;
            conexion.LeerDatosConexion();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            OcultarControlesMenu(false, true, false, true, true, true);
            HabilitarControlesMenu(true, false, true, false, true, true, true);

            string query = "EXECUTE SPC01_InvPolizas 8,'','','','','','','',''";
            conexion.ConsultarID(query);

            TxtSku.Text = Convert.ToString(conexion.prTablaConsultaID.Rows[0]["IDSku"].ToString());

            query = "EXECUTE SPC01_InvPolizas 12,'','','','','','','',''";
            conexion.ConsultarDgv(query);

            DgvInventario.DataSource = conexion.prTablaConsultaDGV;

        }
        protected override void vGuardar()
        {
            string query = "EXECUTE SPC01_InvPolizas 7,0,'','','','','" + TxtSku.Text + "','" + TxtNombre.Text + "','" + TxtCantidad.Text + "'";
            conexion.Guardar(query);
            query = "EXECUTE SPC01_InvPolizas 8,'','','','','','','',''";
            conexion.ConsultarID(query);
            TxtSku.Text = Convert.ToString(conexion.prTablaConsultaID.Rows[0]["IDSku"].ToString());

            query = "EXECUTE SPC01_InvPolizas 12,'','','','','','','',''";
            conexion.ConsultarDgv(query);

            DgvInventario.DataSource = conexion.prTablaConsultaDGV;

            MessageBox.Show("Se guardo inventario con ID: " + TxtSku.Text);
        }
        protected override void vBuscar()
        {
            string query = "EXECUTE SPC01_InvPolizas 9,0,'','','','','" + TxtSku.Text + "','" + TxtNombre.Text + "','" + TxtCantidad.Text + "'";
            conexion.Consultar(query);
            if (conexion.prTablaConsulta.Rows.Count > 0)
            {
                TxtSku.Text = Convert.ToString(conexion.prTablaConsulta.Rows[0]["Sku"].ToString());
                TxtCantidad.Text = Convert.ToString(conexion.prTablaConsulta.Rows[0]["Cantidad"].ToString());
            }
            else
            {
                MessageBox.Show("No existe el articulo");
            }
        }

        protected override void vEliminar()
        {
            string query = "EXECUTE SPC01_InvPolizas 10,0,'','','','','" + TxtSku.Text + "','" + TxtNombre.Text + "','" + TxtCantidad.Text + "'";
            conexion.Guardar(query);

            query = "EXECUTE SPC01_InvPolizas 12,'','','','','','','',''";
            conexion.ConsultarDgv(query);

            DgvInventario.DataSource = conexion.prTablaConsultaDGV;

            MessageBox.Show("Se elimino inventario con ID: " + TxtSku.Text);
        }
        protected override void vEditar()
        {
            string query = "EXECUTE SPC01_InvPolizas 11,0,'','','','','" + TxtSku.Text + "','" + TxtNombre.Text + "','" + TxtCantidad.Text + "'";
            conexion.Guardar(query);

            query = "EXECUTE SPC01_InvPolizas 12,'','','','','','','',''";
            conexion.ConsultarDgv(query);

            DgvInventario.DataSource = conexion.prTablaConsultaDGV;

            MessageBox.Show("Se actualizo inventario con ID: " + TxtSku.Text);

            OcultarControlesMenu(false, true, false, true, true, true);
            HabilitarControlesMenu(true, false, true, false, true, true, true);
        }
    }
}
