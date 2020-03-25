// <copyright file="GeneralContact.cs" company="Event UK">
// This source code is Copyright © Event UK and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Event UK
// </copyright>

namespace WebService.Data
{
    /// <summary>
    /// Generic Contact class to demonstrate EF code first migration tools.
    /// </summary>
    public class GeneralContact
    {
        /// <summary>
        /// Gets or sets the Record PK.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the contact's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the contact's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the contact's city.
        /// </summary>
        public string City { get; set; }
    }
}
