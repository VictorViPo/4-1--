using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardStorageService.Data

    public class CardStorageServiceDbContext : CardStorageServiceDbContext
{
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Card> Cards { get; set; }

    public CardStorageServiceDbContext(DbContextOptions options) : base(options) { }

    protected override void OnConFiguring(DbContextionsBuilder optionsBuilder)
    {
        base.OnConFiguring(optionsBuilder);
        optionsBuilder.UseSqlServer();
        optionsBuilder.UseLoadingProxies();
    }
    }
}