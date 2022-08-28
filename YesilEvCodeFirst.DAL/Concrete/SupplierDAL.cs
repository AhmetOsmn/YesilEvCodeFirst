using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class SupplierDAL : EfRepoBase<YesilEvDbContext, Supplier>, ISupplierDAL
    {
        public SupplierDAL()
        {

        }

        public SupplierDAL(YesilEvDbContext context) : base(context)
        {

        }
    }
}
