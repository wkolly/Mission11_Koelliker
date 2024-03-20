namespace Mission11_Koelliker.Models.ViewModels
{
    public class Paginationinfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumPages => (int) (Math.Ceiling((decimal)TotalItems / ItemsPerPage));


    }
}
