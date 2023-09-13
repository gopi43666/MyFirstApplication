using MyFirstApplication.ViewModels;

using System.ComponentModel;

using Xamarin.Forms;

namespace MyFirstApplication.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}