using System;
using System.Threading;

namespace Xamarin.KeyboardHelper
{
    public class SoftKeyboard
    {
        private static readonly Lazy<SoftKeyboard> MySingleton =
            new Lazy<SoftKeyboard>(() => new SoftKeyboard(), LazyThreadSafetyMode.PublicationOnly);

        public static SoftKeyboard Current => MySingleton.Value;

        public event SoftKeyboardEventHandler VisibilityChanged;

        public void InvokeVisibilityChanged(bool isAcceptingText)
        {
            try
            {
                VisibilityChanged?.Invoke(new SoftKeyboardEventArgs(isAcceptingText));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }
    }
}