using System;
using System.Collections.Generic;

namespace ClassLibrary_Model.Models;

public partial class JobHistory
{
    public int? EmployeeId { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? JobId { get; set; }

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Job? Job { get; set; }
}
