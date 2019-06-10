<img src="Screenshots/icon.png" width="64px" >

# Xamarin.KeyboardHelper

This plugin includes:
- KeyboardEnableEffect -- allows user to show/hide softkeyboard on Android/iOS platform in Xamarin.Forms
- SoftKeyboardService -- check softkeyboard display status

Note: This repo had a name change from Xamarin.EnableKeyboardEffect to Xamarin.KeyboardHelper. Please download a new version of nuget below.

# Building Status

<img src="https://ci.appveyor.com/api/projects/status/github/masonyc/Xamarin.KeyboardHelper?svg=true" width="100">

# Setup

- Need Xamarin.Forms version 3 or above
- `Xamarin.KeyboardHelper` Available on NuGet: https://www.nuget.org/packages/Xamarin.KeyboardHelper/2.0.3
- Install into your platform-specific projects (iOS/Android), and any .NET Standard 2.0 projects required for your app.
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
```csharp
         <Entry effects:KeyboardEffect.EnableKeyboard="False" effects:KeyboardEffect.RequestFocus="True">
                <Entry.Effects>
                    <effects:KeyboardEnableEffect />
                </Entry.Effects>
         </Entry>
```

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
