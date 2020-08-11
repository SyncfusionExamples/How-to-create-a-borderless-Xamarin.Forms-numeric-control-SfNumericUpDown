# How to create a borderless Xamarin.Forms numeric control (SfNumericUpDown)

This article explains how to create a Syncfusion SfNumericUpDown without having its border as per in the following image

![](Output.png) 

It has been achieved by using its custom renderer of Xamarin.Forms SfNumericUpDown with platform specific as per in the below code changes.

**[XAML]**

*Control initialization with custom numericUpDown class*

 ```   
 <local:CustomNumericUpDown x:Name="sfNumericUpDown" HeightRequest="100"  Value="100" AllowNull="false" FormatString="n"/>
```
*Create a CustomNumericUpDown class which is inherited from SfNumericUpDown.*

```
    public class CustomNumericUpDown : SfNumericUpDown
    {
    }
```

## Android
It has been achieved by setting null to the EditText Background which is a child of native numeric control as shown in below

```
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
```

## iOS
To achieve the same in iOS, set the 0 as border width of its native control.

```
        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.SfNumericUpDown.XForms.SfNumericUpDown> e)
        {
            base.OnElementChanged(e);
            if (this.Control != null)
            {
                /// For Achieving Borderwidth customization.
                this.Control.Layer.BorderWidth = 0f;
            }
        }
```

## UWP
By setting the 0 as border thickness as shown in below

```
        protected override void OnElementChanged(ElementChangedEventArgs<SfNumericUpDown> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(0);
            }
        }
```

## See also

[How to change border thickness of numeric control](https://www.syncfusion.com/kb/7633/how-to-change-borderwidth-of-numericupdown-by-using-custom-renderer)

[Spin Button Customization in Xamarin NumericUpDown (SfNumericUpDown)](https://help.syncfusion.com/xamarin/numericupdown/spin-button-customization)

[How to customize the color appearance of numeric controls in Xamarin.Forms](https://www.syncfusion.com/kb/11610/how-to-customize-the-color-appearance-of-numeric-controls-in-xamarin-forms)

[How to customize the spin button of the NumericUpDown](https://www.syncfusion.com/kb/10156/how-to-customise-the-spin-button-of-the-numericupdown)

[Auto Reverse in Xamarin NumericUpDown (SfNumericUpDown)](https://help.syncfusion.com/xamarin/numericupdown/auto-reverse)




