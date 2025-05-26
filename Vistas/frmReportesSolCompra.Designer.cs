
namespace AppBogedaTeo.Vistas
{
    partial class frmReportesSolCompra
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
            this.panelBus = new System.Windows.Forms.Panel();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCantObs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantTerminado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantRegis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantAnulados = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSumImp = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbBusEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusColSolCompra = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbBusProveedores = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtBusFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtBusFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBuscarOP = new System.Windows.Forms.Button();
            this.dgvSolCompra = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panelBus.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBus
            // 
            this.panelBus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelBus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBus.Controls.Add(this.btnExportPDF);
            this.panelBus.Controls.Add(this.btnExportExcel);
            this.panelBus.Controls.Add(this.panel1);
            this.panelBus.Controls.Add(this.cmbBusEstado);
            this.panelBus.Controls.Add(this.label3);
            this.panelBus.Controls.Add(this.txtBusColSolCompra);
            this.panelBus.Controls.Add(this.label15);
            this.panelBus.Controls.Add(this.cmbBusProveedores);
            this.panelBus.Controls.Add(this.label13);
            this.panelBus.Controls.Add(this.dtBusFechaFinal);
            this.panelBus.Controls.Add(this.label2);
            this.panelBus.Controls.Add(this.dtBusFechaInicio);
            this.panelBus.Controls.Add(this.label1);
            this.panelBus.Controls.Add(this.label14);
            this.panelBus.Controls.Add(this.btnBuscarOP);
            this.panelBus.Controls.Add(this.dgvSolCompra);
            this.panelBus.Controls.Add(this.label8);
            this.panelBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBus.Location = new System.Drawing.Point(0, 0);
            this.panelBus.Name = "panelBus";
            this.panelBus.Size = new System.Drawing.Size(1094, 799);
            this.panelBus.TabIndex = 4;
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.Location = new System.Drawing.Point(821, 213);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(175, 34);
            this.btnExportPDF.TabIndex = 90;
            this.btnExportPDF.Text = "Exportar a PDF";
            this.btnExportPDF.UseVisualStyleBackColor = false;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Location = new System.Drawing.Point(821, 161);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(175, 34);
            this.btnExportExcel.TabIndex = 89;
            this.btnExportExcel.Text = "Exportar a Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCantObs);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtCantTerminado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCantRegis);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCantAnulados);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSumImp);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 304);
            this.panel1.TabIndex = 72;
            // 
            // txtCantObs
            // 
            this.txtCantObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantObs.Location = new System.Drawing.Point(506, 159);
            this.txtCantObs.Name = "txtCantObs";
            this.txtCantObs.ReadOnly = true;
            this.txtCantObs.Size = new System.Drawing.Size(490, 24);
            this.txtCantObs.TabIndex = 91;
            this.txtCantObs.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 24);
            this.label9.TabIndex = 90;
            this.label9.Text = "Cantidad Anulados:";
            // 
            // txtCantTerminado
            // 
            this.txtCantTerminado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantTerminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantTerminado.Location = new System.Drawing.Point(506, 111);
            this.txtCantTerminado.Name = "txtCantTerminado";
            this.txtCantTerminado.ReadOnly = true;
            this.txtCantTerminado.Size = new System.Drawing.Size(490, 24);
            this.txtCantTerminado.TabIndex = 89;
            this.txtCantTerminado.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 24);
            this.label5.TabIndex = 88;
            this.label5.Text = "Cantidad Terminados con Observación:";
            // 
            // txtCantRegis
            // 
            this.txtCantRegis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantRegis.Location = new System.Drawing.Point(506, 207);
            this.txtCantRegis.Name = "txtCantRegis";
            this.txtCantRegis.ReadOnly = true;
            this.txtCantRegis.Size = new System.Drawing.Size(490, 24);
            this.txtCantRegis.TabIndex = 85;
            this.txtCantRegis.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 24);
            this.label7.TabIndex = 84;
            this.label7.Text = "Cantidad de Registros:";
            // 
            // txtCantAnulados
            // 
            this.txtCantAnulados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantAnulados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantAnulados.Location = new System.Drawing.Point(506, 63);
            this.txtCantAnulados.Name = "txtCantAnulados";
            this.txtCantAnulados.ReadOnly = true;
            this.txtCantAnulados.Size = new System.Drawing.Size(490, 24);
            this.txtCantAnulados.TabIndex = 83;
            this.txtCantAnulados.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 24);
            this.label6.TabIndex = 82;
            this.label6.Text = "Cantidad Terminados:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 81;
            this.label10.Text = "Resumen";
            // 
            // txtSumImp
            // 
            this.txtSumImp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumImp.Location = new System.Drawing.Point(506, 257);
            this.txtSumImp.Name = "txtSumImp";
            this.txtSumImp.ReadOnly = true;
            this.txtSumImp.Size = new System.Drawing.Size(490, 24);
            this.txtSumImp.TabIndex = 69;
            this.txtSumImp.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(24, 255);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(194, 24);
            this.label20.TabIndex = 68;
            this.label20.Text = "Importe Total Pagado:";
            // 
            // cmbBusEstado
            // 
            this.cmbBusEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusEstado.FormattingEnabled = true;
            this.cmbBusEstado.Location = new System.Drawing.Point(28, 192);
            this.cmbBusEstado.Name = "cmbBusEstado";
            this.cmbBusEstado.Size = new System.Drawing.Size(332, 26);
            this.cmbBusEstado.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 70;
            this.label3.Text = "Estado";
            // 
            // txtBusColSolCompra
            // 
            this.txtBusColSolCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusColSolCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusColSolCompra.Location = new System.Drawing.Point(24, 70);
            this.txtBusColSolCompra.Name = "txtBusColSolCompra";
            this.txtBusColSolCompra.Size = new System.Drawing.Size(332, 24);
            this.txtBusColSolCompra.TabIndex = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(20, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(221, 24);
            this.label15.TabIndex = 67;
            this.label15.Text = "Nro. Solicitud de Compra";
            // 
            // cmbBusProveedores
            // 
            this.cmbBusProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBusProveedores.FormattingEnabled = true;
            this.cmbBusProveedores.Location = new System.Drawing.Point(382, 68);
            this.cmbBusProveedores.Name = "cmbBusProveedores";
            this.cmbBusProveedores.Size = new System.Drawing.Size(321, 26);
            this.cmbBusProveedores.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(378, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 24);
            this.label13.TabIndex = 65;
            this.label13.Text = "Proveedores";
            // 
            // dtBusFechaFinal
            // 
            this.dtBusFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBusFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBusFechaFinal.Location = new System.Drawing.Point(382, 128);
            this.dtBusFechaFinal.Name = "dtBusFechaFinal";
            this.dtBusFechaFinal.Size = new System.Drawing.Size(321, 24);
            this.dtBusFechaFinal.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(378, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "Fecha Final:";
            // 
            // dtBusFechaInicio
            // 
            this.dtBusFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBusFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBusFechaInicio.Location = new System.Drawing.Point(24, 128);
            this.dtBusFechaInicio.Name = "dtBusFechaInicio";
            this.dtBusFechaInicio.Size = new System.Drawing.Size(332, 24);
            this.dtBusFechaInicio.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 61;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(20, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(279, 24);
            this.label14.TabIndex = 45;
            this.label14.Text = "Reporte Solicitud de Compra";
            // 
            // btnBuscarOP
            // 
            this.btnBuscarOP.BackColor = System.Drawing.Color.Sienna;
            this.btnBuscarOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarOP.ForeColor = System.Drawing.Color.White;
            this.btnBuscarOP.Location = new System.Drawing.Point(821, 65);
            this.btnBuscarOP.Name = "btnBuscarOP";
            this.btnBuscarOP.Size = new System.Drawing.Size(175, 32);
            this.btnBuscarOP.TabIndex = 43;
            this.btnBuscarOP.Text = "Buscar";
            this.btnBuscarOP.UseVisualStyleBackColor = false;
            this.btnBuscarOP.Click += new System.EventHandler(this.btnBuscarOP_Click);
            // 
            // dgvSolCompra
            // 
            this.dgvSolCompra.AllowUserToAddRows = false;
            this.dgvSolCompra.AllowUserToDeleteRows = false;
            this.dgvSolCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvSolCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSolCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolCompra.Location = new System.Drawing.Point(14, 266);
            this.dgvSolCompra.MultiSelect = false;
            this.dgvSolCompra.Name = "dgvSolCompra";
            this.dgvSolCompra.ReadOnly = true;
            this.dgvSolCompra.RowHeadersWidth = 51;
            this.dgvSolCompra.Size = new System.Drawing.Size(982, 209);
            this.dgvSolCompra.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Solicitudes de Compra";
            // 
            // frmReportesSolCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 799);
            this.Controls.Add(this.panelBus);
            this.Name = "frmReportesSolCompra";
            this.Text = "frmReportesSolCompra";
            this.panelBus.ResumeLayout(false);
            this.panelBus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSumImp;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbBusEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusColSolCompra;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbBusProveedores;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtBusFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtBusFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBuscarOP;
        private System.Windows.Forms.DataGridView dgvSolCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantRegis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantAnulados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantObs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantTerminado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExportPDF;
        private System.Windows.Forms.Button btnExportExcel;
    }
}