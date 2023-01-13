namespace DebugBug.Test;

[TestClass]
public class UnitTest1 {
	[TestMethod]
	public void TestDoStuff() {
		var result = MyClass.DoStuff();
		Assert.AreEqual(1, result);
	}
}