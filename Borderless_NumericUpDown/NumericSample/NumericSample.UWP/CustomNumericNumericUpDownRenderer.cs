using Syncfusion.SfNumericUpDown.XForms;
using Syncfusion.SfNumericUpDown.XForms.UWP;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(NumericSample.CustomNumericUpDown),
    typeof(NumericSample.UWP.CustomNumericNumericUpDownRenderer))]

namespace NumericSample.UWP
{
    public class CustomNumericNumericUpDownRenderer : SfNumericUpDownRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SfNumericUpDown> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
            }
        }
    }
}