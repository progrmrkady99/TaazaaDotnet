﻿using System;
using System.Collections.Generic;

namespace switchgenericsp
{
    class Program
    {
        static void Main()
        {
            List<string> obj =  new List<string>();
            for(int i=0; i<3; i++)
            {
                switch(i)
                {
                    case 1:
                    obj.Add("Karan");
                    obj.Add("Rahul");
                    System.Console.WriteLine("Name added");
                    break;
                    case 2:
                    if(obj.Contains("Karan"))
                    {
                        Console.WriteLine("Found");
                    }
                    else
                    {
                        Console.WriteLine("Not Found");
                    }
                    break;
                }
            }
        }
    }
}
