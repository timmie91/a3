namespace question2
{
    partial class Form1
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
            this.f2cButton = new System.Windows.Forms.Button();
            this.c2fButton = new System.Windows.Forms.Button();
            this.getCTextBox = new System.Windows.Forms.TextBox();
            this.getFTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // f2cButton
            // 
            this.f2cButton.Location = new System.Drawing.Point(144, 38);
            this.f2cButton.Name = "f2cButton";
            this.f2cButton.Size = new System.Drawing.Size(246, 41);
            this.f2cButton.TabIndex = 0;
            this.f2cButton.Text = "Get degreeC ";
            this.f2cButton.UseVisualStyleBackColor = true;
            this.f2cButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // c2fButton
            // 
            this.c2fButton.Location = new System.Drawing.Point(144, 127);
            this.c2fButton.Name = "c2fButton";
            this.c2fButton.Size = new System.Drawing.Size(246, 41);
            this.c2fButton.TabIndex = 1;
            this.c2fButton.Text = "Get degreeF";
            this.c2fButton.UseVisualStyleBackColor = true;
            this.c2fButton.Click += new System.EventHandler(this.c2fButton_Click);
            // 
            // getCTextBox
            // 
            this.getCTextBox.Location = new System.Drawing.Point(489, 45);
            this.getCTextBox.Name = "getCTextBox";
            this.getCTextBox.Size = new System.Drawing.Size(231, 26);
            this.getCTextBox.TabIndex = 2;
            // 
            // getFTextBox
            // 
            this.getFTextBox.Location = new System.Drawing.Point(489, 134);
            this.getFTextBox.Name = "getFTextBox";
            this.getFTextBox.Size = new System.Drawing.Size(231, 26);
            this.getFTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(839, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Print DegreeC  Value here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(839, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Print DegreeF  Value here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter a degree F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter a degree C";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 244);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getFTextBox);
            this.Controls.Add(this.getCTextBox);
            this.Controls.Add(this.c2fButton);
            this.Controls.Add(this.f2cButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button f2cButton;
        private System.Windows.Forms.Button c2fButton;
        private System.Windows.Forms.TextBox getCTextBox;
        private System.Windows.Forms.TextBox getFTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

