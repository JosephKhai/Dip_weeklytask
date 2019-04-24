using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dip_weeklytask.Models
{
    public class fakeData
    {
        public static IDictionary<int, Room1> room1 { get; set; }

        static fakeData()
        {
            room1 = new Dictionary<int, Room1>();
            room1.Add(0, new Room1 { Number = 223, Building = "TD", Capacity = 22 });
            room1.Add(1, new Room1 { Number = 203, Building = "TC", Capacity = 20 });
            room1.Add(2, new Room1 { Number = 210, Building = "TB", Capacity = 15 });
            room1.Add(3, new Room1 { Number = 310, Building = "TD", Capacity = 18 });
        }
    }
}


