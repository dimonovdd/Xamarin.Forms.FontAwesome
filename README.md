# Xamarin.Forms.FontAwesome <img src="/icon.png" width="45" height="40"/>

This package is a simple implementation of the beautiful ["Icons Font Awesome"](https://fontawesome.com/icons) For Xamarin.Forms [*(Screenshot)*](https://raw.githubusercontent.com/dimonovdd/Xamarin.Forms.FontAwesome/main/SampleImages/sample.jpg)

| Font    | Nuget         |
|:--------|:-------------:|
| Solid   | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.FontAwesome.Solid?style=plastic)](https://www.nuget.org/packages/Xamarin.Forms.FontAwesome.Solid/)    |
| Regular | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.FontAwesome.Regular?style=plastic)](https://www.nuget.org/packages/Xamarin.Forms.FontAwesome.Regular/)|
| Brand   | [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.FontAwesome.Brand?style=plastic)](https://www.nuget.org/packages/Xamarin.Forms.FontAwesome.Brand/)    | 

This package is divided into three nugets, so you don't install fonts that you don't use

Icon naming differs from icons8 according to the C# language rules.

| icons8         | icons8 HTML       | this project  |
|:--------------:|:-----------------:|:-------------:|
|dog             |fa-dog             |Dog            |
|question-circle |fa-question-circle |QuestionCircle |
|500px           |fa-500px           |_500x          |

#### Littel Sample:
```xml
xmlns:iconsB="clr-namespace:FontAwesome.Brand;assembly=FontAwesome.Brand"
```
```xml
<Image>
    <Image.Source>
        <iconsB:IconSource Icon="Github" Size="100" Color="Red"/>
    </Image.Source>
</Image>
```
[***See more...***](https://github.com/dimonovdd/Xamarin.Forms.FontAwesome/blob/main/src/FontAwesome.Sample/FontAwesome.Sample/MainPage.xaml)
