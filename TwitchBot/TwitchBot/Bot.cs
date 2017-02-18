using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using TwitchLib;
using TwitchLib.Models.Client;
using System.Data.SQLite;

namespace TwitchBot
{
    public partial class Bot : Form
    {
        TwitchClient Client;
        ConnectionCredentials Credentials;
        string USER, PASS, CHANNEL, HOSTING, STATUS;
        List<string> Viewers = new List<string>();

        public Bot()
        {
            InitializeComponent();
        }

        void Setup()
        {
            if (!string.IsNullOrEmpty(UsernameTextBox.Text) && !string.IsNullOrEmpty(PasswordTextBox.Text) && !string.IsNullOrEmpty(ChannelTextBox.Text))
            {
                USER = UsernameTextBox.Text;
                PASS = PasswordTextBox.Text;
                CHANNEL = ChannelTextBox.Text;
                Credentials = new ConnectionCredentials(USER, PASS);
                if (Client == null) { Client = new TwitchClient(Credentials, CHANNEL, '!'); }
                if (!Client.IsConnected)
                {
                    // Setup all event handlers
                    Client.OnJoinedChannel += Client_OnJoinedChannel;
                    Client.OnMessageSent += Client_OnMessageSent;
                    Client.OnMessageReceived += Client_OnMessageReceived;
                    Client.OnUserBanned += Client_OnUserBanned;
                    Client.OnUserJoined += Client_OnUserJoined;
                    Client.OnUserLeft += Client_OnUserLeft;
                    Client.OnConnectionError += Client_OnConnectionError;
                    Client.OnNewSubscriber += Client_OnNewSubscriber;
                    Client.OnChatCommandReceived += Client_OnChatCommandReceived;
                    Client.OnHostingStarted += Client_OnHostingStarted;
                    Client.OnHostingStopped += Client_OnHostingStopped;
                    // Connect the client
                    Client.Connect();
                    // Change status identifier
                    STATUS = "Status: Connected";
                    StatusLabel.Text = STATUS;
                }
            }
        }

        private void Client_OnHostingStopped(object sender, TwitchLib.Events.Client.OnHostingStoppedArgs e)
        {
            Client.SendMessage($"{e.HostingChannel} has stopped hosting {HOSTING}");
            HOSTING = string.Empty;
        }

        private void Client_OnHostingStarted(object sender, TwitchLib.Events.Client.OnHostingStartedArgs e)
        {
            Client.SendMessage($"{e.HostingChannel} is now hosting {e.TargetChannel} for {e.Viewers} viewers!");
            HOSTING = e.TargetChannel;
        }

        // Place into a region after completion

        private void Client_OnChatCommandReceived(object sender, TwitchLib.Events.Client.OnChatCommandReceivedArgs e)
        {
            switch (e.Command.Command)
            {
                case "test":
                    Client.SendMessage("Test command fired!");
                    break;
                case "UpdateViewerList":
                    UpdateViewersText();
                    break;
                default:
                    // Action taken by all commands
                    break;
            }
        }

        private void Client_OnNewSubscriber(object sender, TwitchLib.Events.Client.OnNewSubscriberArgs e)
        {
            Client.SendMessage($"Thankyou @{e.Subscriber.Name} for subscribing!");
        }

        private void Client_OnConnectionError(object sender, TwitchLib.Events.Client.OnConnectionErrorArgs e)
        {
            Client.Reconnect();
        }

        private void Client_OnUserLeft(object sender, TwitchLib.Events.Client.OnUserLeftArgs e)
        {
            Client.SendMessage($"@{e.Username} left the stream!");
            Viewers.Remove(e.Username);
            UpdateViewersText();
        }

        private void Client_OnUserJoined(object sender, TwitchLib.Events.Client.OnUserJoinedArgs e)
        {
            Client.SendMessage($"Welcome @{e.Username} to the stream!");
            Viewers.Add(e.Username);
            UpdateViewersText();
        }

        void UpdateViewersText()
        {
            ViewersTextBox.Invoke((MethodInvoker)delegate
            {
                foreach (string v in Viewers)
                {
                    ViewersTextBox.AppendText(v);
                }
            });
        }

        private void Client_OnUserBanned(object sender, TwitchLib.Events.Client.OnUserBannedArgs e)
        {
            OutputTextBox.Invoke((MethodInvoker)delegate
            {
                OutputTextBox.Text = "A user was banned!\n";
            });
            Client.SendMessage($"@{e.Username} you have been banned from {e.Channel} for {e.BanReason}");
        }

        private void Client_OnJoinedChannel(object sender, TwitchLib.Events.Client.OnJoinedChannelArgs e)
        {
            OutputTextBox.Invoke((MethodInvoker)delegate
            {
                OutputTextBox.Text = "Join successfull!\n";
            });
        }

        private void Client_OnMessageReceived(object sender, TwitchLib.Events.Client.OnMessageReceivedArgs e)
        {
            OutputTextBox.Invoke((MethodInvoker)delegate
            {
                OutputTextBox.AppendText($"[{e.ChatMessage.UserType}] {e.ChatMessage.DisplayName}: {e.ChatMessage.Message}\n");
            });
            ChatTextBox.Invoke((MethodInvoker)delegate
            {
                OutputTextBox.AppendText($"[{e.ChatMessage.UserType}] {e.ChatMessage.DisplayName}: {e.ChatMessage.Message}\n");
            });
        }

        private void SendChatMessageButton_Click(object sender, EventArgs e)
        {
            Client.SendMessage(SendChatMessageTextBox.Text);
            SendChatMessageTextBox.Text = string.Empty;
        }

        private void Client_OnMessageSent(object sender, TwitchLib.Events.Client.OnMessageSentArgs e)
        {
            OutputTextBox.Invoke((MethodInvoker)delegate
            {
                OutputTextBox.AppendText($"[{e.SentMessage.UserType}] {USER}: {e.SentMessage.Message}\n");
            });
            ChatTextBox.Invoke((MethodInvoker)delegate
            {
                ChatTextBox.AppendText($"[{e.SentMessage.UserType}] {USER}: {e.SentMessage.Message}\n");
            });
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            STATUS = "Status: Connecting";
            StatusLabel.Text = STATUS;
            Setup();
        }
    }
}
