using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class TblLocation
{
    public int LocNum { get; set; }

    public string? LocName { get; set; }

    public virtual ICollection<TblProject> TblProjects { get; set; } = new List<TblProject>();

    public virtual ICollection<TblDepartment> DepNums { get; set; } = new List<TblDepartment>();
}
