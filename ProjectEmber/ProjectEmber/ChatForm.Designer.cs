namespace ProjectEmber
{
    partial class ChatForm
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
            this.messagePanel = new System.Windows.Forms.RichTextBox();
            this.messageTypeBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messagePanel
            // 
            this.messagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagePanel.Location = new System.Drawing.Point(2, 2);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(610, 401);
            this.messagePanel.TabIndex = 2;
            this.messagePanel.TabStop = false;
            this.messagePanel.Text = "";
            // 
            // messageTypeBox
            // 
            this.messageTypeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTypeBox.Location = new System.Drawing.Point(2, 409);
            this.messageTypeBox.MaxLength = 968;
            this.messageTypeBox.Name = "messageTypeBox";
            this.messageTypeBox.Size = new System.Drawing.Size(565, 20);
            this.messageTypeBox.TabIndex = 0;
            this.messageTypeBox.TabStop = false;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(573, 408);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(39, 20);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = ">";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTypeBox);
            this.Controls.Add(this.messagePanel);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "ChatForm";
            this.Text = "Harmony";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox messagePanel;
        private System.Windows.Forms.TextBox messageTypeBox;
        private System.Windows.Forms.Button sendButton;
    }
}