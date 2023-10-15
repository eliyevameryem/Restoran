namespace Restoran
{
    internal class Program
    {
        

        static void Main(string[] args)
        {

            Restoran menu = new Restoran();
            
            
            string input;

            Console.WriteLine("Restoranimiza xos gelmissiniz");

            do
            {
                Console.WriteLine("-----------------------------------");

                Console.WriteLine("Secmek istediyiniz emeliyyati daxil edin");
                Console.WriteLine("-----------------------------------");

                Console.WriteLine("1 Qida əlavə et");
                Console.WriteLine("2 İçki əlavə et");
                Console.WriteLine("3 Bütün menyunu göstər");
                Console.WriteLine("4 Qiymətə görə menyu axtar");
                Console.WriteLine("5 Alkol faizlərinə görə içkiləri axtar");
                Console.WriteLine("0 Proqramı bitir");

                Console.WriteLine("-----------------------------------");

                input = Console.ReadLine();
                string foodname;
                string drinkname;
                int foodprice;
                int drinkprice;
                int percentage;

                switch (input) 
                {
                    
                    case "1":
                        
                            Console.WriteLine("Elave etmek istediyiniz qidanin adini ve qiymetini daxil edin");

                            foodname = Console.ReadLine();
                            foodprice = int.Parse(Console.ReadLine()); 
                        break;


                        case "2":
                       
                            Console.WriteLine("Ickinin adini, qiymetini ve alkol faizini daxil edin");
                            drinkname = Console.ReadLine();
                            drinkprice = int.Parse(Console.ReadLine());
                            percentage = int.Parse(Console.ReadLine());

                       
                        break;


                        case "3":
                        menu.AddFood();
                        menu.AddDrink();
                        break;

                        case "4":
                        if (menu != null)
                        {
                            Console.WriteLine(" Minimum Qiymeti daxil edin");
                            int minprice = int.Parse(Console.ReadLine());

                            Console.WriteLine(" Maksimum qiymeti daxil edin");
                            int maxprice = int.Parse(Console.ReadLine());
                            menu.GetMenuByPriceFood(minprice, maxprice);
                            menu.GetMenuByPriceDrink(minprice, maxprice);
                        }
                        else
                        {
                            Console.WriteLine("Daxil etdiyiniz qiymet araliga uygun deyildir");
                        }
                       
                        break;

                        case "5":

                        if (menu != null)
                        {
                            Console.WriteLine("Secdiyiniz minimum alkol faizini daxil edin");
                            int mindrinkprice = int.Parse(Console.ReadLine());
                            Console.WriteLine("Secdiyiniz maksimum alkol faizini daxil edin");
                            int maxdrinkprice = int.Parse(Console.ReadLine());
                            menu.GetMenuByPriceDrink(mindrinkprice, maxdrinkprice);
                        }
                        
                        break;

                }



            } while (input == "0");
        }
       
    }
}