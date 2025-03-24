using System;
namespace RyanSpace{
    public static class GetIntConsole{
        public static bool TryGetIntFromConsole(out int result){
            result = 0;

            string? userInput = Console.ReadLine();

            if(string.IsNullOrEmpty(userInput)){
                return false;
            }

            if(int.TryParse(userInput, out result) == false){
                return false;
            }

            return true;
        }
    }
}