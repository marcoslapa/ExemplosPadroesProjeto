using Decorator.MonstrosDecorator;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            MonstroRPG monstro = new MonstroRPG();
            MinotauroDecorator mino = new MinotauroDecorator();
            DragaoDecorator dragtauro = new DragaoDecorator();
            LeaoDecorator leaomino = new LeaoDecorator();

            mino.MonstroComp = monstro;
            Console.WriteLine("=====================================");
            Console.WriteLine("Atacando como Minotauro:");
            mino.Atacar();

            dragtauro.MonstroComp = mino;
            Console.WriteLine("=====================================");
            Console.WriteLine("Atacando como Dragao-Minotauro:");
            dragtauro.Atacar();

            leaomino.MonstroComp = mino;
            Console.WriteLine("=====================================");
            Console.WriteLine("Atacando como Leao-Minotauro:");
            leaomino.Atacar();

            leaomino.MonstroComp = dragtauro;
            Console.WriteLine("=====================================");
            Console.WriteLine("Atacando como Leao-Dragao-Minotauro:");
            leaomino.Atacar();
        }
    }
}
