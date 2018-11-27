using System.Linq;
using Xamarin.Forms;

namespace Xamarin.EnableKeyboardEffect
{
    /// <summary>
    /// Enable Keyboard Effect
    /// </summary>
    public class KeyboardEnableEffect : RoutingEffect
    {
        /// <inheritdoc />
        public KeyboardEnableEffect() : base("Xamarin.EnableKeyboardEffect.KeyboardEnableEffect")
        {
        }
    }

    /// <summary>
    /// Set up Bindable Properties for KeyboardEnableEffect
    /// </summary>
    public static class EnableKeyboardEffect
    {
        /// <summary>
        /// Bindable property to Enable keyboard
        /// </summary>
        public static readonly BindableProperty EnableKeyboardProperty =
            BindableProperty.Create("EnableKeyboard", typeof(bool), typeof(EnableKeyboardEffect), false, propertyChanged: OnEnableKeyboardChanged);

        /// <summary>
        /// Get EnableKeyboard value
        /// </summary>
        /// <param name="view"></param>
        /// <returns></returns>
        public static bool GetEnableKeyboard(BindableObject view)
        {
            return (bool)view.GetValue(EnableKeyboardProperty);
        }

        /// <summary>
        /// Set EnableKeyboard Value
        /// </summary>
        /// <param name="view"></param>
        /// <param name="value"></param>
        public static void SetEnableKeyboard(BindableObject view, bool value)
        {
            view.SetValue(EnableKeyboardProperty, value);
        }

        private static void OnEnableKeyboardChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is View view))
            {
                return;
            }

            var enableKeyboard = (bool)newValue;
            if (enableKeyboard)
            {
                var toRemove = view.Effects.FirstOrDefault(e => e is KeyboardEnableEffect);
                if (toRemove != null)
                {
                    view.Effects.Remove(toRemove);
                }
            }
            else
            {
                view.Effects.Add(new KeyboardEnableEffect());
            }
        }
    }
}