using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSC_Resevations.Models
{
    [Table("Boats")]
    public class Boat
    {
        [Key]
        public int BoatId { get; set; }
        public string VesselName { get; set; }
        public int VesselLength { get; set; }
        public string VesselType { get; set; }
    }
}
