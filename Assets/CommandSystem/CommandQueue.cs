using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandQueue
{
    #region Singleton
    // singleton stuff 
    
    private static CommandQueue instance = new CommandQueue();
    public static CommandQueue Instance => instance;
    private CommandQueue() { }

    #endregion

    Queue<Command> queue = new Queue<Command>();

    public void EnqueueCommand(Command command)
    {
        queue.Enqueue(command);
    }

    public void DequeueCommand()
    {
        if (queue.Count > 0)
        {
            var cmd = queue.Dequeue();
            cmd.Execute();
        }
    }
}
