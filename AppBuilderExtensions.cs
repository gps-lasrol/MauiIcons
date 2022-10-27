﻿namespace Maui_Icons;
public static class AppBuilderExtensions
{
    /// <summary>
	/// Initializes the .NET MAUI Icons Library
	/// </summary>
	/// <param name="builder"><see cref="MauiAppBuilder"/> generated by <see cref="MauiApp"/> </param>
	/// <param name="options"><see cref="Options"/></param>
	/// <returns><see cref="MauiAppBuilder"/> initialized for <see cref="CommunityToolkit.Maui"/></returns>
    /// 

    public static MauiAppBuilder UseMauiDefaultIcons(this MauiAppBuilder mauiAppBuilder)
    {
        return mauiAppBuilder.ConfigureFonts(fonts =>
        {
            // Windows
            fonts.AddFont("Segoe_Fluent_Icons.ttf", "SegoeFluentIcons");
            // Android
            fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons");
            // iOS and Mac
            fonts.AddFont("CupertinoIcons.ttf", "CupertinoIcons");

        });
    }

    public static MauiAppBuilder UseMauiWindowsIcons(this MauiAppBuilder mauiAppBuilder)
    {
        return mauiAppBuilder.ConfigureFonts(fonts =>
        {
            // Windows
            fonts.AddFont("Segoe_Fluent_Icons.ttf", "SegoeFluentIcons");
        });
    }

    public static MauiAppBuilder UseMauiCuppertinoIcons(this MauiAppBuilder mauiAppBuilder)
    {
        return mauiAppBuilder.ConfigureFonts(fonts =>
        {
            // iOS and Mac
            fonts.AddFont("CupertinoIcons.ttf", "CupertinoIcons");
        });
    }
}
