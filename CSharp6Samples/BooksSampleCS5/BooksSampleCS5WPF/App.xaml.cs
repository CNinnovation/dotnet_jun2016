using BooksSample.Repositories;
using BooksSample.Services;
using System.Windows;

namespace BooksSampleCS5WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private BooksService _booksService;
        public BooksService BooksService
        {
            get { return _booksService ?? (_booksService = new BooksService(new BooksRepository())); }
        }
    }
}
