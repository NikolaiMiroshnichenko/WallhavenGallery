using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace WallhavenGallery.Extensions
{
    public static class CollectionsExtension
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> array)
        {
            var observableCollection = new ObservableCollection<T>();
            foreach (var item in array)
            {
                observableCollection.Add(item);
            }
            return observableCollection;
        }

        public static void AddRange<T>(this ObservableCollection<T> observableCollection, 
            IEnumerable<T> array)
        {
            foreach (var item in array)
            {
                observableCollection.Add(item);
            }
        }
    }
}
