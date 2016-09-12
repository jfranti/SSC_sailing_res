using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SSC_Resevations.Models
{
    public class SSC_ReservationsContext : DbContext
    {
        public virtual DbSet<Boat> Boats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SSCReservations;integrated security=true");
        }
    }
}
