using System;

class MathTable {
  private static int number = 0;
  private static int math_table_limit = 0;

  static void Main(string[] args) {
    setNumber();
    setMathTableLimit();
    generateMathTable();
  }

  private static void setNumber() {
    Console.WriteLine("Type a number: ");
    number = int.Parse(Console.ReadLine());
  }

  private static void setMathTableLimit() {
    Console.WriteLine("Type the math table limit: ");
    math_table_limit = int.Parse(Console.ReadLine());
  }

  private static void generateMathTable() {
    Console.WriteLine($"The math table of {number} is: \n");
    for (int i=0; i<=math_table_limit; i++) {
      calculateMathTableLine(number, i);
    }
  }

  private static void calculateMathTableLine(int number, int iteration) {
    Console.WriteLine($"{number} * {iteration} = {number * iteration}");
  }

}
