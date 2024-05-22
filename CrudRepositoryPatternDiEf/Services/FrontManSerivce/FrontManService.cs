

namespace CrudRepositoryPatternDiEf.Services.FrontManSerivce
{
    public class FrontManService : IFrontManService
    {
        //private static List<FrontMan> frontMans = new List<FrontMan>
        //{
        //        new FrontMan
        //        {   Id = 1,
        //            Name = "fredy mercuri",
        //            Band = "queen",
        //            Alive = false
        //        },
        //        new FrontMan
        //        {   Id = 2,
        //            Name = "indio solari",
        //            Band = "los redondos",
        //            Alive = true
        //        },
        //};
        private readonly DataContext _context;

        public FrontManService(DataContext context)
        {
            _context = context;
        }
        public async Task<FrontMan> AddFrontMan(FrontMan frontMan)
        {
            _context.FrontMans.Add(frontMan);
            await _context.SaveChangesAsync();
            return frontMan;
        }

        public async Task<List<FrontMan>> DeleteFrontMan(int id)
        {
            var frontMan = await _context.FrontMans.FindAsync(id);
            //if (frontMan == null)
            //{
            //    return null;
            //}
            _context.FrontMans.Remove(frontMan);
            await _context.SaveChangesAsync();

            return await _context.FrontMans.ToListAsync();
        }

        public async Task<List<FrontMan>> GetAllFrontMans()
        {
            var frontmans = await _context.FrontMans.ToListAsync();
            return frontmans;
        }

        public async Task<FrontMan> GetFrontMan(int id)
        {
            var frontMan = await _context.FrontMans.FindAsync(id);
            return frontMan;
        }

        public async Task<FrontMan> UpdateFrontMan(int id, FrontMan requestFrontMan)
        {
            var frontMan = await _context.FrontMans.FindAsync(id);
            //if (frontMan == null)
            //{
            //    return NotFound();
            //}
            frontMan.Name = requestFrontMan.Name;
            frontMan.Band = requestFrontMan.Band;
            frontMan.Alive = requestFrontMan.Alive;

            await _context.SaveChangesAsync();

            return frontMan;
        }
    }
}
