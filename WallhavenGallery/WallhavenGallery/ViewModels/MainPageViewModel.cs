using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using WallhavenGallery.Models;
using Xamarin.Forms;

namespace WallhavenGallery.ViewModels
{
    public class MainPageViewModel
    {
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


        public ObservableCollection<Entity> GalleryList = new ObservableCollection<Entity>();
    }
}
