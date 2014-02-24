BTOUCH=/Developer/MonoTouch/usr/bin/btouch

all: PixateFreestyle.dll

PixateFreestyle.dll: Makefile Properties/AssemblyInfo.cs ApiDefinition.cs Extras.cs
	$(BTOUCH) -unsafe ApiDefinition.cs Properties/AssemblyInfo.cs StructsAndEnums.cs -x Extras.cs --out=$@ --link-with=PixateFreestyle,PixateFreestyle -r=/Developer/MonoTouch/usr/lib/mono/2.1/System.Core.dll

mdtool:
	'/Applications/Xamarin Studio.app/Contents/MacOS/mdtool' build

clean:
	-rm -f *.a *.dll
	-rm -rf bin obj


