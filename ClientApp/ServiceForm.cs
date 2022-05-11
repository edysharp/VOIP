using Fleck;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class ServiceForm : Form
    {
        ServiceServer serviceServer;
        Service service;
        public ServiceForm(Service _service)
        {
            InitializeComponent();
            service = _service;
            portText.Text = service.port;
            ipText.Text = service.ip;
            serviceText.Text = service.serviceName;
            serviceServer = new ServiceServer(service);
            serviceServer.Start();

            timer1.Enabled = true;
        }

        public void SetStatus(string status)
        {
            statusText.Text = status;
        }

        public void SetIP(string ip)
        {
            ipText.Text = ip;
        }

        public void SetPort(string port)
        {
            portText.Text = port;
        }

        public void AddIncomingCalls(List<IWebSocketConnection> sockets)
        {
            incomingCallsListBox.Items.Clear();
            foreach (var socket in sockets)
            {
                incomingCallsListBox.Items.Add($"Incoming Call: {socket.ConnectionInfo.Id}");
            }
        }
        public void RefreshIncomingCalls()
        {
            if (serviceServer != null)
            {
                var sockets = serviceServer.GetSockets();
                
         
                foreach (var socket in sockets)
                {
                    
                    if (!incomingCallsListBox.Items.Contains($"Incoming Call: Client {socket.Key}")) {
                        incomingCallsListBox.Items.Add($"Incoming Call: Client {socket.Key}");
                    }
                   
                }
            }
     
            
        }


        private void ServiceForm_Load(object sender, EventArgs e)
        {
       
        }

        private void incomingCallsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(incomingCallsListBox.SelectedItem == null)
            {
                return;
            }
            int socketkey = int.Parse(Regex.Match(incomingCallsListBox.SelectedItem.ToString(), @"\d+").Value);
            serviceServer.ConnectAudio(socketkey);

            endCallButton.Show();
            audiConnectedLabel.Show();

        }

        private void stopServiceButton_Click(object sender, EventArgs e)
        {
            ServerSocket.RemoveService(service);
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshIncomingCalls();
            statusText.Text = serviceServer.GetStatus();
        }

        private void endCallButton_Click(object sender, EventArgs e)
        {
            serviceServer.StopAudio();
            incomingCallsListBox.ClearSelected();
            endCallButton.Hide();
            audiConnectedLabel.Hide();

        }

        private void audiConnectedLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
