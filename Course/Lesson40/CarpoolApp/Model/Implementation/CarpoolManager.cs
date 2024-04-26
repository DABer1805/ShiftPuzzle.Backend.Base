
public class CarpoolManager : ICarpoolManager
{
    private ICarpoolRepository _carpoolerRepository;

    public CarpoolManager(ICarpoolRepository carpoolerRepository)
    {
        _carpoolerRepository = carpoolerRepository;
    }   
    public void AddCarpooler(Carpooler carpooler)
    { 
        _carpoolerRepository.AddCarpooler(carpooler);
    }

    public void DeleteCarpooler(int carpoolerId)
    { 
        _carpoolerRepository.DeleteCarpooler(carpoolerId);
    } 

    public List<Carpooler> GetAllCarpooleres()
    { 
        return _carpoolerRepository.GetAllCarpooleres();
    }
}