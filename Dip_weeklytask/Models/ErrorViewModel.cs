using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Dip_weeklytask.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class RoomDbContext : DbContext
    {
        public RoomDbContext(DbContextOptions<RoomDbContext> options)
            : base(options)
        {

        }

        public DbSet<Room_Control> Rooms { get; set; }
    }

    public class Room_Control
    {
        public Room_Control()
        {
            Number = Guid.NewGuid().ToString();
        }

        [Key]
        public string Number { get; set; }   
        public string Building { get; set; }
        public int Capacity { get; set; }
    }
}