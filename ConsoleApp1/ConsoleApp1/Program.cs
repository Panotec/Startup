using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 ~ 10 사이의 숫자를 입력하고 엔터를 입력하세요..");
            
            string line = Console.ReadLine();

            #region ? 연산자

            // 조건문 (if)
            int x = int.Parse(line);
            bool isSeven;

            if (x == 7)
            {
                isSeven = true;
            }
            else
            {
                isSeven = false;
            }

            isSeven = x == 7 ? true : false;

            Console.WriteLine($"isSeven의 값은 {isSeven} 입니다.");

            // Nullable
            int? z = 10;
            int age = 8;

            if (z.HasValue)
            {
                age += z.Value;
            }
            else
            {
                age += 1;
            }

            Console.WriteLine($"age의 값은 {age} 입니다.");

            #endregion

            #region ?? 연산자

            age += z ?? 1;

            Console.WriteLine($"age의 값은 {age} 입니다.");

            #endregion

            #region is 키워드

            if (z is null)
            {
                age += 1;
            }
            else
            {
                age += z.Value;
            }

            Console.WriteLine($"age의 값은 {age} 입니다.");

            #endregion

            #region 컬렉션 초기화

            List<User> users = new List<User>();

            User first = new User();
            first.Name = "John";
            first.Age = 20;
            users.Add(first);

            User second = new User();
            second.Name = "Julia";
            second.Age = 27;
            users.Add(second);

            //users.Add(new User
            //{
            //    Name = "John",
            //    Age = 20
            //});

            //users.Add(new User
            //{
            //    Name = "Julia",
            //    Age = 27
            //});

            //List<User> users = new List<User>
            //{
            //    new User { Name = "John", Age = 20 },
            //    new User { Name = "Julia", Age = 27 }
            //};

            #endregion

            Console.ReadLine();
        }
    }
}
