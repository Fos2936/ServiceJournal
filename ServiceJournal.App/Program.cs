using ServiceJournal.Data;
using ServiceJournal.Logic;

IRepairRepository repository = new DemoRepairRepository();

var service = new RepairService(repository);

Console.WriteLine("Отобранные записи:");

foreach (var item in service.GetImportant())
{
    Console.WriteLine($"{item.Id}: {item.IsDone}");
}
