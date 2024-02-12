using Budget.Api.DataTransferObjects;
using Budget.Api.Entities;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Budget.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly BudgetContext _dBContext;

        private readonly ILogger<UserController> _logger;

        //public UserController(ILogger<UserController> logger)
        public UserController(BudgetContext dBContext, ILogger<UserController> logger)
        {
            _dBContext = dBContext;
            _logger = logger;
        }

        [HttpGet("GetUsers")]
        public IEnumerable<User> Get()
        {
            var getUsers = _dBContext.Users.ToList();
            var users = getUsers.ToArray();

            if (users.Count() < 0)
            {
                return Enumerable.Empty<User>();
            }
            else
            {
                return users;
            }
        }
    }
}
