namespace RestApi.Repository
{
    public interface IDataRepository<TEntity >
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity); 
        void Update(TEntity dbentitiy , TEntity entity);   
        void Delete(TEntity entity);

    }
}
