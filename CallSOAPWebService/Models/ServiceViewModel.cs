using System;
using System.ComponentModel.DataAnnotations;

namespace CallSOAPWebService.Models
{
    public class ServiceViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}