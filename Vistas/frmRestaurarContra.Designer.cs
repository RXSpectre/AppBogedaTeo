
namespace AppBogedaTeo.Vistas
{
    partial class frmRestaurarContra
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
            this.btnValidarCodVerificación = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCodVeri = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodVeri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConfirmContra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.panelCodVeri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValidarCodVerificación
            // 
            this.btnValidarCodVerificación.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnValidarCodVerificación.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidarCodVerificación.ForeColor = System.Drawing.Color.White;
            this.btnValidarCodVerificación.Location = new System.Drawing.Point(393, 274);
            this.btnValidarCodVerificación.Name = "btnValidarCodVerificación";
            this.btnValidarCodVerificación.Size = new System.Drawing.Size(318, 34);
            this.btnValidarCodVerificación.TabIndex = 53;
            this.btnValidarCodVerificación.Text = "Restaurar ";
            this.btnValidarCodVerificación.UseVisualStyleBackColor = false;
            this.btnValidarCodVerificación.Click += new System.EventHandler(this.btnValidarCodVerificación_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkCyan;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(280, 331);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(206, 34);
            this.btnVolver.TabIndex = 52;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Location = new System.Drawing.Point(71, 274);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(316, 34);
            this.btnRestaurar.TabIndex = 51;
            this.btnRestaurar.Text = "Enviar Código al Correo";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(242, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "RESTAURAR CONTRASEÑA";
            // 
            // panelCodVeri
            // 
            this.panelCodVeri.Controls.Add(this.label7);
            this.panelCodVeri.Controls.Add(this.txtCodVeri);
            this.panelCodVeri.Location = new System.Drawing.Point(393, 154);
            this.panelCodVeri.Name = "panelCodVeri";
            this.panelCodVeri.Size = new System.Drawing.Size(408, 91);
            this.panelCodVeri.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(15, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Código Verificación";
            // 
            // txtCodVeri
            // 
            this.txtCodVeri.BackColor = System.Drawing.Color.White;
            this.txtCodVeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodVeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVeri.Location = new System.Drawing.Point(19, 56);
            this.txtCodVeri.MaxLength = 4;
            this.txtCodVeri.Name = "txtCodVeri";
            this.txtCodVeri.Size = new System.Drawing.Size(357, 24);
            this.txtCodVeri.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // txtConfirmContra
            // 
            this.txtConfirmContra.BackColor = System.Drawing.Color.White;
            this.txtConfirmContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmContra.Location = new System.Drawing.Point(11, 213);
            this.txtConfirmContra.Name = "txtConfirmContra";
            this.txtConfirmContra.Size = new System.Drawing.Size(357, 24);
            this.txtConfirmContra.TabIndex = 47;
            this.txtConfirmContra.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(406, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.White;
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(410, 124);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(357, 24);
            this.txtContra.TabIndex = 45;
            this.txtContra.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(10, 125);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(357, 24);
            this.txtDNI.TabIndex = 43;
            // 
            // frmRestaurarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(882, 377);
            this.Controls.Add(this.btnValidarCodVerificación);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelCodVeri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtConfirmContra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDNI);
            this.Name = "frmRestaurarContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRestaurarContra";
            this.panelCodVeri.ResumeLayout(false);
            this.panelCodVeri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidarCodVerificación;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelCodVeri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodVeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConfirmContra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
    }
}