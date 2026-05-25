using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media;

namespace Avalon.Desktop;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        greetingsButton.Content = "Goodbye Cruel World!";
        if (greetingsButton.IsVisible)
        {
            greetingsButton.Content = "I'm visible";
            greetingsButton.Background = Brushes.BlueViolet;
            greetingsButton.Click += ((sender, args) =>
            {
                Console.WriteLine("Hello event: " + sender);
            });
            greetingsButton.HorizontalAlignment = HorizontalAlignment.Center;
        }
    }
    
    public void GreetingButtonClickHandler(object sender, RoutedEventArgs args)
    {
        Console.WriteLine($"Hello {sender}!");
    }
}