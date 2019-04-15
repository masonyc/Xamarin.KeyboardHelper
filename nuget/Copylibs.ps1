Copy-Item "..\scr\Xamarin.EnableKeyboardEffect\bin\Release\Xamarin.EnableKeyboardEffect.*.nupkg" -Destination '.\Temp\nupkg.zip'
Expand-Archive -Path '.\Temp\nupkg.zip' -DestinationPath Temp
Copy-Item '.\Temp\lib' -Destination '.\' -Recurse -ErrorAction SilentlyContinue