namespace Budget.Api.DataTransferObjects
{
    public class ExpenseDto
    {
        public int IdExpense { get; set; }

        public string? Description { get; set; }

        public int? FkIdUser { get; set; }

        public int? FkIdBudget { get; set; }

        public virtual BudgetDto? BudgetNavigation { get; set; }
    }
}
