﻿namespace math_pj_a
{
    partial class Menu
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
            this.factb = new System.Windows.Forms.Button();
            this.invb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido seleccione una opción";
            // 
            // factb
            // 
            this.factb.Location = new System.Drawing.Point(34, 113);
            this.factb.Name = "factb";
            this.factb.Size = new System.Drawing.Size(112, 75);
            this.factb.TabIndex = 1;
            this.factb.Text = "Facturación";
            this.factb.UseVisualStyleBackColor = true;
            this.factb.Click += new System.EventHandler(this.Factb_Click);
            // 
            // invb
            // 
            this.invb.Location = new System.Drawing.Point(188, 113);
            this.invb.Name = "invb";
            this.invb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invb.Size = new System.Drawing.Size(122, 75);
            this.invb.TabIndex = 2;
            this.invb.Text = "Inventario";
            this.invb.UseVisualStyleBackColor = true;
            this.invb.Click += new System.EventHandler(this.Invb_Click_1);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(376, 311);
            this.Controls.Add(this.invb);
            this.Controls.Add(this.factb);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button factb;
        private System.Windows.Forms.Button invb;
    }
}

