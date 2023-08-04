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
    public partial class Polizas : CL_Generales.frmCatalogo
    {
        Conexion conexion = new Conexion();
        public Polizas()
        {
            InitializeComponent();
            _bFuncionaSimple = true;
            conexion.LeerDatosConexion();
        }

        private void Polizas_Load(object sender, EventArgs e)
        {
            OcultarControlesMenu(false, true, false, true, true, true);
            HabilitarControlesMenu(true, false, true, false, true, true, true);

            string query = "EXECUTE SPC01_InvPolizasProceso 1,NULL,NULL,NULL,NULL,NULL";
            conexion.Consultar(query);

            CmbAEmpleado.DataSource = conexion.prTablaConsulta;
            CmbAEmpleado.DisplayMember = "NombreEmpleado";
            CmbAEmpleado.ValueMember = "IdEmpleado";

            query = "EXECUTE SPC01_InvPolizasProceso 2,NULL,NULL,NULL,NULL,NULL";
            conexion.ConsultarEmp(query);

            CmbSku.DataSource = conexion.prTablaConsultaEmp;
            CmbSku.DisplayMember = "Nombre";
            CmbSku.ValueMember = "Sku";

            query = "EXECUTE SPC01_InvPolizasProceso 3,NULL,NULL,NULL,NULL,NULL";
            conexion.ConsultarID(query);

            TxtIdPoliza.Text = Convert.ToString(conexion.prTablaConsultaID.Rows[0]["IDPoliza"].ToString());

            query = "EXECUTE SPC01_InvPolizasProceso 4,NULL,NULL,NULL,NULL,NULL";
            conexion.ConsultarDgv(query);

            DgvPolzias.DataSource = conexion.prTablaConsultaDGV;

            query = "EXECUTE SPC01_InvPolizasProceso 5,NULL,"+ CmbSku.SelectedValue + ",NULL,NULL,NULL";
            conexion.ConsultarCantidad(query);

            TxtCantidad.Text = Convert.ToString(conexion.prTablaConsultaCA.Rows[0]["Cantidad"].ToString());
        }

        private void CmbSku_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = "EXECUTE SPC01_InvPolizasProceso 5,NULL," + CmbSku.SelectedValue + ",NULL,NULL,NULL";
            conexion.ConsultarCantidad(query);

            TxtCantidad.Text = Convert.ToString(conexion.prTablaConsultaCA.Rows[0]["Cantidad"].ToString());
        }

        protected override void vGuardar()
        {
            string Fecha = Convert.ToDateTime(DtFechaAlta.Value).Year.ToString() + (Convert.ToDateTime(DtFechaAlta.Value).Month.ToString()).PadLeft(2, Convert.ToChar("0")) + Convert.ToDateTime(DtFechaAlta.Value).Day.ToString().PadLeft(2, Convert.ToChar("0"));

            string query = "EXECUTE SPC01_InvPolizasProceso 7,NULL," + CmbSku.SelectedValue + "," + TxtCantidad.Text + ",NULL,NULL";
            conexion.ConsultarValidaCantidad(query);
            if (conexion.Graba == 1)
            {
                query = "EXECUTE SPC01_InvPolizasProceso 6," + CmbAEmpleado.SelectedValue + "," + CmbSku.SelectedValue + "," + TxtCantidad.Text + ",'" + Fecha.ToString() + "',NULL";
                conexion.Guardar(query);

                query = "EXECUTE SPC01_InvPolizasProceso 4,NULL,NULL,NULL,NULL,NULL";
                conexion.ConsultarDgv(query);

                DgvPolzias.DataSource = conexion.prTablaConsultaDGV;

                MessageBox.Show("Se guardo poliza con ID: " + TxtIdPoliza.Text);
            }
        }

        protected override void vEliminar()
        {
            conexion.BuscarPol(TxtIdPoliza.Text);
            if (String.IsNullOrEmpty(TxtIdPoliza.Text) || conexion.sExite == 0)
            {
                MessageBox.Show("Seleccione una poliza");
            }
            else if (conexion.sExite == 1)
            {
                string query = "EXECUTE SPC01_InvPolizasProceso 8,NULL,NULL,NULL,NULL," + TxtIdPoliza.Text + "";
                conexion.Guardar(query);

                query = "EXECUTE SPC01_InvPolizasProceso 4,NULL,NULL,NULL,NULL,NULL";
                conexion.ConsultarDgv(query);

                DgvPolzias.DataSource = conexion.prTablaConsultaDGV;

                MessageBox.Show("Se elimino poliza con ID: " + TxtIdPoliza.Text);
            }
            
        }

        protected override void vEditar()
        {
            conexion.BuscarPol(TxtIdPoliza.Text);
            if (String.IsNullOrEmpty(TxtIdPoliza.Text) || conexion.sExite == 0)
            {
                MessageBox.Show("Seleccione una poliza");
            }
            else if (conexion.sExite == 1)
            {
                string Fecha = Convert.ToDateTime(DtFechaAlta.Value).Year.ToString() + (Convert.ToDateTime(DtFechaAlta.Value).Month.ToString()).PadLeft(2, Convert.ToChar("0")) + Convert.ToDateTime(DtFechaAlta.Value).Day.ToString().PadLeft(2, Convert.ToChar("0"));

                string query = "EXECUTE SPC01_InvPolizasProceso 7,NULL," + CmbSku.SelectedValue + "," + TxtCantidad.Text + ",NULL,NULL";
                conexion.ConsultarValidaCantidad(query);
                if (conexion.Graba == 1)
                {
                    query = "EXECUTE SPC01_InvPolizasProceso 9," + CmbAEmpleado.SelectedValue + "," + CmbSku.SelectedValue + "," + TxtCantidad.Text + ",'" + Fecha.ToString() + "',NULL";
                    conexion.Guardar(query);
                    MessageBox.Show("Se actualizo poliza con ID: " + TxtIdPoliza.Text);
                }
            }
            OcultarControlesMenu(false, true, false, true, true, true);
            HabilitarControlesMenu(true, false, true, false, true, true, true);
        }
    }
}
