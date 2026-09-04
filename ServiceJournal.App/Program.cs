using ServiceJournal.Logic;

var service = new RepairService();

Console.WriteLine("Отобранные записи:");

foreach (var item in service.GetImportant())
{
    Console.WriteLine($"{item.Id}: {item.IsDone}");
}
