using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace InvPolizas
{
    public class Conexion
    {
        String sCadenaConexion;
        String sServidorTxt;
        String sBaseDatosTxt;
        String sUsuarioTxt;
        String sContrasenaTxt;
        SqlConnection oSqlConexion;
        Boolean bError;
        DataTable oTabla = new DataTable();
        DataTable oTablaID = new DataTable();
        DataTable oTablaB = new DataTable();
        DataTable oTablaE = new DataTable();
        DataTable oTablaDGV = new DataTable();
        DataTable oTablaCA = new DataTable();
        DataTable oTablaVC = new DataTable();
        int CantidadR;
        int CantidadA;
        DataTable oTablaPol = new DataTable();
        
        
        public string IDEmpleado = "0";
        public int Graba = 0;
        public int sExite = 0;

        public DataTable prTablaConsulta
        {
            get { return oTabla; }
            set { oTabla = value; }
        }
        public DataTable prTablaConsultaID
        {
            get { return oTablaID; }
            set { oTablaID = value; }
        }
        public DataTable prTablaConsultaE
        {
            get { return oTablaB; }
            set { oTablaB = value; }
        }
        public DataTable prTablaConsultaEmp
        {
            get { return oTablaE; }
            set { oTablaE = value; }
        }
        public DataTable prTablaConsultaDGV
        {
            get { return oTablaDGV; }
            set { oTablaDGV = value; }
        }
        public DataTable prTablaConsultaCA
        {
            get { return oTablaCA; }
            set { oTablaCA = value; }
        }
        public DataTable prTablaConsultaVC
        {
            get { return oTablaVC; }
            set { oTablaVC = value; }
        }
        public DataTable prTablaBuscaPol
        {
            get { return oTablaPol; }
            set { oTablaPol = value; }
        }
        

        public void LeerDatosConexion()
        {
            string archivo = Application.StartupPath + "\\Conexion.txt";

            sServidorTxt = String.Empty;
            sBaseDatosTxt = String.Empty;
            sUsuarioTxt = String.Empty;
            sContrasenaTxt = String.Empty;
            try
            {
                using (StreamReader lector = new StreamReader(archivo))
                {
                    while (lector.Peek() > -1)
                    {
                        string linea = lector.ReadLine();
                        if (!String.IsNullOrEmpty(linea))
                        {
                            if (sServidorTxt == "")
                            {
                                sServidorTxt = linea;
                            }
                            else if (sBaseDatosTxt == "")
                            {
                                sBaseDatosTxt = linea;
                            }
                            else if (sUsuarioTxt == "")
                            {
                                sUsuarioTxt = linea;
                            }
                            else if (sContrasenaTxt == "")
                            {
                                sContrasenaTxt = linea;
                            }
                        }
                    }
                }
                sCadenaConexion = "Data Source = " + sServidorTxt + "; Initial Catalog = " + sBaseDatosTxt + "; User ID = " + sUsuarioTxt + "; Password = " + sContrasenaTxt + "";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Guardar(string query)
        {
            try
            {
                SqlConnection oSqlConexion = new SqlConnection(sCadenaConexion);
                oSqlConexion.Open();
                SqlCommand comando = new SqlCommand(query, oSqlConexion);
                comando.ExecuteNonQuery();
                oSqlConexion.Close();
            }
            catch (Exception e)
            { bError = true; throw new Exception(e.Message); }
        }
        public void Consultar(string query)
        {        
            try
            {
                SqlConnection oSqlConexion = new SqlConnection(sCadenaConexion);
                SqlCommand comando = new SqlCommand(query, oSqlConexion);
                oSqlConexion.Open();
                SqlDataAdapter Registro = new SqlDataAdapter(comando);
                Registro.Fill(oTabla);
                oSqlConexion.Close();
            }
            catch (Exception e)
            { bError = true; throw new Exception(e.Message); }
        }
        public void ConsultarEmp(string query)
        {
            try
            {
                SqlConnection oSqlConexion = new SqlConnection(sCadenaConexion);
                SqlCommand comando = new SqlCommand(query, oSqlConexion);
                oSqlConexion.Open();
                SqlDataAdapter Registro = new SqlDataAdapter(comando);
                Registro.Fill(oTablaE);
                oSqlConexion.Close();
            }
            catch (Exception e)
            { bError = true; throw new Exception(e.Message); }
        }
        public void ConsultarDgv(string query)
        {
            try
            {
                oTablaDGV.Clear();
                SqlConnection oSqlConexion = new SqlConnection(sCadenaConexion);
                SqlCommand comando = new SqlCommand(query, oSqlConexion);
                oSqlConexion.Open();
                SqlDataAdapter Registro = new SqlDataAdapter(comando);
                Registro.Fill(oTablaDGV);
                oSqlConexion.Close();
            }
            catch (Exception e)
            { bError = true; throw new Exception(e.Message); }
        }

        public void ConsultarID(string query)
        {
            try
            {
                SqlConnection oSqlConexion = new SqlConnection(sCadenaConexion);
                SqlCommand comando = new SqlCommand(query, oSqlConexion);
                oSqlConexion.Open();
                SqlDataReader Registro = comando.ExecuteReader();
                oTablaID.Load(Registro);
                Registro.Close();
                oSqlConexion.Close();
            }
            catch (Exception e)
            { bError = true; throw new Exception(e.Message); }
        }

        public void ConsultarCantidad(string query)
        {
            try
            {
                oTablaCA.Clear();
                SqlConnection oSqlConexion = new SqlConnection(sCadenaConexion);
                SqlCommand comando = new SqlCommand(query, oSqlConexion);
                oSqlConexion.Open();
                SqlDataReader Registro = comando.ExecuteReader();
                oTablaCA.Load(Registro);
                Registro.Close();
                oSqlConexion.Close();
            }
            catch (Exception e)
            { bError = true; throw new Exception(e.Message); }
        }
        public void ConsultarValidaCantidad(string query)
        {
            try
            {
                SqlConnection oSqlConexion = new SqlConnection(sCadenaConexion);
                SqlCommand comando = new SqlCommand(query, oSqlConexion);
                oSqlConexion.Open();
                SqlDataReader Registro = comando.ExecuteReader();
                oTablaVC.Load(Registro);
                Registro.Close();
                oSqlConexion.Close();
                CantidadR = Convert.ToInt32(oTablaVC.Rows[0]["CantidadR"]);
                CantidadA = Convert.ToInt32(oTablaVC.Rows[0]["CantidadA"]);
                if (CantidadA < CantidadR)
                {
                    MessageBox.Show("La cantidad que se quiere grabar es mayor a la que se tiene en el inventario.");
                    Graba = 0;
                    return;
                }
                Graba = 1;
            }
            catch (Exception e)
            { bError = true; throw new Exception(e.Message); }
        }

        public void Buscar(string query)
        {
            try
            {
                oTablaB.Clear();
                SqlConnection oSqlConexion = new SqlConnection(sCadenaConexion);
                SqlCommand comando = new SqlCommand(query, oSqlConexion);
                oSqlConexion.Open();
                SqlDataAdapter Registro = new SqlDataAdapter(comando);
                Registro.Fill(oTablaB);
                if (oTablaB.Rows.Count <= 0)
                {
                    MessageBox.Show("Empleado no existe");
                }
                else
                {
                    IDEmpleado = Convert.ToString(oTablaB.Rows[0]["IdEmpleado"].ToString());
                }

                oSqlConexion.Close();
            }
            catch (Exception e)
            { bError = true; throw new Exception(e.Message); }
        }
        public void BuscarPol(string sPoliza)
        {
            try
            {
                string query = "EXECUTE SPC01_InvPolizasProceso 9,NULL,NULL,NULL,NULL," + sPoliza + "";
                SqlConnection oSqlConexion = new SqlConnection(sCadenaConexion);
                SqlCommand comando = new SqlCommand(query, oSqlConexion);
                oSqlConexion.Open();
                SqlDataAdapter Registro = new SqlDataAdapter(comando);
                Registro.Fill(oTablaPol);
                if (oTablaPol.Rows.Count <= 0)
                {
                    MessageBox.Show("Poliza no existe ");
                    sExite = 0;
                    return;
                }

                sExite = 1;

                oSqlConexion.Close();
            }
            catch (Exception e)
            { bError = true; throw new Exception(e.Message); }
        }
    }
}