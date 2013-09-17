Xamarin-Pixate
================

To demonstrate the use of Pixate 1.1 (beta 4 or later) within MonoTouch, we'll be using Xamarin's MonoDevelop IDE. Let's get started by creating a new solution. We'll start with creating a C# -> MonoTouch -> Single View Application solution:

![Single View Application](https://raw.github.com/Pixate/MonoTouch-Pixate/master/Screenshots/single_view_application.png)

Name your project and click 'OK'.

## Adding the Pixate Library

Now right-click on your project's References folder in the Solution view and select 'Edit References...'.

![Add Native Ref](https://raw.github.com/Pixate/MonoTouch-Pixate/master/Screenshots/edit_reference.png)

Now add the `Pixate.dll` file that you can [download from here](http://www.pixate.com/prerelease/engine/ios/PixateDLL-1.0RC3.zip) if you don't already have it.  You can also [build the DLL](#pixatedll-build-instructions) yourself.

The dialog should look something like this:

![Add Native Ref](https://raw.github.com/Pixate/MonoTouch-Pixate/master/Screenshots/add_pixate_dll.png)

## Adding a CSS File

Now right-click on your project again in the Solution view and select Add -> New File. Choose 'Misc' from the list on the left, and 'Empty Text File' from the list in the middle. Name your file 'default.css'.

![Add CSS File](https://raw.github.com/Pixate/MonoTouch-Pixate/master/Screenshots/add_css_file.png)

Right-click on the `default.css` file you added and select the 'Properties' menu item. Over on the Properties panel, change 'Build action' to be 'Content'.

![Default to Content](https://raw.github.com/Pixate/MonoTouch-Pixate/master/Screenshots/default_to_content.png)

## Setting up for Styling

At this point, let's add a button or two to our application. Double-click on the .xib file for your project (e.g. <ProjectName>ViewController.xib). Add a couple of buttons like the following:

![Two Buttons](https://raw.github.com/Pixate/MonoTouch-Pixate/master/Screenshots/two_buttons.png)

With each of the new buttons you added, select one, activate the Identity Inspector in the Utilities View.

Now we need to give the buttons a "styleId" so that you can reference it from your CSS. We'll add a Runtime Attribute. Click the small '+' and add an entry with a key path of `styleId`, a type of `String`, and a value of `button1`. For the second button add a `styleId`, a type of `String`, and a value of `button2`.

![Runtime Attribute](https://raw.github.com/Pixate/MonoTouch-Pixate/master/Screenshots/styleId.png)

Now save and close Xcode.

## Set up the Pixate license

At the top of your *Main.cs* file, add this import line:

```csharp
	using PixateLib;
```

Then, at the beginning of your Main method, add this line:

```csharp
	Pixate.LicenseKeyForUser("SERIAL NUMBER", "USER NAME");
```

Be sure to replace *SERIAL NUMBER* and *USER NAME* with your licensing information. If you do not have a license and wish to run in free mode, you will still need this line of code. Simply replace *SERIAL NUMBER* and *USER NAME* with empty strings.

In your *AppDelegate.cs* file, in your *FinishedLaunching* method, anywhere *after* you have created your window but *before* you call MakeKeyAndVisible(), add the following:

```csharp
	window.SetStyleMode (PXStylingMode.PXStylingNormal);
```

This tells the root window to style all of its subviews.

Before we style the buttons, go ahead and run the project in MonoDevelop. It should look something like this:

![Buttons Runs](https://raw.github.com/Pixate/MonoTouch-Pixate/master/Screenshots/buttons_run.png)

## Styling the Buttons

Now comes the easy part, just open your default.css file and add some CSS. For our two buttons, let's try something simple:

```css
	#button1 {
		background-color : yellow;
		border-width     : 2px;
		border-color     : black;
		border-radius    : 8px;
		border-style     : solid;
	}
	#button2 {
		background-color : gray;
		border-width     : 2px;
		border-color     : black;
		border-radius    : 8px;
		border-style     : solid;
	}
```

## First Styled App

Now Run your project. Your buttons should look like this:

![Styled Buttons](https://raw.github.com/Pixate/MonoTouch-Pixate/master/Screenshots/styled_buttons.png)

Here's some slightly fancier styling you can try:

```css
	#button1 {
	  border-radius    : 5px;
	  font-family      : "American Typewriter";
	  font-size        : 13px;
	  font-weight      : bold;
	  text-transform   : uppercase;
	  letter-spacing   : 0.75px;
	  color            : #ffffff;
	  background-color : #008ed4;
	}
	#button2 {
	  color            : #446620;
	  background-color : linear-gradient(#87c44a, #b4da77);
	  border-width     : 1px;
	  border-color     : #84a254;
	  border-style     : solid;
	  border-radius    : 10px;
	  font-size        : 13px;
	}
```

Now you'll get pretty buttons like this:

![Pretty Buttons](https://raw.github.com/Pixate/MonoTouch-Pixate/master/Screenshots/pretty_buttons.png)

Coding Your UI
--------------

If you programmatically create your UI, this library [*will soon*] support the full API from the [Pixate Dev Reference](http://www.pixate.com/documentation.html). In addition, the following three methods are provided to set ID, Class, and CSS on your controls/views:

```csharp
	view.SetStyleId("StyleID");
	view.SetStyleClass("StyleClass");
	view.SetStyleCSS("StyleCSS");
```

For example, here's some code that creates 3 buttons, each with a unique ID, all three with the same Class, and the third styled inline with CSS:

```csharp
	button1 = UIButton.FromType(UIButtonType.RoundedRect);
	button1.Frame = new RectangleF(50, 20, 200, 40);
	button1.SetTitle("#myButton1 .allButtons", UIControlState.Normal);
	button1.SetStyleId("myButton1");
	button1.SetStyleClass("allButtons");

	button2 = UIButton.FromType(UIButtonType.RoundedRect);
	button2.Frame = new RectangleF(50, 70, 200, 40);
	button2.SetTitle("#myButton2 .allButtons", UIControlState.Normal);
	button2.SetStyleId("myButton2");
	button2.SetStyleClass("allButtons");

	button3 = UIButton.FromType(UIButtonType.RoundedRect);
	button3.Frame = new RectangleF(50, 120, 200, 40);
	button3.SetTitle("#myButton3 .allButtons", UIControlState.Normal);
	button3.SetStyleId("myButton3");
	button3.SetStyleClass("allButtons");

	button3.SetStyleCSS("background-color: green; border-radius: 5;");
```

The CSS for these three buttons could be:

```css
	.allButtons {
	 border-radius: 5;
	}

	#myButton1 {
	 background-color: yellow;
	 border-color: black;
	 border-width: 2;
     border-style: solid;
	}

	#myButton2 {
	 background-color: blue;
	 border-color: yellow;
	 border-width: 2;
     border-style: solid;
	}

```

And you would get something like this:

![](https://raw.github.com/Pixate/MonoTouch-Pixate/master/Screenshots/monotouch-sample1.png)

## Making changes in real-time

To turn on real-time monitoring of your CSS for live editing, first you'll need to turn on file monitoring in your AppDelegate, anywhere in the FinishedLaunching method. Add the following:

```csharp
	Pixate.CurrentApplicationStylesheet().MonitorChanges = true;
```

You may want to print out the location of the CSS file Pixate is using so you can edit it (by default your default.css will be loaded out of your app's resources). Use the following to get the temporary CSS file location:

```csharp
	string path = Pixate.CurrentApplicationStylesheet().FilePath;
```

You'll want to print this location out to the console and then edit it. Be sure to save your changes to another file before you run your app again, otherwise your changes will be overwritten. Alternetaively, you can load your CSS from a location on your file system during development (i.e. a DropBox folder) to easier editing: 

```csharp
	Pixate.StyleSheetFromFilePathWithOrigin("/some/path/myStyle.css", PXStylesheetOrigin.PXStylesheetOriginApplication);
```

## Pixate.dll Build Instructions

If you'd like to build the DLL yourself, this is the simple process.
After cloning this project, start by creating a symbolic link to the Pixate file from your Pixate distribution in the Source folder. For example:

    cd Source
	ln -s ~/Desktop/Pixate/Frameworks/Pixate.framework/Pixate   .

Make sure the path to the MonoTouch BTOUCH tool is properly set at the top of the Makefile:

	BTOUCH=/Developer/MonoTouch/usr/bin/btouch

Now just type make:

	make

The resulting `Pixate.dll` file can now be added to your MonoTouch project.

## License

License for the included demos is available in the accompanying [LICENSE.md](https://github.com/Pixate/MonoTouch-Pixate/blob/master/Demos/LICENSE.md) file.

License for the included source is available in the accompanying [LICENSE.md](https://github.com/Pixate/MonoTouch-Pixate/blob/master/Source/LICENSE.md) file.
