using LearningApp.Lesson8.Shopping;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningApp
{
    class Program8
    {
        static void Main8()
        {
            //SOLOLEARN
            //klases i folderius rusiuojamos pagal tipa ar funkcionaluma
            //klase - brezinys sukurti objekta. pvz brezinys sukurt masina.
            //so pavadinimas - "car", bet ne "bmw" arba "audi"
            //viena faila kursim vienai klasei, pavadinimas sutampa su klases pavadinimu

            //labiau tiktu sandeliui/konteineriui 
            //VEIKSMAS O NE INFO VEIKSMAS O NE INFO VEIKSMAS O NE INFO

            //buy/order/pay/etc
            //f-jos - kaip veiksmai, ne kaip daiktai
            //klasiu pavadinimai vienaskaita
            //string[] AllGoods; //labiau tiktu sandeliui/konteineriui 
            //VEIKSMAS O NE INFO VEIKSMAS O NE INFO VEIKSMAS O NE INFO

            //visi klases nariai privalo turet access specifier. viso yra 6
            //private/public - 2 is 6
            //nenurodzius - private

            //kintamieji kai objekto -> is didziosios, nebent private - tada is mazosios

            //objekto sukurimas ir "iskvietimas"

            Client testClient = new Client("Jon", new DateTime(2020, 09, 01), true);
            Client testClient2 = new Client("NotJon", new DateTime(2020, 09, 01), false);



            Delivery testDelivery1 = new Delivery("Kaunas", true);

            Good testGood = new Good(75, true);

            Price testPrice = new Price();

            Console.WriteLine(testPrice);
            Console.WriteLine(testClient.IsRegistered);

            testClient.IsReturningClient();

            Console.WriteLine(testClient.GetHashCode());
            Console.WriteLine(testClient.ToString());
            Console.WriteLine(testClient.IsRegistered);
            Console.WriteLine(testClient.DateOfBirth);

            testClient.DateOfBirth = new DateTime(2019, 12, 12);
            Console.WriteLine(testClient.DateOfBirth);

            testClient.IsRegistered = false;
            Console.WriteLine(testClient.IsRegistered);

            Console.WriteLine("name is " + testClient.FullName);
            testClient.FullName = "Jon Snow";
            Console.WriteLine("now name is " + testClient.FullName);

            //enkapsuliacija?

            //naudojam objekta per "." ir tokiu budu galim prieit public kintamuosius ir f-jas
            //privačių - ne

            //turns out visi kintamieji objektuose kuriami private
            //reiskia - enkapsuliuojami
            //kad belekas ju neikeistu
            //tada duomenys keiciami naudojant public f-jas, nors nepatogu
            //sita isspres "properties"

        }






    }
}
