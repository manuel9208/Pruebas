using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace InvPolizas
{
    public partial class Empleados : CL_Generales.frmCatalogo
    {
        Conexion conexion = new Conexion();
        public Empleados()
        {
            InitializeComponent();
            _bFuncionaSimple = true;
            conexion.LeerDatosConexion();
        }
    


        private void Empleados_Load(object sender, EventArgs e)
        {
            OcultarControlesMenu(false, true, false, true, true, true);
            HabilitarControlesMenu(true, false, true, false, true, true, true);

            string query = "EXECUTE SPC01_InvPolizas 2,'','','','','','','',''";
            conexion.Consultar(query);

            CmbPuestos.DataSource = conexion.prTablaConsulta;
            CmbPuestos.DisplayMember = "Puesto";
            CmbPuestos.ValueMember = "IdPuesto";

            query = "EXECUTE SPC01_InvPolizas 3,'','','','','','','',''";
            conexion.ConsultarID(query);

            TxtEmpleado.Text = Convert.ToString(conexion.prTablaConsultaID.Rows[0]["IdEmpleado"].ToString());

            query = "EXECUTE SPC01_InvPolizas 13,'','','','','','','',''";
            conexion.ConsultarDgv(query);

            DgvEmpleados.DataSource = conexion.prTablaConsultaDGV;

        }
        protected override void vGuardar()
        {
            string query = "EXECUTE SPC01_InvPolizas 1,0,'" + TxtNombres.Text + "','" + TxtAPaterno.Text + "','" + TxtAMaterno.Text + "','" + CmbPuestos.Text + "','','',''";
            conexion.Guardar(query);

            query = "EXECUTE SPC01_InvPolizas 13,'','','','','','','',''";
            conexion.ConsultarDgv(query);

            DgvEmpleados.DataSource = conexion.prTablaConsultaDGV;

            MessageBox.Show("Se guardo empleado con ID: " + TxtEmpleado.Text);
        }

        protected override void vBuscar()
        {
            string query = "EXECUTE SPC01_InvPolizas 4,0,'" + TxtNombres.Text + "','" + TxtAPaterno.Text + "','" + TxtAMaterno.Text + "','" + CmbPuestos.Text + "','','',''";
            conexion.Buscar(query);
            TxtEmpleado.Text = conexion.IDEmpleado;
            if (TxtEmpleado.Text == "0")
            {
                MessageBox.Show("El empleado no existe ");
            }
            else
            {
                MessageBox.Show("El empleado se encuentra con ID: " + TxtEmpleado.Text);
            }
        }

        protected override void vEliminar()
        {
            string query = "EXECUTE SPC01_InvPolizas 5,0,'" + TxtNombres.Text + "','" + TxtAPaterno.Text + "','" + TxtAMaterno.Text + "','" + CmbPuestos.Text + "','','',''";
            conexion.Guardar(query);

            query = "EXECUTE SPC01_InvPolizas 13,'','','','','','','',''";
            conexion.ConsultarDgv(query);

            DgvEmpleados.DataSource = conexion.prTablaConsultaDGV;

            MessageBox.Show("Se Elimino el Empleado con ID: " + TxtEmpleado.Text + " " + TxtNombres.Text + " " + TxtAPaterno.Text + " " + TxtAMaterno.Text);
        }

        protected override void vEditar()
        {
            string query = "EXECUTE SPC01_InvPolizas 6,"+ TxtEmpleado.Text + "," + TxtNombres.Text + "','" + TxtAPaterno.Text + "','" + TxtAMaterno.Text + "','" + CmbPuestos.Text + "','','',''";
            conexion.Guardar(query);

            query = "EXECUTE SPC01_InvPolizas 13,'','','','','','','',''";
            conexion.ConsultarDgv(query);

            DgvEmpleados.DataSource = conexion.prTablaConsultaDGV;

            MessageBox.Show("Se actualizo el Empleado con ID: " + TxtEmpleado.Text + " " + TxtNombres.Text + " " + TxtAPaterno.Text + " " + TxtAMaterno.Text);

            OcultarControlesMenu(false, true, false, true, true, true);
            HabilitarControlesMenu(true, false, true, false, true, true, true);
        }
    }
}
