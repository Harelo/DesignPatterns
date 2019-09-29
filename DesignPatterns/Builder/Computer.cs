using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class Computer
    {
        private string CPU;
        private string GPU;
        private string RAM;
        private string SSD;

        private Computer(ComputerBuilder builder)
        {
            this.CPU = builder.CPU;
            this.GPU = builder.GPU;
            this.RAM = builder.RAM;
            this.SSD = builder.SSD;
        }

        public class ComputerBuilder
        {
            private Computer theComputer;

            public string CPU { get; }
            public string GPU { get; }
            public string RAM { get; }
            public string SSD { get; }

            public ComputerBuilder(string _cpu, string _gpu, string _ram, string _ssd)
            {
                this.CPU = _cpu;
                this.GPU = _gpu;
                this.RAM = _ram;
                this.SSD = _ssd;
            }

            public void build()
            {
                theComputer = new Computer(this);
            }

            public Computer getComputer()
            {
                return theComputer;
            }
        }
    }
}
