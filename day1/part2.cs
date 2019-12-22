using System;
using System.IO;
public class AoC {
    static void Main(string[] args) {
        string[] input = File.ReadAllLines(args[0]);
        int sum = 0;
        foreach(string mass in input) {
            int sumFuel = 0;
            int req = int.Parse(mass);
            while (req/3 - 2 > 0) {
                req = (req/3 - 2);
                sumFuel += req;
            }
            sum += sumFuel;
        }
        Console.WriteLine(sum);
    }
}