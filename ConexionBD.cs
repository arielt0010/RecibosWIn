using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;
using MySql;
using MySql.Data.MySqlClient;

namespace RecibosWin
{
    internal class ConexionBD
    {
        MySqlConnection? conexionBD;

        private MySqlConnection? conectarBD()
        {
            string servidor = "localhost";
            string bd = "recibos";
            string usuario = "root";
            string password = "password";


            string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + ";User Id=" + usuario + ";Password=" + password + "";
            conexionBD = new MySqlConnection(cadenaConexion);

            try
            {
                conexionBD.Open();
                return conexionBD;
            }
            catch (MySqlException mex)
            {
                MessageBox.Show(mex.Message);
                return null;    
            }
        }

        public void insertarDB(string nombreAlumni, string cursoAlumni, string colegio, string gestion, string forma_pago, string monto) {
            conectarBD();
            string theDate = DateTime.Now.ToString("yyyy-MM-dd H:mm:ss");
            string usuario = System.Environment.MachineName;
            string query = "insert into recibosgenerados2(nombre, curso, colegio, gestion, fecha, usuario, forma_pago, monto) values" +
                "(@nombre, @curso, @colegio, @gestion, @fecha, @usuario, @forma_pago, @monto);";
            MySqlCommand cmd = new MySqlCommand(query, conexionBD);
            cmd.Parameters.AddWithValue("@nombre",nombreAlumni);
            cmd.Parameters.AddWithValue("@curso", cursoAlumni);
            cmd.Parameters.AddWithValue("@colegio", colegio);
            cmd.Parameters.AddWithValue("@gestion", gestion);
            cmd.Parameters.AddWithValue("@fecha", theDate);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@forma_pago",forma_pago);
            cmd.Parameters.AddWithValue("@monto", monto);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            while (mySqlDataReader.Read()) { }
            closeConnection();
        }

        public void deleteReciboDB(string eliminar) {
            conectarBD();
            string query = "delete from recibosgenerados2 where Id = @Id;";
            MySqlCommand cmd = new MySqlCommand(query, conexionBD);
            cmd.Parameters.AddWithValue("@Id", eliminar);
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            while (mySqlDataReader.Read()) { }
            closeConnection();
        }

        public void selectAllDB(DataGridView dgv){
            conectarBD();
            try
            {
                string query = "select * from recibosgenerados2;";
                MySqlCommand mySqlCommand = new MySqlCommand(query, conexionBD);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dTable = new DataTable();
                adapter.Fill(dTable);
                dgv.DataSource = dTable;
                closeConnection();
            }
            catch (Exception e) { 
                MessageBox.Show(e.Message);
            }
        }

        private void closeConnection() {
            try
            {
                conexionBD.Close();
            }
            catch (MySqlException mex)
            {
                MessageBox.Show(mex.Message);
            }
        }

        public void selectCriterio(DataGridView dgv, string criterio, string filtro)
        {
            conectarBD();

            try
            {
                string query = "select * from recibosgenerados2 where " + filtro + " like '%" + criterio + "%';";
                MySqlCommand mySqlCommand = new MySqlCommand(query, conexionBD);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dTable = new DataTable();
                adapter.Fill(dTable);
                dgv.DataSource = dTable;
                closeConnection();
            }
            catch(Exception e222) { 
                MessageBox.Show(e222.Message);
            }
        }

        public void selectUltimoNumeroRecibo(DataGridView dgv) {
            try
            {
                conectarBD();
                string query = "select Id from recibosgenerados2 order by Id DESC LIMIT 1 for update";
                MySqlCommand mySqlCommand = new MySqlCommand(query, conexionBD);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = mySqlCommand;
                DataTable dTable = new DataTable();
                adapter.Fill(dTable);
                dgv.DataSource = dTable;
                closeConnection();
            }
            catch (Exception e22) { MessageBox.Show(e22.ToString()); }
        }

        public void updateDB(string Id,string nombreAlumni, string cursoAlumni, string colegio, string gestion, string forma_pago, string monto)
        {
            conectarBD();
            try
            {
                string query = "update recibosgenerados2 set nombre = @nombre, curso = @curso, colegio = @colegio, gestion = @gestion, forma_pago = @forma_pago, monto=@monto where Id=@id;";
                MySqlCommand cmd = new(query, conexionBD);
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@nombre", nombreAlumni);
                cmd.Parameters.AddWithValue("@curso", cursoAlumni);
                cmd.Parameters.AddWithValue("@colegio", colegio);
                cmd.Parameters.AddWithValue("@gestion", gestion);
                cmd.Parameters.AddWithValue("@forma_pago", forma_pago);
                cmd.Parameters.AddWithValue("@monto", monto);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                while (mySqlDataReader.Read()) { }
                closeConnection();
            }
            catch (Exception e1234) {
                MessageBox.Show(e1234.Message);
            }
        }
    }
}
