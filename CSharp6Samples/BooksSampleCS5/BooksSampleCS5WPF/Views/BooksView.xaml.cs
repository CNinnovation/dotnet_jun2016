using BooksSample.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace BooksSampleCS5WPF.Views
{
    /// <summary>
    /// Interaction logic for BooksView.xaml
    /// </summary>
    public partial class BooksView : UserControl
    {
        public BooksView()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private BooksViewModel _viewModel;

        public BooksViewModel ViewModel
        {
            get
            {
                return _viewModel ?? (_viewModel = new BooksViewModel((Application.Current as App).BooksService));
            }
        }
    }
}
