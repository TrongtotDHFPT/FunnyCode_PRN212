﻿using System;
using System.Collections.Generic;

namespace ClassLibrary_Model.Models;

public partial class Job
{
    public string JobId { get; set; } = null!;

    public string? JobTitle { get; set; }

    public int? MinSalary { get; set; }

    public int? MaxSalary { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
