namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        //TODO
        public IEnumerable<Pie> AllPies => throw new NotImplementedException();

        public IEnumerable<Pie> PieOfTheWeek => throw new NotImplementedException();

        public Pie? GetPiById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
