using System;
using System.Collections.Generic;

#nullable disable

namespace MyWebForum.Models
{
    public partial class Userprofile
    {
        public int Id { get; set; }
        public int? UserNo { get; set; }
        public DateTime? RegTime { get; set; }
        public byte[] Sex { get; set; }
        public byte[] Avatar { get; set; }
        public string Introduction { get; set; }
        public int? Integral { get; set; }
    }
}
