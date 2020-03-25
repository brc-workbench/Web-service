// <copyright file="GeneralContactsService.cs" company="Event UK">
// This source code is Copyright © Event UK and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Event UK
// </copyright>

namespace WebService.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using WebService.Data;

    /// <summary>
    /// Service for all GeneralContact data access.
    /// </summary>
    public class GeneralContactsService : IGeneralContactsService
    {
        private static WebServiceDBContext _dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralContactsService"/> class.
        /// </summary>
        /// <param name="context">DBContext.</param>
        public GeneralContactsService(WebServiceDBContext context)
        {
            _dbContext = context;
        }

        /// <summary>
        /// Retrieve full list of contacts.
        /// </summary>
        /// <returns>List of contacts.</returns>
        public async Task<List<GeneralContact>> GeneralContatsFromDatabase()
        {
            return await _dbContext.GeneralContacts.ToListAsync();
        }
    }
}
