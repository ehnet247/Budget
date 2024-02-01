using System.ComponentModel.DataAnnotations;

namespace Budget.Api.Models;

    public class User
{
    [Key]
    public long user_id { get; set; }
    public string name { get; set; }
    public int user_role { get; set; }
}
