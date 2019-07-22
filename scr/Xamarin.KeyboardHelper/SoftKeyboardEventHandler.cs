using System;
using Xamarin.Forms.Internals;

namespace Xamarin.KeyboardHelper
{
    public delegate void SoftKeyboardEventHandler(SoftKeyboardEventArgs e);

    [Preserve(AllMembers = true)]
    public class SoftKeyboardEventArgs : EventArgs
    {
        public SoftKeyboardEventArgs(bool isVisible)
        {
            IsVisible = isVisible;
        }

        public bool IsVisible { get; private set; }
    }
}