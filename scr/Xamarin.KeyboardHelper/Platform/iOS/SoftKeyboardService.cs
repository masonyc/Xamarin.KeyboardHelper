using System;
using UIKit;

namespace Xamarin.KeyboardHelper.Platform.iOS
{
    public class SoftKeyboardService
    {
        public SoftKeyboardService()
        {
            try
            {
                UIKeyboard.Notifications.ObserveDidShow(OnKeyboardDidShow);
                UIKeyboard.Notifications.ObserveDidHide(OnKeyboardDidHide);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        private void OnKeyboardDidHide(object sender, UIKeyboardEventArgs e)
        {
            SoftKeyboard.Current.InvokeVisibilityChanged(false);
        }

        private void OnKeyboardDidShow(object sender, UIKeyboardEventArgs e)
        {
            SoftKeyboard.Current.InvokeVisibilityChanged(true);
        }
    }
}