using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using Newtonsoft.Json;
using SuperSocket.ClientEngine;
using WebSocket4Net;


namespace ClientApp
{
    internal class ClientSocket
    {

        private string status = "Disconnected";
        static WebSocket serverSocket;
        static string serverAddress;
        public static List<Models.Service> services;
        NAudio.Wave.WaveIn waveSource = null;
        NAudio.Wave.DirectSoundOut waveOut = null;


        public ClientSocket(string _serverAddress)
        {
            serverAddress = _serverAddress;
        }
        public void Connect()
        {
            
            status = "Connecting";
            serverSocket = new WebSocket(serverAddress);
            serverSocket.AutoSendPingInterval = 1000;
            serverSocket.Opened += new EventHandler(Websocket_Opened);
            serverSocket.Error += new EventHandler<SuperSocket.ClientEngine.ErrorEventArgs>(Websocket_Error);
            serverSocket.Closed += new EventHandler(Websocket_Closed);
            serverSocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(Websocket_MessageReceived);
            serverSocket.Open();
            status = "Opening";
        }

        public string GetStatus()
        {
            return status;
        }

        private void Websocket_Opened(object sender, EventArgs e)
        {
            status = "Open";
            Debug.WriteLine("Connected To Websocket Voice Channel");
        }

        private void Websocket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            status = "Error Connecting";
        }

        private void Websocket_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Attempting Reconnect");
        }
        public async Task<List<Models.Service>> GetServices()
        {

            while (services == null)
            {
                Thread.Sleep(50);
            }

            return services;
        }

        private void Websocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            string data = (e.Message);
            Dictionary<string, object> dataDict = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);
            var messageType = dataDict["messageType"];

            switch (messageType)
            {
                case "WAVE":
                    status = "Operator Connected";
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


        public async void ConnectAudio(int id)
        {
            waveSource = new WaveIn();
            waveSource.WaveFormat = new WaveFormat(44100, 1);

            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            //waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);
            waveSource.StartRecording();
        }


        void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            Models.WaveMessage wave = new Models.WaveMessage() { messageType = "WAVE", buffer = e.Buffer, bytesRecorded = e.BytesRecorded };
            if (serverSocket != null)
            {
                serverSocket.Send(JsonConvert.SerializeObject(wave));
            }
        }

        public async void StopAudio()
        {
            waveSource.StopRecording();
            //   ConnectedSocket = null;
        }
        // Getters

    }
}
