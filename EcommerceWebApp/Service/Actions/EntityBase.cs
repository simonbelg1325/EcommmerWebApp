using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceWebApp.Service.Actions
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ChangedBy { get; set; }
        public DateTime? ChangedOn { get; set; }

    }
}
