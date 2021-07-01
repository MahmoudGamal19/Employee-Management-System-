namespace orecalProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UN = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pass = new System.Windows.Forms.TextBox();
            this.LOG = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(49, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 35);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(140, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UN
            // 
            this.UN.BackColor = System.Drawing.Color.Silver;
            this.UN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UN.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UN.ForeColor = System.Drawing.Color.Gray;
            this.UN.Location = new System.Drawing.Point(123, 106);
            this.UN.Name = "UN";
            this.UN.Size = new System.Drawing.Size(228, 29);
            this.UN.TabIndex = 4;
            this.UN.Text = "User Name ";
            this.UN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UN.Click += new System.EventHandler(this.UN_Click);
            this.UN.TextChanged += new System.EventHandler(this.UN_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(49, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 39);
            this.panel2.TabIndex = 5;
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.Silver;
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pass.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.Gray;
            this.Pass.Location = new System.Drawing.Point(123, 188);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(228, 29);
            this.Pass.TabIndex = 6;
            this.Pass.Text = "Password";
            this.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass.Click += new System.EventHandler(this.Pass_Click);
            this.Pass.TextChanged += new System.EventHandler(this.Pass_TextChanged);
            // 
            // LOG
            // 
            this.LOG.BackColor = System.Drawing.Color.Gray;
            this.LOG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOG.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOG.Location = new System.Drawing.Point(146, 258);
            this.LOG.Name = "LOG";
            this.LOG.Size = new System.Drawing.Size(135, 42);
            this.LOG.TabIndex = 8;
            this.LOG.Text = "Log In";
            this.LOG.UseVisualStyleBackColor = false;
            this.LOG.Click += new System.EventHandler(this.LOG_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(354, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 32);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(390, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LOG);
            this.Controls.Add(this.UN);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Button LOG;
        private System.Windows.Forms.Button button1;
    }
}