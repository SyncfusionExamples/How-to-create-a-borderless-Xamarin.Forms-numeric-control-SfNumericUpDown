using Android.Graphics.Drawables;
using Android.Widget;
using Syncfusion.SfNumericUpDown.XForms;
using Syncfusion.SfNumericUpDown.XForms.Droid;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(NumericSample.CustomNumericUpDown),
    typeof(NumericSample.Droid.CustomNumericNumericUpDownRenderer))]

namespace NumericSample.Droid
{
    public class CustomNumericNumericUpDownRenderer : SfNumericUpDownRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.SfNumericUpDown.XForms.SfNumericUpDown> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                for (int i = 0; i < Control.ChildCount; i++)
                {
                    var child = Control.GetChildAt(i);
                    if (child is EditText)
                    {
                        var control = child as EditText;
                        control.Background = null;
                    }
                }
            }
        }
    }
}