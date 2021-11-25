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

    public ContextDal(string connectionString)
    {
        _connectionString = connectionString;
    }

     private readonly string _connectionString;

    public ApplicationDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }

    public DbSet<User> Users { get; set; }
}