using System;
using System.Collections.Generic;

namespace Budget.Api.Entities;

public partial class Expense
{
    public int IdExpense { get; set; }

    public string? Description { get; set; }

    public int? FkIdUser { get; set; }

    public int? FkIdBudget { get; set; }

    public virtual Budget? FkIdBudgetNavigation { get; set; }
}
