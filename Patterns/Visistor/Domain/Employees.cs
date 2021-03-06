﻿using System;
using System.Collections.Generic;
using Visistor.Data;

namespace Visistor.Domain
{
    public class Employees : List<Employee>
    {
        public void Attach(Employee employee)
        {
            this.Add(employee);
        }

        public void Detach(Employee employee)
        {
            this.Remove(employee);
        }

        public void Accept<T>(T context, Visitor<T> visitor)
        {
            foreach(var employee in this)
            {
                employee.Accept(context, visitor);
            }

            Console.WriteLine();
        }
    }
}
