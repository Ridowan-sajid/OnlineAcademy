using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRepo2<TYPE, ID, RET>
    {
        List<TYPE> Get();
        TYPE Get(ID id);
        TYPE Get(string name,string password);
        RET Insert(TYPE obj);
        RET Update(TYPE obj);
        bool Delete(ID id);
    }
}
