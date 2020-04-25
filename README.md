<img src="Screenshots/icon.png" width="64px" >

# Xamarin.KeyboardHelper

This plugin includes:
- KeyboardEnableEffect -- allows user to show/hide softkeyboard on Android/iOS platform in Xamarin.Forms
- SoftKeyboardService -- check softkeyboard display status

# Building Status


![CI](https://github.com/masonyc/Xamarin.KeyboardHelper/workflows/CI/badge.svg?branch=master)

# Setup

- Need Xamarin.Forms version 3 or above
- `Xamarin.KeyboardHelper` Available on NuGet: https://www.nuget.org/packages/Xamarin.KeyboardHelper/2.0.8
- Install into your platform-specific projects (iOS/Android), and any .NET Standard 2.1 projects required for your app.
- Add ```
        xmlns:effects="clr-namespace:Xamarin.KeyboardHelper;assembly=Xamarin.KeyboardHelper"  ```at the top of the xaml file 
  
## Platform Support

|Platform|Supported|Version|Notes|
| ------------------- | :-----------: | :------------------: | :------------------: |
|Xamarin.iOS|Yes|iOS 8+| |
|Xamarin.Android|Yes|API 16+|Project should [target Android framework 9.0+](https://docs.microsoft.com/en-us/xamarin/android/app-fundamentals/android-api-levels?tabs=vswin#framework)|    

# KeyboardEnableEffect

## For Android

```csharp
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            
            //need this line to init effect in android
            Xamarin.KeyboardHelper.Platform.Droid.Effects.Init(this);
            
            LoadApplication(new App());
        }
```

## For iOS

```csharp
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            
            //need this line to init effect in iOS
            Xamarin.KeyboardHelper.Platform.iOS.Effects.Init();
            
            LoadApplication(new App());
            return base.FinishedLaunching(app, options);
        }
```

## Usage

### Show soft keyboard

```csharp
        <Entry Text="Show Keyboard" effects:KeyboardEffect.EnableKeyboard="True">
            <Entry.Effects>
                <effects:KeyboardEnableEffect/>
            </Entry.Effects>
        </Entry>
```

### Hide soft keyboard

```csharp
        <Entry Text="Hide Keyboard" effects:KeyboardEffect.EnableKeyboard="False">
            <Entry.Effects>
                <effects:KeyboardEnableEffect/>
            </Entry.Effects>
        </Entry>
```

### Bind boolean property to effect

```csharp
        <Entry Text="Toggle Keyboard" effects:KeyboardEffect.EnableKeyboard="{Binding BooleanBinding}">
            <Entry.Effects>
                <effects:KeyboardEnableEffect/>
            </Entry.Effects>
        </Entry>
```

### Request focus on control

In the previous version of the plugin, control that uses the effect will automatically get the focus when view get rendered. In version 2.0.5 and above, control will not automatically get focus anymore, instead if you want to get focus, you have to call the RequestFocus = true in your XAML file.

```csharp
         <Entry effects:KeyboardEffect.EnableKeyboard="False" effects:KeyboardEffect.RequestFocus="True">
                <Entry.Effects>
                    <effects:KeyboardEnableEffect />
                </Entry.Effects>
         </Entry>
```

- `RequestFocus="True"` will not show the keyboard if `EnableKeyboard="False"`
- `Entry.Focus()` will shows the keyboard even if `EnableKeyboard="False"`. but it will be hidden immediately after it is shown.
- if you do not call Entry.Focus() by code, keyboard will not show up.

##### Then what does `RequestFocus="True"` do ?

Calling `Entry.Focus()` in page ViewIsAppearing will not focus on the entry. `RequestFocus="True"` will do that for you.

# SoftKeyboardService

## Under Page.xaml.cs or view model 
```csharp
        public MainPage()
        {
            InitializeComponent();

            this.Appearing += MainPage_Appearing;
            this.Disappearing += MainPage_Disappearing;
        }

        private void MainPage_Disappearing(object sender, EventArgs e)
        {
            SoftKeyboard.Current.VisibilityChanged -= Current_VisibilityChanged;
        }
        
        private void MainPage_Appearing(object sender, EventArgs e)
        {
            SoftKeyboard.Current.VisibilityChanged += Current_VisibilityChanged;
        }

        private void Current_VisibilityChanged(SoftKeyboardEventArgs e)
        {
            if(e.IsVisible){
                // do your things
            }
            else{
                // do your things
            }
        }
```

# Demo

### Android

<img src="Screenshots/androidDemo.gif">

### iOS

<img src="Screenshots/iosDemo.gif">

# Limitations

Only support Android and iOS for the moment. 

# Contributing

Contributions are welcome.  Feel free to file issues and pull requests on the repo and they'll be reviewed as time permits.

# License
Under MIT, see LICENSE file.
