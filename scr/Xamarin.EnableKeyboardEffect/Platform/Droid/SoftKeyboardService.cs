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