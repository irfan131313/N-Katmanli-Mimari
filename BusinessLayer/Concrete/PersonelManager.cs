using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using DataAccsessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsessLayer.EntityFramework;
using DataAccsessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;

        public PersonelManager (IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }

        public List<Personel> GetList()
        {
            return _personelDal.GetList();
        }

        public void TAdd(Personel t)
        {
            _personelDal.Insert(t);
        }

        public void TDelete(Personel t)
        {
            _personelDal.Delete(t);
        }

        public Personel TGetByID()
        {
            throw new NotImplementedException();
        }

        public Personel TGetByID(int Id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Personel t)
        {
            _personelDal.Update(t);
        }
    }
}
