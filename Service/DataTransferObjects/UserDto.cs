using Budget.Api.Entities;

namespace Budget.Api.DataTransferObjects
{
    public class UserDto
    {
        public int IdUser { get; set; }

        public string? Name { get; set; }

        public string? Password { get; set; }

        public int FkRoleId { get; set; }

        public string? UserRole
        {
            get
            {
                if (FkRole != null)
                    return FkRole.ToString();
                else
                    return string.Empty;
            }
            set
            {
            }
        }

        public virtual Role FkRole { get; set; } = null!;
    }
}
