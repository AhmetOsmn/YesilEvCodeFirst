using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface IRolDAL :
        ISelectableRepo<Rol>,
        IUpdatableRepo<Rol>,
        IDeletableRepo<Rol>,
        IInsertableRepo<Rol>
    {
    }
}
