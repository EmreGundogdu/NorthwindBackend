using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Başarıyla Eklendi";
        public static string ProductDeleted = "Ürün Başarıyla Silindi";
        public static string ProductUpdated = "Ürün Başarıyla Güncellendi";

        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccesfulLogin = "Sisteme Giriş Başarılı";
        public static string UserAlreadyExits = "Bu Kullanıcı Zaten Mevcut";
        public static string UserRegistered = "Kullanıcı Başarıyla Kaydedildi";
        public static string AccesTokenCreated = "Acces Token Başarıyla Oluşturuldu";
    }
}
