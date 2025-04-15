
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
}
