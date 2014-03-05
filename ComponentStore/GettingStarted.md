# Getting Started

## Quick Start

### iOS

In your **Main.cs** file, add the following line to your **Main()** method:

```
	PixateFreestyleLib.PixateFreestyle.InitializePixateFreestyle ();
```

Add a button to your app. Now add a file called **default.css** and place it in your **Resources** folder. In this file, place something similar to this in it:

```css
button {
	text             : "Pixate Freestyle!";
	color            : #446620;
	background-color : linear-gradient(#87c44a, #b4da77);
	border-width     : 3px;
	border-color     : #84a254;
	border-style     : solid;
	border-radius    : 10px;
	font-size        : 20px;
}
```

Now run your app and you should see a styled button.

### Android

In your main activity file, add this line to your **onCreate()** method (after the **base.OnCreate()** call):

```
	Com.Pixate.Freestyle.PixateFreestyle.Init (this);
```

Add a button to your app. Now add a file called **default.css** and place it in your **Assets** folder. In this file, place something similar to this in it:

```css
button {
	text             : "Pixate Freestyle!";
	color            : #446620;
	background-color : linear-gradient(#87c44a, #b4da77);
	border-width     : 3px;
	border-color     : #84a254;
	border-style     : solid;
	border-radius    : 10px;
	font-size        : 20px;
}
```

Now run your app and you should see a styled button.

## Online Documentation

Please see the current Xamarin module documentation [here](http://github.com/Pixate/Xamarin-PixateFreestyle)

The PixateFreestyle documentation can be accessed [here](http://www.pixate.com)

## Mailing List & Twitter

Keep up with notifications and announcements by joining Pixate's [mailing list](http://pixatesurvey.herokuapp.com) and [follow us](http://twitter.com/Pixate) on Twitter.

