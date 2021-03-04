﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Bakım yapılıyor";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists= "Bu isimde daha önce bir ürün eklenmiş";
        public static string CheckIfCategoryLimitExceded="Kategori limiti aşıldı, yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered="Kayıt olundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError ="Parola hatası";
        public static string SuccessfulLogin ="Başarılı giriş";
        public static string UserAlreadyExists ="Kullanıcı  mevcut";
        public static string AccessTokenCreated;
    }
}
