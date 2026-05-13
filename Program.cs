//event handling of message queue

using System;
public class MessageQueue
{
    public event Action ProcessCompleted;

protected void  OnProcessCompleted()
{
    ProcessCompleted?.Invoke();

}
}
class Program
{
  public static void Message()
    {
        Console.WriteLine("Message Processed");
    }
         static void Main(string[] args)
        {
           Process p = new Process();
              p.ProcessCompleted += Message;
    p.StartProcess();
  }
}