﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTut03.Shared
{
    public static class ExtensionFunctional
    {
        //  Func<Employee, bool> predicate =  Predicate<Employee> predicate 
        public static IEnumerable<Employee> Filter(this IEnumerable<Employee> source, Func<Employee, bool> predicate) 
        {
            foreach (var employee in source)
            {
                if (predicate(employee))
                {
                    yield return employee;
                }
            }
        }

        public static void Print<T>(this IEnumerable<T> source, string title)
        {
            if (source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in source)
            {
                if(typeof(T).IsValueType)
                    Console.Write($" {item} ");
                else
                    Console.WriteLine(item);
            }
        }
    }
}