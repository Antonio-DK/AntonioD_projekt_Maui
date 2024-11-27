namespace AntonioD_projekt_Maui
{
    public partial class WaveLengthPage : ContentPage
    {
        public WaveLengthPage()
        {
            InitializeComponent();
        }

        private void OnCalculateWaveLengthClicked(object sender, EventArgs e)
        {
            try
            {
                double speedOfLight = 299792458;
                double frequency = double.Parse(FrequencyEntry.Text);

                if (frequency <= 0)
                    throw new Exception("Vrijednosti mora biti veće od nule!");

                double waveLength = speedOfLight / frequency;
                ResultLabel.Text = $"Valna duljina: {waveLength:F2} m";
            }
            catch (Exception ex)
            {
                DisplayAlert("Greška", $"Pogrešan unos: {ex.Message}", "U redu");
            }
        }
    }
}
