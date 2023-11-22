// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Car Maruti= new Car(new SuzukiEngine(new Cylinder(new Piston(),new CrankShaft(new Transmittor()))));

Car Toyota = new Car(new ToyotaENgine());
class Car {
    public Car( IEngineVendor suzuki)
    {
            
    }

}
interface IEngineVendor { }
class SuzukiEngine:IEngineVendor
{
    public SuzukiEngine()
    {
        
    }
    public SuzukiEngine(Cylinder cylinder)
    {
        
    }
}

class ToyotaENgine:IEngineVendor{ } 

class Piston { 


}

class Cylinder {
    public Cylinder(Piston piston, CrankShaft shaft)
    {
           
    }
}

class Transmittor { }
class CrankShaft {
    public CrankShaft( Transmittor transmittor)
    {
        
    }
}