# Dashboard for Blazor Server - Localization

The example shows how to localize the Dashboard component in Blazor Server applications:

- Translate UI element captions to a different language: dialog boxes, buttons, menu items, error messages, and so on (localization).
- Format numbers, dates, and currencies according to specific culture settings (globalization).

The app uses **satellite resource assemblies** to localize the Dashboard component. 

A custom [CultureSelector](./CS/BlazorDashboardApp/Components/CultureSelector.razor) UI component is implemented to allow users to change the culture at runtime. The app saves the current culture in a cookie that can be read by the Dashboard Localization Provider.

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

- [Get Started - Dashboard Component in Blazor WebAssembly Application](https://github.com/DevExpress-Examples/dashboard-blazor-webassembly-app)
- [Dashboard Blazor Server App - Configuration](https://github.com/DevExpress-Examples/dashboard-blazor-server-configuration)
- [Dashboard Blazor Server App - JavaScript Customization](https://github.com/DevExpress-Examples/dashboard-blazor-server-js-customization)