using Syncfusion.SfNumericUpDown.XForms.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(NumericSample.CustomNumericUpDown),
    typeof(NumericSample.iOS.CustomNumericNumericUpDownRenderer))]

namespace NumericSample.iOS
{
    public class CustomNumericNumericUpDownRenderer : SfNumericUpDownRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.SfNumericUpDown.XForms.SfNumericUpDown> e)
        {
            base.OnElementChanged(e);
            if (this.Control != null)
            {
                /// For Achieving Borderwidth customization.
               this.Control.Layer.BorderWidth = 0f;
            }
        }
    }
}
