using Android.App;
using Android.Runtime;

namespace Xamarin.EnableKeyboardEffect.Droid
{
    [Preserve(AllMembers = true)]
    public static class Effects
    {
        internal static Activity Activity;

        public static void Init(Activity activity)
        {
            Activity = activity;
        }
    }
}