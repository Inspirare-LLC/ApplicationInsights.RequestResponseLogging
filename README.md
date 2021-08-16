# ApplicationInsights.RequestResponseLogging
Application insight extension for request/response logging

Code taken and modified from article: https://www.azureblue.io/how-to-log-http-request-body-with-asp-net-core-application-insights/

# Nuget package
Available as nuget package at https://www.nuget.org/packages/ApplicationInsights.RequestResponseLogging/

# Usage

- Add middleware dependencies in `ConfigureServices` method. Middlewares can be used independently.
```
public void ConfigureServices(IServiceCollection services)
{
    // ...
    services.AddApplicationInsightsTelemetry(Configuration["APPINSIGHTS_CONNECTIONSTRING"]);
            
    services.AddTransient<RequestBodyLoggingMiddleware>();
    services.AddTransient<ResponseBodyLoggingMiddleware>();
}
```

- Enable middlewares by using extensions methods in `Configure` method. Middlewares can be used independently.
```
public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    // Enable our custom middleware
    app.UseRequestBodyLogging();
    app.UseResponseBodyLogging();
}
```

# Contributions

Any contributions are welcome in the form of pull requests.

# Issues

Issues can be raised in the `Issue` section where I'll try to address all of them.
