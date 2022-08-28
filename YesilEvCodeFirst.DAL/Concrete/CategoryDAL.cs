using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class CategoryDAL : EfRepoBase<YesilEvDbContext, Category>, ICategoryDAL
    {
        public CategoryDAL()
        {

        }
        public CategoryDAL(YesilEvDbContext context) : base(context)
        {
        }
    }
}
