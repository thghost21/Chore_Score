namespace chore_score.Controllers;
[ApiController]
[Route("api/chores")]

public class ChoresController : ControllerBase
{

  private readonly ChoresService _choresService;

  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }

  [HttpGet]
  public ActionResult<List<Chore>> GetAllChores()
  {
    try
    {
      List<Chore> chores = _choresService.GetAllChores();
      return Ok(chores);
    }
    catch (Exception error)
    {

      return BadRequest(error.Message);
    }
  }
  [HttpGet("{choreId}")]
  public ActionResult<Chore> GetChoreById(int choreId)
  {
    try
    {
      Chore chore = _choresService.GetChoreById(choreId);
      return chore;
    }
    catch (Exception error)
    {

      return BadRequest(error.Message);
    }
  }
  [HttpDelete("{choreId}")]
  public ActionResult<Chore> DeleteChore(int choreId)
  {
    try
    {
      _choresService.DeleteChore(choreId);
      return Ok("Chore Deleted");
    }
    catch (Exception error)
    {

      return BadRequest(error.Message);
    }
  }
  [HttpPost]
  public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = _choresService.CreateChore(choreData);
      return Ok(chore);
    }
    catch (Exception error)
    {

      return BadRequest(error.Message);
    }
  }
  [HttpPut("{choreId}")]
  public ActionResult<Chore> EditChore([FromBody] Chore choreData, int choreId)
  {
    try
    {
      Chore chore = _choresService.EditChore(choreId, choreData);
      return Ok(chore);
    }
    catch (Exception error)
    {

      return BadRequest(error.Message);
    }
  }
}