namespace RecibosWin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGenerarPDF = new System.Windows.Forms.Button();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            this.cbxAnio = new System.Windows.Forms.ComboBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGestion = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnVerHistorial = new System.Windows.Forms.Button();
            this.lblColegio = new System.Windows.Forms.Label();
            this.cbxColegio = new System.Windows.Forms.ComboBox();
            this.dgvTemp = new System.Windows.Forms.DataGridView();
            this.lblNumeroRecibo = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbTransferencia = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerarPDF
            // 
            this.btnGenerarPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerarPDF.Location = new System.Drawing.Point(674, 588);
            this.btnGenerarPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerarPDF.Name = "btnGenerarPDF";
            this.btnGenerarPDF.Size = new System.Drawing.Size(193, 82);
            this.btnGenerarPDF.TabIndex = 0;
            this.btnGenerarPDF.Text = "Generar PDF";
            this.btnGenerarPDF.UseVisualStyleBackColor = true;
            this.btnGenerarPDF.Click += new System.EventHandler(this.btnGenerarPDF_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(176, 48);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(526, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "GENERADOR DE RECIBOS EN PDF";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(31, 234);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 25);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "del mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "del año";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(47, 388);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(176, 25);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre del alumno:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(374, 284);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(70, 25);
            this.lblMonto.TabIndex = 6;
            this.lblMonto.Text = "Monto:";
            // 
            // cbxDia
            // 
            this.cbxDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbxDia.Location = new System.Drawing.Point(102, 226);
            this.cbxDia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(80, 33);
            this.cbxDia.TabIndex = 7;
            // 
            // cbxMes
            // 
            this.cbxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.Items.AddRange(new object[] {
            "enero",
            "febrero",
            "marzo",
            "abril",
            "mayo",
            "junio",
            "julio",
            "agosto",
            "septiembre",
            "octubre",
            "noviembre",
            "diciembre"});
            this.cbxMes.Location = new System.Drawing.Point(272, 226);
            this.cbxMes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(171, 33);
            this.cbxMes.TabIndex = 8;
            // 
            // cbxAnio
            // 
            this.cbxAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnio.FormattingEnabled = true;
            this.cbxAnio.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbxAnio.Location = new System.Drawing.Point(530, 226);
            this.cbxAnio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxAnio.Name = "cbxAnio";
            this.cbxAnio.Size = new System.Drawing.Size(113, 33);
            this.cbxAnio.TabIndex = 9;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(231, 388);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(470, 31);
            this.txtNombreCliente.TabIndex = 10;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(452, 283);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(141, 31);
            this.txtMonto.TabIndex = 11;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(47, 462);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(169, 25);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Codigo del alumno:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(49, 523);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(62, 25);
            this.lblCurso.TabIndex = 13;
            this.lblCurso.Text = "Curso:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(232, 462);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(178, 31);
            this.txtCodigo.TabIndex = 14;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(147, 520);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(205, 31);
            this.txtCurso.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gestion:";
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
            this.cbxGestion.Location = new System.Drawing.Point(728, 284);
            this.cbxGestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxGestion.Name = "cbxGestion";
            this.cbxGestion.Size = new System.Drawing.Size(113, 33);
            this.cbxGestion.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(898, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnVerHistorial
            // 
            this.btnVerHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerHistorial.Location = new System.Drawing.Point(433, 610);
            this.btnVerHistorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerHistorial.Name = "btnVerHistorial";
            this.btnVerHistorial.Size = new System.Drawing.Size(207, 60);
            this.btnVerHistorial.TabIndex = 19;
            this.btnVerHistorial.Text = "Ver historial de recibos";
            this.btnVerHistorial.UseVisualStyleBackColor = true;
            this.btnVerHistorial.Click += new System.EventHandler(this.btnVerHistorial_Click);
            // 
            // lblColegio
            // 
            this.lblColegio.AutoSize = true;
            this.lblColegio.Location = new System.Drawing.Point(31, 284);
            this.lblColegio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColegio.Name = "lblColegio";
            this.lblColegio.Size = new System.Drawing.Size(77, 25);
            this.lblColegio.TabIndex = 20;
            this.lblColegio.Text = "Colegio:";
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
            "Jardin Materday",
            "Jardin Gabrielito",
            "Jardin Huellitas",
            "Jesus Maestro",
            "Juan Pablo II",
            "Marista",
            "Maria Goretti",
            "La Salle Tarde",
            "Señor Jesus",
            "Uboldi"});
            this.cbxColegio.Location = new System.Drawing.Point(116, 281);
            this.cbxColegio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxColegio.Name = "cbxColegio";
            this.cbxColegio.Size = new System.Drawing.Size(236, 33);
            this.cbxColegio.TabIndex = 21;
            this.cbxColegio.TextChanged += new System.EventHandler(this.cbxColegio_TextChanged);
            // 
            // dgvTemp
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTemp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTemp.Location = new System.Drawing.Point(708, 88);
            this.dgvTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTemp.Name = "dgvTemp";
            this.dgvTemp.RowHeadersWidth = 62;
            this.dgvTemp.RowTemplate.Height = 25;
            this.dgvTemp.Size = new System.Drawing.Size(159, 97);
            this.dgvTemp.TabIndex = 22;
            this.dgvTemp.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTemp_CellValueChanged);
            // 
            // lblNumeroRecibo
            // 
            this.lblNumeroRecibo.AutoSize = true;
            this.lblNumeroRecibo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumeroRecibo.Location = new System.Drawing.Point(47, 131);
            this.lblNumeroRecibo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroRecibo.Name = "lblNumeroRecibo";
            this.lblNumeroRecibo.Size = new System.Drawing.Size(86, 40);
            this.lblNumeroRecibo.TabIndex = 23;
            this.lblNumeroRecibo.Text = "Nro. ";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(275, 131);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(107, 38);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(898, 33);
            this.menuStrip2.TabIndex = 25;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(147, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // rbTransferencia
            // 
            this.rbTransferencia.AutoSize = true;
            this.rbTransferencia.Location = new System.Drawing.Point(374, 330);
            this.rbTransferencia.Name = "rbTransferencia";
            this.rbTransferencia.Size = new System.Drawing.Size(138, 29);
            this.rbTransferencia.TabIndex = 26;
            this.rbTransferencia.TabStop = true;
            this.rbTransferencia.Text = "Transferencia";
            this.rbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Location = new System.Drawing.Point(530, 330);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(99, 29);
            this.rbEfectivo.TabIndex = 27;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 697);
            this.Controls.Add(this.rbEfectivo);
            this.Controls.Add(this.rbTransferencia);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblNumeroRecibo);
            this.Controls.Add(this.dgvTemp);
            this.Controls.Add(this.cbxColegio);
            this.Controls.Add(this.lblColegio);
            this.Controls.Add(this.btnVerHistorial);
            this.Controls.Add(this.cbxGestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.cbxAnio);
            this.Controls.Add(this.cbxMes);
            this.Controls.Add(this.cbxDia);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGenerarPDF);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Generador de recibos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerarPDF;
        private SaveFileDialog sfdGuardar;
        private Label lblTitle;
        private Label lblFecha;
        private Label label3;
        private Label label4;
        private Label lblNombre;
        private Label lblMonto;
        private ComboBox cbxDia;
        private ComboBox cbxMes;
        private ComboBox cbxAnio;
        private TextBox txtNombreCliente;
        private TextBox txtMonto;
        private Label lblCodigo;
        private Label lblCurso;
        private TextBox txtCodigo;
        private TextBox txtCurso;
        private Label label1;
        private ComboBox cbxGestion;
        private MenuStrip menuStrip1;
        private Button btnVerHistorial;
        private Label lblColegio;
        private ComboBox cbxColegio;
        private DataGridView dgvTemp;
        private Label lblNumeroRecibo;
        private Button btnActualizar;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private RadioButton rbTransferencia;
        private RadioButton rbEfectivo;
    }
}