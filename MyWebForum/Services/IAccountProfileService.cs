using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebForum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace MyWebForum.Services
{
    public interface IAccountProfileService
    {
        public Userprofile getProfile(int no);
    }

    public class AccountProfileService : IAccountProfileService
    {
        private readonly ApplicationDbContext _context;

        public AccountProfileService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Userprofile getProfile(int no)
        {
            return _context.USERPROFILE.Where<Userprofile>(i => i.UserNo == no).First();
        }

    }
}
