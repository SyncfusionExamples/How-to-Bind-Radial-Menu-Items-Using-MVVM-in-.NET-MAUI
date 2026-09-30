# How to Bind Radial Menu Items Using MVVM in .NET MAUI

This sample demonstrates how to populate a Syncfusion .NET MAUI `SfRadialMenu` from a view model. The menu items are supplied through a bindable collection rather than being declared one by one in XAML. This keeps the data that describes each item separate from the visual template used to display it, following the Model-View-ViewModel (MVVM) approach.

## What the sample demonstrates

- A `RadialMenuItemInfo` model holds the icon value for one menu item.
- `RadialMenuViewModel` creates an `ObservableCollection<RadialMenuItemInfo>` named `MenuItems` and initializes it with five entries.
- `MainPage.xaml` sets a `RadialMenuViewModel` instance as the page's `BindingContext`.
- The radial menu binds its `ItemsSource` to `MenuItems` and uses an `ItemTemplate` to display each item's `Icon` in a centered `Label`.
- The center button is configured independently from the collection, with its own size, radius, font, and glyph.

## How the binding works

The page's binding context provides the source for bindings in the visual tree. `ItemsSource="{Binding MenuItems}"` asks the radial menu to create an item for each object in the collection. Inside the `DataTemplate`, the binding context changes to the current `RadialMenuItemInfo`, so `Text="{Binding Icon}"` reads the icon for that particular item. The `ObservableCollection` also supports notifying the menu when entries are added or removed while the page is running.

The icon values in this sample are Unicode glyphs from the registered `MauiMaterialAssets` font. The font is registered in `MauiProgram.cs`, and the same font family is set on the item labels and center button. If you replace the glyphs, make sure the selected font contains the characters you use.

## Requirements

- .NET MAUI workload and a compatible .NET SDK for the project target frameworks.
- Visual Studio or the .NET CLI with a configured MAUI target such as Android, iOS, Mac Catalyst, or Windows.
- The Syncfusion MAUI Radial Menu and Core packages referenced by the project. Configure any Syncfusion licensing required by your account and distribution scenario.

## Run the sample

Open `BindRadialItems/BindRadialItems.slnx` in Visual Studio, restore NuGet packages, select an available target device or emulator, and run the `BindRadialItems` project. With the .NET CLI, change to the `BindRadialItems` directory, restore the solution, then build and run using a target framework supported by your environment, for example `net10.0-android` on a configured Android machine.

## Customize the menu

To add or remove entries, update `MenuItems` in `RadialMenuViewModel`. To show additional information for each entry, add properties to `RadialMenuItemInfo` and bind them in the `ItemTemplate`. Keep the collection in the view model and the presentation in XAML so the menu content can change without duplicating item markup. This example focuses on binding and rendering; it does not define command handling or navigation for menu selections.
