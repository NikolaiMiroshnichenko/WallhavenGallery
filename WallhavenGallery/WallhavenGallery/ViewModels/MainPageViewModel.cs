using System.Collections.ObjectModel;
using WallhavenGallery.Models;
using Xamarin.Forms;
using System.Threading.Tasks;
using WallhavenGallery.Services;
using WallhavenGallery.Extensions;
using System;
using System.ComponentModel;

namespace WallhavenGallery.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            NatureCommand = new Command(async() => await NatureGet());
            SpaceCommand = new Command(async () => await SpaceGet());
            TransportCommand = new Command(async () => await TransportGet());
            GirlsCommand = new Command(async () => await GirlsGet());
            AnimeCommand = new Command(async () => await AnimeGet());
            ArtsCommand = new Command(async () => await ArtsGet());
            AnimalsCommand = new Command(async () => await AnimalsGet());
            GamesCommand = new Command(async () => await GamesGet());
            MoviesCommand = new Command(async () => await MoviesGet());
            FantasyCommand = new Command(async () => await FantasyGet());
            SportCommand = new Command(async () => await SportGet());
            ArtsCommand = new Command(async () => await ArtsGet());
            ByEntryCommand = new Command(async () => await ByEntryGet(SearchText));
        }
        public ObservableCollection<Datum> GalleryList { get; set; } = new ObservableCollection<Datum>();
        public String SearchText { get; set; }
        public Command NatureCommand { get; set; } 
        public Command SpaceCommand { get; set; }
        public Command TransportCommand { get; set; }
        public Command GirlsCommand { get; set; }
        public Command AnimeCommand { get; set; }
        public Command ArtsCommand { get; set; }
        public Command AnimalsCommand { get; set; }
        public Command GamesCommand { get; set; }
        public Command MoviesCommand { get; set; }
        public Command FantasyCommand { get; set; }
        public Command SportCommand { get; set; }
        public Command ByEntryCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public async Task NatureGet()
        {
            RestApiClient restApi = new RestApiClient();
            var responseModel = await restApi.GetAsyncByCategory("nature");
            GalleryList.Clear();
            GalleryList.AddRange(responseModel.Data);
        }
        public async Task SpaceGet()
        {
            RestApiClient restApi = new RestApiClient();
            var responseModel = await restApi.GetAsyncByCategory("space");
            GalleryList.Clear();
            GalleryList.AddRange(responseModel.Data);
        }
        public async Task TransportGet()
        {
            RestApiClient restApi = new RestApiClient();
            var responseModel = await restApi.GetAsyncByCategory("transport");
            GalleryList.Clear();
            GalleryList.AddRange(responseModel.Data);
        }
        public async Task GirlsGet()
        {
            RestApiClient restApi = new RestApiClient();
            var responseModel = await restApi.GetAsyncByCategory("girls");
            GalleryList.Clear();
            GalleryList.AddRange(responseModel.Data);
        }
        public async Task AnimeGet()
        {
            RestApiClient restApi = new RestApiClient();
            var responseModel = await restApi.GetAsyncByCategory("anime");
            GalleryList.Clear();
            GalleryList.AddRange(responseModel.Data);
        }

        public async Task ArtsGet()
        {
            RestApiClient restApi = new RestApiClient();
            var responseModel = await restApi.GetAsyncByCategory("art");
            GalleryList.Clear();
            GalleryList.AddRange(responseModel.Data);
        }

        public async Task AnimalsGet()
        {
            RestApiClient restApi = new RestApiClient();
            var responseModel = await restApi.GetAsyncByCategory("animals");
            GalleryList.Clear();
            GalleryList.AddRange(responseModel.Data);
        }

        public async Task GamesGet()
        {
            RestApiClient restApi = new RestApiClient();
            var responseModel = await restApi.GetAsyncByCategory("games");
            GalleryList.Clear();
            GalleryList.AddRange(responseModel.Data);
        }

        public async Task MoviesGet()
        {
            RestApiClient restApi = new RestApiClient();
            var responseModel = await restApi.GetAsyncByCategory("movies");
            GalleryList.Clear();
            GalleryList.AddRange(responseModel.Data);
        }

        public async Task FantasyGet()
        {
            RestApiClient restApi = new RestApiClient();
            var responseModel = await restApi.GetAsyncByCategory("fantasy");
            GalleryList.Clear();
            GalleryList.AddRange(responseModel.Data);
        }

        public async Task SportGet()
        {
            RestApiClient restApi = new RestApiClient();
            var responseModel = await restApi.GetAsyncByCategory("sport");
            GalleryList.Clear();
            GalleryList.AddRange(responseModel.Data);
        }

        public async Task ByEntryGet(string tag)
        {
            if (tag!=null)
            {
                RestApiClient restApi = new RestApiClient();
                var responseModel = await restApi.GetAsyncByCategory(tag);
                GalleryList.Clear();
                GalleryList.AddRange(responseModel.Data);
            }    
        }

        public async Task OnAppearing()
        {
            RestApiClient restApi = new RestApiClient();
            var responseModel = await restApi.GetAsyncAll();
            GalleryList.AddRange(responseModel.Data);
        }
    }
}
