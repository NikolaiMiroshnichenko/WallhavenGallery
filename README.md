# WallhavenGallery
Application is client for Wallhaven.cc REST API. Allow user to get images by categories.
## Architecture
Apllication consists of 3 projects:

**WallHavenGallery** 
This project is standard Xamarin.Forms Shared project, contain view models, XAML views.

**WallHavenGallery.Android**
Xamarin.Forms Android client

**WallHavenGallery.iOS**
Xamarin.Forms iOS client
## Used libraries
- PropertyChanged.Fody for MVVM simplicity
- NewtonSoft.Json for REST API client simplicity
