using System;

//Sam Howsden
//IT 112
//Notes: This project ended up being a lot easier than I expected. The only part I was
    //unsure of was the Dial() method, but I'm pretty sure I executed that right
//Behaviors Not Implemented: I implemented every required behavior
namespace Howsden_Dialer
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone[] dialList = new Phone[10] { new HomePhone("CompuTest", 3039855060, 1), 
                new CellPhone("Curtis Manufacturing", 6035324123, 2), new HomePhone("Data Functions", 8008762524, 1), 
                new HomePhone("Donnay Repair", 7083973330, 1), new HomePhone("ErgoNomic Inc", 3604343894, 1), 
                new HomePhone("ErgoSource", 8009694374, 1), new CellPhone("Fox Bay Industries", 8008748527, 2),
                new CellPhone("Glare-Guard", 8005456254, 2), new CellPhone("Hazard Comm Specialists", 4077836641, 2),
                new CellPhone("Komfort Support", 7144724409, 2)};
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dialList[i].Name + " is being dialed using " + dialList[i].Dial() + "...");
            }
            Console.ReadLine();
        }
    }
}
