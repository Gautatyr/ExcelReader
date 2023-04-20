using ExcelReader.Model;
using Microsoft.EntityFrameworkCore;

namespace ExcelReader;

public class DatabaseInteraction
{
    private readonly ExcelReaderContext Context;
    public DatabaseInteraction(ExcelReaderContext context)
    {
        Context = context;
    }

    public void SeedDatabaseFromList(List<Aliment> aliments)
    {
        foreach (var aliment in aliments)
        {
            Context.Aliments.Add(aliment);
            Context.SaveChanges();
        }
    }
}
