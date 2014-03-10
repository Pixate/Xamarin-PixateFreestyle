#!/bin/bash

DOCS_PATH="."
LICENSE_PATH="../LICENSE"
COMP_PUBLISHER="Pixate, Inc."
SAMPLES_PATH="../Examples"

PIXATE_NAME="Pixate Freestyle"
PIXATE_SUMMARY="Beautiful apps. Cleaner Code. Faster iteration."
PIXATE_DESC="CSS for your Xamarin.iOS and Xamarin.Android apps!"

PIXATE_WEBSITE_URL="http://www.pixate.com"
PIXATE_DOCS_URL="http://github.com/Pixate/Xamarin-PixateFreestyle"
PIXATE_SRC_URL="http://github.com/Pixate/Xamarin-PixateFreestyle"

PIXATE_PKG_VERSION="2.1.1"
PIXATE_PKG_NAME="PixateFreestyle"

PIXATE_ANDROID_SAMPLE_DESC="Pixate Freestyle Xamarin.Android Sample.  Demonstrates how to use the Pixate Freestyle CSS Styling engine with Xamarin.Android"
PIXATE_ANDROID_SAMPLE_SLN="../Examples/Android/Example.Android.sln"

PIXATE_IOS_SAMPLE_DESC="Pixate Freestyle Xamarin.iOS Sample.  Demonstrates how to use the Pixate Freestyle CSS Styling engine with Xamarin.iOS"
PIXATE_IOS_SAMPLE_SLN="../Examples/iOS/Example.iOS.sln"

PIXATE_ANDROID_LIB_NAME="../Source/Android/PixateFreestyle/bin/Release/PixateFreestyle.dll"
PIXATE_IOS_LIB_NAME="../Source/iOS/PixateFreestyle/bin/Release/PixateFreestyle.dll"

echo '******************************************************'
echo '*      Pixate Freestyle Component Build Script       *'
echo '******************************************************'
echo ''


echo 'Deleting old Component Tools...'
rm -rf ./tools/
mkdir ./tools/
cd ./tools/

echo 'Downloading latest Component Tools from Xamarin...'
curl -silent -L https://components.xamarin.com/submit/xpkg > tools.zip

echo 'Extracting downloaded Component Tools...'
unzip -q -o tools.zip 2> /dev/null

echo 'Cleaning up...'
rm tools.zip
cd ..

echo ''

echo 'Building Component...'
mono ./tools/xamarin-component.exe create-manually "./${PIXATE_PKG_NAME}-${PIXATE_PKG_VERSION}.xam" \
	--name="$PIXATE_NAME" \
	--summary="$PIXATE_SUMMARY" \
	--publisher="$COMP_PUBLISHER" \
	--website="$PIXATE_WEBSITE_URL" \
	--docs="$PIXATE_DOCS_URL" \
	--srcurl="${PIXATE_SRC_URL}" \
	--details="./Details.md" \
	--getting-started="./GettingStarted.md" \
	--license="$LICENSE_PATH" \
	--icon="./${PIXATE_PKG_NAME}_128x128.png" \
	--icon="./${PIXATE_PKG_NAME}_512x512.png" \
	--library="android":"$PIXATE_ANDROID_LIB_NAME" \
	--sample="$PIXATE_ANDROID_SAMPLE_DESC":"$PIXATE_ANDROID_SAMPLE_SLN" \
	--library="ios":"$PIXATE_IOS_LIB_NAME" \
	--sample="$PIXATE_IOS_SAMPLE_DESC":"$PIXATE_IOS_SAMPLE_SLN"


echo ''
echo 'Cleaning up...'
rm -rf ./tools/

echo ''
echo '******************************************************'
echo '*                        DONE                        *'
echo '******************************************************'
