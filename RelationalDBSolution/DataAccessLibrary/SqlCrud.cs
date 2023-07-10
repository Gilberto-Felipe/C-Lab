using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqlCrud
    {
        private readonly string _connectionString;

        private readonly SqlDataAccess db = new();

        public SqlCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<BasicContactModel> GetAllContacts()
        {
            string sql = "select Id, FirstName, LastName from dbo.Contacts";

            return db.LoadData<BasicContactModel, dynamic>(sql, new { }, _connectionString);
        }

        public FullContactModel GetFullContactById(int id)
        {
            string sql = "select Id, FirstName, LastName from dbo.Contacts where Id = @Id";

            FullContactModel output = new()
            {
                BasicInfo = db.LoadData<BasicContactModel, dynamic>(sql, new { Id = id }, _connectionString).FirstOrDefault()
            };

            if (output.BasicInfo is null)
            {
                // tell the user that the record was not found !
                return null;
            }

            sql = @"select e.*
                    from dbo.EmailAddresses e
                    inner join ContactEmail ce on ce.EmailId = e.Id
                    where ce.ContactId = @Id";

            output.EmailAddresses = db.LoadData<EmailAddressModel, dynamic>(sql, new { Id = id }, _connectionString);

            sql = @"select p.*
                    from dbo.PhoneNumbers p
                    inner join ContactPhone cp on cp.PhoneId = p.Id
                    where cp.ContactId = @Id";

            output.PhoneNumbers = db.LoadData<PhoneNumberModel, dynamic>(sql, new { Id = id }, _connectionString);

            return output;
        }

        public void CreateContact(FullContactModel contact)
        {
            string sql = "insert into dbo.contacts (FirstName, LastName) values (@FirstName, @LastName);";
            db.SaveData(sql,
                new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName },
                _connectionString);

            sql = "select Id from dbo.contacts where FirstName = @FirstName and LastName = @LastName;";
            int contactId = db.LoadData<IdLookupModel, dynamic>(sql,
                new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName },
                _connectionString).First().Id;

            foreach (var phoneNumber in contact.PhoneNumbers)
            {
                if (phoneNumber.Id == 0)
                {
                    sql = "insert into dbo.PhoneNumbers (Phone) values (@Phone);";
                    db.SaveData(sql,
                        new { phoneNumber.Phone },
                        _connectionString);

                    sql = "select Id from dbo.PhoneNumbers where Phone = @Phone;";
                    phoneNumber.Id = db.LoadData<IdLookupModel, dynamic>(sql,
                        new { phoneNumber.Phone },
                        _connectionString).First().Id;
                }

                sql = "insert into dbo.ContactPhone (ContactId, PhoneId) values (@ContactId, @PhoneId);";
                db.SaveData(sql,
                    new { ContactId = contactId, PhoneId = phoneNumber.Id },
                    _connectionString);
            }

            foreach (var email in contact.EmailAddresses)
            {
                if (email.Id == 0)
                {
                    sql = "insert into dbo.EmailAddresses (Email) values (@Email);";
                    db.SaveData(sql,
                        new { email.Email },
                        _connectionString);

                    sql = "select Id from dbo.EmailAddresses where Email = @Email;";
                    email.Id = db.LoadData<IdLookupModel, dynamic>(sql,
                        new { email.Email },
                        _connectionString).First().Id;
                }

                sql = "insert into dbo.ContactEmail (ContactId, EmailId) values (@ContactId, @EmailId);";
                db.SaveData(sql,
                    new { ContactId = contactId, EmailId = email.Id },
                    _connectionString);
            }
        }

        public void UpdateContactName(BasicContactModel contact)
        {
            string sql = "update dbo.Contacts set FirstName = @FirstName, LastName = @LastName where Id = @Id;";
            db.SaveData(sql, contact, _connectionString);
        }

        public void RemovePhoneNumberFromContact(int contactId, int phoneId)
        {
            // Saber cuantas personas usan el telefono
            // una sola, eliminar link y telefono
            // mas de una, eliminar link (contactId, phoneId)

            string sql = "select Id, ContactId, PhoneId from dbo.ContactPhone where PhoneId = @PhoneId;";
            var links = db.LoadData<ContactPhoneNumberModel, dynamic>(sql,
                new { PhoneId = phoneId },
                _connectionString);

            sql = "delete from dbo.ContactPhone where PhoneId = @PhoneId and ContactId = @ContactId;";
            db.SaveData(sql,
                new { PhoneId = phoneId, ContactId = contactId },
                _connectionString);

            if (links.Count == 1)
            {
                sql = "delete from dbo.PhoneNumbers where Id = @Id";
                db.SaveData(sql,
                    new { Id = phoneId },
                    _connectionString);
            }
        }
    }
}
