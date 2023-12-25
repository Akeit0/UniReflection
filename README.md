# UniReflection
Unity IL2CPP-compliant reflection acceleration library
# Setup
## Requirements
- Unity 2022.2 or newer (2023.3 is not tested)
This library highly depends on the il2cpp runtime.
Be cautious about version differences or this will cause crash.
## How to install
### Package Manager
1. Open the Package Manager by going to Window > Package Manager.
2. Click on the "+" button and select "Add package from git URL".
3. Enter the following URL:

```
https://github.com/Akeit0/UniReflection.git?path=/Assets/UniReflection
```
### manifest.json
Open `Packages/manifest.json` and add the following in the `dependencies` block:

```json
"com.akeit0.uni-reflection": "https://github.com/Akeit0/UniReflection.git?path=/Assets/UniReflection"
```
# Example
## FastNew
No boxing fast new
```cs
class MyClass{
  private int a=0;
  public MyClass(){
  }
  public MyClass(int a){
    this.a=a;
  }
}
//Equivalent to Activator.CreateInstance, but faster 
var myClass=NewCache<MyClass>.CreateInstance();
myClass=NewCache<MyClass,int>.CreateInstance(1);
```
```cs
class MyStruct{
  private int a;
  public MyStruct(int a){
    this.a=a;
  }
}
var myStruct=NewCache<MyStruct>.CreateInstance();
 myStruct=NewCache<MyStruct,int>.CreateInstance(1);
```

### Benchmark on il2cpp
![new  ](/Media/new.png)
## Fast Field Access
```cs
static int a;
Action<int> setter =fieldInfo.CreateStaticFieldSetter<int>();
Func<int> getter =fieldInfo.CreateStaticFieldGetter<int>();
```
```cs
class MyClass{
  private int a=0;
}
var offset=fieldInfo.GetOffset();
var myclass=new MyClass();
ref var a=GetFieldReferenceFromObject(myclass,offset);
```
### Benchmark on il2cpp
![StaticField  ](/Media/StaticField.png)
## Burst Compatible Delegate
InstanceAction or InstanceFunc can be called in burst compiled function.
```cs
[BurstCompile]
public class Foo
{
  [BurstCompile]
  public static void Bar(in InstanceAction<int> a, int i)
  {
    a.Invoke(i);
  }
}
using (var instanceAction=new InstanceAction<int>(i => Debug.Log(i))
{
    Foo.Bar(instanceAction,1);
}
```
Static function delegates and those containing multiple delegates are not supported.
```cs
static void Log(int i)=> Debug.Log(i);

Action<int> action=Log;
// Throw Exception
using (var instanceAction=new InstanceAction<int>(action)
{
    Foo.Bar(instanceAction,1);
}
```
```cs
Action<int> action=i=>_=i;
action +=i=>_=i;
// Throw Exception
using (var instanceAction=new InstanceAction<int>(action)
{
    Foo.Bar(instanceAction,1);
}

```
## IL2CPP API
namespace UniReflection.IL2CPP will allow you to access il2cpp runtime internal.
Il2CppApi class provides many low level apis such as `il2cpp_resolve_icall` which can get internal extern methods pointer (unmanaged[Cdecl]).
## License

[MIT License](LICENSE)
