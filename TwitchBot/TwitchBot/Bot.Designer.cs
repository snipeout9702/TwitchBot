namespace TwitchBot
{
    partial class Bot
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
            this.ViewersTab = new System.Windows.Forms.TabControl();
            this.ConnectionTab = new System.Windows.Forms.TabPage();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ChannelTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.ChatTab = new System.Windows.Forms.TabPage();
            this.SendChatMessageButton = new System.Windows.Forms.Button();
            this.SendChatMessageTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChatTextBox = new System.Windows.Forms.RichTextBox();
            this.ViewersTabPage = new System.Windows.Forms.TabPage();
            this.ViewersTextBox = new System.Windows.Forms.RichTextBox();
            this.ViewersTab.SuspendLayout();
            this.ConnectionTab.SuspendLayout();
            this.ChatTab.SuspendLayout();
            this.ViewersTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewersTab
            // 
            this.ViewersTab.Controls.Add(this.ConnectionTab);
            this.ViewersTab.Controls.Add(this.ChatTab);
            this.ViewersTab.Controls.Add(this.ViewersTabPage);
            this.ViewersTab.Location = new System.Drawing.Point(0, 0);
            this.ViewersTab.Name = "ViewersTab";
            this.ViewersTab.SelectedIndex = 0;
            this.ViewersTab.Size = new System.Drawing.Size(520, 295);
            this.ViewersTab.TabIndex = 0;
            // 
            // ConnectionTab
            // 
            this.ConnectionTab.Controls.Add(this.OutputTextBox);
            this.ConnectionTab.Controls.Add(this.StatusLabel);
            this.ConnectionTab.Controls.Add(this.ConnectButton);
            this.ConnectionTab.Controls.Add(this.ChannelTextBox);
            this.ConnectionTab.Controls.Add(this.PasswordTextBox);
            this.ConnectionTab.Controls.Add(this.UsernameTextBox);
            this.ConnectionTab.Location = new System.Drawing.Point(4, 22);
            this.ConnectionTab.Name = "ConnectionTab";
            this.ConnectionTab.Padding = new System.Windows.Forms.Padding(3);
            this.ConnectionTab.Size = new System.Drawing.Size(512, 269);
            this.ConnectionTab.TabIndex = 0;
            this.ConnectionTab.Text = "Connection";
            this.ConnectionTab.UseVisualStyleBackColor = true;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(9, 115);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(497, 146);
            this.OutputTextBox.TabIndex = 7;
            this.OutputTextBox.Text = "";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(191, 32);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(319, 37);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Status: Disconnected";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(8, 85);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(177, 23);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ChannelTextBox
            // 
            this.ChannelTextBox.Location = new System.Drawing.Point(8, 58);
            this.ChannelTextBox.Name = "ChannelTextBox";
            this.ChannelTextBox.Size = new System.Drawing.Size(177, 20);
            this.ChannelTextBox.TabIndex = 4;
            this.ChannelTextBox.Text = "littlefirestudio";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(8, 32);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(177, 20);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.Text = "oauth:no22wg0ix1e54mghtortkfqcn7ykrd";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(8, 6);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(177, 20);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.Text = "littlefirestudio";
            // 
            // ChatTab
            // 
            this.ChatTab.Controls.Add(this.SendChatMessageButton);
            this.ChatTab.Controls.Add(this.SendChatMessageTextBox);
            this.ChatTab.Controls.Add(this.label1);
            this.ChatTab.Controls.Add(this.ChatTextBox);
            this.ChatTab.Location = new System.Drawing.Point(4, 22);
            this.ChatTab.Name = "ChatTab";
            this.ChatTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChatTab.Size = new System.Drawing.Size(512, 269);
            this.ChatTab.TabIndex = 1;
            this.ChatTab.Text = "Chat";
            this.ChatTab.UseVisualStyleBackColor = true;
            // 
            // SendChatMessageButton
            // 
            this.SendChatMessageButton.Location = new System.Drawing.Point(431, 243);
            this.SendChatMessageButton.Name = "SendChatMessageButton";
            this.SendChatMessageButton.Size = new System.Drawing.Size(75, 21);
            this.SendChatMessageButton.TabIndex = 3;
            this.SendChatMessageButton.Text = "Send";
            this.SendChatMessageButton.UseVisualStyleBackColor = true;
            this.SendChatMessageButton.Click += new System.EventHandler(this.SendChatMessageButton_Click);
            // 
            // SendChatMessageTextBox
            // 
            this.SendChatMessageTextBox.Location = new System.Drawing.Point(6, 243);
            this.SendChatMessageTextBox.Name = "SendChatMessageTextBox";
            this.SendChatMessageTextBox.Size = new System.Drawing.Size(419, 20);
            this.SendChatMessageTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chat";
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Location = new System.Drawing.Point(6, 33);
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.Size = new System.Drawing.Size(500, 204);
            this.ChatTextBox.TabIndex = 0;
            this.ChatTextBox.Text = "";
            // 
            // ViewersTabPage
            // 
            this.ViewersTabPage.Controls.Add(this.ViewersTextBox);
            this.ViewersTabPage.Location = new System.Drawing.Point(4, 22);
            this.ViewersTabPage.Name = "ViewersTabPage";
            this.ViewersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ViewersTabPage.Size = new System.Drawing.Size(512, 269);
            this.ViewersTabPage.TabIndex = 2;
            this.ViewersTabPage.Text = "Viewers";
            this.ViewersTabPage.UseVisualStyleBackColor = true;
            // 
            // ViewersTextBox
            // 
            this.ViewersTextBox.Location = new System.Drawing.Point(8, 6);
            this.ViewersTextBox.Name = "ViewersTextBox";
            this.ViewersTextBox.Size = new System.Drawing.Size(498, 255);
            this.ViewersTextBox.TabIndex = 0;
            this.ViewersTextBox.Text = "";
            // 
            // Bot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 295);
            this.Controls.Add(this.ViewersTab);
            this.Name = "Bot";
            this.Text = "FireBot";
            this.ViewersTab.ResumeLayout(false);
            this.ConnectionTab.ResumeLayout(false);
            this.ConnectionTab.PerformLayout();
            this.ChatTab.ResumeLayout(false);
            this.ChatTab.PerformLayout();
            this.ViewersTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ViewersTab;
        private System.Windows.Forms.TabPage ConnectionTab;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ChannelTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TabPage ChatTab;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ChatTextBox;
        private System.Windows.Forms.Button SendChatMessageButton;
        private System.Windows.Forms.TextBox SendChatMessageTextBox;
        private System.Windows.Forms.TabPage ViewersTabPage;
        private System.Windows.Forms.RichTextBox ViewersTextBox;
    }
}

