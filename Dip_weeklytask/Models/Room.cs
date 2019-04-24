using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dip_weeklytask.Models
{
    public class Room
    {
       
        public int Number;
        public string Building;
        public int Capacity;
        
        public Room()
        {
            Number = 224;
            Building = "TD";
            Capacity = 22;
        }        

        public Room(int number, string building, int capacity)
        {
            Number = number;
            Building = building;
            this.Capacity = capacity;
        }

        public string getInfo()
        {
            return $"{Building}{Number} - {Capacity}";
        }
    }

    
    
}
