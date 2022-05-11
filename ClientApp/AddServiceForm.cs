using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class AddServiceForm : Form
    {
        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void AddServiceForm_Load(object sender, EventArgs e) { 
        
        }

        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hostServiceButton_Click(object sender, EventArgs e)
        {
            try
            {
                string serviceName = serviceNameTextBox.Text.ToString();
                string serviceDescription = descriptionTextBox.Text.ToString(); 
                string serviceIP = ipTextBox.Text.ToString(); 
                string servicePort = portTextBox.Text.ToString(); 
                

                

                Models.Service service = new Models.Service() { serviceName=serviceName,ip = serviceIP,port = servicePort , serviceDescription= serviceDescription };
                ServerSocket.SendService(service);
                ServiceForm form = new ServiceForm(service);
                form.Show();
                this.Close();

    


            }
            catch (Exception ex)
            {
                Debug.WriteLine(" \n Error Getting Form Values \n");

            }
        }
    }
}
