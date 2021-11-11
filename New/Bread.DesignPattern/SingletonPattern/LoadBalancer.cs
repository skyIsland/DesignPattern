using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class LoadBalancer
    {
        private static LoadBalancer _instance = null;

        private IList<CustomServer> _serverList = null;

        private LoadBalancer()
        {
            _serverList = new List<CustomServer>();
        }

        public static LoadBalancer GetLoadBalancer()
        {
            if (_instance == null)
            {
                _instance = new LoadBalancer();
            }
            return _instance;
        }

        public void AddServer(CustomServer server)
        {
            this._serverList.Add(server);
        }

        public void RemoveServer(string serverName)
        {
            var temp = _serverList.FirstOrDefault(x => x.Name == serverName);
            if (temp != null)
            {
                this._serverList.Remove(temp);
            }
        }

        private Random rand = new Random();
        public CustomServer GetServer()
        {
            int index = rand.Next(_serverList.Count);

            return _serverList[index];
        }
    }

    public class CustomServer
    {
        public string Name { get; set; }

        public int Size { get; set; }
    }
}
