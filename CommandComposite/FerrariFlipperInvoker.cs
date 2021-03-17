using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using CommandComposite.Commands;

namespace CommandComposite
{
    public class FerrariFlipperInvoker
    {
        private PointsReceiver _pointsReceiver;

        public ICommand OnStart { get; set; }
        public ICommand OnRampHit { get; set; }
        public ICommand OnTargetHit { get; set; }
        public ICommand OnHoleHit { get; set; }
        public ICommand OnMovingFerrariHit { get; set; }
        public ICommand OnGameOver { get; set; }

        public FerrariFlipperInvoker(PointsReceiver pointsReceiver)
        {
            _pointsReceiver = pointsReceiver;
            
            //Default configuration for the flipper
            OnStart = new GreetingCommand();
            OnRampHit = new RampCommand();
            OnTargetHit = new TargetCommand(pointsReceiver);
            OnHoleHit = new HoleCommand(pointsReceiver);
            OnMovingFerrariHit = new MovingFerrariCommand(pointsReceiver);
            OnGameOver = new GameOverCommand(pointsReceiver);
        }

        public void StartGame()
        {
            OnStart?.Execute();
        }

        public void StopGame()
        {
            OnGameOver?.Execute();
        }

        public void ObstacleHit(string obstacle)
        {
            switch (obstacle)
            {
                case "ramp":
                {
                    OnRampHit?.Execute();
                    break;
                }
                case "hole":
                {
                    OnHoleHit?.Execute();
                    break;
                }
                case "target":
                {
                    OnTargetHit?.Execute();
                    break;
                }
                case "ferrari":
                {
                    OnMovingFerrariHit?.Execute();
                    break;
                }
                default:
                {
                    Console.WriteLine("I think the ball did not hit an obstacle at all...");
                    break;
                }
            }
        }
    }
}
