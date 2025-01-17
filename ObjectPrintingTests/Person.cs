﻿using System;

namespace ObjectPrintingTests
{
    internal class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public Person Brother { get; set; }
        public Person Friend { get; set; }
    }
}