using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromoARC.StartUp
{
    public class JsonWebTokenConfig
    {
        public string Secret { get; set; }
        public int ExpirationDays { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}
