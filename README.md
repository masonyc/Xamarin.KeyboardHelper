# Xamarin.EnableKeyboardEffect
This effect allows user to show/hide softkeyboard on Android/iOS platform in Xamarin.Forms

# Setup

- `Xamarin.EnableKeyboardEffect` Available on NuGet: https://www.nuget.org/packages/Xamarin.EnableKeyboardEffect
- Install into your platform-specific projects (iOS/Android), and any .NET Standard 2.0 projects required for your app.

## Platform Support

|Platform|Supported|Version|Notes|
| ------------------- | :-----------: | :------------------: | :------------------: |
|Xamarin.iOS|Yes|iOS 8+| |
|Xamarin.Android|Yes|API 16+|Project should [target Android framework 8.1+](https://docs.microsoft.com/en-us/xamarin/android/app-fundamentals/android-api-levels?tabs=vswin#framework)|

# Usage

### Show soft keyboard

```csharp
        <Entry Text="Hide Keyboard" effects:EnableKeyboardEffect.EnableKeyboard="True">
            <Entry.Effects>
                <effects:KeyboardEnableEffect/>
            </Entry.Effects>
        </Entry>
```

### Hide soft keyboard

```csharp
        <Entry Text="Hide Keyboard" effects:EnableKeyboardEffect.EnableKeyboard="False">
            <Entry.Effects>
                <effects:KeyboardEnableEffect/>
            </Entry.Effects>
        </Entry>
```

### Bind Boolean property to effect

```csharp
        <Entry Text="Hide Keyboard" effects:EnableKeyboardEffect.EnableKeyboard="{Binding VisibleBinding}">
            <Entry.Effects>
                <effects:KeyboardEnableEffect/>
            </Entry.Effects>
        </Entry>
```


# Limitations

Only support Android for the moment. 

# Contributing

Contributions are welcome.  Feel free to file issues and pull requests on the repo and they'll be reviewed as time permits.
