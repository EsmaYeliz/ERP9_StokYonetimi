﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //Require için ekledik..nbjgjgjhjhhjhjh
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.ViewModels
{
    public class RegisterViewModel
    {
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(50)]
        public string SurName { get; set; }
        [Required, StringLength(50)]
        public string Password { get; set; }
        [Required, StringLength(50)]
        public string Email { get; set; }
    }
}
