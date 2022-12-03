namespace Source.Tests;

[TestClass]
public class T0001
{
    [TestMethod]
    [DataRow(new int[] { 1, 4, 3, 2 }, 6, new int[] { 1, 3 })]
    public void TestMethod1(int[] input0, int input1, int[] expected)
    {
        int[] res = N0001TwoSum.TwoSum(input0, input1);
        Assert.AreEqual(2, res.Length);

        if (res[0] > res[1])
        {
            Assert.AreEqual(expected[0], res[1]);
            Assert.AreEqual(expected[1], res[0]);
        }
        else
        {
            Assert.AreEqual(expected[0], res[0]);
            Assert.AreEqual(expected[1], res[1]);
        }
    }
}
