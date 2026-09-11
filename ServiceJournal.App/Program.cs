using ServiceJournal.Data;
using ServiceJournal.Logic;

string jsonPath = Path.Combine(AppContext.BaseDirectory, "repairs.json");
string xmlPath = Path.Combine(AppContext.BaseDirectory, "repairs.xml");

string kind = args.Length > 0 ? args[0] : "json";

IRepairRepository repository = kind switch
{
    "xml" => new XmlRepairRepository(xmlPath),
    "memory" => new RepairRepository(),
    _ => new JsonRepairRepository(jsonPath)
};
    
Console.WriteLine($"Хранилище: {kind}");
var service = new RepairService(repository);

Console.WriteLine("Новое оборудование: ");
string equipment = Console.ReadLine();

service.AddRepair(equipment, false);
Console.WriteLine("Отобранные записи:");
Console.WriteLine($"Количество незавершённых ремонтов: {service.GetIncompleteRepairsCount()}");

foreach (var item in service.GetImportant())
{
    Console.WriteLine($"{item.Id}: {item.IsDone}");
}