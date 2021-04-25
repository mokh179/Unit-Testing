using System;
using System.Collections.Generic;
using System.Text;

namespace services
{
  public  interface IOperations<T>
    {
        List<T> getAll();
        T getByID(int id);
        bool del(int id);
        T Edit(T obj);

        T Addnew(T obj);
         bool test(string user, string pass);
    }
}
