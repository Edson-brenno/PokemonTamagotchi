using System;

namespace PokeTamagotchiGame.Controller{

    public class AlreadyHabeOnePetException : Exception{
        
        public void AlreadyHabeOnePetException(){
            
            System.Console.WriteLine("Você já possui um mascote!");
        }
    }   
}