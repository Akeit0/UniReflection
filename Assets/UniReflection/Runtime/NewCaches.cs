
#if UNITY_EDITOR ||!ENABLE_IL2CPP
#define Mono
#else
using UniReflection.IL2CPP;
#endif
using System;
using System.Reflection;
using System.Reflection.Emit;
namespace UniReflection
{
    public static unsafe class NewCache<TInstance,T0>
    {
        public static readonly Func<T0, TInstance> CreateInstance;
        public static readonly bool HasValidConstructor;

        public static bool TryCreateInstance(T0 t0, out TInstance instance)
        {
            if (HasValidConstructor)
            {
                instance = CreateInstance(t0);
                return true;
            }

            instance = default;
            return false;
        }

        static NewCache()
        {
            var targetType = typeof(TInstance);

            ConstructorInfo constructor;
            lock (TypeArrayCache.TypeArray1)
            {
                var paramTypes = TypeArrayCache.TypeArray1;
                    paramTypes[0] = typeof(T0);
                 constructor = targetType.GetConstructor(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, paramTypes,
                    null);
            }

            HasValidConstructor = true;

#if Mono
            lock (TypeArrayCache.TypeArray2)
            {
                var paramTypes = TypeArrayCache.TypeArray2;
                paramTypes[0] = typeof(object);
                    paramTypes[1] = typeof(T0);
                
                var dm =
                    new DynamicMethod("new", typeof(TInstance),paramTypes, restrictedSkipVisibility: true);
                var il = dm.GetILGenerator();
                  il.Emit(OpCodes.Ldarg_S,1);
                il.Emit(OpCodes.Newobj, constructor);
                il.Emit(OpCodes.Ret);
                CreateInstance = (Func<T0, TInstance>)dm.CreateDelegate(typeof(Func<T0, TInstance>));
            }

#else
            var isValueType = targetType.IsValueType;
            var klass = targetType.GetClassHandle();
            if (isValueType)
            {
                var p = (delegate*<ref TInstance, T0, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0) =>
                {
                    var t = default(TInstance);
                    p(ref t, t0);
                    return t;
                };
            }
            else
            {
                var p = (delegate*<Il2CppObjectHandle, T0, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0) =>
                {
                    var o = Il2CppApi.il2cpp_object_new(klass);
                    p(o, t0);
                    return Unsafe.As<Il2CppObjectHandle, TInstance>(ref o);
                };
            }
#endif
        }
    }
    public static unsafe class NewCache<TInstance,T0,T1>
    {
        public static readonly Func<T0,T1, TInstance> CreateInstance;
        public static readonly bool HasValidConstructor;

        public static bool TryCreateInstance(T0 t0,T1 t1, out TInstance instance)
        {
            if (HasValidConstructor)
            {
                instance = CreateInstance(t0,t1);
                return true;
            }

            instance = default;
            return false;
        }

        static NewCache()
        {
            var targetType = typeof(TInstance);

            ConstructorInfo constructor;
            lock (TypeArrayCache.TypeArray2)
            {
                var paramTypes = TypeArrayCache.TypeArray2;
                    paramTypes[0] = typeof(T0);
                    paramTypes[1] = typeof(T1);
                 constructor = targetType.GetConstructor(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, paramTypes,
                    null);
            }

            HasValidConstructor = true;

#if Mono
            lock (TypeArrayCache.TypeArray3)
            {
                var paramTypes = TypeArrayCache.TypeArray3;
                paramTypes[0] = typeof(object);
                    paramTypes[1] = typeof(T0);
                    paramTypes[2] = typeof(T1);
                
                var dm =
                    new DynamicMethod("new", typeof(TInstance),paramTypes, restrictedSkipVisibility: true);
                var il = dm.GetILGenerator();
                  il.Emit(OpCodes.Ldarg_S,1);
                  il.Emit(OpCodes.Ldarg_S,2);
                il.Emit(OpCodes.Newobj, constructor);
                il.Emit(OpCodes.Ret);
                CreateInstance = (Func<T0,T1, TInstance>)dm.CreateDelegate(typeof(Func<T0,T1, TInstance>));
            }

#else
            var isValueType = targetType.IsValueType;
            var klass = targetType.GetClassHandle();
            if (isValueType)
            {
                var p = (delegate*<ref TInstance, T0,T1, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1) =>
                {
                    var t = default(TInstance);
                    p(ref t, t0,t1);
                    return t;
                };
            }
            else
            {
                var p = (delegate*<Il2CppObjectHandle, T0,T1, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1) =>
                {
                    var o = Il2CppApi.il2cpp_object_new(klass);
                    p(o, t0,t1);
                    return Unsafe.As<Il2CppObjectHandle, TInstance>(ref o);
                };
            }
#endif
        }
    }
    public static unsafe class NewCache<TInstance,T0,T1,T2>
    {
        public static readonly Func<T0,T1,T2, TInstance> CreateInstance;
        public static readonly bool HasValidConstructor;

