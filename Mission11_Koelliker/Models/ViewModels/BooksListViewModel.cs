namespace Mission11_Koelliker.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IEnumerable<Book> Books { get; set;}
        public Paginationinfo Paginationinfo { get; set;} = new Paginationinfo();

    }
}
