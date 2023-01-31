using Microsoft.VisualStudio.TestTools.UnitTesting;
using Source;

namespace Source.Tests;

[TestClass]
public class T0008
{
    [TestMethod]
    [DataRow("  42", 42)]
    public void TestMethod1(string input0, int expected)
    {
        int res = N0008StringToInteger.MyAtoi(input0);
        Assert.AreEqual(res, expected);
    }

    [TestMethod]
    [DataRow("-4212re", -4212)]
    public void TestMethod2(string input0, int expected)
    {
        int res = N0008StringToInteger.MyAtoi(input0);
        Assert.AreEqual(res, expected);
    }

    [TestMethod]
    [DataRow("  323323323323323re", Int32.MaxValue)]
    public void TestMethod3(string input0, int expected)
    {
        int res = N0008StringToInteger.MyAtoi(input0);
        Assert.AreEqual(res, expected);
    }

}