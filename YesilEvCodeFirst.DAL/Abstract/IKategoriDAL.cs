using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Interfaces;

namespace YesilEvCodeFirst.DAL.Abstract
{
    public interface IKategoriDAL :
        ISelectableRepo<Kategori>,
        IDeletableRepo<Kategori>,
        IUpdatableRepo<Kategori>,
        IInsertableRepo<Kategori>
        //todo: hangi interface'lerin eklenecegine nasıl karar verecegiz?
    {
    }
}
