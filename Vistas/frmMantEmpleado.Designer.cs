
namespace AppBogedaTeo.Vistas
{
    partial class frmMantEmpleado
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
            this.panelBusUsu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCrearUsuInterno = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvUsuLista = new System.Windows.Forms.DataGridView();
            this.txtNomComBus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelMantUsu = new System.Windows.Forms.Panel();
            this.txtNomCom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMant = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBusUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuLista)).BeginInit();
            this.panelMantUsu.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBusUsu
            // 
            this.panelBusUsu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelBusUsu.Controls.Add(this.label4);
            this.panelBusUsu.Controls.Add(this.btnSeleccionar);
            this.panelBusUsu.Controls.Add(this.btnCrearUsuInterno);
            this.panelBusUsu.Controls.Add(this.btnBuscar);
            this.panelBusUsu.Controls.Add(this.dgvUsuLista);
            this.panelBusUsu.Controls.Add(this.txtNomComBus);
            this.panelBusUsu.Controls.Add(this.label9);
            this.panelBusUsu.Controls.Add(this.label8);
            this.panelBusUsu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusUsu.Location = new System.Drawing.Point(0, 0);
            this.panelBusUsu.Name = "panelBusUsu";
            this.panelBusUsu.Size = new System.Drawing.Size(1094, 341);
            this.panelBusUsu.TabIndex = 40;
            this.panelBusUsu.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 54;
            this.label4.Text = "Empleados";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(618, 172);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(182, 34);
            this.btnSeleccionar.TabIndex = 36;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCrearUsuInterno
            // 
            this.btnCrearUsuInterno.BackColor = System.Drawing.Color.Blue;
            this.btnCrearUsuInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuInterno.ForeColor = System.Drawing.Color.White;
            this.btnCrearUsuInterno.Location = new System.Drawing.Point(430, 172);
            this.btnCrearUsuInterno.Name = "btnCrearUsuInterno";
            this.btnCrearUsuInterno.Size = new System.Drawing.Size(182, 34);
            this.btnCrearUsuInterno.TabIndex = 35;
            this.btnCrearUsuInterno.Text = "Añadir Empleado";
            this.btnCrearUsuInterno.UseVisualStyleBackColor = false;
            this.btnCrearUsuInterno.Click += new System.EventHandler(this.btnCrearUsuInterno_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(618, 89);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(173, 34);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvUsuLista
            // 
            this.dgvUsuLista.AllowUserToAddRows = false;
            this.dgvUsuLista.AllowUserToDeleteRows = false;
            this.dgvUsuLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvUsuLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuLista.Location = new System.Drawing.Point(33, 209);
            this.dgvUsuLista.MultiSelect = false;
            this.dgvUsuLista.Name = "dgvUsuLista";
            this.dgvUsuLista.ReadOnly = true;
            this.dgvUsuLista.RowHeadersWidth = 51;
            this.dgvUsuLista.Size = new System.Drawing.Size(767, 126);
            this.dgvUsuLista.TabIndex = 33;
            // 
            // txtNomComBus
            // 
            this.txtNomComBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomComBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomComBus.Location = new System.Drawing.Point(34, 95);
            this.txtNomComBus.Name = "txtNomComBus";
            this.txtNomComBus.Size = new System.Drawing.Size(564, 24);
            this.txtNomComBus.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(31, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nombre Completos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "Buscar Empleado";
            // 
            // panelMantUsu
            // 
            this.panelMantUsu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMantUsu.Controls.Add(this.txtNomCom);
            this.panelMantUsu.Controls.Add(this.label3);
            this.panelMantUsu.Controls.Add(this.panel5);
            this.panelMantUsu.Controls.Add(this.cmbRol);
            this.panelMantUsu.Controls.Add(this.label7);
            this.panelMantUsu.Controls.Add(this.lblMant);
            this.panelMantUsu.Controls.Add(this.txtDNI);
            this.panelMantUsu.Controls.Add(this.txtContra);
            this.panelMantUsu.Controls.Add(this.txtCorreo);
            this.panelMantUsu.Controls.Add(this.label1);
            this.panelMantUsu.Controls.Add(this.label5);
            this.panelMantUsu.Controls.Add(this.label2);
            this.panelMantUsu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMantUsu.Location = new System.Drawing.Point(0, 341);
            this.panelMantUsu.Name = "panelMantUsu";
            this.panelMantUsu.Size = new System.Drawing.Size(1094, 416);
            this.panelMantUsu.TabIndex = 41;
            this.panelMantUsu.Visible = false;
            // 
            // txtNomCom
            // 
            this.txtNomCom.BackColor = System.Drawing.Color.White;
            this.txtNomCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomCom.Location = new System.Drawing.Point(445, 93);
            this.txtNomCom.Name = "txtNomCom";
            this.txtNomCom.Size = new System.Drawing.Size(581, 24);
            this.txtNomCom.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(441, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nombres Completos";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnVolver);
            this.panel5.Controls.Add(this.btnActualizar);
            this.panel5.Controls.Add(this.btnCrearCuenta);
            this.panel5.Location = new System.Drawing.Point(180, 335);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(418, 45);
            this.panel5.TabIndex = 40;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkCyan;
            this.btnVolver.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(287, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 45);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(148, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(139, 45);
            this.btnActualizar.TabIndex = 28;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCrearCuenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCrearCuenta.Location = new System.Drawing.Point(0, 0);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(148, 45);
            this.btnCrearCuenta.TabIndex = 27;
            this.btnCrearCuenta.Text = "Crear";
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Visible = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(33, 254);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(361, 26);
            this.cmbRol.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Rol";
            // 
            // lblMant
            // 
            this.lblMant.AutoSize = true;
            this.lblMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMant.ForeColor = System.Drawing.Color.White;
            this.lblMant.Location = new System.Drawing.Point(31, 15);
            this.lblMant.Name = "lblMant";
            this.lblMant.Size = new System.Drawing.Size(199, 24);
            this.lblMant.TabIndex = 29;
            this.lblMant.Text = "CREAR EMPLEADO";
            // 
            // txtDNI
            // 
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(34, 93);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(357, 24);
            this.txtDNI.TabIndex = 23;
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.White;
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(35, 171);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(357, 24);
            this.txtContra.TabIndex = 24;
            this.txtContra.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(445, 174);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(581, 24);
            this.txtCorreo.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(441, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Contraseña";
            // 
            // frmMantEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 757);
            this.Controls.Add(this.panelMantUsu);
            this.Controls.Add(this.panelBusUsu);
            this.Name = "frmMantEmpleado";
            this.Text = "frmMantEmpleado";
            this.panelBusUsu.ResumeLayout(false);
            this.panelBusUsu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuLista)).EndInit();
            this.panelMantUsu.ResumeLayout(false);
            this.panelMantUsu.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBusUsu;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCrearUsuInterno;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvUsuLista;
        private System.Windows.Forms.TextBox txtNomComBus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelMantUsu;
        private System.Windows.Forms.TextBox txtNomCom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMant;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}