using EPolling.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace EPolling.Domain.Model
{
    public class Wards
    {
        [Key]
        public int WardId { get; set; }
        public string Ward { get; set; }
        public int LgaId { get; set; }
        public int StateId { get; set; }
    }
}

