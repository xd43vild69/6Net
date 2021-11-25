using Net6DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net6Migration;

public class ContextDal: DbContext
{
    public ContextDal(DbContextOptions<ContextDal> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
}