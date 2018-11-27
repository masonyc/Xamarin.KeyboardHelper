using System;
using UIKit;
using Xamarin.EnableKeyboardEffect.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("Xamarin.EnableKeyboardEffect")]
[assembly: ExportEffect(typeof(KeyboardEnableEffect), nameof(KeyboardEnableEffect))]

namespace Xamarin.EnableKeyboardEffect.iOS
{
    public class KeyboardEnableEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                if (!(Control is UITextField nativeTextField))
                {
                    return;
                }

                nativeTextField.InputView = new UIView();
                nativeTextField.BecomeFirstResponder();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        protected override void OnDetached()
        {
            try
            {
                if (!(Control is UITextField nativeTextField))
                {
                    return;
                }
                nativeTextField.InputView = null;
                nativeTextField.BecomeFirstResponder();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}