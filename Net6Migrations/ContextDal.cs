using Net6DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Net6Migration;

public class ContextDal : DbContext
{
    public ContextDal()
    {
    }

    public ContextDal(DbContextOptions<ContextDal> options)
        : base(options)
    {
    }

    private readonly string _connectionString;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("workstation id=xdavidgomez13.mssql.somee.com;packet size=4096;user id=xdavidgomez13_SQLLogin_1;pwd=*;data source=xdavidgomez13.mssql.somee.com;persist security info=False;initial catalog=xdavidgomez13");
        }
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Design> Designs { get; set; }
}