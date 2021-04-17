using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.Lesson8.Shopping
{
    class Client
    {

        public string FullName;
        public DateTime DateOfBirth;
        public bool IsRegistered;

        //konstruktorius. grazinama reiksme sitoj f-joj nerasoma.
        //darbas - sukurti objekta
        //pavadinimas su klases pavadinimu
        //beveik visada buna public
        //konstruktorius dazniausiai duoda pradine reiksme

        public Client(string firstName, DateTime dateOfBirth, bool isRegistered = false) 
        {
            FullName = firstName;
            DateOfBirth = dateOfBirth;
            IsRegistered = isRegistered;
            //jei sutaptu pavadinimai kintamojo firstName cia ir firstName kaip objekto,
            //tai naudot reiktu this.firstName referuojant i objekto firstNAme
        }


        public void Buy()
        {
            
        }

        public void Order() 
        {       

        }

        private void ClientAge() 
        {
            
        }

        public void IsReturningClient() 
        {
            Console.WriteLine("is Returning Client");
        }

    }
}
