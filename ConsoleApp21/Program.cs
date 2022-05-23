using System;

namespace ConsoleApp21
{
    class Program

      //  5.6. Итоговый проект
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, double Age, bool HasPet, string[] favPet, string[] favcolors) User;
            {
                Console.WriteLine("Введите ваше имя:");
                User.Name = Console.ReadLine();
                Console.WriteLine("Введите вашу фамилию:");
                User.LastName = Console.ReadLine();

                int intAge;
                string age;
                do
                {
                    Console.WriteLine("Введите возраст цифрами:");
                    age = Console.ReadLine();

                } while (CheckNum(age, out intAge));
                User.Age = intAge;
                User.Age = AgeTrue(User.Age);

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                var HasPet1 = Console.ReadLine();
                User.HasPet = false;

                if (HasPet1 == "Да" || HasPet1 == "да")
                {
                    User.HasPet = true;
                    int intkolvo;
                    string kolvo;
                    do
                    {
                        Console.WriteLine("Введите количество животных (число):");
                        kolvo = Console.ReadLine();

                    } while (CheckNum(kolvo, out intkolvo));

                    int kolvo1 = intkolvo;
                    if (kolvo1 <= 0)
                    {
                        Console.WriteLine("Это значит, что у вас нет животного :(");
                        User.favPet = null;
                        User.HasPet = false;
                    }
                    else
                    {
                        FavPet(kolvo1, out string[] namePet);
                        User.favPet = namePet;
                    }
                }
                else
                {
                    User.favPet = null;
                }
               
                int intkolcolor;
                string kolvocolor;
                do
                {
                    Console.WriteLine("Сколько у вас любимых цветов? (число не больше 5ти):");
                    kolvocolor = Console.ReadLine();

                } while (CheckNum(kolvocolor, out intkolcolor));

                int kolcolor = intkolcolor;
                if (kolcolor >= 1 && kolcolor <= 5)
                {
                    FavColor(kolcolor, out string[] nameColor);
                    User.favcolors = nameColor;
                }
                else
                {
                    if (kolcolor <= 0)
                    {
                        Console.WriteLine("Жаль, что у вас нет любимых цветов :(");
                        User.favcolors = null;

                    }
                    else
                    {
                        Console.WriteLine("Вы выбрали слишком много цветов");
                        User.favcolors = null;
                    }
          
                }
           
            }

            Console.WriteLine("Данные , которые нам удалось у вас узнать:");
            YourData(User.Name, User.LastName, User.Age, User.HasPet, User.favPet, User.favcolors);
            Console.ReadKey();
        }

        static void YourData(string name, string lastname, double age, bool haspet, string[] favpet, string[] favcolors)

        {
            Console.WriteLine("Ваше ФИО: {0} {1}", lastname, name);
            Console.WriteLine("Ваш возраст: {0}", age);
            if (haspet)
            {
                Console.WriteLine("У вас есть животные, их клички:");
                foreach (var name1 in favpet)
                {
                    Console.WriteLine(name1);
                }
            }
            else
            {
                Console.WriteLine("У вас нет животных");
            }

            if (favcolors == null)
            {
                Console.WriteLine("У вас нет любимых цветов");
            }
            else
            {
                Console.WriteLine("Ваши любимые цвета:");
                foreach (var name2 in favcolors)
                {
                    Console.WriteLine(name2);
                }
            }
        }
        
        static void FavPet(int kolvo, out string[] namePet)
        
        {
            namePet = new string[kolvo];
  
                  for (int i = 0; i < kolvo; i++)
                  {
                    Console.WriteLine("Введите кличку {0} животного: ", i + 1);
                    namePet[i] = Console.ReadLine();
                  }
        
        }

        static void FavColor(int kolvo, out string[] nameColor)
        {
            nameColor = new string[kolvo];
            for (int i = 0; i < kolvo; i++)
            {
                Console.WriteLine("Введите {0} цвет: ", i + 1);
                nameColor[i] = Console.ReadLine();
            }
        }

        static double AgeTrue(double age)
        {
        
            if (age > 0 && age < 150)
            {
                return age;
            }
            else
            {
                Console.WriteLine("Некорректный ввод, попробуйте еще раз  ");
                Console.WriteLine("Введите ваш возраст:");
                age = double.Parse(Console.ReadLine());
                return AgeTrue(age);
            }
        }

        static bool CheckNum(string number, out int corrnumber)

        {
            bool result1 = int.TryParse(number, out int intnum);
            if (result1 == true)
            {
                corrnumber = intnum;
                return false;
            
            }

            corrnumber = 0;
            return true;
        }
                
    
    }
}


