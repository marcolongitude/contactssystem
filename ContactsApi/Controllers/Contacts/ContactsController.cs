using DomainLayer.Model;
using DomainServiceLayer.Interfaces;
using System;

namespace ContactsApi.Controllers;
 
public class ContactsController 
{
    public IResult GetContacts(IContactsService contactService)
    {
        try
        {
            return Results.Ok(contactService.GetAllContacts());
        }
        catch(Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    public IResult GetContactById(int id, IContactsService contactService)
    {
        try
        {
            Contacts contact = contactService.GetContact(id);
            return contact is null ? Results.NotFound() : Results.Ok(contact);
        }
        catch(Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    public IResult InsertContact(Contacts contact, IContactsService contactService)
    {
        try
        {
            contactService.InsertContact(contact);
            // return Results.Created($"/contact/{contact.Id}", contact);
            return Results.Ok(contact);
        }
        catch (Exception ex)
        {
            
            return Results.Problem(ex.Message);
        }
    }

    public IResult UpdateContact(Contacts contact, IContactsService contactService)
    {
        try
        {
            contactService.UpdateContact(contact);
            return Results.Ok(contact);
        }
        catch (Exception ex)
        {
            
            return Results.Problem(ex.Message);
        }
    }

    public IResult DeleteContact(int id, IContactsService contactService)
    {
        try
        {
            contactService.DeleteContact(id);
            return Results.Ok($"Contato - {id}, foi removido com sucesso.");
        }
        catch(Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}