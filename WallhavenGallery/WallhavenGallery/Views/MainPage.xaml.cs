using System.ComponentModel;
using Xamarin.Forms;

namespace WallhavenGallery
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        StackLayout stackLayout = new StackLayout()
        {
            BackgroundColor = Color.Yellow
        };
        
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.OnAppearing();
            var source = Gallery.ItemsSource;
        }
    }
}
