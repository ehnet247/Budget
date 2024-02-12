namespace Budget.Api.DataTransferObjects
{
    public class RoleDto
    {
        public int IdRole { get; set; }

        public string RoleName { get; set; } = null!;

        public virtual ICollection<UserDto> Users { get; set; } = new List<UserDto>();
    }
}
