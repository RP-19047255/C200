using System;
namespace S02.Models
{
   public class SysUser
   {
      public string UserId { get; set; }
      public string Password { get; set; }
      public string FullName { get; set; }
      public string Email { get; set; }
      public string UserRole { get; set; }
      public DateTime LastLogin { get; set; }
      public string Token { get; set; }
   }
}
