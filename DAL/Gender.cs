using System;
using System.Collections.Generic;

namespace RouteDemo.DAL;

public partial class Gender
{
    public int Id { get; set; }

    public string? Text { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
