using System;
using BenchmarkDotNet.Attributes; 
using BenchmarkDotNet.Running;

namespace Algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }

        public class BechmarkClass
        {
            public class PointClass
            {
                public int X; public int Y;
            }

            public struct PointStruct
            {
                public int X; public int Y;
            }

            public Random rnd;

            public PointClass pc1;
            public PointClass pc2;

            public PointStruct ps1;
            public PointStruct ps2;

            public BechmarkClass()
            {
                // start data
                this.rnd = new Random();
                // 1
                PointClass pc1 = new PointClass() { X = rnd.Next(1, 100), Y = rnd.Next(1, 100) };
                PointClass pc2 = new PointClass() { X = rnd.Next(1, 100), Y = rnd.Next(1, 100) };

                // 2
                PointStruct ps1 = new PointStruct() { X = rnd.Next(1, 100), Y = rnd.Next(1, 100) };
                PointStruct ps2 = new PointStruct() { X = rnd.Next(1, 100), Y = rnd.Next(1, 100) };

            }

            // 1
            [Benchmark]
            public void RunPointClassDistance()
            {
                PointDistance(pc1, pc2);
            }

            // 2
            [Benchmark]
            public void RunPointStrDistance()
            {
                PointDistance(ps1, ps2);
            }

            // 3
            [Benchmark]
            public void RunPointClassDistanceD()
            {
                PointDistanceD(ps1, ps2);
            }

            // 4
            [Benchmark]
            public void RunPointDistanceShort()
            {
                PointDistanceShort(ps1, ps2);
            }


            public float PointDistance(PointClass pointOne, PointClass pointTwo)
            {
                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return MathF.Sqrt((x * x) + (y * y));
            }

            public float PointDistance(PointStruct pointOne, PointStruct pointTwo)
            {
                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return MathF.Sqrt((x * x) + (y * y));
            }

            public double PointDistanceD(PointStruct pointOne, PointStruct pointTwo)
            {
                double x = pointOne.X - pointTwo.X;
                double y = pointOne.Y - pointTwo.Y;
                return Math.Sqrt((x * x) + (y * y));
            }

            public float PointDistanceShort(PointStruct pointOne, PointStruct pointTwo)
            {
                float x = pointOne.X - pointTwo.X;
                float y = pointOne.Y - pointTwo.Y;
                return (x * x) + (y * y);
            }
        }
    }
}
