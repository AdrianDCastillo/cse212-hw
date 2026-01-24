using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities (Low: 1, Mid: 5, High: 10) to the queue.
    // The "High" priority item is added last to verify the loop checks the entire queue.
    // Expected Result: Items should be dequeued in order of priority: High, Mid, Low.
    // Defect(s) Found: 
    // 1. The loop in Dequeue was skipping the last item in the queue (index < _queue.Count - 1).
    // 2. The Dequeue method was not removing the item from the queue, causing the same item to be returned repeatedly.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Mid", 5);
        priorityQueue.Enqueue("High", 10);

        Assert.AreEqual("High", priorityQueue.Dequeue());
        Assert.AreEqual("Mid", priorityQueue.Dequeue());
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with the same priority to the queue.
    // Expected Result: Items with the same priority should be dequeued in FIFO order (First In, First Out).
    // Defect(s) Found: 
    // 1. The comparison operator in Dequeue was >= instead of >, causing the queue to behave as LIFO for same-priority items.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 2);
        priorityQueue.Enqueue("Item2", 2);
        priorityQueue.Enqueue("Item3", 2);

        Assert.AreEqual("Item1", priorityQueue.Dequeue());
        Assert.AreEqual("Item2", priorityQueue.Dequeue());
        Assert.AreEqual("Item3", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: An InvalidOperationException should be thrown with the message "The queue is empty."
    // Defect(s) Found: None.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}