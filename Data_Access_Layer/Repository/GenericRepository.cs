using System.Collections.Generic;
using System.Linq;
using Data_Access_Layer.Abstract;
using Data_Access_Layer.Concrete;

namespace Data_Access_Layer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Delete(T t)
        {
            //Şu anda bu kod refactor edilebilir. Ancak bu şekilde kalsın.
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }
    }
}