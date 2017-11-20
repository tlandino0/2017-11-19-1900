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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lgtthemebtn = new System.Windows.Forms.Button();
            this.drkthemebtn = new System.Windows.Forms.Button();
            this.ngtthemebtn = new System.Windows.Forms.Button();
            this.logchkBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendingTextbox
            // 
            this.sendingTextbox.AcceptsTab = true;
            this.sendingTextbox.Location = new System.Drawing.Point(8, 400);
            this.sendingTextbox.Name = "sendingTextbox";
            this.sendingTextbox.Size = new System.Drawing.Size(538, 20);
            this.sendingTextbox.TabIndex = 2;
            this.sendingTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendingTextbox_KeyDown);
            this.sendingTextbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sendingTextbox_KeyUp);
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(562, 392);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(75, 35);
            this.sendbutton.TabIndex = 3;
            this.sendbutton.Text = "Send";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sendbutton_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Handle";
            // 
            // testbutton
            // 
            this.testbutton.Location = new System.Drawing.Point(335, 46);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(136, 23);
            this.testbutton.TabIndex = 15;
            this.testbutton.Text = "Test Connection";
            this.testbutton.UseVisualStyleBackColor = true;
            this.testbutton.Click += new System.EventHandler(this.button5_Click);
            // 
            // handleTextbox
            // 
            this.handleTextbox.Location = new System.Drawing.Point(183, 48);
            this.handleTextbox.Name = "handleTextbox";
            this.handleTextbox.Size = new System.Drawing.Size(102, 20);
            this.handleTextbox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Port";
            // 
            // PortTextbox
            // 
            this.PortTextbox.Location = new System.Drawing.Point(40, 48);
            this.PortTextbox.Name = "PortTextbox";
            this.PortTextbox.Size = new System.Drawing.Size(77, 20);
            this.PortTextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // passwdtextbox
            // 
            this.passwdtextbox.Location = new System.Drawing.Point(350, 10);
            this.passwdtextbox.Name = "passwdtextbox";
            this.passwdtextbox.Size = new System.Drawing.Size(121, 20);
            this.passwdtextbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP address";
            // 
            // IPtextbox
            // 
            this.IPtextbox.Location = new System.Drawing.Point(72, 10);
            this.IPtextbox.Name = "IPtextbox";
            this.IPtextbox.Size = new System.Drawing.Size(213, 20);
            this.IPtextbox.TabIndex = 9;
            // 
            // msgTextbox
            // 
            this.msgTextbox.Location = new System.Drawing.Point(3, 6);
            this.msgTextbox.Name = "msgTextbox";
            this.msgTextbox.Size = new System.Drawing.Size(632, 383);
            this.msgTextbox.TabIndex = 17;
            this.msgTextbox.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 456);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.msgTextbox);
            this.tabPage1.Controls.Add(this.sendbutton);
            this.tabPage1.Controls.Add(this.sendingTextbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(643, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chat";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.IPtextbox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.testbutton);
            this.tabPage2.Controls.Add(this.passwdtextbox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.handleTextbox);
            this.tabPage2.Controls.Add(this.PortTextbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(643, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.logchkBox);
            this.tabPage3.Controls.Add(this.ngtthemebtn);
            this.tabPage3.Controls.Add(this.drkthemebtn);
            this.tabPage3.Controls.Add(this.lgtthemebtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(643, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lgtthemebtn
            // 
            this.lgtthemebtn.Location = new System.Drawing.Point(560, 6);
            this.lgtthemebtn.Name = "lgtthemebtn";
            this.lgtthemebtn.Size = new System.Drawing.Size(75, 51);
            this.lgtthemebtn.TabIndex = 0;
            this.lgtthemebtn.Text = "Switch to light theme";
            this.lgtthemebtn.UseVisualStyleBackColor = true;
            // 
            // drkthemebtn
            // 
            this.drkthemebtn.BackColor = System.Drawing.Color.DimGray;
            this.drkthemebtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.drkthemebtn.Location = new System.Drawing.Point(560, 63);
            this.drkthemebtn.Name = "drkthemebtn";
            this.drkthemebtn.Size = new System.Drawing.Size(75, 46);
            this.drkthemebtn.TabIndex = 1;
            this.drkthemebtn.Text = "Switch to Dark Theme";
            this.drkthemebtn.UseVisualStyleBackColor = false;
            // 
            // ngtthemebtn
            // 
            this.ngtthemebtn.BackColor = System.Drawing.Color.Black;
            this.ngtthemebtn.ForeColor = System.Drawing.Color.Transparent;
            this.ngtthemebtn.Location = new System.Drawing.Point(560, 115);
            this.ngtthemebtn.Name = "ngtthemebtn";
            this.ngtthemebtn.Size = new System.Drawing.Size(75, 50);
            this.ngtthemebtn.TabIndex = 2;
            this.ngtthemebtn.Text = "Switch to Night Theme";
            this.ngtthemebtn.UseVisualStyleBackColor = false;
            // 
            // logchkBox
            // 
            this.logchkBox.AutoSize = true;
            this.logchkBox.Location = new System.Drawing.Point(6, 24);
            this.logchkBox.Name = "logchkBox";
            this.logchkBox.Size = new System.Drawing.Size(134, 17);
            this.logchkBox.TabIndex = 3;
            this.logchkBox.Text = "Save chats to a log file";
            this.logchkBox.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(477, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Connect!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(175)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(560, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Switch to Echelon Theme";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(651, 456);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainform";
            this.Text = "2017-11-19";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sendbutton;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox logchkBox;
        private System.Windows.Forms.Button ngtthemebtn;
        private System.Windows.Forms.Button drkthemebtn;
        private System.Windows.Forms.Button lgtthemebtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

