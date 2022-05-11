using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SuperSocket.ClientEngine;
using WebSocket4Net;


namespace ClientApp
{
    public static class ServerSocket
    {
        
        static WebSocket serverSocket;
        static string serverAddress = "ws://127.0.0.1:8181";
        public static List<Models.Service> services;
        static Form1 form;
        public static void Connect()
        {
            
            serverSocket = new WebSocket(serverAddress);
            serverSocket.AutoSendPingInterval = 1000;
            serverSocket.Opened += new EventHandler(Websocket_Opened);
            serverSocket.Error += new EventHandler<SuperSocket.ClientEngine.ErrorEventArgs>(Websocket_Error);
            serverSocket.Closed += new EventHandler(Websocket_Closed);
            serverSocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(Websocket_MessageReceived);
            serverSocket.Open();
        }

        private static void Websocket_Opened(object sender, EventArgs e)
        {
            Debug.WriteLine("Connected To Websocket Server");
        }

        private static void Websocket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {

        }

        private static void Websocket_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Attempting Reconnect");
        }
        public static async void SendService(Models.Service service)
        {
            Models.ServiceMessage msg = new Models.ServiceMessage()
            {
                messageType = "ADD_SERVICE",
                service = service
            };
            serverSocket.Send(JsonConvert.SerializeObject(msg));
        }
        public static async void RemoveService(Models.Service service)
        {
            Models.ServiceMessage msg = new Models.ServiceMessage()
            {
                messageType = "REMOVE_SERVICE",
                service = service
            };
            serverSocket.Send(JsonConvert.SerializeObject(msg));
        }
        public static async Task<List<Models.Service>> GetServices(){ 
           
            while(services == null)
            {
               Thread.Sleep(50);
            }
            
            return services; 
        }

        private static void Websocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            string data = (e.Message);
            Dictionary<string,object> dataDict =  JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
            var messageType = dataDict["messageType"];
            
            switch (messageType) {
                case "SERVICES":
                    Models.ServicesMessage msgReceived = JsonConvert.DeserializeObject<Models.ServicesMessage>(data);
                    services = new List<Models.Service>();
                    services = msgReceived.services;
                  
                   
                    Debug.WriteLine("Services Received");
                    break;
            }
            
        }

    }
}
