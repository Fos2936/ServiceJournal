using System.Collections.Generic;
using ServiceJournal.Data;

namespace ServiceJournal.Logic;

public class RepairService
{
    private readonly RepairRepository _repository = new();

    public List<Repair> GetImportant()
    {
        return _repository.GetAll()
            .Where(item => item.IsDone == false)
            .ToList();
    }
}
