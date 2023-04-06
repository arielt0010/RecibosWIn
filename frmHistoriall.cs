using ClosedXML.Excel;
using DGVPrinterHelper;
using System.Data;
using System.Net.NetworkInformation;

namespace RecibosWin
{
    public partial class frmHistoriall : Form
    {
        ConexionBD cbx;
        frmInsertar frmInsertar;

        public frmHistoriall()
        {
            InitializeComponent();

        }

        private void frmHistoriall_Load(object sender, EventArgs e)
        {
            if (IsNetworkAvailable())
            {
                cbx = new ConexionBD();
                cbx.selectAllDB(dgvN);
                textBox1.Hide();
                btnEliminar.Enabled = false;
                txtBuscar.Text = "Buscar por... (Selecciona el filtro en el desplegable)";
                txtBuscar.ForeColor = Color.Silver;
                this.dgvN.Columns[0].Width = 50;
                btnUpdate.Enabled = false;
                gbxActualizar.Visible = false;
            }
            else
            {
                MessageBox.Show("Error, sin conexion a Internet!\nRevise el estado de la conexion a internet y vuelva a intentar", "Sin conexion a Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Desea eliminar el elemento seleccionado?", "Confirmar accion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.OK)
            {
                if (IsNetworkAvailable() == true)
                {
                    string eliminar = textBox1.Text;
                    cbx.deleteReciboDB(eliminar);
                    cbx.selectAllDB(dgvN);
                    btnEliminar.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error, sin conexion a Internet!\nRevise el estado de la conexion a internet y vuelva a intentar", "Sin conexion a Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertar = new frmInsertar();
            frmInsertar.ShowDialog();
            cbx.selectAllDB(dgvN);
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (IsNetworkAvailable() == true)
            {
                cbx = new ConexionBD();
                cbx.selectAllDB(dgvN);
                btnEliminar.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error, sin conexion a Internet!\nRevise el estado de la conexion a internet y vuelva a intentar", "Sin conexion a Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                cbx.selectAllDB(dgvN);
            }
            else
            {
                string filtro = cbxFiltro.Text;
                switch (filtro)
                {
                    case "Numero de recibo":
                        if (txtBuscar.Text == "" && txtBuscar.Text == "Buscar por... (Selecciona el filtro en el desplegable)")
                        {
                            cbx.selectAllDB(dgvN);
                        }
                        else
                        {
                            cbx.selectCriterio(dgvN, txtBuscar.Text, "Id");
                        }
                        break;
                    case "Nombre del alumno":
                        if (txtBuscar.Text == "" && txtBuscar.Text == "Buscar por... (Selecciona el filtro en el desplegable)")
                        {
                            cbx.selectAllDB(dgvN);
                        }
                        else
                        {
                            cbx.selectCriterio(dgvN, txtBuscar.Text, "nombre");
                        }
                        break;
                    case "Curso":
                        if (txtBuscar.Text == "" && txtBuscar.Text == "Buscar por... (Selecciona el filtro en el desplegable)")
                        {
                            cbx.selectAllDB(dgvN);
                        }
                        else
                        {
                            cbx.selectCriterio(dgvN, txtBuscar.Text, "curso");
                        }
                        break;
                    case "Colegio":
                        if (txtBuscar.Text == "" && txtBuscar.Text == "Buscar por... (Selecciona el filtro en el desplegable)")
                        {
                            cbx.selectAllDB(dgvN);
                        }
                        else
                        {
                            cbx.selectCriterio(dgvN, txtBuscar.Text, "colegio");
                        }
                        break;
                    case "Gestion":
                        if (txtBuscar.Text == "" && txtBuscar.Text == "Buscar por... (Selecciona el filtro en el desplegable)")
                        {
                            cbx.selectAllDB(dgvN);
                        }
                        else
                        {
                            cbx.selectCriterio(dgvN, txtBuscar.Text, "gestion");
                        }
                        break;
                    case "Fecha de creacion":
                        if (txtBuscar.Text == "" && txtBuscar.Text == "Buscar por... (Selecciona el filtro en el desplegable)")
                        {
                            cbx.selectAllDB(dgvN);
                        }
                        else
                        {
                            cbx.selectCriterio(dgvN, txtBuscar.Text, "fecha");
                        }
                        break;
                    default:
                        cbx.selectAllDB(dgvN);
                        break;
                }
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar por... (Selecciona el filtro en el desplegable)")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar por... (Selecciona el filtro en el desplegable)";
                txtBuscar.ForeColor = Color.Silver;
                cbx.selectAllDB(dgvN);
            }
        }

        private void dgvDatosS_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dgvN.Rows[e.RowIndex].Cells[0].Value.ToString();
            btnEliminar.Enabled = true;
            btnUpdate.Enabled = true;
            txtNombreH.Text = dgvN.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCursoH.Text = dgvN.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbxColegioH.Text = dgvN.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbxGestionH.Text = dgvN.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtMonto.Text = dgvN.Rows[e.RowIndex].Cells[8].Value.ToString();
            if (dgvN.Rows[e.RowIndex].Cells[7].Value.ToString() == "EFECTIVO")
            {
                rbEfectivo.Checked = true;
            }
            else if (dgvN.Rows[e.RowIndex].Cells[7].Value.ToString() == "TRANSFERENCIA")
            {
                rbTransferencia.Checked = true;
            }
        }

        private void frmHistoriall_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }



        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte";
            printer.SubTitle = String.Format("Generado en la fecha: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            this.dgvN.Columns[0].Width = 40;
            this.dgvN.Columns[4].Width = 55;
            printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.CellWidth;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "";
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dgvN);
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string ruta2 = "";

                sfdExportar.InitialDirectory = "c:\temp";
                sfdExportar.Filter = "Excel files (*.xlsx)|*.xlsx";
                sfdExportar.FilterIndex = 0;
                sfdExportar.RestoreDirectory = true;
                sfdExportar.Title = "Export Excel File To";
                DialogResult dr22 = new DialogResult();
                dr22 = sfdExportar.ShowDialog();
                if (dr22 == DialogResult.OK)
                {
                    var wb = new XLWorkbook();
                    DataTable dt = new DataTable();
                    foreach (DataGridViewColumn colum in dgvN.Columns)
                    {
                        dt.Columns.Add(colum.HeaderText, colum.ValueType);
                    }
                    foreach (DataGridViewRow row in dgvN.Rows)
                    {
                        dt.Rows.Add();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                        }
                    }
                    var ws = wb.Worksheets.Add(dt, "Hoja1");
                    wb.SaveAs(sfdExportar.FileName);
                    ruta2 = sfdExportar.FileName;
                    MessageBox.Show("Documento generado con exito. \n Se encuentra en la ruta: " + ruta2);

                }
            }
            catch (Exception e22)
            {
                MessageBox.Show(e22.Message.ToString());
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            gbxActualizar.Visible = true;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gbxActualizar.Visible = false;
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (IsNetworkAvailable() == true)
            {
                if (rbEfectivo.Checked == true || rbTransferencia.Checked == false)
                {
                    cbx.updateDB(textBox1.Text, txtNombreH.Text.ToUpper(), txtCursoH.Text.ToUpper(), cbxColegioH.Text.ToUpper(), cbxGestionH.Text, "EFECTIVO", txtMonto.Text);
                }
                else if (rbEfectivo.Checked == false || rbTransferencia.Checked == true)
                {
                    cbx.updateDB(textBox1.Text, txtNombreH.Text.ToUpper(), txtCursoH.Text.ToUpper(), cbxColegioH.Text.ToUpper(), cbxGestionH.Text, "TRANSFERENCIA", txtMonto.Text);
                }
                else
                {
                    MessageBox.Show("Error, faltan datos por ingresar!\nCompruebe los campos e intente de nuevo", "Ingresar campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cbx.selectAllDB(dgvN);
                gbxActualizar.Visible = false;
                btnUpdate.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error, sin conexion a Internet!\nRevise el estado de la conexion a internet y vuelva a intentar", "Sin conexion a Internet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxColegioH_TextChanged(object sender, EventArgs e)
        {
            string colegi0 = cbxColegioH.Text;
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

        public static bool IsNetworkAvailable()
        {
            return IsNetworkAvailable(0);
        }


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