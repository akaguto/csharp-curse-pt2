using Enumeracao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeracao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }

        public Worker() 
        { 
        }
        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }
    }
}
