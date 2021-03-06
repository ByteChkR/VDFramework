﻿namespace VDFramework.Singleton
{
	using Utility;
	using Exceptions;

	/// <summary>
	/// A abstract generic implementation of the singleton pattern
	/// </summary>
	/// <typeparam name="T">The type to create a singleton of</typeparam>
	public abstract class Singleton<T>
		where T : Singleton<T>, new()
	{
		protected Singleton()
		{
			if (!IsInitialized)
			{
				Instance = this as T;
			}
			else
			{
				throw new SingletonViolationException();
			}
		}

		~Singleton()
		{
			if (instance == this)
			{
				instance = null;
			}
		}

		private static T instance;

		public static T Instance
		{
			get
			{
				// ReSharper disable once ConvertIfStatementToNullCoalescingExpression
				if (instance == null)
				{
					instance = InstanceCreator<T>.CreateInstance();
				}

				return instance;
			}
			set => instance = value;
		}

		public static T InstanceIfInitialized => IsInitialized ? instance : null;

		public static bool IsInitialized => instance != null;

		/// <summary>
		/// Sets the instance of the singleton to null.
		/// </summary>
		public void DestroyInstance()
		{
			instance = null;
		}
	}
}