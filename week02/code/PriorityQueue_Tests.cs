using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue for items with different priorities, where the highest priority item was added last.
    // Expected Result: Jill.
    // Defect(s) Found: The item dequeued was Alice instead of Jill. The for loop in the Dequeue method used the
    // condition index < _queue.Count - 1, which made the loop skip the last item in the queue, Jill, so her priority
    // was never compared. The solution was to remove the "- 1" and use index < _queue.Count
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Alice", 3);
        priorityQueue.Enqueue("Henrique", 2);
        priorityQueue.Enqueue("Jill", 4);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Jill", result);
    }

    [TestMethod]
    // Scenario: Enqueue for items with equals priority, where the highest priority was added in Henrique and Jill.
    // Expected Result: "Henrique"
    // Defect(s) Found: The item dequeued was Jill instead of Henrique. The if condition in the Dequeue method used >= which
    // mean that an item with equal priority to the winner replaced it, so that last tied item won instead of the first one. 
    // The solution was to change >= to only >, so that an item replaces the winner only if its priority is higher.
    // 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Alice", 3);
        priorityQueue.Enqueue("Henrique", 4);
        priorityQueue.Enqueue("Jill", 4);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Henrique", result);
    }

    // Add more test cases as needed below.
}