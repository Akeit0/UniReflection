using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.PerformanceTesting;
using NUnit.Framework;

namespace UniReflection.Tests
{

    public class BenchmarkClassNew
    {
        const int WarmupCount = 5;
        const int MeasurementCount = 100;

        class MyClass
        {
            public int A = 5;
        }

        [TearDown]
        public void TearDown()
        {
            GC.Collect();
        }

        [Test, Performance]
        public void NewDirect()
        {
            Measure.Method(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        new MyClass();
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class Direct", SampleUnit.Microsecond))
                .Run();
        }

        [Test, Performance]
        public void NewConstraint()
        {
            static T New<T>() where T : new() => new T();
            Measure.Method(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        New<MyClass>();
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class generic constrained", SampleUnit.Microsecond))
                .Run();
        }

        [Test, Performance]
        public void NewCache()
        {
            Measure.Method(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        NewCache<MyClass>.CreateInstance();
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class cache", SampleUnit.Microsecond))
                .Run();
        }

        
    }
    public class BenchmarkClassNewWithParameter
    {
        const int WarmupCount = 5;
        const int MeasurementCount = 100;

        private class MyClass
        {
            public MyClass(int a)
            {
                A = a;
            }

            public int A = 5;
        }

        [TearDown]
        public void TearDown()
        {
            GC.Collect();
        }

        [Test, Performance]
        public void NewDirect()
        {
            Measure.Method(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        new MyClass(1);
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class Direct", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void NewActivator()
        {
            [MethodImpl(MethodImplOptions.NoInlining)]
            static T New<T>() where T : new() => new T();
            Measure.Method(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        Activator.CreateInstance(typeof(MyClass),1);
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class generic constrained", SampleUnit.Microsecond))
                .Run();
        }

        [Test, Performance]
        public void NewCache()
        {
            Measure.Method(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        NewCache< MyClass,int>.CreateInstance(1);
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class cache", SampleUnit.Microsecond))
                .Run();
        }
    }
    public class BenchmarkStructNew
    {
        const int WarmupCount = 5;
        const int MeasurementCount = 100;

        

        struct MyStruct
        {
            public int A ;
        }

        [TearDown]
        public void TearDown()
        {
            GC.Collect();
        }
        [Test, Performance]
        public void CallNop()
        {
            Measure.Method(() =>
                {
                    [MethodImpl(MethodImplOptions.NoInlining)]
                    static void New() {}
                    for (int i = 0; i < 1000; i++)
                    {
                        New();
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class Direct", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void NewDirect()
        {
            Measure.Method(() =>
                {
                    [MethodImpl(MethodImplOptions.NoInlining)]
                    static MyStruct New() => new MyStruct();
                    for (int i = 0; i < 1000; i++)
                    {
                        New();
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class Direct", SampleUnit.Microsecond))
                .Run();
        }

        [Test, Performance]
        public void NewConstraint()
        {
            [MethodImpl(MethodImplOptions.NoInlining)]
            static T New<T>() where T : new() => new T();
            Measure.Method(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        New<MyStruct>();
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class generic constrained", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void NewActivator()
        {
            Measure.Method(() =>
                {
                    [MethodImpl(MethodImplOptions.NoInlining)]
                    static T New<T>() where T : new() => Activator.CreateInstance<T>();
                    for (int i = 0; i < 1000; i++)
                    {
                        New<MyStruct>();
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class generic constrained", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void NewCache()
        {
            Measure.Method(() =>
                {
                    [MethodImpl(MethodImplOptions.NoInlining)]
                    static T New<T>() => NewCache<T>.CreateInstance();
                    for (int i = 0; i < 1000; i++)
                    {
                        
                        New<MyStruct>();
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class cache", SampleUnit.Microsecond))
                .Run();
        }

        
    }
    public class BenchmarkStructNewWithParameter
    {
        const int WarmupCount = 5;
        const int MeasurementCount = 100;

        private struct MyStruct
        {
            public MyStruct(int a)
            {
                A = a;
            }

            public int A ;
        }
        [TearDown]
        public void TearDown()
        {
            GC.Collect();
        }

        [Test, Performance]
        public void NewDirect()
        {
            Measure.Method(() =>
                {
                    [MethodImpl(MethodImplOptions.NoInlining)]
                    static MyStruct New(int x) => new (x);
                    for (int i = 0; i < 1000; i++)
                    {
                        New(1);
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class Direct", SampleUnit.Microsecond))
                .Run();
        }

        [Test, Performance]
        public void NewCache()
        {
            Measure.Method(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        NewCache< MyStruct,int>.CreateInstance(1);
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("New class cache", SampleUnit.Microsecond))
                .Run();
        }
    }

    public class BenchmarkStaticIntField
    {
        const int WarmupCount = 5;
        const int MeasurementCount = 100;
        [TearDown]
        public void TearDown()
        {
            GC.Collect();
        }
        public static int A;
        private FieldInfo _fieldInfo=typeof(BenchmarkStaticIntField).GetField(nameof(A),BindingFlags.Static|BindingFlags.Public);
        [Test, Performance]
        public void SetDirect()
        {
            Measure.Method(() =>
                {
                    [MethodImpl(MethodImplOptions.NoInlining)]
                    static void Set(int x) => A=x;
                    for (int i = 0; i < 1000; i++)
                    {
                        Set(1);
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("Set Static Int Field  directly", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void GetDirect()
        {
            Measure.Method(() =>
                {
                    [MethodImpl(MethodImplOptions.NoInlining)]
                    static int Get() => A;
                    for (int i = 0; i < 1000; i++)
                    {
                        Get();
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("Get Static Int Field  directly", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void SetReflection()
        {
            Measure.Method(() =>
                {
                    
                   var f= _fieldInfo;
                    for (int i = 0; i < 1000; i++)
                    {
                        f.SetValue(null,1);
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("Set Static Int Field  via FieldInfo", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void GetReflection()
        {
            Measure.Method(() =>
                {
                    
                    var f= _fieldInfo;
                    for (int i = 0; i < 1000; i++)
                    {
                        f.GetValue(null);
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("Get Static Int Field  via FieldInfo", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void SetSetter()
        {
            Measure.Method(() =>
                {
                    var set =_fieldInfo.CreateStaticFieldSetter<int>();
                    for (int i = 0; i < 1000; i++)
                    {
                        set(1);
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("Set Static Int Field  via CachedSetter", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void GetGetter()
        {
            Measure.Method(() =>
                {
                    var getter =_fieldInfo.CreateStaticFieldGetter<int>();
                    for (int i = 0; i < 1000; i++)
                    {
                        getter();
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("Get Static Int Field  via CachedGetter", SampleUnit.Microsecond))
                .Run();
        }
    }
    public class BenchmarkStaticStringField
    {
        const int WarmupCount = 5;
        const int MeasurementCount = 100;
        [TearDown]
        public void TearDown()
        {
            GC.Collect();
        }
        public static string A;
        private FieldInfo _fieldInfo=typeof(BenchmarkStaticStringField).GetField(nameof(A),BindingFlags.Static|BindingFlags.Public);
        [Test, Performance]
        public void SetDirect()
        {
            Measure.Method(() =>
                {
                    [MethodImpl(MethodImplOptions.NoInlining)]
                    static void Set(string x) => A=x;
                    for (int i = 0; i < 1000; i++)
                    {
                        Set("1");
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("Set static string field directly", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void GetDirect()
        {
            Measure.Method(() =>
                {
                    [MethodImpl(MethodImplOptions.NoInlining)]
                    static string Get() => A;
                    for (int i = 0; i < 1000; i++)
                    {
                        Get();
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("Get static string field directly", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void SetReflection()
        {
            Measure.Method(() =>
                {

                    var f = _fieldInfo;
                    for (int i = 0; i < 1000; i++)
                    {
                        f.SetValue(null,"1");
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("Set static string field  via FieldInfo", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void GetReflection()
        {
            Measure.Method(() =>
                {

                    var f = _fieldInfo;
                    for (int i = 0; i < 1000; i++)
                    {
                        f.GetValue(null);
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("Get static string field  via FieldInfo", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void SetSetter()
        {
            Measure.Method(() =>
                {
                    var set =_fieldInfo.CreateStaticFieldSetter<string>();
                    for (int i = 0; i < 1000; i++)
                    {
                        set("1");
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("Set static string field  via CachedSetter", SampleUnit.Microsecond))
                .Run();
        }
        [Test, Performance]
        public void GetGetter()
        {
            Measure.Method(() =>
                {
                    var getter =_fieldInfo.CreateStaticFieldGetter<string>();
                    for (int i = 0; i < 1000; i++)
                    {
                        getter();
                    }
                })
                .WarmupCount(WarmupCount)
                .MeasurementCount(MeasurementCount)
                .SampleGroup(new SampleGroup("Get static string field  via CachedGetter", SampleUnit.Microsecond))
                .Run();
        }
    }
}