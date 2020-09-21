using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(@"Bem vindo ao Text Heroes!!!
Escolha:
1 - Humanos
2 - Necromancers");
            string op = Console.ReadLine();
            CharacterClassFactoryAb factory;
            if (op == "1")
                factory = new HumanFactory();
            else
                factory = new NecromancerFactory();

            PersonagemSimples ps = factory.CriarSimples();
            PersonagemSimplesAtirador psa = factory.CriarSimplesAtirador();

            ps.Bater();
            psa.Atirar();
            Console.ReadKey();                        
        }
    }
}
