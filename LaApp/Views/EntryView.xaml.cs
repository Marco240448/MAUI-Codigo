using LaApp.ViewModels;

namespace LaApp.Views;

public partial class EntryView : ContentView
{
    public static readonly BindableProperty ColorProperty = BindableProperty.Create(nameof(Color), typeof(Color), typeof(EntryView), Colors.Black);

    public Color Color
    {
        get => (Color)GetValue(EntryView.ColorProperty);
        set => SetValue(EntryView.ColorProperty, value);
    }

    //Entry text

    public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(EntryView), string.Empty);

    public string Text
    {
        get => (string)GetValue(EntryView.TextProperty);
        set => SetValue(EntryView.TextProperty, value);
    }

    //Entry placeholder

    public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(EntryView), string.Empty);

    public string Placeholder
    {
        get => (string)GetValue(EntryView.PlaceholderProperty);
        set => SetValue(EntryView.PlaceholderProperty, value);
    }

    //Icon source
    public static readonly BindableProperty IconSourceProperty = BindableProperty.Create(nameof(IconSource), typeof(string), typeof(EntryView), string.Empty);

    public string IconSource
    {
        get => (string)GetValue(EntryView.IconSourceProperty);
        set => SetValue(EntryView.IconSourceProperty, value);
    }

    //Entry placeholder color

    public static readonly BindableProperty PlaceholderColorProperty = BindableProperty.Create(nameof(PlaceholderColor), typeof(Color), typeof(EntryView), Colors.Black);

    public Color PlaceholderColor
    {
        get => (Color)GetValue(EntryView.PlaceholderColorProperty);
        set => SetValue(EntryView.PlaceholderColorProperty, value);
    }

    // Booleano para mostrar u ocultar el botón de la derecha y si es es de tipo password
    public static readonly BindableProperty IsPasswordProperty = BindableProperty.Create(nameof(IsPassword), typeof(bool), typeof(EntryView), false);

    public bool IsPassword
    {
        get => (bool)GetValue(EntryView.IsPasswordProperty);
        set => SetValue(EntryView.IsPasswordProperty, value);
    }

    public EntryView()
    {
        InitializeComponent();
        BindingContext = this;
    }
}