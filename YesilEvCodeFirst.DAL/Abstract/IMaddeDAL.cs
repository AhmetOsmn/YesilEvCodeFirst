using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface IMaddeDAL :
        IInsertableRepo<Madde>,
        ISelectableRepo<Madde>,
        IDeletableRepo<Madde>,
        IUpdatableRepo<Madde>
    {
    }
}
