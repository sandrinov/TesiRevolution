using System;
using System.ComponentModel.DataAnnotations;

namespace AppointmentsManagerShared
{
    public class Call
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Mandatory Field Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Mandatory Field Name")]
        [StringLength(50)]
        public string Provider { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        [StringLength(500)]
        public string Note { get; set; }
    }
}
