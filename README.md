# MAUI MVVM Hello World! project
This source code contains the MAUI default project generated by visual Studio 2022 transformed in a MVVM way.

The initial source code is obtained by creating a new MAUI project in Visual Studio 2022 Preview.

For now, the current version of MAUI is [preview 13](https://devblogs.microsoft.com/dotnet/announcing-net-maui-preview-13/). 

## 1. Steps to transform the project in MVVM

-Create folders: Pages, ViewModels.

-Move MainPage.xaml in the folder Pages.

-In ViewModels, Create BaseViewModel.cs, MainViewModel.cs.

-Modify Mainpage.xaml:
link the page to the view model.

bind label and button to the view model.

-Modify MainPage.xaml.cs
remove the backend code.


## 2.Resources

MAUI HackerNews application:
https://github.com/brminnick/HackerNews

MAUI WeatherTwentyOne application:
https://github.com/davidortinau/WeatherTwentyOne

MAUI dotnet-podcasts application:
https://github.com/microsoft/dotnet-podcasts

MAUI TechiesMoneyExchange application:
https://github.com/jesulink2514/TechiesMoneyExchange

MAUI Small MAUI application:
use nav Shell.
https://ballardchalmers.com/2022/02/09/net-maui-deep-dive-part-two-building-our-maui-app/
https://github.com/CliffAgius/.NET-MAUI---Aircraft-Facts-App

-MAUI Application example using devExpress components:
https://community.devexpress.com/blogs/mobile/archive/2021/11/15/stock-market-app-for-net-multi-platform-app-ui-net-maui-part-1.aspx

MAUI BirdAtlas application:
less old, 17 Aug2021
https://github.com/AppCreativity/BirdAtlas/tree/master/frontend_maui


An interessting page on MAUI
https://github.com/MahmudX/awesome-maui

.NET MAUI doc:
https://docs.microsoft.com/en-us/dotnet/maui/get-started/first-app?pivots=devices-windows