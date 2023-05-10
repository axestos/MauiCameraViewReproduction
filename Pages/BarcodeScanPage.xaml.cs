using BarcodeScanner.Mobile;

namespace MauiCameraViewReproduction.Pages;

public partial class BarcodeScanPage : ContentPage
{
	public BarcodeScanPage()
	{
        Methods.SetSupportBarcodeFormat(BarcodeFormats.All);

        InitializeComponent();

        MainThread.BeginInvokeOnMainThread(async () =>
        {
            var allowed = await Methods.AskForRequiredPermission();

            if (!allowed)
            {
                await DisplayAlert("No camera permission",
                    "There was no permission for the camera found, please provide the permission",
                    "OK");
                await Navigation.PopModalAsync();
            }
        });

        this.BackButton.Source = ImageSource.FromFile("back_arrow_icon.png");
        SetFlashLightButtonImage();
    }

    private void ToggleFlashLight(object sender, EventArgs e)
    {
        HapticFeedback.Default.Perform(HapticFeedbackType.Click);
        this.CameraView.TorchOn = !this.CameraView.TorchOn;
        SetFlashLightButtonImage();
    }

    private void SetFlashLightButtonImage()
    {
        this.FlashLightButton.Source = this.CameraView.TorchOn ?
            ImageSource.FromFile("flashlight_on.png") : ImageSource.FromFile("flashlight_off.png");
    }

    private void OnBarcodeDetected(object sender, OnDetectedEventArg e)
    {
        var barcodes = e.BarcodeResults;

        var result = string.Empty;

        foreach (var barcode in barcodes)
        {
            result += $"Type : {barcode.BarcodeType}, Value : {barcode.DisplayValue}{Environment.NewLine}";
        }

        MainThread.BeginInvokeOnMainThread(async () =>
        {
            await DisplayAlert("Barcode result", result, "OK");
            await Navigation.PopModalAsync();
        });
    }

    private void BackButton_Clicked(object sender, EventArgs e)
    {
        HapticFeedback.Default.Perform(HapticFeedbackType.Click);
        Navigation.PopModalAsync();
    }
}