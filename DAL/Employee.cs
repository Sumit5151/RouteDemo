using System;
using System.Collections.Generic;

namespace RouteDemo.DAL;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? GenderId { get; set; }

    public int? DepartmentId { get; set; }



    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual Department? Department { get; set; }

    public virtual Gender? Gender { get; set; }
}
