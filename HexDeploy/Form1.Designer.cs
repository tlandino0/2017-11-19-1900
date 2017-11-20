namespace HexDeploy
{
    partial class mainform
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.settingsbutton = new System.Windows.Forms.Button();
            this.PortTextbox = new System.Windows.Forms.TextBox();
            this.passwdtextbox = new System.Windows.Forms.TextBox();
            this.IPtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.handleTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.testbutton = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 441);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(537, 20);
            this.textBox1.TabIndex = 2;
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(564, 439);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(75, 23);
            this.sendbutton.TabIndex = 3;
            this.sendbutton.Text = "Send";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 80);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(646, 355);
            this.textBox2.TabIndex = 4;
            // 
            // settingsbutton
            // 
            this.settingsbutton.Location = new System.Drawing.Point(15, 12);
            this.settingsbutton.Name = "settingsbutton";
            this.settingsbutton.Size = new System.Drawing.Size(73, 23);
            this.settingsbutton.TabIndex = 5;
            this.settingsbutton.Text = "Settings";
            this.settingsbutton.UseVisualStyleBackColor = true;
            // 
            // PortTextbox
            // 
            this.PortTextbox.Location = new System.Drawing.Point(364, 53);
            this.PortTextbox.Name = "PortTextbox";
            this.PortTextbox.Size = new System.Drawing.Size(77, 20);
            this.PortTextbox.TabIndex = 7;
            // 
            // passwdtextbox
            // 
            this.passwdtextbox.Location = new System.Drawing.Point(231, 54);
            this.passwdtextbox.Name = "passwdtextbox";
            this.passwdtextbox.Size = new System.Drawing.Size(121, 20);
            this.passwdtextbox.TabIndex = 8;
            // 
            // IPtextbox
            // 
            this.IPtextbox.Location = new System.Drawing.Point(12, 54);
            this.IPtextbox.Name = "IPtextbox";
            this.IPtextbox.Size = new System.Drawing.Size(213, 20);
            this.IPtextbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Port";
            // 
            // handleTextbox
            // 
            this.handleTextbox.Location = new System.Drawing.Point(447, 53);
            this.handleTextbox.Name = "handleTextbox";
            this.handleTextbox.Size = new System.Drawing.Size(102, 20);
            this.handleTextbox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Handle";
            // 
            // testbutton
            // 
            this.testbutton.Location = new System.Drawing.Point(564, 51);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(73, 23);
            this.testbutton.TabIndex = 15;
            this.testbutton.Text = "Test";
            this.testbutton.UseVisualStyleBackColor = true;
            this.testbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(667, 473);
            this.Controls.Add(this.testbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.handleTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPtextbox);
            this.Controls.Add(this.passwdtextbox);
            this.Controls.Add(this.PortTextbox);
            this.Controls.Add(this.settingsbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "mainform";
            this.Text = "2017-11-19";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button settingsbutton;
        private System.Windows.Forms.TextBox PortTextbox;
        private System.Windows.Forms.TextBox passwdtextbox;
        private System.Windows.Forms.TextBox IPtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox handleTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button testbutton;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

