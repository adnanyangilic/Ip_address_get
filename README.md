# Ip_address_get
This simple project gets visitor client IP address. You must check to see Home controller, Index.cshtml and startup.cs

In Startup.cs add services.AddHttpContextAccessor(); services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();
