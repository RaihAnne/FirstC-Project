using System.Dynamic;
using System.Xml.XPath;

namespace RyanSpace{
    public class Adder{
        public int Result {get; private set;}
        public int AddendA {get; private set;}
        public int AddendB {get; private set;}


        public Adder(int a, int b){
            AddendA = a;
            AddendB = b;
            Result = a+b;
        }
    }
}
