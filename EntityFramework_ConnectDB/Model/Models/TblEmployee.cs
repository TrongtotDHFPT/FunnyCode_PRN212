using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class TblEmployee
{
    public decimal EmpSsn { get; set; }

    public string? EmpName { get; set; }

    public string? EmpAddress { get; set; }

    public decimal? EmpSalary { get; set; }

    public string? EmpSex { get; set; }

    public DateTime? EmpBirthdate { get; set; }

    public int? DepNum { get; set; }

    public decimal? SupervisorSsn { get; set; }

    public DateTime? EmpStartdate { get; set; }

    public virtual TblDepartment? DepNumNavigation { get; set; }

    public virtual ICollection<TblEmployee> InverseSupervisorSsnNavigation { get; set; } = new List<TblEmployee>();

    public virtual TblEmployee? SupervisorSsnNavigation { get; set; }

    public virtual ICollection<TblDepartment> TblDepartments { get; set; } = new List<TblDepartment>();

    public virtual ICollection<TblDependent> TblDependents { get; set; } = new List<TblDependent>();
}
