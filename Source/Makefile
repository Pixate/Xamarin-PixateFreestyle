BTOUCH=/Developer/MonoTouch/usr/bin/btouch

all: Pixate.dll

Pixate.dll: Makefile AssemblyInfo.cs ApiDefinition.cs extra.cs
	$(BTOUCH) -unsafe ApiDefinition.cs AssemblyInfo.cs StructsAndEnums.cs -x extra.cs --out=$@ --link-with=PXEngine,PXEngine -r=/Developer/MonoTouch/usr/lib/mono/2.1/System.Core.dll

mdtool:
	'/Applications/Xamarin Studio.app/Contents/MacOS/mdtool' build

clean:
	-rm -f *.a *.dll
	-rm -rf bin obj