        public static bool TryCreateInstance(T0 t0,T1 t1,T2 t2, out TInstance instance)
        {
            if (HasValidConstructor)
            {
                instance = CreateInstance(t0,t1,t2);
                return true;
            }

            instance = default;
            return false;
        }

        static NewCache()
        {
            var targetType = typeof(TInstance);

            ConstructorInfo constructor;
            lock (TypeArrayCache.TypeArray3)
            {
                var paramTypes = TypeArrayCache.TypeArray3;
                    paramTypes[0] = typeof(T0);
                    paramTypes[1] = typeof(T1);
                    paramTypes[2] = typeof(T2);
                 constructor = targetType.GetConstructor(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, paramTypes,
                    null);
            }

            HasValidConstructor = true;

#if Mono
            lock (TypeArrayCache.TypeArray4)
            {
                var paramTypes = TypeArrayCache.TypeArray4;
                paramTypes[0] = typeof(object);
                    paramTypes[1] = typeof(T0);
                    paramTypes[2] = typeof(T1);
                    paramTypes[3] = typeof(T2);
                
                var dm =
                    new DynamicMethod("new", typeof(TInstance),paramTypes, restrictedSkipVisibility: true);
                var il = dm.GetILGenerator();
                  il.Emit(OpCodes.Ldarg_S,1);
                  il.Emit(OpCodes.Ldarg_S,2);
                  il.Emit(OpCodes.Ldarg_S,3);
                il.Emit(OpCodes.Newobj, constructor);
                il.Emit(OpCodes.Ret);
                CreateInstance = (Func<T0,T1,T2, TInstance>)dm.CreateDelegate(typeof(Func<T0,T1,T2, TInstance>));
            }

#else
            var isValueType = targetType.IsValueType;
            var klass = targetType.GetClassHandle();
            if (isValueType)
            {
                var p = (delegate*<ref TInstance, T0,T1,T2, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2) =>
                {
                    var t = default(TInstance);
                    p(ref t, t0,t1,t2);
                    return t;
                };
            }
            else
            {
                var p = (delegate*<Il2CppObjectHandle, T0,T1,T2, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2) =>
                {
                    var o = Il2CppApi.il2cpp_object_new(klass);
                    p(o, t0,t1,t2);
                    return Unsafe.As<Il2CppObjectHandle, TInstance>(ref o);
                };
            }
#endif
        }
    }
    public static unsafe class NewCache<TInstance,T0,T1,T2,T3>
    {
        public static readonly Func<T0,T1,T2,T3, TInstance> CreateInstance;
        public static readonly bool HasValidConstructor;

        public static bool TryCreateInstance(T0 t0,T1 t1,T2 t2,T3 t3, out TInstance instance)
        {
            if (HasValidConstructor)
            {
                instance = CreateInstance(t0,t1,t2,t3);
                return true;
            }

            instance = default;
            return false;
        }

