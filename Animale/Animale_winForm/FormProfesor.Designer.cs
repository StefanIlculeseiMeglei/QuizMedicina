namespace Animale_Form
{
    partial class FormProfesor
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
            this.buttonStartUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartUp
            // 
            this.buttonStartUp.Location = new System.Drawing.Point(24, 396);
            this.buttonStartUp.Name = "buttonStartUp";
            this.buttonStartUp.Size = new System.Drawing.Size(75, 23);
            this.buttonStartUp.TabIndex = 4;
            this.buttonStartUp.Text = "GO BACK";
            this.buttonStartUp.UseVisualStyleBackColor = true;
            this.buttonStartUp.Click += new System.EventHandler(this.buttonStartUp_Click);
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStartUp);
            this.Name = "FormProfesor";
            this.Text = "FormProfesor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartUp;
    }
}