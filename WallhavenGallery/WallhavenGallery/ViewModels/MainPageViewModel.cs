using System.Collections.ObjectModel;
using WallhavenGallery.Models;
using Xamarin.Forms;
using System.Threading.Tasks;
using WallhavenGallery.Services;

namespace WallhavenGallery.ViewModels
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            RestApiClient restApi = new RestApiClient();
            Task.Run(async () =>
            {
                
                var list = await restApi.GetAsyncAll();
            }
            );

        }

        public ObservableCollection<ResponseModel> GalleryList = new ObservableCollection<ResponseModel>();

        public Command NatureCommand { get; set; }
        public Command SpaceCommand { get; set; }
        public Command TransportCommand { get; set; }
        public Command GirlsCommand { get; set; }
        public Command AnimeCommand { get; set; }
        public Command ArtsCommand { get; set; }
        public Command AnimalCommand { get; set; }
        public Command GamesCommand { get; set; }
        public Command MoviesCommand { get; set; }
        public Command FantasyCommand { get; set; }
        public Command SportCommand { get; set; }
        public Command OtherCommand { get; set; }
    }
}
