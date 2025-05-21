using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class TblDepartment
{
    public int DepNum { get; set; }

    public string? DepName { get; set; }

    public decimal? MgrSsn { get; set; }

    public DateTime? MgrAssDate { get; set; }

    public virtual TblEmployee? MgrSsnNavigation { get; set; }

    public virtual ICollection<TblEmployee> TblEmployees { get; set; } = new List<TblEmployee>();

    public virtual ICollection<TblProject> TblProjects { get; set; } = new List<TblProject>();

    public virtual ICollection<TblLocation> LocNums { get; set; } = new List<TblLocation>();
}
