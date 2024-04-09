namespace Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable 
    {
        private readonly DataContext _context;

        public IBookRepository Books { get; private set; }

        public UnitOfWork(
            DataContext context
        )
        {
            _context = context;

            Books = new BookRepository(_context);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
