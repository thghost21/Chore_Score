

namespace chore_score.Services;
public class ChoresService
{
  private readonly ChoresRepository _repository;

  public ChoresService(ChoresRepository repository)
  {
    _repository = repository;
  }

  public List<Chore> GetAllChores()
  {
    List<Chore> chores = _repository.GetAllChores();
    return chores;
  }

  public Chore GetChoreById(int choreId)
  {
    Chore chore = _repository.GetChoreByID(choreId);
    if (chore == null)
    {
      throw new Exception($"Invalid Chore Id: {choreId}");
    }
    return chore;
  }

  public void DeleteChore(int choreId)
  {
    _repository.DeleteChore(choreId);

  }

  internal Chore EditChore(int choreId, Chore choreData)
  {
    Chore chore = GetChoreById(choreId);
    chore.Description = choreData.Description;
    chore.Name = choreData.Name;
    chore.IsComplete = choreData.IsComplete;

    _repository.EditChore(chore);
    return chore;
  }

  internal Chore CreateChore(Chore choreData)
  {
    Chore chore = _repository.CreateChore(choreData);
    return chore;
  }
}
