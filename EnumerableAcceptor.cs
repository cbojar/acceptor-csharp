using System;
using System.Collections.Generic;

namespace CBojar.Acceptors
{
	public class EnumerableAcceptor<T> : IAcceptor<T>
	{
		protected IEnumerable<T> _value;

		public EnumerableAcceptor(IEnumerable<T> value) {
			_value = value;
		}

		public IAcceptor<T> Accept(Action<T> visitor) {
			foreach(T member in _value) {
				new Acceptor<T>(member).Accept(visitor);
			}
			return this;
		}

		public IAcceptor<T> Accept<U>(Action<U> visitor) where U : T {
			foreach(T member in _value) {
				new Acceptor<T>(member).Accept(visitor);
			}
			return this;
		}

		public IAcceptor<T> Accept<U, V>(Action<V> visitor) where U : T, V {
			foreach(T member in _value) {
				new Acceptor<T>(member).Accept<U, V>(visitor);
			}
			return this;
		}
	}
}