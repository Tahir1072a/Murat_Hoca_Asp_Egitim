using Data_Access_Layer.Abstract;
using Data_Access_Layer.Repository;
using Entity_Layer.Concrete;

namespace Data_Access_Layer.EntityFramework
{
    public class EfHeaderDal : GenericRepository<Header>,IHeaderDal
    {
        
    }
}