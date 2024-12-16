namespace DCProyCaracMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        public void GetDeviceInfo(object sender, EventArgs e)
        {
            InfoDevice.Text = $"Fabricante: {DeviceInfo.Manufacturer}\n" +
                              $"Modelo: {DeviceInfo.Model}\n" +
                              $"Nombre: {DeviceInfo.Name}\n" +
                              $"Plataforma: {DeviceInfo.Platform}\n" +
                              $"OS Version: {DeviceInfo.VersionString}\n" + 
                              $"Idioma: {DeviceInfo.Idiom}";
        }

        public void OnVibrateClicked(object sender, EventArgs e)
        {
            Vibration.Vibrate();
        }

        public void GetBatteryClicked(object sender, EventArgs e)
        {
            var level = Battery.ChargeLevel * 100;
            var state = Battery.State;
            var source = Battery.PowerSource;

            InfoBattery.Text = $"Nivel de bateria: {level}%\n " +
                               $"Estado: {state}\n" +
                               $"Fuente: {source}";
        }

        public async void TakePhotoClicked(object sender, EventArgs e)
        {
            var photo = await MediaPicker.CapturePhotoAsync();
            if (photo != null)
            {
                PhotoImage.Source = ImageSource.FromStream(() => photo.OpenReadAsync().Result);
            }

        }
    }

}
