using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;


        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                //task 1

                IndestructibleBlock ceilingBlock = new IndestructibleBlock(new MatrixCoords(startRow-1 , i));
                IndestructibleBlock leftSideBlock = new IndestructibleBlock(new MatrixCoords(i, startCol-1));
                IndestructibleBlock rightSideBlock = new IndestructibleBlock(new MatrixCoords(i , endCol));

                engine.AddObject(ceilingBlock);
                engine.AddObject(leftSideBlock);
                engine.AddObject(rightSideBlock);
                engine.AddObject(currBlock);
               
            }
            //task 5
            TrailObject trailBlock = new TrailObject(new MatrixCoords(WorldRows/2, WorldCols/2), new char[,] {{'&'}}, 30);

            engine.AddObject(trailBlock);

            //task 6
            //MeteoriteBall mBall = new MeteoriteBall(new MatrixCoords(10, 10), new MatrixCoords(1, 1), 3);
            //engine.AddObject(mBall);

            // Task9 Test UnstoppableBall
            //Ball theUnstopableBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0), new MatrixCoords(-1, 1));
            //engine.AddObject(theUnstopableBall);

            //for (int i = 2; i < WorldCols/2; i+=4)
            //{
            //    engine.AddObject(new UnpassableBlock(new MatrixCoords(4, i)));
            //}

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            //Engine gameEngine = new Engine(renderer, keyboard,200);
            EngineForShootingRocket gameEngine = new EngineForShootingRocket(renderer, keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };
            //Task13
            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };
        

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
