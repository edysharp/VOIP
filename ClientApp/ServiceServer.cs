using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fleck;
using NAudio.Wave;
using Newtonsoft.Json;

namespace ClientApp
{
    internal class ServiceServer
    {
        private string ip;
        private string port;
        private string serviceName;
        private string serviceDescription;
        private string serverAddress;
        int id = 1;
        private Dictionary<int,IWebSocketConnection> SocketList; // this is basically going to be the list of incoming calls;
        private string status = "Disconnected";
        IWebSocketConnection ConnectedSocket = null;

        NAudio.Wave.WaveIn waveSource = null;
        NAudio.Wave.DirectSoundOut waveOut = null;
        public ServiceServer(Models.Service service) // ok so at this point, the user has said they are hosting a service, thus they need their own websocket server now
        {
            ip = service.ip;
            port = service.port;
            serviceName = service.serviceName;
            serviceDescription = service.serviceDescription;
            serverAddress = $"ws://{ip}:{port}";
            SocketList = new Dictionary<int,IWebSocketConnection>();
        }

        public void Start() // stats the server
        {
            try
            {
                var server = new WebSocketServer($"ws://0.0.0.0:{port}");
                server.Start(socket =>
                {
                    socket.OnOpen = () => SocketOpened(socket, id++);
                    socket.OnClose = () => SocketClosed(socket, id);
                    socket.OnMessage = message => Websocket_MessageReceived(message,socket);

                });

                status = "Connected";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void Websocket_MessageReceived(string data, IWebSocketConnection socket)
        {
          
            Dictionary<string, object> dataDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
            var messageType = dataDict["messageType"];

            switch (messageType)
            {
                case "WAVE":
                    waveOut = new NAudio.Wave.DirectSoundOut();
                    Models.WaveMessage msgReceived = JsonConvert.DeserializeObject<Models.WaveMessage>(data);

                    IWaveProvider provider = new RawSourceWaveStream(
                         new MemoryStream(msgReceived.buffer), new WaveFormat(44100, 1));

                    waveOut.Init(provider);
                    waveOut.Play();

                    //Debug.WriteLine("Wave Received");
                    break;
            }

        }

        public void SocketOpened(IWebSocketConnection socket,int id)
        {
            Debug.WriteLine($"Client with socket ID: {socket.ConnectionInfo.Id} connected");
            
            SocketList.Add(id,socket);
            
            status = "Open";
        }
        public void SocketClosed(IWebSocketConnection socket,int id)
        {
            Debug.WriteLine("Socket Closed");
           SocketList.Remove(id);
            status = "Closed";
          
        }


        public async void ConnectAudio(int id)
        {
            ConnectedSocket = SocketList[id];
            waveSource = new WaveIn();
            waveSource.WaveFormat = new WaveFormat(44100, 1);

            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            //waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);
            waveSource.StartRecording();

        }


        void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            Models.WaveMessage wave = new Models.WaveMessage() { messageType = "WAVE", buffer=e.Buffer,bytesRecorded=e.BytesRecorded};
            if(ConnectedSocket != null)
            {
                ConnectedSocket.Send(JsonConvert.SerializeObject(wave));
            }
        }

        public async void StopAudio()
        {
            waveSource.StopRecording();
         //   ConnectedSocket = null;
        }
        // Getters

        public Dictionary<int,IWebSocketConnection> GetSockets()
        {
            return SocketList;
        }

        public string GetStatus()
        {
            return status;
        }

    }
}
