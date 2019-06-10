using System;
using UIKit;
using Xamarin.KeyboardHelper.Platform.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("Xamarin.KeyboardHelper")]
[assembly: ExportEffect(typeof(KeyboardEnableEffect), nameof(KeyboardEnableEffect))]

namespace Xamarin.KeyboardHelper.Platform.iOS
{
    public class KeyboardEnableEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                if (!(Control is UITextField nativeTextField) || KeyboardEffect.GetEnableKeyboard(Element))
                {
                    return;
                }

                nativeTextField.InputView = new UIView();

                nativeTextField.InputAssistantItem.LeadingBarButtonGroups = null;
                nativeTextField.InputAssistantItem.TrailingBarButtonGroups = null;

                var requestFocus = KeyboardEffect.GetRequestFocus(Element);
                if (requestFocus)
                {
                    nativeTextField.BecomeFirstResponder();
                }
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
                var requestFocus = KeyboardEffect.GetRequestFocus(Element);
                if (requestFocus)
                {
                    nativeTextField.BecomeFirstResponder();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}