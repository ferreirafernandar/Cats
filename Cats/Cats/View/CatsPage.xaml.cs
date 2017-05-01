using Xamarin.Forms;

namespace Cats.View
{
    public partial class CatsPage : ContentPage
    {
        public CatsPage()
        {
            InitializeComponent();
            ListViewCats.ItemSelected += ListViewCats_ItemSelected;
        }
        private async void ListViewCats_ItemSelected(object sender,SelectedItemChangedEventArgs e)
        {
            var SelectedCat = e.SelectedItem as Model.Cat;
            if (SelectedCat != null)
            {
                await Navigation.PushAsync(new View.DetailsPage(SelectedCat));
                ListViewCats.SelectedItem = null;
            }
        }
    }
}