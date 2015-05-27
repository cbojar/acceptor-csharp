using System;

namespace CBojar.Acceptors
{
	public class Acceptor<T> : IAcceptor<T>
	{
		protected T _value;

		public Acceptor(T value) {
			_value = value;
		}

		public IAcceptor<T> Accept(Action<T> visitor) {
			visitor(_value);
			return this;
		}

		public IAcceptor<T> Accept<U>(Action<U> visitor) where U : T {
			if(IsMyType(typeof(U))) {
				visitor((U)_value);
			}
			return this;
		}

		public IAcceptor<T> Accept<U, V>(Action<V> visitor) where U : T, V {
			if(IsMyType(typeof(U))) {
				visitor((U)_value);
			}
			return this;
		}

		private bool IsMyType(System.Type type) {
			if(_value == null) {
				return false;
			}
			var myType = _value.GetType();
			return myType.Equals(type) || myType.IsSubclassOf(type);
		}
	}
}