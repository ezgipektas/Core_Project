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
    public class ToDoListManager : IToDoListService
    {
        ITodoListDal _todoListDal;

        public ToDoListManager(ITodoListDal todoListDal)
        {
            _todoListDal = todoListDal;
        }

        public void TAdd(ToDoList t)
        {
            _todoListDal.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
            _todoListDal.Delete(t);
        }

        public ToDoList TGetByID(int id)
        {
            return _todoListDal.GetByID(id);
        }

        public List<ToDoList> TGetList()
        {
            return _todoListDal.GetList();
        }

        public void TUpdate(ToDoList t)
        {
            _todoListDal.Update(t);
        }
    }
}
