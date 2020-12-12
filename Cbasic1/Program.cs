using System;
using System.IO;
namespace Cbasic1
{
	class Program
	{
		static void Demo()
		{
			System.IO.File.WriteAllText(@"C:\xampp\htdocs\filetext\demo.txt", "add 3 \nmultiply 5 \nsub 2 \napply 3");
		}

		static void Demo1()
		{
			string[] lines = File.ReadAllLines(@"C:\xampp\htdocs\filetext\demo1.txt");
			int total = 0;
			foreach (string line in lines) 
			{
				string[] s = line.Split(' ');
				Console.WriteLine($"ข้อความ {s[0]} = {s[1]}");
				total += int.Parse(s[1]);
			}
			Console.WriteLine(total);
		}
		static void Demo2()
		{
			string[] lines = File.ReadAllLines(@"C:\xampp\htdocs\filetext\demo10.txt");
			int total = 0;
			int add = 0;
			int multiply = 0;
			int sub = 0;
			int apply = 0;
			foreach (string line in lines)
			{
				string[] s = line.Split(' ');
                /*Console.WriteLine($"ข้อความ {s[0]} = {s[1]}");
				total += int.Parse(s[1]);*/

                if (s[0] == "add")
                {
                    add = int.Parse(s[1]);
                }
                if (s[0] == "multiply")
                {
                    multiply = int.Parse(s[1]);
                    total = add + multiply;
                }
                if (s[0] == "sub")
                {
                    sub = int.Parse(s[1]);
                    total = (add + multiply) * sub;
                }
                if (s[0] == "apply")
                {
                    apply = int.Parse(s[1]);

					if(apply != 0)
                    {
						total = apply;
						if (add != 0 && apply != 0)
						{
                            total = add + apply;
                            if (add != 0 && multiply != 0 && apply != 0)
							{
								total = (add + multiply) * apply;
								if (add != 0 && multiply != 0 && sub != 0)
								{
									total = ((add + multiply) * sub) - apply;
								}
							}if(add != 0 && sub != 0 && apply != 0)
                            {
								total = (add + sub) - apply;
								if (add != 0 && multiply != 0 && sub != 0)
								{
									total = ((add + multiply) * sub) - apply;
								}
							}
							
						}
                        if (sub != 0 && apply != 0)
                        {
                            total = sub - apply;
                            if (add != 0 && multiply != 0 && apply != 0)
                            {
                                total = (add + multiply) * apply;
                                if (add != 0 && multiply != 0 && sub != 0)
                                {
                                    total = ((add + multiply) * sub) - apply;
                                }
                            }
                            if (add != 0 && sub != 0 && apply != 0)
                            {
                                total = (add + sub) - apply;
                                if (add != 0 && multiply != 0 && sub != 0)
                                {
                                    total = ((add + multiply) * sub) - apply;
                                }
                            }
                        }
                        if (multiply != 0 && apply != 0)
                        {
                            total = multiply * apply;
                            if (add != 0 && multiply != 0 && apply != 0)
                            {
                                total = (add + multiply) * apply;
                                if (add != 0 && multiply != 0 && sub != 0)
                                {
                                    total = ((add + multiply) * sub) - apply;
                                }
                            }
                            if (add != 0 && sub != 0 && apply != 0)
                            {
                                total = (add + sub) - apply;
                                if (add != 0 && multiply != 0 && sub != 0)
                                {
                                    total = ((add + multiply) * sub) - apply;
                                }
                            }
                        }
                    }
                }

            }
            Console.WriteLine(total);

		}
       
        static void Main(string[] args)
		{
			Demo2();
			Console.ReadKey();
		}
	}
}
