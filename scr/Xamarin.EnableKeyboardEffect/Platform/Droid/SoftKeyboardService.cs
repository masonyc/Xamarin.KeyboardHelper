using Android.App;
using Android.Content;
using Android.Views;
using Android.Views.InputMethods;
using System;

namespace Xamarin.EnableKeyboardEffect.Platform.Droid
{
    public class SoftKeyboardService : Java.Lang.Object, ViewTreeObserver.IOnGlobalLayoutListener
    {
        private static InputMethodManager _inputManager;

        private static bool _wasAcceptingText;

        public void OnGlobalLayout()
        {
            try
            {
                if (_inputManager is null || _inputManager.Handle == IntPtr.Zero)
                {
                    _inputManager = (InputMethodManager)Effects.Activity.GetSystemService(Context.InputMethodService);
                }

                // Set visibility to false when focus on background view.
                var currentFocus = Effects.Activity.CurrentFocus;
                if (currentFocus.AccessibilityClassName == "android.view.ViewGroup")
                {
                    SoftKeyboard.Current.InvokeVisibilityChanged(false);
                    _wasAcceptingText = _inputManager.IsAcceptingText;
                    return;
                }

                if (_wasAcceptingText == _inputManager.IsAcceptingText)
                {
                    return;
                }

                SoftKeyboard.Current.InvokeVisibilityChanged(_inputManager.IsAcceptingText);
                _wasAcceptingText = _inputManager.IsAcceptingText;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}