using DataAccessLogic.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLogic.DataBaseContext
{
    public class FlatLineDataBaseContext : IdentityDbContext<User>
    {
        public FlatLineDataBaseContext(DbContextOptions<FlatLineDataBaseContext> options)
            : base(options)
        {

        }
    }
}
