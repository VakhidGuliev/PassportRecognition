using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService.src.Repository
{
    public interface IDbRepository<T>
    {
        public  Task<bool> IsDocumentExists(string documentNumber);
    }
}
