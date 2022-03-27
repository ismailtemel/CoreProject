using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService:IGenericService<Writer>
    {
        List<Writer> GetWritetById(int id);

        //void WriterAdd(Writer writer);
        //void CategoryDelete(Writer writer);
        //void CategoryUpdate(Writer writer);
        //List<Writer> GetList();
        //Writer GetById(int id);
    }
}
