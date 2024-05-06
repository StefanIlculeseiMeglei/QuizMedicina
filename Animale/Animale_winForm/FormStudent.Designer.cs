namespace Animale_Form
{
    partial class FormStudent
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
            this.userName = new System.Windows.Forms.Label();
            this.labelUserPoints = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonStartUp = new System.Windows.Forms.Button();
            this.buttonPopulateList = new System.Windows.Forms.Button();
            this.buttonShowSelectedEx = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStartQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(12, 26);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(152, 16);
            this.userName.TabIndex = 0;
            this.userName.Text = "PLACEHOLDER_NAME";
            // 
            // labelUserPoints
            // 
            this.labelUserPoints.AutoSize = true;
            this.labelUserPoints.Location = new System.Drawing.Point(13, 67);
            this.labelUserPoints.Name = "labelUserPoints";
            this.labelUserPoints.Size = new System.Drawing.Size(163, 16);
            this.labelUserPoints.TabIndex = 1;
            this.labelUserPoints.Text = "PLACEHOLDER_POINTS";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(266, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonStartUp
            // 
            this.buttonStartUp.Location = new System.Drawing.Point(15, 415);
            this.buttonStartUp.Name = "buttonStartUp";
            this.buttonStartUp.Size = new System.Drawing.Size(75, 23);
            this.buttonStartUp.TabIndex = 3;
            this.buttonStartUp.Text = "GO BACK";
            this.buttonStartUp.UseVisualStyleBackColor = true;
            this.buttonStartUp.Click += new System.EventHandler(this.buttonStartUp_Click);
            // 
            // buttonPopulateList
            // 
            this.buttonPopulateList.Location = new System.Drawing.Point(12, 345);
            this.buttonPopulateList.Name = "buttonPopulateList";
            this.buttonPopulateList.Size = new System.Drawing.Size(75, 23);
            this.buttonPopulateList.TabIndex = 4;
            this.buttonPopulateList.Text = "FILL LIST";
            this.buttonPopulateList.UseVisualStyleBackColor = true;
            this.buttonPopulateList.Click += new System.EventHandler(this.buttonPopulateList_Click);
            // 
            // buttonShowSelectedEx
            // 
            this.buttonShowSelectedEx.Location = new System.Drawing.Point(12, 374);
            this.buttonShowSelectedEx.Name = "buttonShowSelectedEx";
            this.buttonShowSelectedEx.Size = new System.Drawing.Size(75, 23);
            this.buttonShowSelectedEx.TabIndex = 5;
            this.buttonShowSelectedEx.Text = "SHOW";
            this.buttonShowSelectedEx.UseVisualStyleBackColor = true;
            this.buttonShowSelectedEx.Click += new System.EventHandler(this.buttonShowSelectedEx_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonStartQuiz
            // 
            this.buttonStartQuiz.Location = new System.Drawing.Point(12, 291);
            this.buttonStartQuiz.Name = "buttonStartQuiz";
            this.buttonStartQuiz.Size = new System.Drawing.Size(75, 23);
            this.buttonStartQuiz.TabIndex = 7;
            this.buttonStartQuiz.Text = "StartQuiz";
            this.buttonStartQuiz.UseVisualStyleBackColor = true;
            this.buttonStartQuiz.Click += new System.EventHandler(this.buttonStartQuiz_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.buttonStartQuiz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShowSelectedEx);
            this.Controls.Add(this.buttonPopulateList);
            this.Controls.Add(this.buttonStartUp);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelUserPoints);
            this.Controls.Add(this.userName);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label labelUserPoints;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonStartUp;
        private System.Windows.Forms.Button buttonPopulateList;
        private System.Windows.Forms.Button buttonShowSelectedEx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartQuiz;
    }
}