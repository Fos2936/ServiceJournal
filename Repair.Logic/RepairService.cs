using System.Collections.Generic;

namespace ServiceJournal.Logic;

public class RepairService
{
    private readonly IRepairRepository _repository;

    public RepairService(IRepairRepository repository)
    {
        _repository = repository;
    }

    public List<Repair> GetImportant()
    {
        return _repository.GetAll()
            .Where(item => item.IsDone == false)
            .ToList();
    }

    public void AddRepair(string equipment, bool isDone)
    {
        if (string.IsNullOrWhiteSpace(equipment)) return;
        int nextId = _repository.GetAll().Count + 1;
        _repository.Add(new Repair
        {
            Id = nextId,
            Equipment = equipment,
            IsDone = isDone
        });
    }

    public int GetIncompleteRepairsCount() => _repository.GetAll().Count(item => !item.IsDone);
}
