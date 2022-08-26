using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DAL.Abstract;

namespace YesilEvCodeFirst.DAL.Concrete
{
    public class KategoriDAL : EfRepoBase<YesilEvDbContext, Kategori>, IKategoriDAL
    {
        public KategoriDAL()
        {

        }
        public KategoriDAL(YesilEvDbContext context) : base(context)
        {
        }
    }
}
