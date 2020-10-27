using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSamples.Models
{
    public class Artist
    {
        public Guid Id { get; set; }
        public string ArtsName { get; set; }
        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}
