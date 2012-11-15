
using System;
using System.Collections.Generic;
using System.Text;

namespace Hanoi {
    class Program {
        static int countMoves = 0;
        static void Main(string[] args) {
            Begin:
                char from = 'A', to = 'C', help = 'B';
                int x = giveInt();
                Console.WriteLine("\n  from = A, help = B, to = C\n");
                hanoi(x, from, to, help);
                Console.WriteLine("Moves: " + countMoves);
                countMoves = 0;
            goto Begin;
        }

        static void hanoi(int x, char from, char to, char help) {
            if (x > 0) {
                countMoves++;
                x--;
                hanoi(x, from, help, to);
                move(x, from, to);
                hanoi(x, help, to, from);
            }

        }

        static void move(int x, char from, char to) {
            Console.WriteLine("  move disk " + x + " from " + from + " to " + to);
        }
        static int giveInt() {
            int x;
            do {

                try {
                    Console.Write("  input number of disk: ");
                    x = Int32.Parse(Console.ReadLine());
                } catch (FormatException e) {
                    x = -10;
                }
            } while (x < 1 || x > 15);
            return x;
        }

    }
}