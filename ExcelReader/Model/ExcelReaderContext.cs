using Microsoft.EntityFrameworkCore;

namespace ExcelReader.Model;

public class ExcelReaderContext : DbContext
{
    public DbSet<Aliment> aliments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseInMemoryDatabase("ExcelReader,db");
}