        static NewCache()
        {
            var targetType = typeof(TInstance);

            ConstructorInfo constructor;
            lock (TypeArrayCache.TypeArray4)
            {
                var paramTypes = TypeArrayCache.TypeArray4;
                    paramTypes[0] = typeof(T0);
                    paramTypes[1] = typeof(T1);
                    paramTypes[2] = typeof(T2);
                    paramTypes[3] = typeof(T3);
                 constructor = targetType.GetConstructor(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, paramTypes,
                    null);
            }

            HasValidConstructor = true;

#if Mono
            lock (TypeArrayCache.TypeArray5)
            {
                var paramTypes = TypeArrayCache.TypeArray5;
                paramTypes[0] = typeof(object);
                    paramTypes[1] = typeof(T0);
                    paramTypes[2] = typeof(T1);
                    paramTypes[3] = typeof(T2);
                    paramTypes[4] = typeof(T3);
                
                var dm =
                    new DynamicMethod("new", typeof(TInstance),paramTypes, restrictedSkipVisibility: true);
                var il = dm.GetILGenerator();
                  il.Emit(OpCodes.Ldarg_S,1);
                  il.Emit(OpCodes.Ldarg_S,2);
                  il.Emit(OpCodes.Ldarg_S,3);
                  il.Emit(OpCodes.Ldarg_S,4);
                il.Emit(OpCodes.Newobj, constructor);
                il.Emit(OpCodes.Ret);
                CreateInstance = (Func<T0,T1,T2,T3, TInstance>)dm.CreateDelegate(typeof(Func<T0,T1,T2,T3, TInstance>));
            }

#else
            var isValueType = targetType.IsValueType;
            var klass = targetType.GetClassHandle();
            if (isValueType)
            {
                var p = (delegate*<ref TInstance, T0,T1,T2,T3, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2,t3) =>
                {
                    var t = default(TInstance);
                    p(ref t, t0,t1,t2,t3);
                    return t;
                };
            }
            else
            {
                var p = (delegate*<Il2CppObjectHandle, T0,T1,T2,T3, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2,t3) =>
                {
                    var o = Il2CppApi.il2cpp_object_new(klass);
                    p(o, t0,t1,t2,t3);
                    return Unsafe.As<Il2CppObjectHandle, TInstance>(ref o);
                };
            }
#endif
        }
    }
    public static unsafe class NewCache<TInstance,T0,T1,T2,T3,T4>
    {
        public static readonly Func<T0,T1,T2,T3,T4, TInstance> CreateInstance;
        public static readonly bool HasValidConstructor;

        public static bool TryCreateInstance(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4, out TInstance instance)
        {
            if (HasValidConstructor)
            {
                instance = CreateInstance(t0,t1,t2,t3,t4);
                return true;
            }

            instance = default;
            return false;
        }

