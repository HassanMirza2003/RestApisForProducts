using RestApi.Models.Entities;
using RestApi.Repository;

namespace RestApi.Models.DataManager
{
    public class ProductDataManager : IDataRepository<Product>
    {
        //Depepndecy injection
        private readonly ApplicationDbContext Db;
        public ProductDataManager(ApplicationDbContext context)
        {
            this.Db = context;
        }
        public void Add(Product entity)
        {
            Db.Products.Add(entity);
            Db.SaveChanges();
        }

        public void Delete(Product entity)
        {
            Db.Products.Remove(entity);
            Db.SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
           return Db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return Db.Products.SingleOrDefault(x=> x.Id == id);
        }

        public void Update(Product dbentitiy, Product entity)
        {
            dbentitiy.Name = entity.Name;
            dbentitiy.Description = entity.Description; 
            dbentitiy.Price = entity.Price;
            Db.SaveChanges();
        }
    }
}
