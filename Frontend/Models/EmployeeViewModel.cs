﻿using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frontend.Models
{
    public class EmployeeViewModel
    {

        [DisplayName("ID")]
        public int EmployeeID { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; }

        public string IDNumber { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public DateOnly? HireDate { get; set; }

        public string Position { get; set; }
    }
}
