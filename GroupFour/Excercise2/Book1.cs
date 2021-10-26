using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

internal class Book
{
    public string IDValue = String.Empty;
    public string nameValue = String.Empty;
    public bool reserveStatus = false;

    public string BookID
    {
        get { return IDValue; }
        set { IDValue = (String.IsNullOrEmpty(value)) ? String.Empty : value; }
    }

    public string BookName
    {
        get { return nameValue; }
        set { nameValue = (String.IsNullOrEmpty(value)) ? String.Empty : value; }
    }

    public bool isReserved => reserveStatus;


    public Book(string id, string name, bool status)
    {
        BookID = id;
        BookName = name;
        reserveStatus = status;
    }
}