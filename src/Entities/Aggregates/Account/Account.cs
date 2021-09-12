using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.Account
{
    public class Account : IAgregationRoot
    {
        public long Id { get; set; }

        public DateTime DateCreated { get; set; }

        public decimal CreditLimit { get; set; }

        public List<AccountContact> Contacts { get; set; }

        public void AddContact(string name)
        {
            if (Contacts.Any(x => x.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase)))
                throw new Exception("Já existe um contato com este nome.");

            var contact = new AccountContact() { Name = name };

            Contacts.Add(contact);
        }
    }
}
