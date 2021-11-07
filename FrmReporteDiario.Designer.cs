
namespace InterfazFincaCafetera_Borr
{
    partial class FrmReporteDiario
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
            this.btnRDcancelar = new System.Windows.Forms.Button();
            this.btnRDMostrar = new System.Windows.Forms.Button();
            this.CalendarioReporteDiario = new System.Windows.Forms.MonthCalendar();
            this.LblFecha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRDcancelar
            // 
            this.btnRDcancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btnRDcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRDcancelar.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRDcancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnRDcancelar.Location = new System.Drawing.Point(299, 294);
            this.btnRDcancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRDcancelar.Name = "btnRDcancelar";
            this.btnRDcancelar.Size = new System.Drawing.Size(115, 29);
            this.btnRDcancelar.TabIndex = 7;
            this.btnRDcancelar.Text = "Cancelar";
            this.btnRDcancelar.UseVisualStyleBackColor = false;
            this.btnRDcancelar.Click += new System.EventHandler(this.btnRDcancelar_Click);
            // 
            // btnRDMostrar
            // 
            this.btnRDMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btnRDMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRDMostrar.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRDMostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnRDMostrar.Location = new System.Drawing.Point(166, 294);
            this.btnRDMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRDMostrar.Name = "btnRDMostrar";
            this.btnRDMostrar.Size = new System.Drawing.Size(109, 29);
            this.btnRDMostrar.TabIndex = 6;
            this.btnRDMostrar.Text = "Mostrar";
            this.btnRDMostrar.UseVisualStyleBackColor = false;
            this.btnRDMostrar.Click += new System.EventHandler(this.btnRDMostrar_Click);
            // 
            // CalendarioReporteDiario
            // 
            this.CalendarioReporteDiario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.CalendarioReporteDiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.CalendarioReporteDiario.Location = new System.Drawing.Point(166, 123);
            this.CalendarioReporteDiario.Margin = new System.Windows.Forms.Padding(7);
            this.CalendarioReporteDiario.Name = "CalendarioReporteDiario";
            this.CalendarioReporteDiario.TabIndex = 5;
            this.CalendarioReporteDiario.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.LblFecha.Location = new System.Drawing.Point(162, 85);
            this.LblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(51, 19);
            this.LblFecha.TabIndex = 4;
            this.LblFecha.Text = "Fecha";
            // 
            // FrmReporteDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(586, 409);
            this.Controls.Add(this.btnRDcancelar);
            this.Controls.Add(this.btnRDMostrar);
            this.Controls.Add(this.CalendarioReporteDiario);
            this.Controls.Add(this.LblFecha);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReporteDiario";
            this.Text = "Reporte diario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRDcancelar;
        private System.Windows.Forms.Button btnRDMostrar;
        private System.Windows.Forms.MonthCalendar CalendarioReporteDiario;
        private System.Windows.Forms.Label LblFecha;
    }
}