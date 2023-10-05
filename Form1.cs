
using System.Net.NetworkInformation;

namespace RecibosWin

{
    public partial class Form1 : Form
    {
        DocumentoPDF documentoPDF = new DocumentoPDF();
        ConexionBD conexionBD = new ConexionBD();
        frmHistoriall frmHistoriall = new frmHistoriall();
        string str;
        int n;

        public Form1()
        {
            InitializeComponent();

        }

        //verificar si hay conexion a internet e inicializar el contador
        private void Form1_Load(object sender, EventArgs e)
        {
            if (IsNetworkAvailable() == true)
            {
                conexionBD.selectUltimoNumeroRecibo(dgvTemp);
                str = dgvTemp.Rows[0].Cells[0].Value.ToString()!;
                if (str == null)
                {
                    lblNumeroRecibo.Text = "Nro. 1";
                }
                else
                {
                    n = Convert.ToInt32(str) + 1;
                    lblNumeroRecibo.Text = "Nro. " + n.ToString();
                }
                dgvTemp.Hide();
                rbTransferencia.Checked = true;
            }
            else {
                MessageBox.Show("Error, sin conexion a Internet!\nRevise el estado de la conexion a internet y vuelva a intentar", "Sin conexion a Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //actualizar contador para ver cual recibo toca generar
        private void ActualizarNroRecibo()
        {
            if (IsNetworkAvailable() == true)
            {
                conexionBD.selectUltimoNumeroRecibo(dgvTemp);
                str = dgvTemp.Rows[0].Cells[0].Value.ToString()!;
                n = Convert.ToInt32(str) + 1;
                lblNumeroRecibo.Text = "Nro. " + n.ToString();
            }
            else {
                MessageBox.Show("Error, sin conexion a Internet!\nRevise el estado de la conexion a internet y vuelva a intentar", "Sin conexion a Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //para generar el pdf e insertar a la db
        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            string name = txtNombreCliente.Text.ToUpper();
            string cash = txtMonto.Text;
            string day = cbxDia.Text;
            string month = cbxMes.Text;
            string year = cbxAnio.Text;
            string codigo_alum = txtCodigo.Text.ToUpper();
            string curso_alum = txtCurso.Text.ToUpper();
            string gestion = cbxGestion.Text;

            if (string.IsNullOrEmpty(cbxDia.Text) || string.IsNullOrEmpty(cbxMes.Text) || string.IsNullOrEmpty(cbxAnio.Text)
                || string.IsNullOrEmpty(cbxGestion.Text) || string.IsNullOrEmpty(cbxColegio.Text) || string.IsNullOrWhiteSpace(txtNombreCliente.Text)
                || string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Error, faltan datos por ingresar!\nCompruebe los campos e intente de nuevo", "Ingresar campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string ruta2 = " ";

                    sfdGuardar.InitialDirectory = "c:\temp";
                    sfdGuardar.Filter = "PDF Files (*.pdf),|*.PDF";
                    sfdGuardar.FilterIndex = 2;
                    sfdGuardar.RestoreDirectory = true;
                    sfdGuardar.FileName = name;
                    DialogResult dr2 = new DialogResult();
                    dr2 = sfdGuardar.ShowDialog();
                    if (dr2 == DialogResult.OK)
                    {
                        if (IsNetworkAvailable() == true)
                        {
                            ruta2 = sfdGuardar.FileName;
                            ActualizarNroRecibo();
                            Thread.Sleep(80);
                            documentoPDF.generatePDF(n.ToString(), name, cash, day, month, year,
                                                     codigo_alum, curso_alum, gestion, ruta2);
                            if (rbEfectivo.Checked == true || rbTransferencia.Checked == false)
                            {
                                conexionBD.insertarDB(name, curso_alum, cbxColegio.Text.ToUpper(), gestion, "EFECTIVO", cash);
                            }
                            else if (rbEfectivo.Checked == false || rbTransferencia.Checked == true)
                            {
                                conexionBD.insertarDB(name, curso_alum, cbxColegio.Text.ToUpper(), gestion, "TRANSFERENCIA", cash);
                            }
                            else
                            {
                                MessageBox.Show("Error, faltan datos por ingresar!\nCompruebe los campos e intente de nuevo", "Ingresar campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            ActualizarNroRecibo();
                            MessageBox.Show("Documento generado con exito. \n Se encuentra en la ruta: " + ruta2, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else {
                            MessageBox.Show("Error, sin conexion a Internet!\nRevise el estado de la conexion a internet y vuelva a intentar", "Sin conexion a Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception e2)
                {
                    MessageBox.Show(e2.Message);
                }
                txtNombreCliente.Clear();
                txtCodigo.Clear();
                txtCurso.Clear();
            }

        }

        //cargar frmHistorial al hacer click y al haber conexion a internet
        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            if (IsNetworkAvailable() == true)
            {
                frmHistoriall.Show();
            }
            else {
                MessageBox.Show("Error, sin conexion a Internet!\nRevise el estado de la conexion a internet y vuelva a intentar", "Sin conexion a Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        //detectar si hubo cambio para modificar al contador
        private void dgvTemp_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string str = dgvTemp.Rows[0].Cells[0].Value.ToString()!;
            int n = Convert.ToInt32(str) + 1;
            lblNumeroRecibo.Text = "Nro. " + n.ToString();
        }

        //evento al hacer click a un boton, actualize el numero de recibo a generar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarNroRecibo();
        }

        //salir - menutoolstrip
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //acerca de - menutoolstrip
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hecho por Ariel Tellez Torrico.", "Acerca del programa");
        }

        //case con los montos de los colegios
        private void cbxColegio_TextChanged(object sender, EventArgs e)
        {
            string colegi0 = cbxColegio.Text;
            switch (colegi0)
            {
                case "Bertoluso":
                    txtMonto.Text = "";
                    break;
                case "Bilingue Santa Cruz":
                    txtMonto.Text = "";
                    break;
                case "Cristo Rey":
                    txtMonto.Text = "100";
                    break;
                case "De La Sierra":
                    txtMonto.Text = "130";
                    break;
                case "Don Bosco":
                    txtMonto.Text = "";
                    break;
                case "Emprendedor":
                    txtMonto.Text = "";
                    break;
                case "Golden Lion/Kinda":
                    txtMonto.Text = "";
                    break;
                case "Interamericano":
                    txtMonto.Text = "";
                    break;
                case "Jesus Maestro":
                    txtMonto.Text = "120";
                    break;
                case "Juan Pablo II":
                    txtMonto.Text = "100";
                    break;
                case "Marista":
                    txtMonto.Text = "";
                    break;
                case "Maria Goretti":
                    txtMonto.Text = "";
                    break;
                case "La Salle Tarde":
                    txtMonto.Text = "";
                    break;
                case "Señor Jesus":
                    txtMonto.Text = "200";
                    break;
                case "Uboldi":
                    txtMonto.Text = "150";
                    break;
                default: break;
            }
        }

        //ver si hay conexion a internet, este es el metodo a llamar
        public static bool IsNetworkAvailable()
        {
            return IsNetworkAvailable(0);
        }

        //verificar si hay conexion a internet
        public static bool IsNetworkAvailable(long minimumSpeed)
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
                return false;

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                // discard because of standard reasons
                if ((ni.OperationalStatus != OperationalStatus.Up) ||
                    (ni.NetworkInterfaceType == NetworkInterfaceType.Loopback) ||
                    (ni.NetworkInterfaceType == NetworkInterfaceType.Tunnel))
                    continue;

                // this allow to filter modems, serial, etc.
                // I use 10000000 as a minimum speed for most cases
                if (ni.Speed < minimumSpeed)
                    continue;

                // discard virtual cards (virtual box, virtual pc, etc.)
                if ((ni.Description.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (ni.Name.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0))
                    continue;

                // discard "Microsoft Loopback Adapter", it will not show as NetworkInterfaceType.Loopback but as Ethernet Card.
                if (ni.Description.Equals("Microsoft Loopback Adapter", StringComparison.OrdinalIgnoreCase))
                    continue;

                return true;
            }
            return false;
        }
    }
}
