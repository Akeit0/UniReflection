#if UNITY_EDITOR ||!ENABLE_IL2CPP
#define Mono
#endif

using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UniReflection.IL2CPP;

namespace UniReflection
{
    internal static class TypeArrayCache
    {
        
        internal static readonly Type[] TypeArray0 = Array.Empty<Type>();
        internal static readonly Type[] TypeArray1 = new Type[1];
        internal static readonly Type[] TypeArray2 = new Type[2];
        internal static readonly Type[] TypeArray3 = new Type[3];
        internal static readonly Type[] TypeArray4 = new Type[4];
        internal static readonly Type[] TypeArray5 = new Type[5];
        internal static readonly Type[] TypeArray6 = new Type[6];
        internal static readonly Type[] TypeArray7 = new Type[7];
        internal static readonly Type[] TypeArray8 = new Type[8];
        internal static readonly Type[] TypeArray9 = new Type[9];
        internal static readonly Type[] TypeArray10 = new Type[10];

    }

    internal static class TypeArrayCache<T>
    {
        internal static readonly Type[] TypeArray = { typeof(T) };
    }

    public static unsafe class NewCache<T>
    {
        public static readonly Func<T> CreateInstance;
        public static readonly bool HasValidConstructor;

        public static bool TryCreateInstance(out T instance)
        {
            if (HasValidConstructor)
            {
                instance = CreateInstance();
                return true;
            }

            instance = default;
            return false;
        }

        static NewCache()
        {
            var targetType = typeof(T);
            var isValueType = targetType.IsValueType;
            var constructor = targetType.GetConstructor(BindingFlags.Instance|BindingFlags.Public|BindingFlags.NonPublic,null,Array.Empty<Type>(),null);
            if (constructor is null)
            {
                if (!isValueType)
                {
                    CreateInstance = () => throw new Exception($"no default constructor for {targetType}");
                    HasValidConstructor = false;
                }

                HasValidConstructor = true;
                CreateInstance = () => default;
                return;
            }

            HasValidConstructor = true;
#if Mono
                var dm =
                new DynamicMethod("", typeof(T), TypeArrayCache<object>.TypeArray, restrictedSkipVisibility: true);
                var il = dm.GetILGenerator();
                il.Emit(OpCodes.Newobj, constructor);
                il.Emit(OpCodes.Ret);
                CreateInstance = (Func<T>)dm.CreateDelegate(typeof(Func<T>));
#else


            {
                if (isValueType)
                {
                    var p = (delegate*<ref T, void>)constructor.MethodHandle.Value;
                    CreateInstance = () =>
                    {
                        var t = default(T);
                        p(ref t);
                        return t;
                    };
                }
                else
                {
                    var klass = targetType.GetClassHandle();
                    var p = (delegate*<Il2CppObjectHandle, void>)constructor.MethodHandle.Value;
                    CreateInstance = () =>
                    {
                        var o = Il2CppApi.il2cpp_object_new(klass);
                        p(o);
                        return Unsafe.As<Il2CppObjectHandle, T>(ref o);
                    };
                }
            }
#endif
        }
    }
}