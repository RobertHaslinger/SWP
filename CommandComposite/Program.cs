using System;

namespace CommandComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            FerrariFlipperInvoker flipper = new FerrariFlipperInvoker(new PointsReceiver());
            flipper.StartGame();
            while (true)
            {
                Console.WriteLine("Simulate an outcome: What did the ball hit (ramp, target, hole, ferrari, exit)?");
                string outcome = Console.ReadLine();
                
                if (outcome == "exit") break;
                
                flipper.ObstacleHit(outcome);
            }
            flipper.StopGame();
        }
    }
}
