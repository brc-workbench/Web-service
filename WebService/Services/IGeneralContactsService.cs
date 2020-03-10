using System.Threading.Tasks;
using System.Collections.Generic;
using WebService.Data;

namespace WebService.Services
{
    public interface IGeneralContactsService
    {
        public Task<List<GeneralContact>> GeneralContatsFromDatabase();
    }
}
