using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipmentTracker
{
    public class Equipment
    {
        //core model
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public bool Status { get; set; } = false; 
        public DateTime LastMaintenanceDate { get; set; } = DateTime.MinValue; 

    }
}
