namespace CrudRepositoryPatternDiEf.Services.FrontManSerivce
{
    public interface IFrontManService
    {
        Task<List<FrontMan>> GetAllFrontMans();
        Task<FrontMan> GetFrontMan(int id);
        Task<FrontMan> AddFrontMan(FrontMan frontMan);
        Task<FrontMan> UpdateFrontMan(int id, FrontMan requestFrontMan);
        Task<List<FrontMan>> DeleteFrontMan(int id);

    }
}
