using System;
using System.IO;
public class AoC {
    static void Main(string[] args) {
        string input = File.ReadAllText(args[0]);
        // Get array of numbers
        int[] instructions = Array.ConvertAll(input.Split(','), s => Int32.Parse(s));
        for (int i = 0; i < instructions.Length; i+= 4) 
        {
            int result = 0;
            if (instructions[i] == 1) // Sum
            {
                result = instructions[instructions[i+1]] + instructions[instructions[i+2]];
            }
            else if (instructions[i] == 2) // Multiply
            {
                result = instructions[instructions[i+1]] * instructions[instructions[i+2]];
            }
            else if (instructions[i] == 99) // Halt
            { 
                Console.WriteLine("[{0}]", string.Join(", ", instructions));
                break;
            }
            instructions[instructions[i+3]] = result;
        }
    }
}