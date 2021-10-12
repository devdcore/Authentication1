using Authentication1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication1.Model
{
    public class AuthDbContext: IdentityDbContext<ExtraInfoUser>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) 
        { 
            
        }
    }
}
