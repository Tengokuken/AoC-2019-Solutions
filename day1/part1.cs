using System;
using System.IO;
public class AoC {
    static void Main(string[] args) {
        string[] input = File.ReadAllLines(args[0]);
        int sum = 0;
        foreach(string mass in input) {
            int req = (int.Parse(mass)/3 - 2);
            sum += req;
        }
        Console.WriteLine(sum);
    }
}