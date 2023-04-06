namespace RecibosWin
{
    partial class frmHistoriall
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxFiltro = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvN = new System.Windows.Forms.DataGridView();
            this.mStripHistoriall = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdExportar = new System.Windows.Forms.SaveFileDialog();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxActualizar = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.rbTransferencia = new System.Windows.Forms.RadioButton();
            this.cbxGestionH = new System.Windows.Forms.ComboBox();
            this.cbxColegioH = new System.Windows.Forms.ComboBox();
            this.txtCursoH = new System.Windows.Forms.TextBox();
            this.txtNombreH = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblGestion = new System.Windows.Forms.Label();
            this.lblColegio = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvN)).BeginInit();
            this.mStripHistoriall.SuspendLayout();
            this.gbxActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(414, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(416, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HISTORIAL DE RECIBOS";
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInsertar.Location = new System.Drawing.Point(1021, 170);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(149, 72);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar datos";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.Location = new System.Drawing.Point(1021, 252);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(147, 77);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar datos seleccionados";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReload.Location = new System.Drawing.Point(1019, 580);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(149, 85);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Actualizar campos";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(80, 98);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(67, 25);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(183, 92);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(530, 31);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // cbxFiltro
            // 
            this.cbxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltro.FormattingEnabled = true;
            this.cbxFiltro.Items.AddRange(new object[] {
            "Numero de recibo",
            "Nombre del alumno",
            "Curso",
            "Colegio",
            "Gestion",
            "Fecha de creacion"});
            this.cbxFiltro.Location = new System.Drawing.Point(769, 90);
            this.cbxFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxFiltro.Name = "cbxFiltro";
            this.cbxFiltro.Size = new System.Drawing.Size(187, 33);
            this.cbxFiltro.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(1031, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 31);
            this.textBox1.TabIndex = 9;
            // 
            // dgvN
            // 
            this.dgvN.AllowUserToAddRows = false;
            this.dgvN.AllowUserToDeleteRows = false;
            this.dgvN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvN.Location = new System.Drawing.Point(34, 147);
            this.dgvN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvN.Name = "dgvN";
            this.dgvN.ReadOnly = true;
            this.dgvN.RowHeadersWidth = 62;
            this.dgvN.RowTemplate.Height = 25;
            this.dgvN.Size = new System.Drawing.Size(957, 571);
            this.dgvN.TabIndex = 10;
            this.dgvN.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDatosS_RowHeaderMouseClick);
            // 
            // mStripHistoriall
            // 
            this.mStripHistoriall.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mStripHistoriall.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.mStripHistoriall.Location = new System.Drawing.Point(0, 0);
            this.mStripHistoriall.Name = "mStripHistoriall";
            this.mStripHistoriall.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mStripHistoriall.Size = new System.Drawing.Size(1219, 35);
            this.mStripHistoriall.TabIndex = 11;
            this.mStripHistoriall.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.exportarToolStripMenuItem.Text = "Exportar";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdate.Location = new System.Drawing.Point(1021, 337);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 77);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Actualizar datos seleccionados";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbxActualizar
            // 
            this.gbxActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxActualizar.Controls.Add(this.txtMonto);
            this.gbxActualizar.Controls.Add(this.lblMonto);
            this.gbxActualizar.Controls.Add(this.rbEfectivo);
            this.gbxActualizar.Controls.Add(this.rbTransferencia);
            this.gbxActualizar.Controls.Add(this.cbxGestionH);
            this.gbxActualizar.Controls.Add(this.cbxColegioH);
            this.gbxActualizar.Controls.Add(this.txtCursoH);
            this.gbxActualizar.Controls.Add(this.txtNombreH);
            this.gbxActualizar.Controls.Add(this.btnCancelar);
            this.gbxActualizar.Controls.Add(this.btnActualizar);
            this.gbxActualizar.Controls.Add(this.lblGestion);
            this.gbxActualizar.Controls.Add(this.lblColegio);
            this.gbxActualizar.Controls.Add(this.lblCurso);
            this.gbxActualizar.Controls.Add(this.lblNombre);
            this.gbxActualizar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbxActualizar.Location = new System.Drawing.Point(0, 752);
            this.gbxActualizar.Name = "gbxActualizar";
            this.gbxActualizar.Size = new System.Drawing.Size(1219, 194);
            this.gbxActualizar.TabIndex = 13;
            this.gbxActualizar.TabStop = false;
            this.gbxActualizar.Text = "Actualizar datos";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(132, 135);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(150, 31);
            this.txtMonto.TabIndex = 13;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(50, 135);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(66, 25);
            this.lblMonto.TabIndex = 12;
            this.lblMonto.Text = "Monto";
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(494, 137);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(99, 29);
            this.rbEfectivo.TabIndex = 11;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTransferencia
            // 
            this.rbTransferencia.AutoSize = true;
            this.rbTransferencia.Location = new System.Drawing.Point(322, 137);
            this.rbTransferencia.Name = "rbTransferencia";
            this.rbTransferencia.Size = new System.Drawing.Size(138, 29);
            this.rbTransferencia.TabIndex = 10;
            this.rbTransferencia.TabStop = true;
            this.rbTransferencia.Text = "Transferencia";
            this.rbTransferencia.UseVisualStyleBackColor = true;
            // 
            // cbxGestionH
            // 
            this.cbxGestionH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGestionH.FormattingEnabled = true;
            this.cbxGestionH.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbxGestionH.Location = new System.Drawing.Point(692, 93);
            this.cbxGestionH.Name = "cbxGestionH";
            this.cbxGestionH.Size = new System.Drawing.Size(112, 33);
            this.cbxGestionH.TabIndex = 9;
            // 
            // cbxColegioH
            // 
            this.cbxColegioH.FormattingEnabled = true;
            this.cbxColegioH.Items.AddRange(new object[] {
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
            this.cbxColegioH.Location = new System.Drawing.Point(692, 42);
            this.cbxColegioH.Name = "cbxColegioH";
            this.cbxColegioH.Size = new System.Drawing.Size(264, 33);
            this.cbxColegioH.TabIndex = 8;
            this.cbxColegioH.TextChanged += new System.EventHandler(this.cbxColegioH_TextChanged);
            // 
            // txtCursoH
            // 
            this.txtCursoH.Location = new System.Drawing.Point(132, 84);
            this.txtCursoH.Name = "txtCursoH";
            this.txtCursoH.Size = new System.Drawing.Size(150, 31);
            this.txtCursoH.TabIndex = 7;
            // 
            // txtNombreH
            // 
            this.txtNombreH.Location = new System.Drawing.Point(132, 37);
            this.txtNombreH.Name = "txtNombreH";
            this.txtNombreH.Size = new System.Drawing.Size(430, 31);
            this.txtNombreH.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(925, 148);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(1058, 148);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 34);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.Location = new System.Drawing.Point(603, 93);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(72, 25);
            this.lblGestion.TabIndex = 3;
            this.lblGestion.Text = "Gestion";
            // 
            // lblColegio
            // 
            this.lblColegio.AutoSize = true;
            this.lblColegio.Location = new System.Drawing.Point(602, 42);
            this.lblColegio.Name = "lblColegio";
            this.lblColegio.Size = new System.Drawing.Size(73, 25);
            this.lblColegio.TabIndex = 2;
            this.lblColegio.Text = "Colegio";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(50, 84);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(58, 25);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(38, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // frmHistoriall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 946);
            this.Controls.Add(this.gbxActualizar);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvN);
            this.Controls.Add(this.cbxFiltro);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mStripHistoriall);
            this.MainMenuStrip = this.mStripHistoriall;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHistoriall";
            this.Text = "Historial de recibos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHistoriall_FormClosing);
            this.Load += new System.EventHandler(this.frmHistoriall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvN)).EndInit();
            this.mStripHistoriall.ResumeLayout(false);
            this.mStripHistoriall.PerformLayout();
            this.gbxActualizar.ResumeLayout(false);
            this.gbxActualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnReload;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private ComboBox cbxFiltro;
        
        public TextBox textBox1;
        public  DataGridView dgvN;
        private MenuStrip mStripHistoriall;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem imprimirToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private SaveFileDialog sfdExportar;
        private Button btnUpdate;
        private GroupBox gbxActualizar;
        private ComboBox cbxGestionH;
        private ComboBox cbxColegioH;
        private TextBox txtCursoH;
        private TextBox txtNombreH;
        private Button btnCancelar;
        private Button btnActualizar;
        private Label lblGestion;
        private Label lblColegio;
        private Label lblCurso;
        private Label lblNombre;
        private TextBox txtMonto;
        private Label lblMonto;
        private RadioButton rbEfectivo;
        private RadioButton rbTransferencia;
    }
}