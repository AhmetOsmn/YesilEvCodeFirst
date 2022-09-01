using System;
using System.Linq;
using System.Text;
using YesilEvCodeFirst.Common;
using YesilEvCodeFirst.Core.Context;
using YesilEvCodeFirst.Core.Entities;
using YesilEvCodeFirst.Core.Repos;
using YesilEvCodeFirst.DTOs;
using YesilEvCodeFirst.DTOs.UserAdmin;
using YesilEvCodeFirst.ExceptionHandling;
using YesilEvCodeFirst.Logs.Concrete;
using YesilEvCodeFirst.Mapping;
using YesilEvCodeFirst.Validation.Login;
using YesilEvCodeFirst.Validation.User;

namespace YesilEvCodeFirst.DAL.Use
{
    public class UseUserDAL : EfRepoBase<YesilEvDbContext, User>
    {
        JsonLogger<LogDTO> myLog = new JsonLogger<LogDTO>("MyLog.txt");

        public UserDetailDTO UserLogin(LoginDTO dto)
        {
            LoginValidator validator = new LoginValidator(dto);

            try
            {
                if (!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
                }
                //using (YesilEvDbContext context = new YesilEvDbContext())
                //{
                //    var result = context.User.Where(u => u.Email.Equals(dto.Email) && u.Password.Equals(dto.Password)).FirstOrDefault();
                //    user = result;
                //}
                var user = GetByCondition(u => u.Email.Equals(dto.Email) && u.Password.Equals(dto.Password)).FirstOrDefault();
                if (user == null)
                {
                    throw new Exception("Kullanıcı bulunamadı.");
                }
                else
                {
                    LogExtension.LogFunc(myLog, "", "Ahmet", "Giris islemi basarili", "Login", Islem.Info);
                    return MappingProfile.UserToGetUserDetailDTO(user);
                }
            }
            catch (ModelNotValidException ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Login", Islem.Error);
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Login", Islem.Error);
            }
            return null;
        }

        public bool AddUser(AddUserDTO dto)
        {
            AddUserValidator validator = new AddUserValidator(dto);

            try
            {
                if (!validator.IsValid)
                {
                    throw new ModelNotValidException(validator.ValidationMessages);
                }
                using (YesilEvDbContext context = new YesilEvDbContext())
                {
                    var tempUser = context.User.Where(u => u.Email.Equals(dto.Email)).FirstOrDefault();
                    if(tempUser == null)
                    {
                        User addUser = MappingProfile.AddUserDTOtoUser(dto);
                        addUser.RolID = 2;
                        // todo: password hashlenerek ve sold'lama yapilarak db'ye kaydedilmeli
                        context.User.Add(addUser);
                        context.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Email ile kayitli kullanici mevcut.");
                    }
                
                }

                LogExtension.LogFunc(myLog, "", "Ahmet", "Ekleme islemi basarili", "User", Islem.Info);

                return true;
            }
            catch (ModelNotValidException ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "User", Islem.Error);
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "Urun", Islem.Error);
            }
            return false;
        }
        public UserDetailDTO GetUserDetailWithEmail(string email)
        {
            try
            {
                User tempUser = GetByCondition(x => x.Email.Equals(email)).FirstOrDefault();
                if (tempUser != null)
                {
                    LogExtension.LogFunc(myLog, "", "Ahmet", "Detay getirme basarili", "User", Islem.Info);
                    //int sayi = GetUserProductCount(tempUser.CustomerID);
                    return MappingProfile.UserToGetUserDetailDTO(tempUser);
                }
                else
                {
                    throw new Exception("Kullanici bulunamadi.");
                }
            }
            catch (Exception ex)
            {
                LogExtension.LogFunc(myLog, "", "Ahmet", ex.Message, "User", Islem.Info);
            }

            return null;
        }
        /*public int GetUserProductCount(int id)
        {
            using (YesilEvDbContext context = new YesilEvDbContext())
            {

                return context.Product.Where(x=> x.);
            }
            
        }*/
    }
}
