using System;
using projmaker;

namespace projmaker {
    internal class argsHandler {
        public static void handle(string[] args) {
            if (args.Length == 0) {
                System.Console.WriteLine("Arguments not found.");
            }
        }
    }
}