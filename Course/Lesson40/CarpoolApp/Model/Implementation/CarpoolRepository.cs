public class CarpoolRepository : ICarpoolRepository
{
    private readonly CarpoolerContext _context;

    public CarpoolRepository(CarpoolerContext context)
    {
        _context = context;
    }

    public void AddCarpooler(Carpooler carpooler)
    {
        _context.Carpooleres.Add(carpooler);
        _context.SaveChanges();
    }

    public void DeleteCarpooler(int carpollerid)
    {   
        _context.Carpooleres.Where(c => c.ID == carpollerid).ToList().ForEach(c => _context.Carpooleres.Remove(c));
        _context.SaveChanges(); 
    }

    public List<Carpooler> GetAllCarpooleres()
    {
        return _context.Carpooleres.ToList();
    }
}