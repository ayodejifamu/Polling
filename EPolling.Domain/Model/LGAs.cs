using EPolling.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace EPolling.Domain.Model
{
    public class LGAs
    {
        [Key]
        public int LgaId { get; set; }
        public string LGA { get; set; }
        public int StateId { get; set; }
    }
}

