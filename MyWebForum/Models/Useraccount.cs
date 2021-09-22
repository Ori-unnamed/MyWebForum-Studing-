using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace MyWebForum.Models
{
    public partial class Useraccount: IdentityUser
    {
        
        public int UserNo { get; set; }
        public string UerName { get; set; }
        public string UserNickname { get; set; }
        public DateTime? RegTime { get; set; }
        public byte[] RankId { get; set; }
    }
}
