


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

  public void DeleteChore(int choreId)
  {
    string sql = "DELETE FROM chores WHERE id = @choreId;";
    int rowsAffected = _db.Execute(sql, new { choreId = choreId });
    if (rowsAffected == 1)
    {
      return;
    }
    if (rowsAffected == 0)
    {
      throw new Exception("0 chores deleted");
    }
    if (rowsAffected > 1)
    {
      throw new Exception($"{rowsAffected} chores deleted");
    }
  }

  public Chore GetChoreByID(int choreId)
  {
    string sql = "SELECT * FROM chores WHERE id = @choreId;";

    Chore chore = _db.Query<Chore>(sql, new { choreId = choreId }).SingleOrDefault();
    return chore;
  }

  public Chore CreateChore(Chore choreData)
  {
    string sql = @"
    INSERT INTO 
    chores(name, description)
    VALUES(@Name, @Description);
    
    SELECT * FROM chores WHERE id = LAST_INSERT_ID()";

    Chore chore = _db.Query<Chore>(sql, choreData).SingleOrDefault();
    return chore;
  }

  public void EditChore(Chore chore)
  {
    string sql = @"
    UPDATE chores SET name = @Name, description = @Description, isComplete = @IsComplete WHERE ID = @Id;";

    _db.Execute(sql, chore);
  }
}