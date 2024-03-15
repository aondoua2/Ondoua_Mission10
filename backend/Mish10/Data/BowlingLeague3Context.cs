using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;

namespace Mish10.Data;

public class BowlingLeague3Context : DbContext // liaison
{
    public DbSet<Bowler> Bowlers { get; set; }
    public DbSet<Team> Teams { get; set; }

    public BowlingLeague3Context(DbContextOptions<BowlingLeague3Context>options) : base(options)
    {

    }
 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=BowlingLeague (3).sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    private void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
     
    }
}
