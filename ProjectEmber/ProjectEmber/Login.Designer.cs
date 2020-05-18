namespace ProjectEmber
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
            this.loginButton = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(107, 92);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(42, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.Location = new System.Drawing.Point(47, 9);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(168, 41);
            this.logoLabel.TabIndex = 1;
            this.logoLabel.Text = "Harmony";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 50);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(219, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name (can be up to %s characters in length):";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(12, 66);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(233, 20);
            this.loginTextBox.TabIndex = 3;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 122);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Harmony | Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox loginTextBox;
    }
}

