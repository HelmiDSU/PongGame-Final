using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    public class GameData : IEnumerable<GameDataEntry>
    {
        private List<GameDataEntry> entries;

        public GameData()
        {
            entries = new List<GameDataEntry>();
        }

        public void AddEntry(GameDataEntry entry)
        {
            entries.Add(entry);
        }

        public void Clear()
        {
            entries.Clear();
        }

        public IEnumerator<GameDataEntry> GetEnumerator()
        {
            return entries.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void LogPositions(int ballX, int ballY, int paddle1Y, int paddle2Y)
        {
            entries.Add(new GameDataEntry(ballX, ballY, paddle1Y, paddle2Y, DateTime.Now));
        }

    }

    public class GameDataEntry
    {
        public int BallX { get; set; }
        public int BallY { get; set; }
        public int Paddle1Y { get; set; }
        public int Paddle2Y { get; set; }
        public DateTime Timestamp { get; set; }

        public GameDataEntry(int ballX, int ballY, int paddle1Y, int paddle2Y, DateTime timestamp)
        {
            BallX = ballX;
            BallY = ballY;
            Paddle1Y = paddle1Y;
            Paddle2Y = paddle2Y;
            Timestamp = timestamp;
        }


    }



}
