s/EXTERN_C const \(IID\|CLSID\|LIBID\|DIID\) \(IID\|CLSID\|LIBID\|DIID\)_\(..*\);/#define \2_\3 __uuidof(\3)/