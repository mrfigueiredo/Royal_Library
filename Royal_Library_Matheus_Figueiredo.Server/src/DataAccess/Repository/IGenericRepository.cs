namespace Royal_Library_Matheus_Figueiredo.Server.src.DataAccess.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All(); 

        Task<T> GetById(int id);

        Task<bool> Add(T entity);

        Task<bool> Delete(int id);

        Task<bool> Update(T entity);
    }
}
