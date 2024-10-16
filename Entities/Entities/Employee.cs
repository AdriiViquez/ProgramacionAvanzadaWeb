﻿using System;
using System.Collections.Generic;

namespace Entities.Entities;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Idnumber { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public DateOnly? HireDate { get; set; }

    public string? Position { get; set; }
}
