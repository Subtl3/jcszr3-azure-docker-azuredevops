using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballHub.Core.Models
{
    public class Stadium
    {
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Stadium()
        {

        }

        public Stadium(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
    }
}
