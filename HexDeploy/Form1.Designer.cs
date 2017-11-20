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
            this.sendingTextbox = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.mainmenuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.testbutton = new System.Windows.Forms.Button();
            this.handleTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PortTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwdtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPtextbox = new System.Windows.Forms.TextBox();
            this.msgTextbox = new System.Windows.Forms.RichTextBox();
            this.mainmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendingTextbox
            // 
            this.sendingTextbox.AcceptsTab = true;
            this.sendingTextbox.Location = new System.Drawing.Point(16, 524);
            this.sendingTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendingTextbox.Multiline = true;
            this.sendingTextbox.Name = "sendingTextbox";
            this.sendingTextbox.Size = new System.Drawing.Size(715, 22);
            this.sendingTextbox.TabIndex = 2;
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(752, 522);
            this.sendbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(100, 28);
            this.sendbutton.TabIndex = 3;
            this.sendbutton.Text = "Send";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.button3_Click);
            this.sendbutton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendbutton_KeyDown);
            // 
            // mainmenuStrip
            // 
            this.mainmenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.mainmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainmenuStrip.Name = "mainmenuStrip";
            this.mainmenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainmenuStrip.Size = new System.Drawing.Size(868, 28);
            this.mainmenuStrip.TabIndex = 16;
            this.mainmenuStrip.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Handle";
            // 
            // testbutton
            // 
            this.testbutton.Location = new System.Drawing.Point(752, 43);
            this.testbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(97, 28);
            this.testbutton.TabIndex = 15;
            this.testbutton.Text = "Test";
            this.testbutton.UseVisualStyleBackColor = true;
            this.testbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // handleTextbox
            // 
            this.handleTextbox.Location = new System.Drawing.Point(596, 47);
            this.handleTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.handleTextbox.Name = "handleTextbox";
            this.handleTextbox.Size = new System.Drawing.Size(135, 22);
            this.handleTextbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Port";
            // 
            // PortTextbox
            // 
            this.PortTextbox.Location = new System.Drawing.Point(485, 47);
            this.PortTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PortTextbox.Name = "PortTextbox";
            this.PortTextbox.Size = new System.Drawing.Size(101, 22);
            this.PortTextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // passwdtextbox
            // 
            this.passwdtextbox.Location = new System.Drawing.Point(308, 48);
            this.passwdtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwdtextbox.Name = "passwdtextbox";
            this.passwdtextbox.Size = new System.Drawing.Size(160, 22);
            this.passwdtextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP address";
            // 
            // IPtextbox
            // 
            this.IPtextbox.Location = new System.Drawing.Point(16, 48);
            this.IPtextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPtextbox.Name = "IPtextbox";
            this.IPtextbox.Size = new System.Drawing.Size(283, 22);
            this.IPtextbox.TabIndex = 9;
            // 
            // msgTextbox
            // 
            this.msgTextbox.Location = new System.Drawing.Point(16, 77);
            this.msgTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msgTextbox.Name = "msgTextbox";
            this.msgTextbox.Size = new System.Drawing.Size(832, 434);
            this.msgTextbox.TabIndex = 17;
            this.msgTextbox.Text = "";
            // 
            // mainform
            // 
            this.AcceptButton = this.sendbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(868, 561);
            this.Controls.Add(this.msgTextbox);
            this.Controls.Add(this.testbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.handleTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPtextbox);
            this.Controls.Add(this.passwdtextbox);
            this.Controls.Add(this.PortTextbox);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.sendingTextbox);
            this.Controls.Add(this.mainmenuStrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainform";
            this.Text = "2017-11-19";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainmenuStrip.ResumeLayout(false);
            this.mainmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.MenuStrip mainmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button testbutton;
        private System.Windows.Forms.TextBox handleTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PortTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwdtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPtextbox;
        public System.Windows.Forms.TextBox sendingTextbox;
        private System.Windows.Forms.RichTextBox msgTextbox;
    }
}

