using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    private List<Book> BookLists = new List<Book>();
    protected void Page_Load(object sender, EventArgs e)
    {
        FillBookList();
    }

    private void FillBookList()
    {
        Book book1 = new Book("9b0896fa-3880-4c2e-bfd6-925c87f22878", "CQRS for Dummies", false);
        Book book2 = new Book("0550818d-36ad-4a8d-9c3a-a715bf15de76", "Visual Studio Tips", false);
        Book book3 = new Book("8e0f11f1-be5c-4dbc-8012-c19ce8cbe8e1", "NHibernate Cookbook ", false);

        BookLists.Add(book1);
        BookLists.Add(book2);
        BookLists.Add(book3);
    }

    private void ButtonSearch_Click(object sender, EventArgs e)
    {
        // Search
        //SearchBox1.

        // Return

    }

    private void ButtonBook_Click(object sender, EventArgs e)
    {

    }


}