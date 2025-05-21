using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class TblDependent
{
    public string DepName { get; set; } = null!;

    public decimal EmpSsn { get; set; }

    public string? DepSex { get; set; }

    public DateTime? DepBirthdate { get; set; }

    public string? DepRelationship { get; set; }

    public virtual TblEmployee EmpSsnNavigation { get; set; } = null!;
}
