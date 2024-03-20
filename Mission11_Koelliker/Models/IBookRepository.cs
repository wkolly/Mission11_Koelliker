namespace Mission11_Koelliker.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
