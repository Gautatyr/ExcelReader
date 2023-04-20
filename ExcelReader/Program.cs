using ExcelReader;
using ExcelReader.Model;

ExcelReaderContext context = new();
DatabaseInteraction database = new(context);

//Add SPecte console loading on and comment
List<Aliment> aliments = Reader.ParseFile();

//Add SPecte console loading on and comment
database.SeedDatabaseFromList(aliments);

//Display Database Results