namespace RecibosWin
{
    partial class frmInsertar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblColegio = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.brnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxColegio = new System.Windows.Forms.ComboBox();
            this.lblGestion = new System.Windows.Forms.Label();
            this.rbTransferencia = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cbxGestion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 58);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(176, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del alumno:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(135, 109);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(62, 25);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso:";
            // 
            // lblColegio
            // 
            this.lblColegio.AutoSize = true;
            this.lblColegio.Location = new System.Drawing.Point(120, 172);
            this.lblColegio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColegio.Name = "lblColegio";
            this.lblColegio.Size = new System.Drawing.Size(77, 25);
            this.lblColegio.TabIndex = 3;
            this.lblColegio.Text = "Colegio:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(209, 55);
            this.txtNombreAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(374, 31);
            this.txtNombreAlumno.TabIndex = 5;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(209, 103);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(171, 31);
            this.txtCurso.TabIndex = 6;
            // 
            // brnCancelar
            // 
            this.brnCancelar.Location = new System.Drawing.Point(198, 439);
            this.brnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brnCancelar.Name = "brnCancelar";
            this.brnCancelar.Size = new System.Drawing.Size(163, 68);
            this.brnCancelar.TabIndex = 8;
            this.brnCancelar.Text = "Cancelar";
            this.brnCancelar.UseVisualStyleBackColor = true;
            this.brnCancelar.Click += new System.EventHandler(this.brnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(401, 422);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 85);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxColegio
            // 
            this.cbxColegio.FormattingEnabled = true;
            this.cbxColegio.Items.AddRange(new object[] {
            "Bertoluso",
            "Bilingue Santa Cruz",
            "Cristo Rey",
            "De La Sierra",
            "Don Bosco",
            "Emprendedor",
            "Golden Lion/Kinda",
            "Interamericano",
            "Jesus Maestro",
            "Juan Pablo II",
            "Marista",
            "Maria Goretti",
            "La Salle Tarde",
            "Señor Jesus",
            "Uboldi"});
            this.cbxColegio.Location = new System.Drawing.Point(205, 169);
            this.cbxColegio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxColegio.Name = "cbxColegio";
            this.cbxColegio.Size = new System.Drawing.Size(247, 33);
            this.cbxColegio.TabIndex = 10;
            this.cbxColegio.TextChanged += new System.EventHandler(this.cbxColegio_TextChanged);
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Location = new System.Drawing.Point(121, 239);
            this.lblGestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(76, 25);
            this.lblGestion.TabIndex = 11;
            this.lblGestion.Text = "Gestion:";
            // 
            // rbTransferencia
            // 
            this.rbTransferencia.AutoSize = true;
            this.rbTransferencia.Location = new System.Drawing.Point(125, 352);
            this.rbTransferencia.Name = "rbTransferencia";
            this.rbTransferencia.Size = new System.Drawing.Size(138, 29);
            this.rbTransferencia.TabIndex = 13;
            this.rbTransferencia.TabStop = true;
            this.rbTransferencia.Text = "Transferencia";
            this.rbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(310, 350);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(99, 29);
            this.rbEfectivo.TabIndex = 14;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(123, 296);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(70, 25);
            this.lblMonto.TabIndex = 15;
            this.lblMonto.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(209, 293);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(150, 31);
            this.txtMonto.TabIndex = 16;
            // 
            // cbxGestion
            // 
            this.cbxGestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGestion.FormattingEnabled = true;
            this.cbxGestion.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbxGestion.Location = new System.Drawing.Point(205, 236);
            this.cbxGestion.Name = "cbxGestion";
            this.cbxGestion.Size = new System.Drawing.Size(175, 33);
            this.cbxGestion.TabIndex = 17;
            // 
            // frmInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 555);
            this.Controls.Add(this.cbxGestion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.rbEfectivo);
            this.Controls.Add(this.rbTransferencia);
            this.Controls.Add(this.lblGestion);
            this.Controls.Add(this.cbxColegio);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.brnCancelar);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.lblColegio);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInsertar";
            this.Text = "Insertar datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblNombre;
        private Label lblCurso;
        private Label lblColegio;
        private TextBox txtNombreAlumno;
        private TextBox txtCurso;
        private Button brnCancelar;
        private Button btnGuardar;
        private ComboBox cbxColegio;
        private Label lblGestion;
        private RadioButton rbTransferencia;
        private RadioButton rbEfectivo;
        private Label lblMonto;
        private TextBox txtMonto;
        private ComboBox cbxGestion;
    }
}