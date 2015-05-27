using System;

namespace CBojar.Acceptors
{
	public interface IAcceptor<T>
	{
		IAcceptor<T> Accept(Action<T> visitor);
		IAcceptor<T> Accept<U>(Action<U> visitor) where U : T;
		IAcceptor<T> Accept<U, V>(Action<V> visitor) where U : T, V;
	}
}