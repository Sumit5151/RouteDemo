using System;
using System.Collections.Generic;

namespace RouteDemo.DAL;

public partial class Address
{
    public int Id { get; set; }

    public string? Address1 { get; set; }

    public bool? IsPreferred { get; set; }

    public int? EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }
}
