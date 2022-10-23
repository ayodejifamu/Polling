using EPolling.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System;
namespace EPolling.Domain.Model
{
    public class States
    {
        [Key]
        public int StateId { get; set; }
        public string? State { get; set; }
    }
}

