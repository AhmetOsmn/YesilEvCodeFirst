using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface IYetkiDAL :
        IInsertableRepo<Yetki>,
        IUpdatableRepo<Yetki>,
        IDeletableRepo<Yetki>,
        ISelectableRepo<Yetki>
    {
    }
}
