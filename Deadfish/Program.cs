namespace Deadfish;
class Program
{
    static void Main(string[] args)
    {
        List<String> operators = new List<String>();
        operators.Add("i");
        operators.Add("d");
        operators.Add("s");
        operators.Add("o");
        operators.Add("h");
        operators.Add(";");

        Int32 accumulator = 0;
        
        while (true)
        {
            Console.Write(">> ");
                
            String code = Console.ReadLine();

            if (code != null)
            {
                while (code.Length > 0)
                {
                    Char op = code.First();
                    code = code.Substring(1);

                    if (op == 'i')
                    {
                        accumulator++;
                    }

                    if (op == 'd')
                    {
                        accumulator--;
                    }

                    if (op == 's')
                    {
                        accumulator = (Int32) Math.Pow(accumulator, 2);
                    }

                    if (op == 'o')
                    {
                        Console.WriteLine(accumulator);
                    }

                    if (op == 'h')
                    {
                        code = "";
                    }

                    if (op == ';')
                    {
                        accumulator = 0;
                    }

                    if (accumulator == -1 || accumulator == 256)
                    {
                        accumulator = 0;
                    }
                }
            }
        }   
    }
}