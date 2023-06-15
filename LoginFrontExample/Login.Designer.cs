namespace LoginFrontExample
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
            this.WelcomLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // WelcomLabel
            // 
            this.WelcomLabel.AutoSize = true;
            this.WelcomLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomLabel.Location = new System.Drawing.Point(128, 92);
            this.WelcomLabel.Name = "WelcomLabel";
            this.WelcomLabel.Size = new System.Drawing.Size(157, 33);
            this.WelcomLabel.TabIndex = 0;
            this.WelcomLabel.Text = "Bienvenido";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(138)))), ((int)(((byte)(153)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.Location = new System.Drawing.Point(122, 410);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(163, 41);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Iniciar Session";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // UserTextBox
            // 
            this.UserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.UserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserTextBox.CausesValidation = false;
            this.UserTextBox.Font = new System.Drawing.Font("Arial", 15.75F);
            this.UserTextBox.Location = new System.Drawing.Point(122, 271);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(163, 25);
            this.UserTextBox.TabIndex = 7;
            this.UserTextBox.Text = "Usuario";
            this.UserTextBox.Click += new System.EventHandler(this.ClearSampleText);
            this.UserTextBox.Leave += new System.EventHandler(this.IfTextboxEmpty);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Arial", 15.75F);
            this.PasswordTextBox.Location = new System.Drawing.Point(122, 346);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(163, 25);
            this.PasswordTextBox.TabIndex = 7;
            this.PasswordTextBox.Text = "Contraseña";
            this.PasswordTextBox.Click += new System.EventHandler(this.ClearSampleText);
            this.PasswordTextBox.Leave += new System.EventHandler(this.IfTextboxEmpty);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(122, 293);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 3);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(122, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 3);
            this.panel1.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(412, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.WelcomLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}

