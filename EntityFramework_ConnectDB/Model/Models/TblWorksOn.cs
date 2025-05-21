using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class TblWorksOn
{
    public decimal EmpSsn { get; set; }

    public int ProNum { get; set; }

    public int? WorkHours { get; set; }

    public virtual TblProject ProNumNavigation { get; set; } = null!;
}
