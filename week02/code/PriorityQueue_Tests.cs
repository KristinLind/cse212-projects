using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities
    // Expected Result: Item with highest priority is returned first
    // Defect(s) Found: The loop that searched for the highest priority item did not check the
    // final element in the list because it used "_queue.Count - 1" in the loop condition.
    // This caused the highest priority item to sometimes be skipped.
    public void TestPriorityQueue_HighestPriority()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("Low", 1);
        queue.Enqueue("Medium", 5);
        queue.Enqueue("High", 10);

        var result = queue.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Remove items sequentially
    // Expected Result: Items come out in descending priority order
    // Defect(s) Found: The Dequeue method returned the value but did not remove it from the
    // queue, causing the same item to be returned repeatedly.
    public void TestPriorityQueue_Order()
    {
        var queue = new PriorityQueue();

        queue.Enqueue("A", 2);
        queue.Enqueue("B", 8);
        queue.Enqueue("C", 5);

        Assert.AreEqual("B", queue.Dequeue());
        Assert.AreEqual("C", queue.Dequeue());
        Assert.AreEqual("A", queue.Dequeue());
    }
}
