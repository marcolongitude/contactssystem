using DomainLayer.Model;
using DomainServiceLayer.Interfaces;
using ContactsApi.Controllers;
using System;

public static class ContactsRoutes
{
    public static void ConfigureContactsRoutes(this WebApplication app)
    {
        var Controller = new ContactsController();

        app.MapGet("/contacts", Controller.GetContacts);
        app.MapGet("/contact/{id}", Controller.GetContactById);
        app.MapPost("/contact", Controller.InsertContact);
        app.MapPut("/contact", Controller.UpdateContact);
        app.MapDelete("/contact/{id}", Controller.DeleteContact);
    }
}