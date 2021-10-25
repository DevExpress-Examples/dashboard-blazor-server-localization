<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/419764217/21.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1038500)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# Dashboard for Blazor Server - Localization

The example shows how to localize the Dashboard component in Blazor Server applications:

- Translate UI element captions to a different language: dialog boxes, buttons, menu items, error messages, and so on (localization).
- Format numbers, dates, and currencies according to specific culture settings (globalization).

The app uses **satellite resource assemblies** to localize the Dashboard component. 

A custom [CultureSelector](./CS/BlazorDashboardApp/Components/CultureSelector.razor) UI component is implemented to allow users to change the culture at runtime. The app saves the current culture in a cookie.

![blazor-localized-dashboard](img/blazor-localized-dashboard.png)


<!-- default file list -->
## Files to Look At

* [Dashboard.razor](./CS/BlazorDashboardApp/Pages/Dashboard.razor)
* [CultureSelector.razor](./CS/BlazorDashboardApp/Components/CultureSelector.razor)
* [CultureController.cs](./CS/BlazorDashboardApp/Controllers/CultureController.cs)
* [_Host.cshtml](./CS/BlazorDashboardApp/Pages/_Host.cshtml#L29-L39)
* [Startup.cs](./CS/BlazorDashboardApp/Startup.cs)
<!-- default file list end -->

## Documentation

- [Create a Blazor Server Dashboard Application](https://docs.devexpress.com/Dashboard/403029)

## More Examples

- [Dashboard for Blazor WebAssembly - Localization](https://github.com/DevExpress-Examples/dashboard-blazor-webassembly-localization)
- [Dashboard Blazor Server App - Configuration](https://github.com/DevExpress-Examples/dashboard-blazor-server-configuration)
- [Dashboard Blazor Server App - JavaScript Customization](https://github.com/DevExpress-Examples/dashboard-blazor-server-js-customization)
