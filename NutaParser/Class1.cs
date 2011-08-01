// возможно убрать state.Deep
// in и out в типах

using System.Collections.Generic;

public struct A<T>
{
	public class B { }
}

public class Class1
{
	A<int>.B a;
	public A<bool?>?[] A;
	public
	HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<
	int
	>>>>>>>>>>
	b;
}
