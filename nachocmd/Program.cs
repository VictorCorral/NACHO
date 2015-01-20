﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NACHO;

namespace nachodump
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is what knows about files (as should any user of the NACHO library)
            if (args.Length <= 0)
            {
                //TODO print usage

            }
            else
            {
                System.IO.StreamReader reader = new System.IO.StreamReader(args[0]);
                string messages;
                ACH ach = ACHParser.ParseStream(reader, out messages);
                System.Console.WriteLine(messages);
                System.Console.WriteLine("\n"+ACHPrinter.PrintACH(ach));
            }
        }
    }
}