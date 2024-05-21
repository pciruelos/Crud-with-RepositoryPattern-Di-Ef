

namespace CrudRepositoryPatternDiEf.Services.FrontManSerivce
{
    public class FrontManService : IFrontManService
    {
        private static List<FrontMan> frontMans = new List<FrontMan>
        {
                new FrontMan
                {   Id = 1,
                    Name = "fredy mercuri",
                    Band = "queen",
                    Alive = false
                },
                new FrontMan
                {   Id = 2,
                    Name = "indio solari",
                    Band = "los redondos",
                    Alive = true
                },
        };
        public FrontMan AddFrontMan(FrontMan frontMan)
        {
            frontMans.Add(frontMan);
            return frontMans;
        }

        public List<FrontMan> DeleteFrontMan(int id)
        {
            var frontMan = frontMans.Find(x => x.Id == id);
            //if (frontMan == null)
            //{
            //    return null;
            //}
            frontMans.Remove(frontMan);

            return frontMans;
        }

        public List<FrontMan> GetAllFrontMans()
        {
            return frontMans;
        }

        public FrontMan GetFrontMan(int id)
        {
            var frontMan = frontMans.Find(x => x.Id == id);
            return frontMan;
        }

        public FrontMan UpdateFrontMan(int id, FrontMan requestFrontMan)
        {
            var frontMan = frontMans.Find(x => x.Id == id);
            //if (frontMan == null)
            //{
            //    return NotFound();
            //}
            frontMan.Name = requestFrontMan.Name;
            frontMan.Band = requestFrontMan.Band;
            frontMan.Alive = requestFrontMan.Alive;

            return frontMan;
        }
    }
}
