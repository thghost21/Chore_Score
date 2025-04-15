

public class ChoresRepository
{
  private readonly IDbConnection _db;
  public ChoresRepository(IDbConnection db)
  {
    _db = db;
  }

  public List<Chore> GetAllChores()
  {
    string sql = "SELECT * FROM chores;";
    List<Chore> chores = _db.Query<Chore>(sql).ToList();
    return chores;
  }

  internal Chore GetChoreByID(int choreId)
  {
    string sql = "SELECT * FROM chores WHERE id = @choreId;";

    Chore chore = _db.Query<Chore>(sql, new { choreId = choreId }).SingleOrDefault();
    return chore;
  }
}