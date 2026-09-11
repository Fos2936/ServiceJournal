using ServiceJournal.Logic;

namespace ServiceJournal.Data;

public class RepairRepository : IRepairRepository
{
    private readonly List<Repair> _items = new()
    {
        new Repair { Id = 1, Equipment = "Токарный станок", IsDone = false },
        new Repair { Id = 2, Equipment = "Гидравлический пресс", IsDone = false },
        new Repair { Id = 3, Equipment = "Сварочный аппарат", IsDone = true }
    };

    public List<Repair> GetAll() => _items;

    public void Add(Repair item)
    {
        // Демонстрационное хранилище доступно только для чтения
    }
}