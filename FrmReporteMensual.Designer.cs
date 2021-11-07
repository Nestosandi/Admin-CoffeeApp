
namespace InterfazFincaCafetera_Borr
{
    partial class FrmReporteMensual
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
            this.CalendarioReporteMensual = new System.Windows.Forms.MonthCalendar();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btn3Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(152, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // CalendarioReporteMensual
            // 
            this.CalendarioReporteMensual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.CalendarioReporteMensual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.CalendarioReporteMensual.Location = new System.Drawing.Point(156, 129);
            this.CalendarioReporteMensual.Margin = new System.Windows.Forms.Padding(7);
            this.CalendarioReporteMensual.Name = "CalendarioReporteMensual";
            this.CalendarioReporteMensual.TabIndex = 1;
            this.CalendarioReporteMensual.TrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnMostrar.Location = new System.Drawing.Point(156, 300);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(109, 29);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            // 
            // btn3Cancelar
            // 
            this.btn3Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btn3Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3Cancelar.Font = new System.Drawing.Font("Louis George Café", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btn3Cancelar.Location = new System.Drawing.Point(289, 300);
            this.btn3Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn3Cancelar.Name = "btn3Cancelar";
            this.btn3Cancelar.Size = new System.Drawing.Size(115, 29);
            this.btn3Cancelar.TabIndex = 3;
            this.btn3Cancelar.Text = "Cancelar";
            this.btn3Cancelar.UseVisualStyleBackColor = false;
            this.btn3Cancelar.Click += new System.EventHandler(this.btn3Cancelar_Click);
            // 
            // FrmReporteMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(586, 409);
            this.Controls.Add(this.btn3Cancelar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.CalendarioReporteMensual);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReporteMensual";
            this.Text = "Reporte mensual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar CalendarioReporteMensual;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btn3Cancelar;
    }
}