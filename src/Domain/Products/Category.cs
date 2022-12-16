﻿using Flunt.Validations;
using IWantApp.Domain;

public class Category : Entity
{

    public string Name { get; set; }
    public bool Active { get; set; }


    public Category(string name, string createdBy, string editedBy)
    {
        var contract = new Contract<Category>()
           .IsNotNullOrEmpty(name, "Name")
           .IsGreaterOrEqualsThan(name, 3, "Name")
           .IsNotNullOrEmpty(createdBy, "CreatedBy")
           .IsNotNullOrEmpty(editedBy, "EditedBy");
        AddNotifications(contract);
        Name = name;
        Active = true;
        CreatedBy = createdBy;
        CreatedOn = DateTime.Now;
        EditedBy = editedBy;
        EditedOn = DateTime.Now;
    }
}
