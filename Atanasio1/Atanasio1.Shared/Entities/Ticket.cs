using Atanasio1.Shared.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Atanasio1.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public string TicketId { get; set; } = null!;

        [Display(Name = "Fecha de uso")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}")]
        public DateTime? UseDate { get; set; } = null;

        public bool isUsed { get; set; } = false;

        [Display(Name = "Portería")]
        public EntranceType? Entrance { get; set; } = null;
    }
}
