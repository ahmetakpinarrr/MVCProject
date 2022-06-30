using System;
using DataAccessLayer.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.concrete;
using System.Data.Entity;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges(); // Entity Frameworkte değişiklikler kaydolsun diye SaveChanges metodu kullanılır.
        }

        public void Insert(Category p)
        {
            _object.Add(p);
             
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }
    }
}
//Tolist Listeleme için
//    Add ekleme için
//    Remove silmek için kullanılan yöntemlerdir.

