using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("간단한 계산기 프로그램");
            Console.WriteLine("1. 수식 계산");
            Console.WriteLine("2. 종료");

            Console.Write("원하는 기능을 선택하세요 (1 또는 2): ");
            string choice = Console.ReadLine();

            if (choice == "2")
            {
                Console.WriteLine("프로그램을 종료합니다.");
                break;
            }

            Console.Write("계산할 수식을 입력하세요: ");
            string expression = Console.ReadLine();

            try
            {
                double result = Evaluate(expression);
                Console.WriteLine($"결과: {result}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"에러: {ex.Message}\n");
            }
        }
    }

    static double Evaluate(string expression)
    {
        
        System.Data.DataTable table = new System.Data.DataTable();
        return Convert.ToDouble(table.Compute(expression, string.Empty));
    }
}
