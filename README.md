# FlatButton
FlatButton is a button that inherits from the Flat UI style (think Windows 8). 

[[!ScreenShot](http://screencast.com/t/q75F5T4N)]

## Credit
FlatButton was originally published by Katsuma Tanaka, and later bound to work with Xamarin.iOS by Pierce Boggan.

Please thank him for his hard work in creating the control, as well as the demo, as the Xamarin.iOS version is pretty much just a bound version of his work.

## Installation
For a completely fresh install, build the static library, followed by the binding project. Reference the .dll generated by the binding project in a project you wish to use it.

You can also use the .dll in the demo folder in your apps (although this .dll is built using the universal profile and may increase the size of your app).

## Properties
### FaceColor (UIColor)
A surface color of the button.

### SideColor (UIColor)
A side color of the button.

### Radius (float)
A corner radius of the button.

### Margin (float)
A button height in normal state.

### Depth (float)
A button depth when the button pushed down.

## Example Usage
See the demo application for example usage.

## License
FlatButton is released under the **MIT License**, see LICENSE.md.