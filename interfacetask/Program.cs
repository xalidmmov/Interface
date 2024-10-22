namespace interfacetask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[0]; 
            bool cixis = false;

            while (!cixis)
            {
                Console.WriteLine("Menyu:");
                Console.WriteLine("1. Yeni istifadeei elave et");
                Console.WriteLine("2. Butun istifadecileri goster");
                Console.WriteLine("3. Çıxış");
                Console.Write("Seciminizi daxil edin: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Tam adinizi daxil edin: ");
                        string fullName = Console.ReadLine();

                        Console.Write("Email-i daxil edin: ");
                        string email = Console.ReadLine();

                        Console.Write("sifreni daxil edin: ");
                        string password = Console.ReadLine();

                        User newUser = new User(fullName, email, password);

                        if (newUser.PasswordChecker(password))
                        {
                            Array.Resize(ref users, users.Length + 1);
                            users[users.Length - 1] = newUser;
                            Console.WriteLine("Yeni istifadeci elave edildi.");
                        }
                        else
                        {
                            Console.WriteLine("Şifre şertleri ödenmir. İstifadeci elave edilmedi.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Butun istifadeciler:");
                        foreach (User user in users)
                        {
                            user.ShowFullInfo();
                        }
                        break;

                    case "3":
                        cixis = true;
                        Console.WriteLine("Proqramdan cixilir.");
                        break;

                    default:
                        Console.WriteLine("Yanlış secim etdiniz. Yeniden cehd edin.");
                        break;
                }
            }
        }
    }
}
        

    

