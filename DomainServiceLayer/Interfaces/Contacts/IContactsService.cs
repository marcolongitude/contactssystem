using DomainLayer.Model;

namespace DomainServiceLayer.Interfaces;

public interface IContactsService
{
    IEnumerable<Contacts> GetAllContacts();
    Contacts GetContact(int id);
    void InsertContact(Contacts contact);
    void UpdateContact(Contacts contact);
    void DeleteContact(int id);
}