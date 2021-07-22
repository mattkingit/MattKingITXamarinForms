using MattKingITXamarinForms.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MattKingITXamarinForms.Views
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