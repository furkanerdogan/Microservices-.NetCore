using StackExchange.Redis;

namespace Course.Services.Basket.Services
{
    public class RedisService
    {
        private readonly string _host;

        private readonly int _port;

        private ConnectionMultiplexer _ConnectionMultiplexer; //its coming from redis library to connection

        public RedisService(string host, int port)
        {
            _host = host;
            _port = port;
        }

        public void Connect() => _ConnectionMultiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");

        public IDatabase GetDb(int db = 1) => _ConnectionMultiplexer.GetDatabase(db); //one of ready db from redis its first one
    }
}
