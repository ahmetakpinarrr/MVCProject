using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface ICategoryDal:IRepository<Category>
    { 
        ////// BURADAKİ METOTLARI KULLANMIYORUZ. YETERLİ DEĞİL. IREPOSİTORYİ KULLANIYORUZ.
        //////CRUD  
        //// TYPE NAME();
        //List<Category> List(); //türü List İsmide List olan bir metod tanımladık. 2.List yazan yeri "Listele" de yapabilirdik ama biz ingilizce olsun istedik.
        //void Insert(Category p); //ekleme
        //void Update(Category p); //güncelleme
        //void Delete(Category p); // silme görevlerini yapacaklar. 



    }
}
