public interface ICarpoolManager
{
    List<Carpooler> GetAllCarpooleres();
    void AddCarpooler(Carpooler carpooler);
    void DeleteCarpooler(int carpoolerId);
}