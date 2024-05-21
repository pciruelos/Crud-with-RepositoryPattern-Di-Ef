namespace CrudRepositoryPatternDiEf.Services.FrontManSerivce
{
    public interface IFrontManService
    {
        List<FrontMan> GetAllFrontMans();
        FrontMan GetFrontMan(int id);
        FrontMan AddFrontMan(FrontMan frontMan);
        FrontMan UpdateFrontMan(int id, FrontMan requestFrontMan);
        List<FrontMan> DeleteFrontMan(int id);

    }
}
