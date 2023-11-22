namespace FirstApi.Models
{

    public class Car {
        private IEngine _engine;
        private IAccessories _accessories;
        public Car(IEngine e,IAccessories a)
        {

            _engine = e;
            _accessories = a;
        }
    }
    public interface IEngine { }
    public class SuzukiEngine:IEngine { }
    public class ToyotaEngine : IEngine { }

    public interface IAccessories { }
    public class CarAccessories : IAccessories { }
}
