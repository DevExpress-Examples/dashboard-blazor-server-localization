<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/419764217/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1038500)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Dashboard for Blazor Server - Localization

The example shows how to localize the Dashboard component in Blazor Server applications:

- Translate UI element captions to a different language: dialog boxes, buttons, menu items, error messages, and so on (localization).
- Format numbers, dates, and currencies according to specific culture settings (globalization).

The app uses **satellite resource assemblies** to localize the Dashboard component. You can obtain localized resources from our [Localization Service](https://docs.devexpress.com/LocalizationService/16235/localization-service).

A custom [CultureSelector](./CS/BlazorDashboardApp/Components/CultureSelector.razor) UI component is implemented to allow users to change the culture at runtime. The app saves the current culture in a cookie.

The [ResourceManager.setLocalizationMessages](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.ResourceManager?p=netframework#js_devexpress_dashboard_resourcemanager_setlocalizationmessages_static_localizationmessages_) method is used to localize the specified string at runtime (the "Export To" button's caption in the dashboard title).

![blazor-localized-dashboard](img/blazor-localized-dashboard.png)

## Files to Review

* [Dashboard.razor](./CS/BlazorDashboardApp/Pages/Dashboard.razor)
* [CultureSelector.razor](./CS/BlazorDashboardApp/Components/CultureSelector.razor)
* [CultureController.cs](./CS/BlazorDashboardApp/Controllers/CultureController.cs)
* [_Layout.cshtml](./CS/BlazorDashboardApp/Pages/_Layout.cshtml#L35-L49)
* [Program.cs](./CS/BlazorDashboardApp/Program.cs)

## Documentation

- [Create a Blazor Server Dashboard Application](https://docs.devexpress.com/Dashboard/403029)

## More Examples

- [Dashboard for Blazor WebAssembly - Localization](https://github.com/DevExpress-Examples/dashboard-blazor-webassembly-localization)
- [Dashboard Blazor Server App - Configuration](https://github.com/DevExpress-Examples/dashboard-blazor-server-configuration)
- [Dashboard Blazor Server App - JavaScript Customization](https://github.com/DevExpress-Examples/dashboard-blazor-server-js-customization)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=dashboard-blazor-server-localization&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=dashboard-blazor-server-localization&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
