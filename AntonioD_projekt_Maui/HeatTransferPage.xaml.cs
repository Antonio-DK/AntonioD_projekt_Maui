namespace AntonioD_projekt_Maui
{
    public partial class HeatTransferPage : ContentPage
    {
        public HeatTransferPage()
        {
            InitializeComponent();
        }

        private void OnCalculateHeatTransferClicked(object sender, EventArgs e)
        {
            try
            {
                double mass = double.Parse(MassEntry.Text);
                double specificHeat = double.Parse(SpecificHeatEntry.Text);
                double tempChange = double.Parse(TempChangeEntry.Text);

                if (mass <= 0 || specificHeat <= 0 || tempChange <= 0)
                    throw new Exception("Vrijednosti moraju biti veće od nule!");

                double heatTransfer = mass * specificHeat * tempChange;
                ResultLabel.Text = $"Prijenos topline: {heatTransfer:F2} J";
            }
            catch (Exception ex)
            {
                DisplayAlert("Greška", $"Pogrešan unos: {ex.Message}", "U redu");
            }
        }
    }
}