using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class ProductDAL : EfRepoBase<YesilEvDbContext,Product>, IProductDAL
    {
        public ProductDAL()
        {

        }

        public ProductDAL(YesilEvDbContext context) : base(context)
        {

        }
    }
}