        static NewCache()
        {
            var targetType = typeof(TInstance);

            ConstructorInfo constructor;
            lock (TypeArrayCache.TypeArray5)
            {
                var paramTypes = TypeArrayCache.TypeArray5;
                    paramTypes[0] = typeof(T0);
                    paramTypes[1] = typeof(T1);
                    paramTypes[2] = typeof(T2);
                    paramTypes[3] = typeof(T3);
                    paramTypes[4] = typeof(T4);
                 constructor = targetType.GetConstructor(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, paramTypes,
                    null);
            }

            HasValidConstructor = true;

#if Mono
            lock (TypeArrayCache.TypeArray6)
            {
                var paramTypes = TypeArrayCache.TypeArray6;
                paramTypes[0] = typeof(object);
                    paramTypes[1] = typeof(T0);
                    paramTypes[2] = typeof(T1);
                    paramTypes[3] = typeof(T2);
                    paramTypes[4] = typeof(T3);
                    paramTypes[5] = typeof(T4);
                
                var dm =
                    new DynamicMethod("new", typeof(TInstance),paramTypes, restrictedSkipVisibility: true);
                var il = dm.GetILGenerator();
                  il.Emit(OpCodes.Ldarg_S,1);
                  il.Emit(OpCodes.Ldarg_S,2);
                  il.Emit(OpCodes.Ldarg_S,3);
                  il.Emit(OpCodes.Ldarg_S,4);
                  il.Emit(OpCodes.Ldarg_S,5);
                il.Emit(OpCodes.Newobj, constructor);
                il.Emit(OpCodes.Ret);
                CreateInstance = (Func<T0,T1,T2,T3,T4, TInstance>)dm.CreateDelegate(typeof(Func<T0,T1,T2,T3,T4, TInstance>));
            }

#else
            var isValueType = targetType.IsValueType;
            var klass = targetType.GetClassHandle();
            if (isValueType)
            {
                var p = (delegate*<ref TInstance, T0,T1,T2,T3,T4, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2,t3,t4) =>
                {
                    var t = default(TInstance);
                    p(ref t, t0,t1,t2,t3,t4);
                    return t;
                };
            }
            else
            {
                var p = (delegate*<Il2CppObjectHandle, T0,T1,T2,T3,T4, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2,t3,t4) =>
                {
                    var o = Il2CppApi.il2cpp_object_new(klass);
                    p(o, t0,t1,t2,t3,t4);
                    return Unsafe.As<Il2CppObjectHandle, TInstance>(ref o);
                };
            }
#endif
        }
    }
    public static unsafe class NewCache<TInstance,T0,T1,T2,T3,T4,T5>
    {
        public static readonly Func<T0,T1,T2,T3,T4,T5, TInstance> CreateInstance;
        public static readonly bool HasValidConstructor;

        public static bool TryCreateInstance(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4,T5 t5, out TInstance instance)
        {
            if (HasValidConstructor)
            {
                instance = CreateInstance(t0,t1,t2,t3,t4,t5);
                return true;
            }

            instance = default;
            return false;
        }

        static NewCache()
        {
            var targetType = typeof(TInstance);

            ConstructorInfo constructor;
            lock (TypeArrayCache.TypeArray6)
            {
                var paramTypes = TypeArrayCache.TypeArray6;
                    paramTypes[0] = typeof(T0);
                    paramTypes[1] = typeof(T1);
                    paramTypes[2] = typeof(T2);
                    paramTypes[3] = typeof(T3);
                    paramTypes[4] = typeof(T4);
                    paramTypes[5] = typeof(T5);
                 constructor = targetType.GetConstructor(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, paramTypes,
                    null);
            }

            HasValidConstructor = true;

#if Mono
            lock (TypeArrayCache.TypeArray7)
            {
                var paramTypes = TypeArrayCache.TypeArray7;
                paramTypes[0] = typeof(object);
                    paramTypes[1] = typeof(T0);
                    paramTypes[2] = typeof(T1);
                    paramTypes[3] = typeof(T2);
                    paramTypes[4] = typeof(T3);
                    paramTypes[5] = typeof(T4);
                    paramTypes[6] = typeof(T5);
                
                var dm =
                    new DynamicMethod("new", typeof(TInstance),paramTypes, restrictedSkipVisibility: true);
                var il = dm.GetILGenerator();
                  il.Emit(OpCodes.Ldarg_S,1);
                  il.Emit(OpCodes.Ldarg_S,2);
                  il.Emit(OpCodes.Ldarg_S,3);
                  il.Emit(OpCodes.Ldarg_S,4);
                  il.Emit(OpCodes.Ldarg_S,5);
                  il.Emit(OpCodes.Ldarg_S,6);
                il.Emit(OpCodes.Newobj, constructor);
                il.Emit(OpCodes.Ret);
                CreateInstance = (Func<T0,T1,T2,T3,T4,T5, TInstance>)dm.CreateDelegate(typeof(Func<T0,T1,T2,T3,T4,T5, TInstance>));
            }

#else
            var isValueType = targetType.IsValueType;
            var klass = targetType.GetClassHandle();
            if (isValueType)
            {
                var p = (delegate*<ref TInstance, T0,T1,T2,T3,T4,T5, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2,t3,t4,t5) =>
                {
                    var t = default(TInstance);
                    p(ref t, t0,t1,t2,t3,t4,t5);
                    return t;
                };
            }
            else
            {
                var p = (delegate*<Il2CppObjectHandle, T0,T1,T2,T3,T4,T5, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2,t3,t4,t5) =>
                {
                    var o = Il2CppApi.il2cpp_object_new(klass);
                    p(o, t0,t1,t2,t3,t4,t5);
                    return Unsafe.As<Il2CppObjectHandle, TInstance>(ref o);
                };
            }
#endif
        }
    }
    public static unsafe class NewCache<TInstance,T0,T1,T2,T3,T4,T5,T6>
    {
        public static readonly Func<T0,T1,T2,T3,T4,T5,T6, TInstance> CreateInstance;
        public static readonly bool HasValidConstructor;

