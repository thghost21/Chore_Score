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
  public ActionResult<Chore> getChoreById(int choreId)
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
}