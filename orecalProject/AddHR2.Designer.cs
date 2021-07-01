namespace orecalProject
{
    partial class AddHR2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddHR2));
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SSN = new System.Windows.Forms.TextBox();
            this.L_N = new System.Windows.Forms.TextBox();
            this.M_N = new System.Windows.Forms.TextBox();
            this.F_N = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UN = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.TextBox();
            this.PH = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.Sal = new System.Windows.Forms.TextBox();
            this.Dep = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New HR ";
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(396, -1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(34, 31);
            this.back.TabIndex = 39;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Name  :";
            // 
            // SSN
            // 
            this.SSN.BackColor = System.Drawing.Color.Silver;
            this.SSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SSN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSN.Location = new System.Drawing.Point(81, 130);
            this.SSN.Name = "SSN";
            this.SSN.Size = new System.Drawing.Size(243, 16);
            this.SSN.TabIndex = 41;
            this.SSN.Text = "16 Number";
            this.SSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SSN.Click += new System.EventHandler(this.SSN_Click);
            // 
            // L_N
            // 
            this.L_N.BackColor = System.Drawing.Color.Silver;
            this.L_N.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.L_N.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_N.Location = new System.Drawing.Point(307, 87);
            this.L_N.Name = "L_N";
            this.L_N.Size = new System.Drawing.Size(87, 16);
            this.L_N.TabIndex = 59;
            this.L_N.Text = "Last";
            this.L_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.L_N.Click += new System.EventHandler(this.L_N_Click);
            // 
            // M_N
            // 
            this.M_N.BackColor = System.Drawing.Color.Silver;
            this.M_N.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.M_N.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M_N.Location = new System.Drawing.Point(196, 87);
            this.M_N.Name = "M_N";
            this.M_N.Size = new System.Drawing.Size(87, 16);
            this.M_N.TabIndex = 58;
            this.M_N.Text = "midel";
            this.M_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.M_N.Click += new System.EventHandler(this.M_N_Click);
            // 
            // F_N
            // 
            this.F_N.BackColor = System.Drawing.Color.Silver;
            this.F_N.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.F_N.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_N.Location = new System.Drawing.Point(81, 87);
            this.F_N.Name = "F_N";
            this.F_N.Size = new System.Drawing.Size(87, 16);
            this.F_N.TabIndex = 57;
            this.F_N.Text = "Frist";
            this.F_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.F_N.Click += new System.EventHandler(this.F_N_Click);
            this.F_N.TextChanged += new System.EventHandler(this.F_N_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "SSN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "UserName  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Password  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "Phone :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 64;
            this.label7.Text = "Adress  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 18);
            this.label8.TabIndex = 65;
            this.label8.Text = "Salary  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 18);
            this.label9.TabIndex = 66;
            this.label9.Text = "Department  :";
            // 
            // UN
            // 
            this.UN.BackColor = System.Drawing.Color.Silver;
            this.UN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UN.Location = new System.Drawing.Point(138, 180);
            this.UN.Name = "UN";
            this.UN.Size = new System.Drawing.Size(186, 13);
            this.UN.TabIndex = 67;
            this.UN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.Silver;
            this.Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pass.Location = new System.Drawing.Point(138, 241);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(186, 13);
            this.Pass.TabIndex = 68;
            this.Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PH
            // 
            this.PH.BackColor = System.Drawing.Color.Silver;
            this.PH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PH.Location = new System.Drawing.Point(138, 302);
            this.PH.Name = "PH";
            this.PH.Size = new System.Drawing.Size(186, 13);
            this.PH.TabIndex = 69;
            this.PH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.Color.Silver;
            this.ad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ad.Location = new System.Drawing.Point(138, 360);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(230, 13);
            this.ad.TabIndex = 70;
            this.ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sal
            // 
            this.Sal.BackColor = System.Drawing.Color.Silver;
            this.Sal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sal.Location = new System.Drawing.Point(138, 418);
            this.Sal.Name = "Sal";
            this.Sal.Size = new System.Drawing.Size(124, 13);
            this.Sal.TabIndex = 71;
            this.Sal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Dep
            // 
            this.Dep.BackColor = System.Drawing.Color.Silver;
            this.Dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dep.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dep.FormattingEnabled = true;
            this.Dep.Location = new System.Drawing.Point(138, 466);
            this.Dep.Name = "Dep";
            this.Dep.Size = new System.Drawing.Size(256, 24);
            this.Dep.TabIndex = 72;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(372, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 43);
            this.button1.TabIndex = 73;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddHR2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(431, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dep);
            this.Controls.Add(this.Sal);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.PH);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.UN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L_N);
            this.Controls.Add(this.M_N);
            this.Controls.Add(this.F_N);
            this.Controls.Add(this.SSN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddHR2";
            this.Text = "AddHR2";
            this.Load += new System.EventHandler(this.AddHR2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SSN;
        private System.Windows.Forms.TextBox L_N;
        private System.Windows.Forms.TextBox M_N;
        private System.Windows.Forms.TextBox F_N;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UN;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox PH;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox Sal;
        private System.Windows.Forms.ComboBox Dep;
        private System.Windows.Forms.Button button1;
    }
}