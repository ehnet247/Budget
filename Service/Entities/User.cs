using System;
using System.Collections.Generic;

namespace Budget.Api.Entities;

public partial class User
{
    public int IdUser { get; set; }

    public string? Name { get; set; }

    public string? Password { get; set; }

    public int FkRoleId { get; set; }

    public string? UserRole { get; set; }

    public virtual Role FkRole { get; set; } = null!;
}
