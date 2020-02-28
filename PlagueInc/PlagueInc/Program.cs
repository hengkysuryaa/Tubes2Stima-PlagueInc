﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlagueInc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Graph g = new Graph();
            g.addEdge("0", "1", 4);
            g.addEdge("0", "2", 2);
            g.addEdge("1", "2", 1);
            g.addEdge("1", "3", 5);
            g.addEdge("2", "3", 8);
            g.addEdge("2", "4", 10);
            g.addEdge("3", "4", 2);
            g.addEdge("3", "5", 6);
            g.addEdge("4", "5", 3);
            System.Console.WriteLine(g.ToString());
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}