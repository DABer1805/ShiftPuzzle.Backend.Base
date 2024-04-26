using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;   

public class CarpoolController : ControllerBase
{
    private readonly ICarpoolManager _carpoolManager;

    public CarpoolController(ICarpoolManager carpoolManager)
    {
        _carpoolManager = carpoolManager;
    }   

    [HttpGet("api/carpool/search")]
    public IEnumerable<Carpooler> GetAll()
    {
        // Пока так, фильтры если успею, то добавлю (но задел для них готов в БД)
        return _carpoolManager.GetAllCarpooleres();
    }

    [HttpPost("api/carpool/add")]
    public void Create([FromBody] Carpooler task)
    {
        _carpoolManager.AddCarpooler(task);
    }

    [HttpDelete("api/carpool/{id}")]
    public void Delete(int id)
    {  
        _carpoolManager.DeleteCarpooler(id); 
    }
}