        public static bool TryCreateInstance(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4,T5 t5,T6 t6, out TInstance instance)
        {
            if (HasValidConstructor)
            {
                instance = CreateInstance(t0,t1,t2,t3,t4,t5,t6);
                return true;
            }

            instance = default;
            return false;
        }

        static NewCache()
        {
            var targetType = typeof(TInstance);

            ConstructorInfo constructor;
            lock (TypeArrayCache.TypeArray7)
            {
                var paramTypes = TypeArrayCache.TypeArray7;
                    paramTypes[0] = typeof(T0);
                    paramTypes[1] = typeof(T1);
                    paramTypes[2] = typeof(T2);
                    paramTypes[3] = typeof(T3);
                    paramTypes[4] = typeof(T4);
                    paramTypes[5] = typeof(T5);
                    paramTypes[6] = typeof(T6);
                 constructor = targetType.GetConstructor(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, paramTypes,
                    null);
            }

            HasValidConstructor = true;

#if Mono
            lock (TypeArrayCache.TypeArray8)
            {
                var paramTypes = TypeArrayCache.TypeArray8;
                paramTypes[0] = typeof(object);
                    paramTypes[1] = typeof(T0);
                    paramTypes[2] = typeof(T1);
                    paramTypes[3] = typeof(T2);
                    paramTypes[4] = typeof(T3);
                    paramTypes[5] = typeof(T4);
                    paramTypes[6] = typeof(T5);
                    paramTypes[7] = typeof(T6);
                
                var dm =
                    new DynamicMethod("new", typeof(TInstance),paramTypes, restrictedSkipVisibility: true);
                var il = dm.GetILGenerator();
                  il.Emit(OpCodes.Ldarg_S,1);
                  il.Emit(OpCodes.Ldarg_S,2);
                  il.Emit(OpCodes.Ldarg_S,3);
                  il.Emit(OpCodes.Ldarg_S,4);
                  il.Emit(OpCodes.Ldarg_S,5);
                  il.Emit(OpCodes.Ldarg_S,6);
                  il.Emit(OpCodes.Ldarg_S,7);
                il.Emit(OpCodes.Newobj, constructor);
                il.Emit(OpCodes.Ret);
                CreateInstance = (Func<T0,T1,T2,T3,T4,T5,T6, TInstance>)dm.CreateDelegate(typeof(Func<T0,T1,T2,T3,T4,T5,T6, TInstance>));
            }

#else
            var isValueType = targetType.IsValueType;
            var klass = targetType.GetClassHandle();
            if (isValueType)
            {
                var p = (delegate*<ref TInstance, T0,T1,T2,T3,T4,T5,T6, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2,t3,t4,t5,t6) =>
                {
                    var t = default(TInstance);
                    p(ref t, t0,t1,t2,t3,t4,t5,t6);
                    return t;
                };
            }
            else
            {
                var p = (delegate*<Il2CppObjectHandle, T0,T1,T2,T3,T4,T5,T6, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2,t3,t4,t5,t6) =>
                {
                    var o = Il2CppApi.il2cpp_object_new(klass);
                    p(o, t0,t1,t2,t3,t4,t5,t6);
                    return Unsafe.As<Il2CppObjectHandle, TInstance>(ref o);
                };
            }
#endif
        }
    }
    public static unsafe class NewCache<TInstance,T0,T1,T2,T3,T4,T5,T6,T7>
    {
        public static readonly Func<T0,T1,T2,T3,T4,T5,T6,T7, TInstance> CreateInstance;
        public static readonly bool HasValidConstructor;

