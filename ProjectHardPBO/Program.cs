﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHardPBO
{
    /* 
    Nama : Listya Dwi Subagya
    NIM : 222410102054
    Kelas : PBO A
     */

    using System;
    public class Processor
    {
        public string merk, tipe;
    }
    public class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    public class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
    public class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core i3";
        }
    }
    public class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core i5";
        }
    }
    public class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core i7";
        }
    }
    public class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "RAYZEN";
        }
    }
    public class ATHLON : AMD
    {
        public ATHLON()
        {
            base.tipe = "ATHLON";
        }
    }
    public class VGA
    {
        public string merk;
    }
    public class Nvidia : VGA
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    public class amd : VGA
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }

    public class Laptop
    {
        public string merk, tipe;
        public VGA vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }
    public class ASUS : Laptop
    {
        public ASUS()
        {
            base.merk = "ASUS";
        }
    }
    public class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }
    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    public class ROG : ASUS
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }
    public class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    public class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }
    public class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
    public class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }
    public class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SOAL 1");
            Laptop laptop2 = new IdeaPad();
            laptop2.vga = new amd();
            laptop2.processor = new Ryzen();

            Console.WriteLine("Vga              : " + laptop2.vga.merk);
            Console.WriteLine("Merk Prosessor   : " + laptop2.processor.merk);
            Console.WriteLine("Tipe Prosessor   : " + laptop2.processor.tipe);
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            Console.WriteLine(" ");

            Console.WriteLine("Soal Nomor 2");
            Console.WriteLine("==========Ngoding==========");
            Vivobook ngoding1 = new Vivobook();
            ngoding1.vga = new Nvidia();
            ngoding1.processor = new Ryzen();
            ngoding1.Ngoding();
            Console.WriteLine(" ");


            Console.WriteLine("SOAL 3");
            Laptop laptopkentang = new Vivobook();
            laptopkentang.vga = new Nvidia();
            laptopkentang.processor = new CoreI5();

            Console.WriteLine("Vga              : " + laptopkentang.vga.merk);
            Console.WriteLine("Merk Prosessor   : " + laptopkentang.processor.merk);
            Console.WriteLine("Tipe Prosessor   : " + laptopkentang.processor.tipe);
            Console.WriteLine(" ");


            Console.WriteLine("SOAL 4");
            Predator predator = new Predator();
            predator.vga = new amd();
            predator.processor = new CoreI7();

            Console.WriteLine("Vga              : " + predator.vga.merk);
            Console.WriteLine("Merk Prosessor   : " + predator.processor.merk);
            Console.WriteLine("Tipe Prosessor   : " + predator.processor.tipe);
            predator.BermainGame();
            Console.WriteLine(" ");

            //Console.WriteLine("SOAL 5");
            //ACER acer = new Predator();
            //acer.BermainGame();
        }
    }


}
