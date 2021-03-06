/**************************************************************************** 
 * Copyright 2012 David Lurton
 * This Source Code Form is subject to the terms of the Mozilla Public 
 * License, v. 2.0. If a copy of the MPL was not distributed with this file, 
 * You can obtain one at http://mozilla.org/MPL/2.0/.
 ****************************************************************************/

using System;
using System.Collections.Generic;
using System.Threading;
using Happy.ScriptEngine.Compiler;

namespace Happy.ScriptEngine
{
	public static class Util
	{
		public static string Format(string fmt, params object[] args)
		{
			return String.Format(Thread.CurrentThread.CurrentCulture,
				fmt, args);
		}
		public static int ParseInt32(string parseMe)
		{
			return Int32.Parse(parseMe, Thread.CurrentThread.CurrentCulture);
		}

		public static bool IsNullOrEmpty(Array array)
		{
			return array == null || array.Length == 0;
		}

		public static IEnumerable<T> EnumerateBetween<T>(IEnumerable<T> enumerable, Action between)
		{
			IEnumerator<T> enumerator = enumerable.GetEnumerator();
			while (enumerator.MoveNext())
			{
				between();
				yield return enumerator.Current;
			}
		}

		public static T CastAssert<T>(object input)
		{
			DebugAssert.IsInstanceOfType(typeof(T), input);
			return (T) input;
		}

		public static void ForAll<T>(this IEnumerable<T> items, Action<T> d)
		{
			foreach(T i in items)
				d(i);
		}

		public static void ForAllBetween<T>(this IEnumerable<T> items, Action<T> d, Action b)
		{
			IEnumerator<T> enumerator = items.GetEnumerator();
			if(enumerator.MoveNext())
			{
				d(enumerator.Current);
				while (enumerator.MoveNext()) 
				{
					b();
					d(enumerator.Current);
				}
			}
		}
	}
}

