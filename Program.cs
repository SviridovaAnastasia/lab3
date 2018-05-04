using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Niva niva = new Niva();
            Console.WriteLine("у " + niva.GetName() + " " + niva.GetWeel().ToString() + " колес(а) и масса " + niva.GetMass() + " кг");
            Mersedes mersedes = new Mersedes();
            Console.WriteLine("у " + mersedes.GetName() + " " + mersedes.GetWeel().ToString() + " колес(а) и масса " + mersedes.GetMass() + " кг");
            MersedesSLK mersedesslk = new MersedesSLK();
            Console.WriteLine("у " + mersedesslk.GetName() + " " + mersedesslk.GetWeel().ToString() + " колес(а) и масса " + mersedesslk.GetMass() + " кг");
            Console.ReadLine();
        }
    }
    public interface Mechanism
    {
        string GetName();
    }
    public interface Car : Mechanism
    {
        int GetWeel();

        string GetMass();
    }
    public class Niva : Car
    {
        public string GetName()
        {
            return "нива";
        }
        public int GetWeel()
        {
            return 4;
        }
        public string GetMass()
        {
            return "2000";
        }
    }
    public class Mersedes : Car
    {
        virtual//не знаю что значит
        public string GetName()
        {
            return "мерседес";
        }
        public int GetWeel()
        {
            return 4;
        }
        public string GetMass()
        {
            return "1500";
        }
    }
    public class MersedesSLK : Mersedes{
        override
        public string GetName() {
            return "мерседес SLK";
        }
    }
}
