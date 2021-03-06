﻿

using System.IO;
using Windows.Storage.Streams;

namespace System.Runtime.InteropServices.WindowsRuntime
{
	public static class WindowsRuntimeBufferExtensions
	{
		[Uno.NotImplemented]
		public static IBuffer AsBuffer(this byte[] source){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static IBuffer AsBuffer(this byte[] source, int offset, int length){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static IBuffer AsBuffer(this byte[] source, int offset, int length, int capacity){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static Stream AsStream(this IBuffer source){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static void CopyTo(this byte[] source, IBuffer destination){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static void CopyTo(this IBuffer source, byte[] destination){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static void CopyTo(this IBuffer source, IBuffer destination){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static void CopyTo(this byte[] source, int sourceIndex, IBuffer destination, uint destinationIndex, int count){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static void CopyTo(this IBuffer source, uint sourceIndex, byte[] destination, int destinationIndex, int count){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static void CopyTo(this IBuffer source, uint sourceIndex, IBuffer destination, uint destinationIndex, uint count){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static byte GetByte(this IBuffer source, uint byteOffset){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static IBuffer GetWindowsRuntimeBuffer(this MemoryStream underlyingStream){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static IBuffer GetWindowsRuntimeBuffer(this MemoryStream underlyingStream, int positionInStream, int length){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static bool IsSameData(this IBuffer buffer, IBuffer otherBuffer){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static byte[] ToArray(this IBuffer source){ throw new NotImplementedException(); }
		[Uno.NotImplemented]
		public static byte[] ToArray(this IBuffer source, uint sourceIndex, int count){ throw new NotImplementedException(); }
	}
}