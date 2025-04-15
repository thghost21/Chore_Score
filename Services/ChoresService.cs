

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
}
