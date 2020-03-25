// <copyright file="IGeneralContactsService.cs" company="Event UK">
// This source code is Copyright © Event UK and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Event UK
// </copyright>

namespace WebService.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using WebService.Data;

    /// <summary>
    /// Interface for GeneralContacts.
    /// </summary>
    public interface IGeneralContactsService
    {
        /// <summary>
        /// Retrieve full list of contacts.
        /// </summary>
        /// <returns>List of contacts.</returns>
        public Task<List<GeneralContact>> GeneralContatsFromDatabase();
    }
}
