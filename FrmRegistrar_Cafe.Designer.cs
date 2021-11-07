
namespace InterfazFincaCafetera_Borr
{
    partial class FrmRegistrar_Cafe
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
            this.btnRegistrarCafé = new System.Windows.Forms.Button();
            this.btnCancelCafé = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarCafé
            // 
            this.btnRegistrarCafé.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btnRegistrarCafé.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCafé.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.btnRegistrarCafé.FlatAppearance.BorderSize = 20;
            this.btnRegistrarCafé.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarCafé.Font = new System.Drawing.Font("Louis George Café", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCafé.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnRegistrarCafé.Location = new System.Drawing.Point(143, 150);
            this.btnRegistrarCafé.Name = "btnRegistrarCafé";
            this.btnRegistrarCafé.Size = new System.Drawing.Size(502, 165);
            this.btnRegistrarCafé.TabIndex = 0;
            this.btnRegistrarCafé.Text = "Registro Café";
            this.btnRegistrarCafé.UseVisualStyleBackColor = false;
            this.btnRegistrarCafé.Click += new System.EventHandler(this.btnRegistrarCafé_Click);
            // 
            // btnCancelCafé
            // 
            this.btnCancelCafé.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.btnCancelCafé.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelCafé.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelCafé.Font = new System.Drawing.Font("Louis George Café", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCafé.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(52)))), ((int)(((byte)(34)))));
            this.btnCancelCafé.Location = new System.Drawing.Point(143, 339);
            this.btnCancelCafé.Name = "btnCancelCafé";
            this.btnCancelCafé.Size = new System.Drawing.Size(502, 37);
            this.btnCancelCafé.TabIndex = 1;
            this.btnCancelCafé.Text = "Cancel";
            this.btnCancelCafé.UseVisualStyleBackColor = false;
            this.btnCancelCafé.Click += new System.EventHandler(this.btnCancelCafé_Click);
            // 
            // FrmRegistrar_Cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(214)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(780, 507);
            this.Controls.Add(this.btnCancelCafé);
            this.Controls.Add(this.btnRegistrarCafé);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmRegistrar_Cafe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Café               ";
            this.Load += new System.EventHandler(this.FrmRegistrar_Cafe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCafé;
        private System.Windows.Forms.Button btnCancelCafé;
    }
}