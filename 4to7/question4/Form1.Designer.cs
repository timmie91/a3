namespace question4
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptTextBox = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.encMsgLabel = new System.Windows.Forms.Label();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lengthNumberTextBox = new System.Windows.Forms.TextBox();
            this.generateStringBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1413, 584);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txtURL
            // 
            this.txtURL.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtURL.Location = new System.Drawing.Point(0, 0);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(503, 26);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(509, -5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 37);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please type your message in the text box";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // encryptTextBox
            // 
            this.encryptTextBox.Location = new System.Drawing.Point(325, 308);
            this.encryptTextBox.Name = "encryptTextBox";
            this.encryptTextBox.Size = new System.Drawing.Size(292, 26);
            this.encryptTextBox.TabIndex = 4;
            this.encryptTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(325, 340);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(169, 33);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt Now";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // encMsgLabel
            // 
            this.encMsgLabel.AutoSize = true;
            this.encMsgLabel.Location = new System.Drawing.Point(330, 376);
            this.encMsgLabel.Name = "encMsgLabel";
            this.encMsgLabel.Size = new System.Drawing.Size(0, 20);
            this.encMsgLabel.TabIndex = 8;
            this.encMsgLabel.Click += new System.EventHandler(this.encMsgLabel_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(325, 399);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(169, 33);
            this.decryptBtn.TabIndex = 9;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Image String Length =";
            // 
            // lengthNumberTextBox
            // 
            this.lengthNumberTextBox.Location = new System.Drawing.Point(820, 289);
            this.lengthNumberTextBox.Name = "lengthNumberTextBox";
            this.lengthNumberTextBox.Size = new System.Drawing.Size(100, 26);
            this.lengthNumberTextBox.TabIndex = 16;
            // 
            // generateStringBtn
            // 
            this.generateStringBtn.Location = new System.Drawing.Point(651, 321);
            this.generateStringBtn.Name = "generateStringBtn";
            this.generateStringBtn.Size = new System.Drawing.Size(305, 56);
            this.generateStringBtn.TabIndex = 17;
            this.generateStringBtn.Text = "Show Me Another String";
            this.generateStringBtn.UseVisualStyleBackColor = true;
            this.generateStringBtn.Click += new System.EventHandler(this.generateStringBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Please enter the string here";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(651, 406);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 26);
            this.textBox1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(651, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 59);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(903, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 22;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.generateStringBtn);
            this.Controls.Add(this.lengthNumberTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encMsgLabel);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.encryptTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Tim\'s Browser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encryptTextBox;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label encMsgLabel;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lengthNumberTextBox;
        private System.Windows.Forms.Button generateStringBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

