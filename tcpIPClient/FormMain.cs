using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace tcpIPClient
{
    public partial class FormMain : Form
    {
        TcpClient       tcpClient;
        TcpListener     tcpListener;
        Boolean         bServerIsListening;
        NetworkStream   netStream;
        Thread          oServerThread;
        Thread          oClientConnectThread;


        public FormMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            comboBoxClientProtocol.Text = comboBoxClientProtocol.Items[0].ToString();
            comboBoxServerProtocol.Text = comboBoxServerProtocol.Items[0].ToString();
            bServerIsListening = false;
        }

        private void buttonClientconnect_Click(object sender, EventArgs e)
        {
            if (buttonClientConnect.Text == "Connect")
            {
                try
                {
                    oClientConnectThread = new Thread(new ThreadStart(clientThreadFunction));
                    oClientConnectThread.Start();
                }
                catch (Exception ex)
                {
                    textBoxClientLog.AppendText(ex.Message + Environment.NewLine);
                }
            }
            else
            {
                try
                {
                    textBoxClientLog.AppendText("Disconnected from Server " + textBoxServerName.Text + ":" + textBoxServerPort.Text + Environment.NewLine);
                    tcpClient.Close();
                    netStream.Close();
                    buttonClientConnect.Text = "Connect";
                    buttonClientConnect.ForeColor = Color.DarkGreen;
                    textBoxServerName.Enabled = true;
                    textBoxServerPort.Enabled = true;
                    groupBoxClientKeyboard.Enabled = false;
                    groupBoxClientProtocol.Enabled = false;
                    groupBoxClientReceive.Enabled = false;
                    textBoxClientReceive.Clear();
                }
                catch
                {
                }
            }
        }

        private void buttonListen_Click(object sender, EventArgs e)
        {
            if (!bServerIsListening)
            {
                try
                {
                    tcpListener = new TcpListener(System.Net.IPAddress.Parse("127.0.0.1"), Convert.ToInt32(textBoxListenPort.Text));
                    oServerThread = new Thread(new ThreadStart(serverThreadFunction));
                    oServerThread.Start();
                    buttonListen.Text = "Stop Listen";
                    buttonListen.ForeColor = Color.Red;
                    textBoxClientsConnected.Enabled = true;
                    textBoxListenPort.Enabled = false;
                    groupBoxServerKeyboard.Enabled = true;
                    groupBoxServerRecieve.Enabled = true;
                    bServerIsListening = true;
                }
                catch
                {
                    textBoxServerLog.AppendText("Could not connect to Port " + textBoxListenPort.Text + Environment.NewLine);
                }
            }
            else
            {
                try
                {
                    tcpListener.Stop();
                    oServerThread.Abort();
                    buttonListen.Text = "Listen";
                    buttonClientConnect.ForeColor = Color.DarkGreen;
                    textBoxClientsConnected.Clear();
                    textBoxServerRecieve.Clear();
                    textBoxClientsConnected.Enabled = false;
                    textBoxListenPort.Enabled = true;
                    groupBoxServerKeyboard.Enabled = false;
                    groupBoxServerRecieve.Enabled = false;
                    bServerIsListening = false;
                }
                catch
                {
                    textBoxServerLog.AppendText("Could not stop connection on Port " + textBoxListenPort.Text + Environment.NewLine);
                }
            }
        }

        private void serverThreadFunction()
        {
        }

        private void clientThreadFunction()
        {
            tcpClient = new TcpClient(textBoxServerName.Text, Convert.ToInt32(textBoxServerPort.Text));
            netStream = tcpClient.GetStream();
            buttonClientConnect.Text = "Disconnect";
            buttonClientConnect.ForeColor = Color.Red;
            textBoxServerName.Enabled = false;
            textBoxServerPort.Enabled = false;
            groupBoxClientKeyboard.Enabled = true;
            groupBoxClientProtocol.Enabled = true;
            groupBoxClientReceive.Enabled = true;
            textBoxClientLog.AppendText("Successfully connected too Server " + textBoxServerName.Text + ":" + textBoxServerPort.Text + Environment.NewLine);
            oClientConnectThread.Abort();
        }

        private void buttonClientSend_Click(object sender, EventArgs e)
        {
            if (tcpClient.Connected)
            {
                byte[] streamBytes = System.Text.ASCIIEncoding.UTF8.GetBytes(textBoxClientSend.Text);
                netStream.Write(streamBytes, 0, streamBytes.Length);
            }
        }

        private void textBoxClientSend_TextChanged(object sender, EventArgs e)
        {
            if (checkBoxEveryKeystroke.Checked && tcpClient.Connected)
            {
                byte[] streamBytes = System.Text.ASCIIEncoding.UTF8.GetBytes(textBoxClientSend.Text);
                netStream.Write(streamBytes, 0, streamBytes.Length);
                textBoxClientLog.AppendText(textBoxClientSend.Text + Environment.NewLine);
            }
        }

        #region clearbuttons

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void buttonClientSendClear_Click(object sender, EventArgs e)
            {
                textBoxClientSend.Clear();
            }

            private void buttonClientRecieveClear_Click(object sender, EventArgs e)
            {
                textBoxClientReceive.Clear();
            }

            private void buttonClientLogClear_Click(object sender, EventArgs e)
            {
                textBoxClientLog.Clear();
            }

            private void buttonServerSendClear_Click(object sender, EventArgs e)
            {
                textBoxServerSend.Clear();
            }

            private void buttonServerRecieveClear_Click(object sender, EventArgs e)
            {
                textBoxServerRecieve.Clear();
            }

            private void buttonServerLogClear_Click(object sender, EventArgs e)
            {
                textBoxServerLog.Clear();
            }

        #endregion

            private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AboutBox myAboutBox = new AboutBox();
                myAboutBox.ShowDialog();
            }

    }
}
