// возможно убрать state.Deep
// in и out в типах

using System.Collections.Generic;

public struct A<T>
{
}

public class Class1
{
	public A<bool?>?[] A;
	/*public
	HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<
	HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<HashSet<
	int
	>>>>>>>>>>
	>>>>>>>>>>
	a;*/
}
