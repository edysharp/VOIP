namespace Models
{

    public class Message
    {
        public string messageType;
        public string body;

    }

    public class ServicesMessage
    {
        public string messageType;
        public List<Service> services;
    }
    public class ServiceMessage
    {
        public string messageType;
        public Service service;
    }

    public class Service
    {
        public string serviceName;
        public string serviceDescription;
        public string ip;
        public string port;
        public Guid socketId;
    }

    public class WaveMessage
    {
        public string messageType;
        public byte[] buffer;
        public int bytesRecorded;
    }


}