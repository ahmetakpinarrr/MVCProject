using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    interface IRepository<T>
    {
        List<T> List();

        void Insert(T p);
        void Delete(T p);
        void Update(T p);

        List<T> List(Expression<Func<T, bool>> filter); // şartlı listeleme metodu örneğin yazar adı ali olanı getir dediğimizde getirecek.Buradan klıtsallık alan bütün sınıflara bu filtreleme özelliği eklenmiş oldu.

    }
}
