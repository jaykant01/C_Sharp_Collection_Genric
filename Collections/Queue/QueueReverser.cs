namespace Collections;

public class QueueReverser
{
    public Queue<int> ReverseQueue(Queue<int> queue)
    {
       
        if (queue.Count == 0)
            return queue;

        int front = queue.Dequeue();

        queue = ReverseQueue(queue);

        queue.Enqueue(front);

        return queue;
    }
}
