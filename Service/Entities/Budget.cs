using System;
using System.Collections.Generic;

namespace Budget.Api.Entities;

public partial class Budget
{
    public int IdBudget { get; set; }

    public string Name { get; set; } = null!;

    public int? MonthlyAllocatedAmount { get; set; }

    public int? SpentAmount { get; set; }

    public virtual ICollection<Expense> Expenses { get; set; } = new List<Expense>();
}
