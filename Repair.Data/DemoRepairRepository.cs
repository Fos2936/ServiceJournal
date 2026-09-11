using System.Collections.Generic;
using ServiceJournal.Logic;

namespace ServiceJournal.Data;

public class DemoRepairRepository : IRepairRepository
{
    public List<Repair> GetAll()
    {
        return new List<Repair>
        {
            new Repair { Id = 33, Equipment = "Воздушный компрессор", IsDone = false }
        };
    }

    public void Add(Repair item)
    {
        // Демонстрационное хранилище доступно только для чтения
    }
}