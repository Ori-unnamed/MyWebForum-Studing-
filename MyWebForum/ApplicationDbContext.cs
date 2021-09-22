using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MyWebForum.Models;

namespace MyWebForum
{
    public class ApplicationDbContext : IdentityDbContext<Useraccount>
    {
        public DbSet<Useraccount> useraccounts { get; set; }
        public DbSet<Userprofile> USERPROFILE { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }


}