        public static bool TryCreateInstance(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4,T5 t5,T6 t6,T7 t7, out TInstance instance)
        {
            if (HasValidConstructor)
            {
                instance = CreateInstance(t0,t1,t2,t3,t4,t5,t6,t7);
                return true;
            }

            instance = default;
            return false;
        }

        static NewCache()
        {
            var targetType = typeof(TInstance);

            ConstructorInfo constructor;
            lock (TypeArrayCache.TypeArray8)
            {
                var paramTypes = TypeArrayCache.TypeArray8;
                    paramTypes[0] = typeof(T0);
                    paramTypes[1] = typeof(T1);
                    paramTypes[2] = typeof(T2);
                    paramTypes[3] = typeof(T3);
                    paramTypes[4] = typeof(T4);
                    paramTypes[5] = typeof(T5);
                    paramTypes[6] = typeof(T6);
                    paramTypes[7] = typeof(T7);
                 constructor = targetType.GetConstructor(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, paramTypes,
                    null);
            }

            HasValidConstructor = true;

#if Mono
            lock (TypeArrayCache.TypeArray9)
            {
                var paramTypes = TypeArrayCache.TypeArray9;
                paramTypes[0] = typeof(object);
                    paramTypes[1] = typeof(T0);
                    paramTypes[2] = typeof(T1);
                    paramTypes[3] = typeof(T2);
                    paramTypes[4] = typeof(T3);
                    paramTypes[5] = typeof(T4);
                    paramTypes[6] = typeof(T5);
                    paramTypes[7] = typeof(T6);
                    paramTypes[8] = typeof(T7);
                
                var dm =
                    new DynamicMethod("new", typeof(TInstance),paramTypes, restrictedSkipVisibility: true);
                var il = dm.GetILGenerator();
                  il.Emit(OpCodes.Ldarg_S,1);
                  il.Emit(OpCodes.Ldarg_S,2);
                  il.Emit(OpCodes.Ldarg_S,3);
                  il.Emit(OpCodes.Ldarg_S,4);
                  il.Emit(OpCodes.Ldarg_S,5);
                  il.Emit(OpCodes.Ldarg_S,6);
                  il.Emit(OpCodes.Ldarg_S,7);
                  il.Emit(OpCodes.Ldarg_S,8);
                il.Emit(OpCodes.Newobj, constructor);
                il.Emit(OpCodes.Ret);
                CreateInstance = (Func<T0,T1,T2,T3,T4,T5,T6,T7, TInstance>)dm.CreateDelegate(typeof(Func<T0,T1,T2,T3,T4,T5,T6,T7, TInstance>));
            }

#else
            var isValueType = targetType.IsValueType;
            var klass = targetType.GetClassHandle();
            if (isValueType)
            {
                var p = (delegate*<ref TInstance, T0,T1,T2,T3,T4,T5,T6,T7, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2,t3,t4,t5,t6,t7) =>
                {
                    var t = default(TInstance);
                    p(ref t, t0,t1,t2,t3,t4,t5,t6,t7);
                    return t;
                };
            }
            else
            {
                var p = (delegate*<Il2CppObjectHandle, T0,T1,T2,T3,T4,T5,T6,T7, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2,t3,t4,t5,t6,t7) =>
                {
                    var o = Il2CppApi.il2cpp_object_new(klass);
                    p(o, t0,t1,t2,t3,t4,t5,t6,t7);
                    return Unsafe.As<Il2CppObjectHandle, TInstance>(ref o);
                };
            }
#endif
        }
    }
    public static unsafe class NewCache<TInstance,T0,T1,T2,T3,T4,T5,T6,T7,T8>
    {
        public static readonly Func<T0,T1,T2,T3,T4,T5,T6,T7,T8, TInstance> CreateInstance;
        public static readonly bool HasValidConstructor;

