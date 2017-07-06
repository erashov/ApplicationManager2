using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace ApplicationManager.DAL.Entites
{
    public class UserEntity:IdentityUser
    {
        public string Login { get; set; }
        public int GroupId { get; set; }
        public GroupEntity Group { get; set; }
    }
}