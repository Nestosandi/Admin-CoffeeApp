
namespace Cafetal1
{
    partial class Estadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estadisticas));
            this.txtbx_ganancias_year = new System.Windows.Forms.TextBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx_ganancias_year
            // 
            this.txtbx_ganancias_year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.txtbx_ganancias_year.Font = new System.Drawing.Font("Louis George Café", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_ganancias_year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.txtbx_ganancias_year.Location = new System.Drawing.Point(98, 55);
            this.txtbx_ganancias_year.Name = "txtbx_ganancias_year";
            this.txtbx_ganancias_year.Size = new System.Drawing.Size(1412, 36);
            this.txtbx_ganancias_year.TabIndex = 1;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btn_regresar.Font = new System.Drawing.Font("Louis George Café", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btn_regresar.Location = new System.Drawing.Point(858, 737);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(139, 51);
            this.btn_regresar.TabIndex = 2;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.txtbx_ganancias_year);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estadisticas";
            this.Text = "Estadisticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_ganancias_year;
        private System.Windows.Forms.Button btn_regresar;
    }
}