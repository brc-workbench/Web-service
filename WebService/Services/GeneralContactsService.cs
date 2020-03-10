using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebService.Data;

namespace WebService.Services
{
    public class GeneralContactsService : IGeneralContactsService
    {
        private static WebServiceDBContext _dbContext;

        public GeneralContactsService(WebServiceDBContext context)
        {
            _dbContext = context;
        }

        public async Task<List<GeneralContact>> GeneralContatsFromDatabase()
        {
            return await _dbContext.GeneralContacts.ToListAsync();
        }
    }
}
