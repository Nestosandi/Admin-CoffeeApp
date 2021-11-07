
namespace InterfazFincaCafetera_Borr
{
    partial class FrmInformacionEmpleado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNombreRecolector = new System.Windows.Forms.ComboBox();
            this.txtCantidadRecogida = new System.Windows.Forms.TextBox();
            this.txtCantidadTotaldeCafeRecogido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal_A_Pagar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Louis George Café", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(42, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del recolector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Louis George Café", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(42, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad recogida a la fecha";
            // 
            // cmbNombreRecolector
            // 
            this.cmbNombreRecolector.FormattingEnabled = true;
            this.cmbNombreRecolector.Location = new System.Drawing.Point(47, 71);
            this.cmbNombreRecolector.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNombreRecolector.Name = "cmbNombreRecolector";
            this.cmbNombreRecolector.Size = new System.Drawing.Size(202, 21);
            this.cmbNombreRecolector.TabIndex = 4;
            // 
            // txtCantidadRecogida
            // 
            this.txtCantidadRecogida.Enabled = false;
            this.txtCantidadRecogida.Location = new System.Drawing.Point(46, 134);
            this.txtCantidadRecogida.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadRecogida.Multiline = true;
            this.txtCantidadRecogida.Name = "txtCantidadRecogida";
            this.txtCantidadRecogida.Size = new System.Drawing.Size(259, 30);
            this.txtCantidadRecogida.TabIndex = 5;
            // 
            // txtCantidadTotaldeCafeRecogido
            // 
            this.txtCantidadTotaldeCafeRecogido.Enabled = false;
            this.txtCantidadTotaldeCafeRecogido.Location = new System.Drawing.Point(45, 206);
            this.txtCantidadTotaldeCafeRecogido.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidadTotaldeCafeRecogido.Multiline = true;
            this.txtCantidadTotaldeCafeRecogido.Name = "txtCantidadTotaldeCafeRecogido";
            this.txtCantidadTotaldeCafeRecogido.Size = new System.Drawing.Size(284, 33);
            this.txtCantidadTotaldeCafeRecogido.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Louis George Café", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(42, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad de café total recogido";
            // 
            // txtTotal_A_Pagar
            // 
            this.txtTotal_A_Pagar.Enabled = false;
            this.txtTotal_A_Pagar.Location = new System.Drawing.Point(48, 279);
            this.txtTotal_A_Pagar.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal_A_Pagar.Multiline = true;
            this.txtTotal_A_Pagar.Name = "txtTotal_A_Pagar";
            this.txtTotal_A_Pagar.Size = new System.Drawing.Size(161, 30);
            this.txtTotal_A_Pagar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Louis George Café", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(43, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total a pagar";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Louis George Café", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnRegresar.Location = new System.Drawing.Point(48, 332);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(117, 37);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmInformacionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(586, 409);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtTotal_A_Pagar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadTotaldeCafeRecogido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidadRecogida);
            this.Controls.Add(this.cmbNombreRecolector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmInformacionEmpleado";
            this.Text = "Información Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNombreRecolector;
        private System.Windows.Forms.TextBox txtCantidadRecogida;
        private System.Windows.Forms.TextBox txtCantidadTotaldeCafeRecogido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal_A_Pagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegresar;
    }
}