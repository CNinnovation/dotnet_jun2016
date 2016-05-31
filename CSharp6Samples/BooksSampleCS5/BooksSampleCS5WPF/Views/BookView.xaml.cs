using BooksSample.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace BooksSampleCS5WPF.Views
{
    /// <summary>
    /// Interaction logic for BookView.xaml
    /// </summary>
    public partial class BookView : UserControl
    {
        public BookView()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private BookViewModel _viewModel;
        public BookViewModel ViewModel
        {
            get
            {
                return _viewModel ?? (_viewModel = new BookViewModel((Application.Current as App).BooksService));
            }
        }
    }
}
