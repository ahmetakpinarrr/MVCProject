using DataAccessLayer.Abstract;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    //Category veya Writer için 2 kez benzer kodları yazdık örnek olsun diye. Çok fazla sınıf olduğunda çok fazla kod yazmış oluyoruz.
    //Bunun önüne geçmek için GenericRepository Kullanacağız.
    public class WriterRepository : IWriterDal
    {
        Context c = new Context();
        DbSet<Writer> _object;
        public void Delete(Writer p)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer p)
        {
            throw new NotImplementedException();
        }

        public List<Writer> List()
        {
            throw new NotImplementedException();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer p)
        {
            throw new NotImplementedException();
        }
    }
}
