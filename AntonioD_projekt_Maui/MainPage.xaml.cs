namespace AntonioD_projekt_Maui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnWaveLengthClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WaveLengthPage());
        }

        private async void OnHeatTransferClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HeatTransferPage());
        }
    }

}
