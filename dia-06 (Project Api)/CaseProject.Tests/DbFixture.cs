using Microsoft.EntityFrameworkCore;
using MinhaApi.Data;

namespace DbFixture
{
    public class DbFixture: IDisposable
    {
        public AppDbContext Context{get;}

        public DbFixture()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("lot-minerio").Options;
            Context = new AppDbContext(options);
        }
        // Metodo de apagar o banco 
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}