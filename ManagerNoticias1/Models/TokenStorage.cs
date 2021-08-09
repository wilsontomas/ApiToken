using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticiasManager.Models
{
    class TokenStorage
    {
        private static TokenStorage _Instance;
        private TokenStorage() { }
        public static TokenStorage Instance { get {
                if (_Instance == null) _Instance = new TokenStorage();
                return _Instance;
            } }

        public string token { get; set; }
    }
}
