namespace YesilEvCodeFirst.DTOs.UserFavList
{
    public class FavListDTO
    {
        public int FavorID { get; set; }
        public string FavoriListName { get; set; }

        public override string ToString()
        {
            return FavoriListName;
        }
    }
}
