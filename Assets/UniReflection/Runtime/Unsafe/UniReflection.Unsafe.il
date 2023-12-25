
// Metadata version: v4.0.30319
.assembly extern netstandard
{
  .publickeytoken = (CC 7B 13 FF CD 2D DD 51 )                         // .{...-.Q
  .ver 2:1:0:0
}
.assembly UniReflection.Unsafe
{
   .custom instance void [netstandard]System.Runtime.CompilerServices.ExtensionAttribute::.ctor() = ( 01 00 00 00 )
  .custom instance void [netstandard]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 )
  .custom instance void [netstandard]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  .hash algorithm 0x00008004
  .ver 4:0:6:0
}
.module UniReflection.Unsafe.dll
// MVID: {9AF8BDDC-406F-4A74-9F37-09AF6F151255}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000009    //  ILONLY
// Image base: 0x05010000


// =============== CLASS MEMBERS DECLARATION ===================

.class public abstract auto ansi sealed beforefieldinit UniReflection.Unsafe
       extends [netstandard]System.Object
{

    .method public hidebysig static 
        void SkipInit<T> (
            [out] !!T& 'value'
        ) cil managed aggressiveinlining 
    {
        // Method begins at RVA 0x2050
        // Code size 8 (0x8)
         // Code size 1 (0x1)
        .maxstack 1

        IL_0000: ret
    } // end of method Unsafe::SkipInit
    
  .method public hidebysig static !!T  Read<T>(void* source) cil managed aggressiveinlining
  {
    // コード サイズ       7 (0x7)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  ldobj      !!T
    IL_0006:  ret
  } // end of method Unsafe::Read

  .method public hidebysig static !!T  ReadUnaligned<T>(void* source) cil managed aggressiveinlining
  {
    // コード サイズ       10 (0xa)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  unaligned. 1
    IL_0004:  ldobj      !!T
    IL_0009:  ret
  } // end of method Unsafe::ReadUnaligned

  .method public hidebysig static !!T  ReadUnaligned<T>(uint8& source) cil managed aggressiveinlining
  {
    // コード サイズ       10 (0xa)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  unaligned. 1
    IL_0004:  ldobj      !!T
    IL_0009:  ret
  } // end of method Unsafe::ReadUnaligned
  
  .method public hidebysig static void  Write<T>(void* destination,
                                                 !!T 'value') cil managed aggressiveinlining
  {
    // コード サイズ       8 (0x8)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stobj      !!T
    IL_0007:  ret
  } // end of method Unsafe::Write

  .method public hidebysig static void  WriteUnaligned<T>(void* destination,
                                                          !!T 'value') cil managed aggressiveinlining
  {
    // コード サイズ       11 (0xb)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  unaligned. 1
    IL_0005:  stobj      !!T
    IL_000a:  ret
  } // end of method Unsafe::WriteUnaligned

  .method public hidebysig static void  WriteUnaligned<T>(uint8& destination,
                                                          !!T 'value') cil managed aggressiveinlining
  {
    // コード サイズ       11 (0xb)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  unaligned. 1
    IL_0005:  stobj      !!T
    IL_000a:  ret
  } // end of method Unsafe::WriteUnaligned

  .method public hidebysig static void  Copy<T>(void* destination,
                                                !!T& source) cil managed aggressiveinlining
  {
    // コード サイズ       13 (0xd)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldobj      !!T
    IL_0007:  stobj      !!T
    IL_000c:  ret
  } // end of method Unsafe::Copy

  .method public hidebysig static void  Copy<T>(!!T& destination,
                                                void* source) cil managed aggressiveinlining
  {
    // コード サイズ       13 (0xd)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldobj      !!T
    IL_0007:  stobj      !!T
    IL_000c:  ret
  } // end of method Unsafe::Copy


  .method public hidebysig static void*  AsPointer<T>(!!T& 'value') cil managed aggressiveinlining
  {
    // コード サイズ       3 (0x3)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  conv.u
    IL_0002:  ret
  } // end of method Unsafe::AsPointer
  .method public hidebysig static void*  AsPointer<T>(valuetype [netstandard]System.Span`1<!!T>& 'value') cil managed aggressiveinlining
  {
    // コード サイズ       3 (0x3)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  conv.u
    IL_0002:  ret
  } // end of method Unsafe::AsPointer
  .method public hidebysig static void*  AsPointer<T>(valuetype [netstandard]System.ReadOnlySpan`1<!!T>& 'value') cil managed aggressiveinlining
  {
    // コード サイズ       3 (0x3)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  conv.u
    IL_0002:  ret
  } // end of method Unsafe::AsPointer
  
  
.method public hidebysig static  void*  AsPointer(object o) cil managed aggressiveinlining
  {
    // コード サイズ       2 (0x2)
    .maxstack  1
    IL_0000:  ldarg.0
   IL_0001:  conv.u
    IL_0002:  ret
  } // end of method Unsafe::AsPointer
  
  .method public hidebysig static valuetype [netstandard]System.Span`1<!!T>&  AsSpanRef<T>(void* source) cil managed aggressiveinlining
  {
    // コード サイズ       4 (0x4)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  ret
  } // end of method Unsafe::AsSpanRef
  .method public hidebysig static valuetype [netstandard]System.ReadOnlySpan`1<!!T>&  AsReadOnlySpanRef<T>(void* source) cil managed aggressiveinlining
  {
    // コード サイズ       4 (0x4)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  ret
  } // end of method Unsafe::AsReadOnlySpanRef
  
  .method public hidebysig static int32  SizeOf<T>() cil managed aggressiveinlining
  {
    // コード サイズ       7 (0x7)
    .maxstack  1
    IL_0000:  sizeof     !!T
    IL_0006:  ret
  } // end of method Unsafe::SizeOf

  .method public hidebysig static void  CopyBlock(void* destination,
                                                  void* source,
                                                  uint32 byteCount) cil managed aggressiveinlining
  {
    // コード サイズ       6 (0x6)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  cpblk
    IL_0005:  ret
  } // end of method Unsafe::CopyBlock

  .method public hidebysig static void  CopyBlock(uint8& destination,
                                                  uint8& source,
                                                  uint32 byteCount) cil managed aggressiveinlining
  {
    // コード サイズ       6 (0x6)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  cpblk
    IL_0005:  ret
  } // end of method Unsafe::CopyBlock

  .method public hidebysig static void  CopyBlockUnaligned(void* destination,
                                                           void* source,
                                                           uint32 byteCount) cil managed aggressiveinlining
  {
    // コード サイズ       9 (0x9)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  unaligned. 1
    IL_0006:  cpblk
    IL_0008:  ret
  } // end of method Unsafe::CopyBlockUnaligned

  .method public hidebysig static void  CopyBlockUnaligned(uint8& destination,
                                                           uint8& source,
                                                           uint32 byteCount) cil managed aggressiveinlining
  {
    // コード サイズ       9 (0x9)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  unaligned. 1
    IL_0006:  cpblk
    IL_0008:  ret
  } // end of method Unsafe::CopyBlockUnaligned

  .method public hidebysig static void  InitBlock(void* startAddress,
                                                  uint8 'value',
                                                  uint32 byteCount) cil managed aggressiveinlining
  {
    // コード サイズ       6 (0x6)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  initblk
    IL_0005:  ret
  } // end of method Unsafe::InitBlock

  .method public hidebysig static void  InitBlock(uint8& startAddress,
                                                  uint8 'value',
                                                  uint32 byteCount) cil managed aggressiveinlining
  {
    // コード サイズ       6 (0x6)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  initblk
    IL_0005:  ret
  } // end of method Unsafe::InitBlock

  .method public hidebysig static void  InitBlockUnaligned(void* startAddress,
                                                           uint8 'value',
                                                           uint32 byteCount) cil managed aggressiveinlining
  {
    // コード サイズ       9 (0x9)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  unaligned. 1
    IL_0006:  initblk
    IL_0008:  ret
  } // end of method Unsafe::InitBlockUnaligned

  .method public hidebysig static void  InitBlockUnaligned(uint8& startAddress,
                                                           uint8 'value',
                                                           uint32 byteCount) cil managed aggressiveinlining
  {
    // コード サイズ       9 (0x9)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ldarg.2
    IL_0003:  unaligned. 1
    IL_0006:  initblk
    IL_0008:  ret
  } // end of method Unsafe::InitBlockUnaligned

  .method public hidebysig static !!T  As<class T>(object o) cil managed aggressiveinlining
  {
    // コード サイズ       2 (0x2)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  ret
  } // end of method Unsafe::As
  .method public hidebysig static !!T&  AsRef<T>(void* source) cil managed aggressiveinlining
  {
    // コード サイズ       4 (0x4)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  ret
  } // end of method Unsafe::AsRef

  .method public hidebysig static !!T&  AsRef<T>(!!T& source) cil managed aggressiveinlining
  {
   .param [1]
            .custom instance void [netstandard]System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = (
                01 00 00 00
            )
    // コード サイズ       2 (0x2)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  ret
  } // end of method Unsafe::AsRef
.method public hidebysig static valuetype [netstandard]System.ReadOnlySpan`1<!!T>&  AsRef<T>(valuetype [netstandard]System.ReadOnlySpan`1<!!T>& source) cil managed aggressiveinlining
  {
   .param [1]
            .custom instance void [netstandard]System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = (
                01 00 00 00
            )
    // コード サイズ       2 (0x2)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  ret
  } // end of method Unsafe::AsRef
  .method public hidebysig static valuetype [netstandard]System.Span`1<!!T>&  AsRef<T>(valuetype [netstandard]System.Span`1<!!T>& source) cil managed aggressiveinlining
  {
   .param [1]
            .custom instance void [netstandard]System.Runtime.CompilerServices.IsReadOnlyAttribute::.ctor() = (
                01 00 00 00
            )
    // コード サイズ       2 (0x2)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  ret
  } // end of method Unsafe::AsRef
  .method public hidebysig static !!TTo&
          As<TFrom,TTo>(!!TFrom& source) cil managed aggressiveinlining
  {
    // コード サイズ       2 (0x2)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  ret
  } // end of method Unsafe::As

  .method public hidebysig static !!T&  Unbox<valuetype .ctor ([netstandard]System.ValueType) T>(object 'box') cil managed aggressiveinlining
  {
    // コード サイズ       7 (0x7)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  unbox      !!T
    IL_0006:  ret
  } // end of method Unsafe::Unbox

  .method public hidebysig static !!T&  Add<T>(!!T& source,
                                               int32 elementOffset) cil managed aggressiveinlining
  {
    // コード サイズ       12 (0xc)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  sizeof     !!T
    IL_0008:  conv.i
    IL_0009:  mul
    IL_000a:  add
    IL_000b:  ret
  } // end of method Unsafe::Add

  .method public hidebysig static void*  Add<T>(void* source,
                                                int32 elementOffset) cil managed aggressiveinlining
  {
    // コード サイズ       12 (0xc)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  sizeof     !!T
    IL_0008:  conv.i
    IL_0009:  mul
    IL_000a:  add
    IL_000b:  ret
  } // end of method Unsafe::Add

  .method public hidebysig static !!T&  Add<T>(!!T& source,
                                               native int elementOffset) cil managed aggressiveinlining
  {
    // コード サイズ       11 (0xb)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  sizeof     !!T
    IL_0008:  mul
    IL_0009:  add
    IL_000a:  ret
  } // end of method Unsafe::Add

  .method public hidebysig static !!T&  AddByteOffset<T>(!!T& source,
                                                         native int byteOffset) cil managed aggressiveinlining
  {
    // コード サイズ       4 (0x4)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  add
    IL_0003:  ret
  } // end of method Unsafe::AddByteOffset

  .method public hidebysig static !!T&  Subtract<T>(!!T& source,
                                                    int32 elementOffset) cil managed aggressiveinlining
  {
    // コード サイズ       12 (0xc)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  sizeof     !!T
    IL_0008:  conv.i
    IL_0009:  mul
    IL_000a:  sub
    IL_000b:  ret
  } // end of method Unsafe::Subtract

  .method public hidebysig static void*  Subtract<T>(void* source,
                                                     int32 elementOffset) cil managed aggressiveinlining
  {
    // コード サイズ       12 (0xc)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  sizeof     !!T
    IL_0008:  conv.i
    IL_0009:  mul
    IL_000a:  sub
    IL_000b:  ret
  } // end of method Unsafe::Subtract

  .method public hidebysig static !!T&  Subtract<T>(!!T& source,
                                                    native int elementOffset) cil managed aggressiveinlining
  {
    // コード サイズ       11 (0xb)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  sizeof     !!T
    IL_0008:  mul
    IL_0009:  sub
    IL_000a:  ret
  } // end of method Unsafe::Subtract

  .method public hidebysig static !!T&  SubtractByteOffset<T>(!!T& source,
                                                              native int byteOffset) cil managed aggressiveinlining
  {
    // コード サイズ       4 (0x4)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  sub
    IL_0003:  ret
  } // end of method Unsafe::SubtractByteOffset

  .method public hidebysig static native int
          ByteOffset<T>(!!T& origin,
                        !!T& target) cil managed aggressiveinlining
  {
    // コード サイズ       4 (0x4)
    .maxstack  2
    IL_0000:  ldarg.1
    IL_0001:  ldarg.0
    IL_0002:  sub
    IL_0003:  ret
  } // end of method Unsafe::ByteOffset

  .method public hidebysig static bool  AreSame<T>(!!T& left,
                                                   !!T& right) cil managed aggressiveinlining
  {
    // コード サイズ       5 (0x5)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  ceq
    IL_0004:  ret
  } // end of method Unsafe::AreSame

  .method public hidebysig static bool  IsAddressGreaterThan<T>(!!T& left,
                                                                !!T& right) cil managed aggressiveinlining
  {
    // コード サイズ       5 (0x5)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  cgt.un
    IL_0004:  ret
  } // end of method Unsafe::IsAddressGreaterThan

  .method public hidebysig static bool  IsAddressLessThan<T>(!!T& left,
                                                             !!T& right) cil managed aggressiveinlining
  {
    // コード サイズ       5 (0x5)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  clt.un
    IL_0004:  ret
  } // end of method Unsafe::IsAddressLessThan
  .method public hidebysig static !!0/*T*/&
    NullRef<T>() cil managed
  {
    .maxstack 8
    IL_0000: ldc.i4.0
    IL_0001: conv.u
    IL_0002: ret

  } // end of method Unsafe::NullRef
  
  .method public hidebysig static bool  IsNullRef<T>(!!T& ptr) cil managed aggressiveinlining
  {
    // コード サイズ       5 (0x5)
    .maxstack  2
    IL_0000:  ldarg.0
    IL_0001:  ldc.i4.0
    IL_0002:  conv.u
    IL_0003:  ceq
    IL_0004:  ret
  } // end of method Unsafe::AreSame
  

} // end of class netstandard.CompilerServices.Unsafe

.class private auto ansi sealed beforefieldinit netstandard.CompilerServices.IsReadOnlyAttribute
       extends [netstandard]System.Attribute
{
  .method public hidebysig specialname rtspecialname
          instance void  .ctor() cil managed
  {
    // コード サイズ       7 (0x7)
    .maxstack  1
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [netstandard]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method IsReadOnlyAttribute::.ctor

} // end of class netstandard.CompilerServices.IsReadOnlyAttribute