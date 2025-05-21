using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class TblProject
{
    public int ProNum { get; set; }

    public string? ProName { get; set; }

    public int? LocNum { get; set; }

    public int? DepNum { get; set; }

    public virtual TblDepartment? DepNumNavigation { get; set; }

    public virtual TblLocation? LocNumNavigation { get; set; }

    public virtual ICollection<TblWorksOn> TblWorksOns { get; set; } = new List<TblWorksOn>();
}
