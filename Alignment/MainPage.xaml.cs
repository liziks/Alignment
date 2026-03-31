namespace Alignment;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    void OnHorizontalStart(object sender, EventArgs e) =>
        DemoLabel.HorizontalOptions = LayoutOptions.Start;

    void OnHorizontalCenter(object sender, EventArgs e) =>
        DemoLabel.HorizontalOptions = LayoutOptions.Center;

    void OnHorizontalEnd(object sender, EventArgs e) =>
        DemoLabel.HorizontalOptions = LayoutOptions.End;

    void OnHorizontalFill(object sender, EventArgs e) =>
        DemoLabel.HorizontalOptions = LayoutOptions.Fill;

    void OnVerticalStart(object sender, EventArgs e) =>
        DemoLabel.VerticalOptions = LayoutOptions.Start;

    void OnVerticalCenter(object sender, EventArgs e) =>
        DemoLabel.VerticalOptions = LayoutOptions.Center;

    void OnVerticalEnd(object sender, EventArgs e) =>
        DemoLabel.VerticalOptions = LayoutOptions.End;

    void OnVerticalFill(object sender, EventArgs e) =>
        DemoLabel.VerticalOptions = LayoutOptions.Fill;
}