        public static bool TryCreateInstance(T0 t0,T1 t1,T2 t2,T3 t3,T4 t4,T5 t5,T6 t6,T7 t7,T8 t8, out TInstance instance)
        {
            if (HasValidConstructor)
            {
                instance = CreateInstance(t0,t1,t2,t3,t4,t5,t6,t7,t8);
                return true;
            }

            instance = default;
            return false;
        }

        static NewCache()
        {
            var targetType = typeof(TInstance);

            ConstructorInfo constructor;
            lock (TypeArrayCache.TypeArray9)
            {
                var paramTypes = TypeArrayCache.TypeArray9;
                    paramTypes[0] = typeof(T0);
                    paramTypes[1] = typeof(T1);
                    paramTypes[2] = typeof(T2);
                    paramTypes[3] = typeof(T3);
                    paramTypes[4] = typeof(T4);
                    paramTypes[5] = typeof(T5);
                    paramTypes[6] = typeof(T6);
                    paramTypes[7] = typeof(T7);
                    paramTypes[8] = typeof(T8);
                 constructor = targetType.GetConstructor(
                    BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, paramTypes,
                    null);
            }

            HasValidConstructor = true;

#if Mono
            lock (TypeArrayCache.TypeArray10)
            {
                var paramTypes = TypeArrayCache.TypeArray10;
                paramTypes[0] = typeof(object);
                    paramTypes[1] = typeof(T0);
                    paramTypes[2] = typeof(T1);
                    paramTypes[3] = typeof(T2);
                    paramTypes[4] = typeof(T3);
                    paramTypes[5] = typeof(T4);
                    paramTypes[6] = typeof(T5);
                    paramTypes[7] = typeof(T6);
                    paramTypes[8] = typeof(T7);
                    paramTypes[9] = typeof(T8);
                
                var dm =
                    new DynamicMethod("new", typeof(TInstance),paramTypes, restrictedSkipVisibility: true);
                var il = dm.GetILGenerator();
                  il.Emit(OpCodes.Ldarg_S,1);
                  il.Emit(OpCodes.Ldarg_S,2);
                  il.Emit(OpCodes.Ldarg_S,3);
                  il.Emit(OpCodes.Ldarg_S,4);
                  il.Emit(OpCodes.Ldarg_S,5);
                  il.Emit(OpCodes.Ldarg_S,6);
                  il.Emit(OpCodes.Ldarg_S,7);
                  il.Emit(OpCodes.Ldarg_S,8);
                  il.Emit(OpCodes.Ldarg_S,9);
                il.Emit(OpCodes.Newobj, constructor);
                il.Emit(OpCodes.Ret);
                CreateInstance = (Func<T0,T1,T2,T3,T4,T5,T6,T7,T8, TInstance>)dm.CreateDelegate(typeof(Func<T0,T1,T2,T3,T4,T5,T6,T7,T8, TInstance>));
            }

#else
            var isValueType = targetType.IsValueType;
            var klass = targetType.GetClassHandle();
            if (isValueType)
            {
                var p = (delegate*<ref TInstance, T0,T1,T2,T3,T4,T5,T6,T7,T8, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2,t3,t4,t5,t6,t7,t8) =>
                {
                    var t = default(TInstance);
                    p(ref t, t0,t1,t2,t3,t4,t5,t6,t7,t8);
                    return t;
                };
            }
            else
            {
                var p = (delegate*<Il2CppObjectHandle, T0,T1,T2,T3,T4,T5,T6,T7,T8, void>)constructor.MethodHandle.Value;
                CreateInstance = (t0,t1,t2,t3,t4,t5,t6,t7,t8) =>
                {
                    var o = Il2CppApi.il2cpp_object_new(klass);
                    p(o, t0,t1,t2,t3,t4,t5,t6,t7,t8);
                    return Unsafe.As<Il2CppObjectHandle, TInstance>(ref o);
                };
            }
#endif
        }
    }
}