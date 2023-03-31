using System;

namespace Overriding
{

    class ArmorSuite
    {
        public virtual void Initialize()  // 재정의 가능하게 virtual 을 언급했다.
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();  // 이부분을 작성하지 않으면 기반클래스의 console 이 사라진다. 
            Console.WriteLine("Repulsor Rays Armed");
        }
    }


    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Creating ArmorSuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            Console.WriteLine("\n Creating IronMan...");
            ArmorSuite ironman = new IronMan();  // ArmorSuite 를 상속받았기 때문에 간능하다
                                                 // 다형성의 특성이다.
                                                 // 부모자식간에 연결이 되어 있기 때문에 . 
            ironman.Initialize();

            Console.WriteLine("\n Creating WarMachine");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();


        }
    }
}
