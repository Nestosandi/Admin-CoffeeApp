
namespace InterfazFincaCafetera_Borr
{
    partial class FrmRegistrarRecolector
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.DgvRecolectores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecolectores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(17, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Celular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(16, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cédula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(11, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = " Fecha de inscripción";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 66);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(104, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(20, 136);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(104, 20);
            this.txtCelular.TabIndex = 4;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(20, 203);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(104, 20);
            this.txtCedula.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnRegistrar.Location = new System.Drawing.Point(21, 329);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(141, 35);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnCancelar.Location = new System.Drawing.Point(166, 329);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 35);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // DtFecha
            // 
            this.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFecha.Location = new System.Drawing.Point(21, 270);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(169, 20);
            this.DtFecha.TabIndex = 11;
            // 
            // DgvRecolectores
            // 
            this.DgvRecolectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecolectores.Location = new System.Drawing.Point(184, 66);
            this.DgvRecolectores.Name = "DgvRecolectores";
            this.DgvRecolectores.Size = new System.Drawing.Size(393, 157);
            this.DgvRecolectores.TabIndex = 12;
            // 
            // FrmRegistrarRecolector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(617, 409);
            this.Controls.Add(this.DgvRecolectores);
            this.Controls.Add(this.DtFecha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRegistrarRecolector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar recolector";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecolectores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker DtFecha;
        private System.Windows.Forms.DataGridView DgvRecolectores;
    }
}