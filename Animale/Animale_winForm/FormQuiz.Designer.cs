namespace Animale_Form
{
    partial class FormQuiz
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
            this.labelTextIntrebare = new System.Windows.Forms.Label();
            this.labelOp1 = new System.Windows.Forms.Label();
            this.labelOp2 = new System.Windows.Forms.Label();
            this.labelOp3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTextIntrebare
            // 
            this.labelTextIntrebare.AutoSize = true;
            this.labelTextIntrebare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.labelTextIntrebare.Location = new System.Drawing.Point(252, 64);
            this.labelTextIntrebare.MaximumSize = new System.Drawing.Size(500, 300);
            this.labelTextIntrebare.Name = "labelTextIntrebare";
            this.labelTextIntrebare.Size = new System.Drawing.Size(269, 25);
            this.labelTextIntrebare.TabIndex = 0;
            this.labelTextIntrebare.Text = "PLACEHOLDER QUESTION";
            // 
            // labelOp1
            // 
            this.labelOp1.AutoSize = true;
            this.labelOp1.Location = new System.Drawing.Point(103, 171);
            this.labelOp1.MaximumSize = new System.Drawing.Size(200, 0);
            this.labelOp1.Name = "labelOp1";
            this.labelOp1.Size = new System.Drawing.Size(135, 16);
            this.labelOp1.TabIndex = 1;
            this.labelOp1.Text = "PLACEHOLDER OP1";
            // 
            // labelOp2
            // 
            this.labelOp2.AutoSize = true;
            this.labelOp2.Location = new System.Drawing.Point(346, 171);
            this.labelOp2.MaximumSize = new System.Drawing.Size(200, 0);
            this.labelOp2.Name = "labelOp2";
            this.labelOp2.Size = new System.Drawing.Size(135, 16);
            this.labelOp2.TabIndex = 2;
            this.labelOp2.Text = "PLACEHOLDER OP2";
            // 
            // labelOp3
            // 
            this.labelOp3.AutoSize = true;
            this.labelOp3.Location = new System.Drawing.Point(590, 171);
            this.labelOp3.MaximumSize = new System.Drawing.Size(200, 0);
            this.labelOp3.Name = "labelOp3";
            this.labelOp3.Size = new System.Drawing.Size(135, 16);
            this.labelOp3.TabIndex = 3;
            this.labelOp3.Text = "PLACEHOLDER OP3";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(71, 171);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(314, 171);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(557, 171);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(71, 360);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.labelOp3);
            this.Controls.Add(this.labelOp2);
            this.Controls.Add(this.labelOp1);
            this.Controls.Add(this.labelTextIntrebare);
            this.Name = "FormQuiz";
            this.Text = "FormQuiz";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextIntrebare;
        private System.Windows.Forms.Label labelOp1;
        private System.Windows.Forms.Label labelOp2;
        private System.Windows.Forms.Label labelOp3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button buttonNext;
    }
}