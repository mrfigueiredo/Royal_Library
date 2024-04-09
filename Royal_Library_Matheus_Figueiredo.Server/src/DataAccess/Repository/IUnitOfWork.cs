namespace Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Repository
{
    public interface IUnitOfWork
    {
        IBookRepository Books { get; }

        Task CompleteAsync();

    }
}
