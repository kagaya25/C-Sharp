﻿namespace T_097_Making_Controls
{
    partial class Mybutton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Mybutton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Mybutton";
            this.Size = new System.Drawing.Size(71, 27);
            this.Click += new System.EventHandler(this.Mybutton_Click);
            this.MouseEnter += new System.EventHandler(this.Mybutton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Mybutton_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Mybutton_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
