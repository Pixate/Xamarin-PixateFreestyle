BTOUCH=/Developer/MonoTouch/usr/bin/btouch

all: Pixate.dll

Pixate.dll: Makefile AssemblyInfo.cs ApiDefinition.cs extra.cs
	$(BTOUCH) -unsafe ApiDefinition.cs AssemblyInfo.cs StructsAndEnums.cs -x extra.cs --out=$@ --link-with=PXEngine,PXEngine

clean:
	-rm -f *.a *.dll
