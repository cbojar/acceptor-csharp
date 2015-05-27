# Acceptor (in C#)

This is a generic, universal implementation of the Visitor Pattern. It can
extend the visitor pattern to any object or collection of objects. Internally,
it checks the type of the wrapped object against the desired type, and calls the
visitor if the internal object can be cast to the desired type.
