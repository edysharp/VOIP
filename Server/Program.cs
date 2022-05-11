using Fleck;
using Newtonsoft.Json;
using System.Diagnostics;

Console.WriteLine("Starting VOIP Server");
Server.Start();
while (true)
{

}


public static class Server
{
    public static List<IWebSocketConnection> sockets = new List<IWebSocketConnection>();// this is to store the client sockets that connect to the server
    public static List<Models.Service> services = new List<Models.Service>(); // this is to store a list of the services // e.g. hotel room service, ip : x: port y

    public const string serverAddress = "ws://0.0.0.0:8181";
    
    public static void Start()
    {
        TestFill();
        var server = new WebSocketServer(serverAddress);
        server.Start(socket =>
        {
            socket.OnOpen = () => SocketOpened(socket);
            socket.OnClose = () => Console.WriteLine("Close!");
            socket.OnMessage = message => Websocket_MessageReceived(message,socket);
        });
    }

    public static void SocketOpened(IWebSocketConnection socket)
    {
        Console.WriteLine($"Client with socket ID: {socket.ConnectionInfo.Id} connected");
        sockets.Add(socket);
        SendServices(socket);
    }


    public static void SocketClosed(IWebSocketConnection socket)
    {
        sockets.Remove(socket); //when a socket is closed, we need to remove it, and see if they have listed any services
        services.RemoveAll(service => service.socketId == socket.ConnectionInfo.Id);
    }


    public static void AddService(Models.Service service, IWebSocketConnection socket)
    {
      
    }

    public static void SendServices(IWebSocketConnection socket)
    {
        Models.ServicesMessage message = new Models.ServicesMessage()
        {
            services = services,
            messageType = "SERVICES"
        };
        socket.Send(JsonConvert.SerializeObject(message));

    }
    public static void SendServices()
    {
        Models.ServicesMessage message = new Models.ServicesMessage()
        {
            services = services,
            messageType = "SERVICES"
        };
        foreach (var socket in sockets)
        {
            socket.Send(JsonConvert.SerializeObject(message));
        }
       

    }
    private static void Websocket_MessageReceived(string data, IWebSocketConnection socket)
    {
        Dictionary<string, object> dataDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
        var messageType = dataDict["messageType"];

        switch (messageType)
        {
            case "ADD_SERVICE":
                Models.ServiceMessage msgReceived = JsonConvert.DeserializeObject<Models.ServiceMessage>(data);
                msgReceived.service.socketId = socket.ConnectionInfo.Id;
                services.Add(msgReceived.service);
                SendServices();


                Debug.WriteLine("Services Received");
                break;
            case "REMOVE_SERVICE":
                Models.ServiceMessage msgReceived2 = JsonConvert.DeserializeObject<Models.ServiceMessage>(data);
                services.RemoveAll(service => service.socketId == socket.ConnectionInfo.Id);
                SendServices();


                Debug.WriteLine("Remove Services Received");
                break;
        }

    }

    #region testing Services

    public static void TestFill()
    {
        services = new List<Models.Service>()
        {
            new Models.Service() { ip = "test.ip.1.1.4", serviceDescription = "Room Service For Hotel Wifi", serviceName = "Room Service", port = "1234" },
            new Models.Service() { ip = "test.ip.4.9.7", serviceDescription = "Reception Service For Hotel Wifi", serviceName = "Reception Service", port = "4124" },
            new Models.Service() { ip = "test.ip.9.6.9", serviceDescription = "Concierge For Hotel Wifi", serviceName = "Concierge", port = "1243" },
            new Models.Service() { ip = "test.ip.7.4.0", serviceDescription = "Houskeeping For Hotel Wifi", serviceName = "House Keeping", port = "2123" },
            new Models.Service() { ip = "test.ip.5.3.4", serviceDescription = "Restaruant For Hotel Wifi", serviceName = "Restaruant Bookings", port = "6873" },



        };
    }
    #endregion

}


