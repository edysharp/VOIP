using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class CallForm : Form
    {
        Models.Service service;
        ClientSocket socket;
        public CallForm(Models.Service _service)
        {
            InitializeComponent();
            service = _service;
            ipLabel.Text = _service.ip;
            serviceNameLabel.Text = _service.serviceName;
            descriptionLabel.Text = _service.serviceDescription;
            portLabel.Text = _service.port;

            
        }

     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CallForm_Load(object sender, EventArgs e)
        {

        }

        private void portLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Connecting To Audio";
            socket = new ClientSocket($"ws://{service.ip}:{service.port}");
            socket.Connect();
            button1.Text = "Connected To Audio";
            timer1.Enabled = true;
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statusLabel.Text = socket.GetStatus();
        }
    }
}
