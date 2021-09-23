
namespace Cafetal1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBx_Total_venta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.txtbx_pagototal_recolectores = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Louis George Café", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(414, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese total de la venta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtBx_Total_venta
            // 
            this.TxtBx_Total_venta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.TxtBx_Total_venta.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Total_venta.Location = new System.Drawing.Point(420, 296);
            this.TxtBx_Total_venta.Name = "TxtBx_Total_venta";
            this.TxtBx_Total_venta.Size = new System.Drawing.Size(352, 27);
            this.TxtBx_Total_venta.TabIndex = 1;
            this.TxtBx_Total_venta.TextChanged += new System.EventHandler(this.TxtBx_Total_venta_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Louis George Café", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(778, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "$";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIngresar.Font = new System.Drawing.Font("Louis George Café", 18F, System.Drawing.FontStyle.Bold);
            this.BtnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.BtnIngresar.Location = new System.Drawing.Point(813, 281);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(141, 48);
            this.BtnIngresar.TabIndex = 3;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cancel.Font = new System.Drawing.Font("Louis George Café", 18F, System.Drawing.FontStyle.Bold);
            this.Btn_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.Btn_Cancel.Location = new System.Drawing.Point(960, 281);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(141, 48);
            this.Btn_Cancel.TabIndex = 4;
            this.Btn_Cancel.Text = "Cancelar";
            this.Btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // txtbx_pagototal_recolectores
            // 
            this.txtbx_pagototal_recolectores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.txtbx_pagototal_recolectores.Font = new System.Drawing.Font("Louis George Café", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_pagototal_recolectores.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbx_pagototal_recolectores.Location = new System.Drawing.Point(420, 427);
            this.txtbx_pagototal_recolectores.Name = "txtbx_pagototal_recolectores";
            this.txtbx_pagototal_recolectores.Size = new System.Drawing.Size(681, 36);
            this.txtbx_pagototal_recolectores.TabIndex = 5;
            this.txtbx_pagototal_recolectores.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_registrar.Font = new System.Drawing.Font("Louis George Café", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btn_registrar.Location = new System.Drawing.Point(420, 578);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(681, 47);
            this.btn_registrar.TabIndex = 6;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txtbx_pagototal_recolectores);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBx_Total_venta);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registrar Producción";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBx_Total_venta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.TextBox txtbx_pagototal_recolectores;
        private System.Windows.Forms.Button btn_registrar;
    }
}

