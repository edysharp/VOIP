namespace ClientApp
{
    public partial class Form1 : Form
    {
        AddServiceForm addServiceForm;
      
        
        public Form1()
        {
            InitializeComponent();
   
            ServerSocket.Connect();

            var services = ServerSocket.GetServices();
            AddServicesToPanel(services);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public async void AddServicesToPanel(Task<List<Models.Service>> _services)
        {
            var services = await _services;
            
            foreach (Models.Service service in services)
            {

                Button b = new Button();
                b.Width = 320;
                b.Height = 65;
                b.Text = service.serviceName;
                servicePanel.Controls.Add(b);
                b.Click += (a, b) => button_Click(a,b,service);
            }
        }

        private void addService_Click(object sender, EventArgs e)
        {
            addServiceForm = new AddServiceForm();
            addServiceForm.Show();
        }
        private void button_Click(object sender, EventArgs e, Models.Service service)
        {
            CallForm form= new CallForm(service);
            form.Show();
        }

        private void servicePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refreshServices_Click(object sender, EventArgs e)
        {
            servicePanel.Controls.Clear();
            var services = ServerSocket.GetServices();
            AddServicesToPanel(services);

        }
    }

}