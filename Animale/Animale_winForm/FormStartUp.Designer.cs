namespace Quiz_Form
{
    partial class FormStartUp
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
            this.buttonChangeForm = new System.Windows.Forms.Button();
            this.buttonChangeForm1 = new System.Windows.Forms.Button();
            this.buttonChangeForm2 = new System.Windows.Forms.Button();
            this.buttonChangeForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangeForm
            // 
            this.buttonChangeForm.Location = new System.Drawing.Point(26, 338);
            this.buttonChangeForm.Name = "buttonChangeForm";
            this.buttonChangeForm.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeForm.TabIndex = 0;
            this.buttonChangeForm.Text = "Click Me";
            this.buttonChangeForm.UseVisualStyleBackColor = true;
            this.buttonChangeForm.Click += new System.EventHandler(this.buttonChangeForm_Click);
            // 
            // buttonChangeForm1
            // 
            this.buttonChangeForm1.Location = new System.Drawing.Point(26, 286);
            this.buttonChangeForm1.Name = "buttonChangeForm1";
            this.buttonChangeForm1.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeForm1.TabIndex = 1;
            this.buttonChangeForm1.Text = "Student";
            this.buttonChangeForm1.UseVisualStyleBackColor = true;
            this.buttonChangeForm1.Click += new System.EventHandler(this.buttonChangeForm1_Click);
            // 
            // buttonChangeForm2
            // 
            this.buttonChangeForm2.Location = new System.Drawing.Point(26, 245);
            this.buttonChangeForm2.Name = "buttonChangeForm2";
            this.buttonChangeForm2.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeForm2.TabIndex = 2;
            this.buttonChangeForm2.Text = "Profesor";
            this.buttonChangeForm2.UseVisualStyleBackColor = true;
            this.buttonChangeForm2.Click += new System.EventHandler(this.buttonChangeForm2_Click);
            // 
            // buttonChangeForm3
            // 
            this.buttonChangeForm3.Location = new System.Drawing.Point(26, 203);
            this.buttonChangeForm3.Name = "buttonChangeForm3";
            this.buttonChangeForm3.Size = new System.Drawing.Size(93, 23);
            this.buttonChangeForm3.TabIndex = 3;
            this.buttonChangeForm3.Text = "Administrator";
            this.buttonChangeForm3.UseVisualStyleBackColor = true;
            this.buttonChangeForm3.Click += new System.EventHandler(this.buttonChangeForm3_Click);
            // 
            // FormStartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChangeForm3);
            this.Controls.Add(this.buttonChangeForm2);
            this.Controls.Add(this.buttonChangeForm1);
            this.Controls.Add(this.buttonChangeForm);
            this.Name = "FormStartUp";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeForm;
        private System.Windows.Forms.Button buttonChangeForm1;
        private System.Windows.Forms.Button buttonChangeForm2;
        private System.Windows.Forms.Button buttonChangeForm3;
    }
}