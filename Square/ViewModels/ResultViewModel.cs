using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Square.ViewModels
{
    public class ResultViewModel
    {
        [Required]
        public double sidelength { get; set; }
        public double Area { get; set; }
        public String Error { get; set; }
    }
}


