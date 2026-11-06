# EhLib.WinForms.Demos
These projects demonstrate the capabilities of the EhLib.WinForms library.

Projects are designed to run in an integrated environment - Visual Studio.

Projects can be compiled and launched without installing additional components in Visual Studio.

The demo projects reference the NuGet package [EhLib.WinForms.Trial](https://www.nuget.org/packages/EhLib.WinForms.Trial) (version 2.0.*).
It is downloaded from nuget.org automatically on the first build.

EhLib.WinForms.Trial is intended for evaluation purposes only. Licensing information: https://www.ehlib.com

Open `EhLibDemos.slnx` in Visual Studio 2026. The projects target .NET Framework 4.8 and .NET 8 (net8.0-windows).

## List of projects

* `MainDemo` - the main project. Demonstrates the visual capabilities of the library when creating an application for working with tabular data.

* `DisplayLayoutStorableApp` - the project demonstrates the ability to save/restore the visual settings (like window pos and size, grid columns width) in the configuration files.

* `ProcessList` - implementation of the Windows Task Manager window using the DataGridEh component.

## EhLib.WinForms library 

EhLib.WinForms library contains components and classes for Windows Forms.

Below is a list of the main components of the library:

### DataGridEh
It is the main and most sophisticated component of the library.
DataGridEh allows you to show and edit data in a table with titles, footers, indicator column and other features.

![DataGridEh design-time](http://www.ehlib.com/IMAGES/EhLib.WinForms.DataGridEh.DesignTime.png)

![DataGridEh](http://www.ehlib.com/IMAGES/EhLib.WinForms.DataGridEh.png)


### DataVertGridEh
A grid control that displays data in a customizable grid in vertical orientation.


### DataPropertyGridEh
Displays one item (row) of the data source in vertical orientation. 


### PivotGridEh
A pivot grid for data analysis: groups and aggregates data by rows and columns.


### PlannerControlEh
A scheduler control that shows events in day, week, month, year and timeline views.


### TextBoxEh
Represents a control that can be used to display or edit unformatted text. 


### MaskedTextBoxEh
Enhanced TextBoxEh control that supports a declarative syntax for accepting or rejecting user input. 


### NumericBoxEh
Represents a control that can be used to display or edit numeric values. 


### ComboBoxEh
Represents a Windows combo box control. 


### DateTimeBoxEh
Represents a Windows control that allows you to select a date and time and display them in the specified format. 


## Demo data

* City data in MainDemo (`MainDemo/Data/cities10000.Cities1000Small.xml`) is a subset of the [GeoNames](https://www.geonames.org) data, licensed under [CC BY 4.0](https://creativecommons.org/licenses/by/4.0/).

## License

The source code of the demo projects is licensed under the MIT License, see [LICENSE](LICENSE).

The EhLib.WinForms library is not covered by this license. It is distributed under its own license, see https://www.ehlib.com.

The demo data is not covered by this license either, see [Demo data](#demo-data).
