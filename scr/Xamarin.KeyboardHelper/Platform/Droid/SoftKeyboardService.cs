using Android.Runtime;
using Android.Views;
using Android.Views.InputMethods;
using Android.Widget;
using Google.Android.Material.TextField;
using System;
using Context = Android.Content.Context;

namespace Xamarin.KeyboardHelper.Platform.Droid
{
    [Preserve(AllMembers = true)]
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

                EditText editText;

                if (currentFocus is TextInputLayout inputLayout)
                {
                    editText = inputLayout.EditText;
                }
                else if (currentFocus is EditText text)
                {
                    editText = text;
                }
                else
                {
                    return;
                }

                if (!editText.ShowSoftInputOnFocus)
                {
                    _inputManager?.HideSoftInputFromWindow(currentFocus.WindowToken, HideSoftInputFlags.None);
                }

                if (_wasAcceptingText == _inputManager?.IsAcceptingText)
                {
                    // Fixed entry get focused by code pop up keyboard
                    if (!editText.ShowSoftInputOnFocus)
                    {
                        SoftKeyboard.Current.InvokeVisibilityChanged(false);
                    }
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