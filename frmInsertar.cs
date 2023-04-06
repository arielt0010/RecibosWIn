using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecibosWin
{
    public partial class frmInsertar : Form
    {
        private ConexionBD a;
        public string reciboIDF = "";
        frmHistoriall h = new frmHistoriall();

        public frmInsertar()
        {
            InitializeComponent();
            a = new ConexionBD();

        }

        private void brnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombreAlumno.Text.ToUpper();
            string curso = txtCurso.Text.ToUpper();
            string colegio = cbxColegio.Text.ToUpper();
            string gestion = cbxGestion.Text;
            string monto = txtMonto.Text;
            if(string.IsNullOrEmpty(cbxGestion.Text) ||
                string.IsNullOrWhiteSpace(txtNombreAlumno.Text) || string.IsNullOrEmpty(cbxColegio.Text) ||
                rbEfectivo.Checked == false && rbTransferencia.Checked == false)
            {
                MessageBox.Show("Error, faltan datos por ingresar!\nCompruebe los campos e intente de nuevo", "Ingresar campos", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                
                if (rbEfectivo.Checked == true || rbTransferencia.Checked == false)
                {
                    a.insertarDB(nombre, curso, colegio, gestion, "EFECTIVO", monto);
                }
                else if (rbEfectivo.Checked == false || rbTransferencia.Checked == true)
                {
                    a.insertarDB(nombre, curso, colegio, gestion, "TRANSFERENCIA", monto);
                }
                else
                {
                    MessageBox.Show("Error, faltan datos por ingresar!\nCompruebe los campos e intente de nuevo", "Ingresar campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                 
            a.selectAllDB(h.dgvN);
            this.Close();
            }

        }

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
    }
}
