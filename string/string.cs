using System;

class TestString {
	static void Main() {
		string s = "Test";
		string t = string.Copy(s);

		Console.WriteLine(s == t);
		Console.WriteLine((object) s == (object) t);
	}
}