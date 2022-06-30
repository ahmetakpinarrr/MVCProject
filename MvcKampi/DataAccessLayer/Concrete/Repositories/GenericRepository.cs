using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    /*--------------------
    BU BÖLÜM SAYESİNDE  CATEGORYREPOSİTORY, WRİTERREPOSİTORY GİBİ TEK TEK TANIMLAMAK YERİNE, 
    BÜTÜN İNTERFACELERDE KULLANILABİLECEK MİMARİYİ KURUYORUZ.

    ------------------------------------------------- */

    public class GenericRepository<T> : IRepository<T> where T : class
        //GenericRepository olarak T değeri alacak ve interface olarak o değeri IRepositoryden alacak. Tek şartı T değerinin class olması.
    {

        Context c = new Context();
        DbSet<T> _object;  //_object aslında bizim T değerine karşılık gelen sınıfı tutuyor demek.

        public GenericRepository()
        {
            _object = c.Set<T>(); // _objecte bir değer atadık dedikki senin değerin contexte bağlı olarak gönderilen T değeridir.
        }
        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList(); // şartlı listeleme entity frameworkun metodudur bu. filter dan gelen değere göre listeleme yapar.
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
