using DomainLayer.Model;
using DomainServiceLayer.Interfaces;
using InfrastructureLayer.Repositories.Interfaces;

namespace DomainServiceLayer.Services;

public class ContactsService: IContactsService
{
    private readonly IBaseRepository<Contacts> _repository;

    public ContactsService(IBaseRepository<Contacts> repository)
    {
        _repository = repository;
    }

    public IEnumerable<Contacts> GetAllContacts() 
    {
        return _repository.GetAll();
    }

    public Contacts GetContact(int id)
    {
        return _repository.GetById(id);
    }

    public void InsertContact(Contacts contact) 
    {
        _repository.Insert(contact);
    }

    public void UpdateContact(Contacts contact)
    {
        _repository.Update(contact);
    }

    public void DeleteContact(int id)
    {
        Contacts contact = _repository.GetById(id);
        if(contact != null)
        {
            _repository.Remove(contact);
            _repository.SaveChanges();
        }
    }
}