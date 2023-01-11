using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _writerUserDal;

        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }

        public void TAdd(AppUser t)
        {
            _writerUserDal.Insert(t);
        }

        public void TDelete(AppUser t)
        {
            _writerUserDal.Delete(t);
        }

        public List<AppUser> TGetbyFilter()
        {
            throw new NotImplementedException();
        }

        public AppUser TGetByID(int id)
        {
            return _writerUserDal.GetByID(id);
        }

        public List<AppUser> TGetList()
        {
            return _writerUserDal.GetList();
        }

        public void TUpdate(AppUser t)
        {
            _writerUserDal.Update(t);
        }
    }
}
