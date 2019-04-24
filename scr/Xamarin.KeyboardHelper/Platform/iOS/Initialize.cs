using System;
using UIKit;

namespace Xamarin.KeyboardHelper.Platform.iOS
{
    [Foundation.Preserve(AllMembers = true)]
    public static class Effects
    {
        public static void Init()
        {
            StartNotifying();
        }

        private static void StartNotifying()
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

        private static void OnKeyboardDidHide(object sender, UIKeyboardEventArgs e)
        {
            SoftKeyboard.Current.InvokeVisibilityChanged(false);
        }

        private static void OnKeyboardDidShow(object sender, UIKeyboardEventArgs e)
        {
            SoftKeyboard.Current.InvokeVisibilityChanged(true);
        }
    }
}