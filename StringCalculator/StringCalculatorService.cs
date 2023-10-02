namespace StringCalculator
{
    public class StringCalculatorService
    {
        public int Add(string numbers)
        { 
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            if (numbers.StartsWith("//"))
            {
                int sum = 0;
                int delimitadorI = numbers.IndexOf('\n');
                if (delimitadorI != -1)
                {
                    string del = numbers.Substring(2, delimitadorI - 2);
                    string numberspart = numbers.Substring(delimitadorI + 1);
                    string[] numbersArray = numberspart.Split(new string[] { del }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string number in numbersArray)
                    {
                        if (int.TryParse(number, out int num))
                        {
                            if (num <= -1)
                            {
                                Console.WriteLine("El metodo add no permite numeros negativos" + num);
                                num = 0;
                            }
                            sum += num;
                        } 
                    }
                }
                return sum;
            }

            var parts = numbers.Split(',', '\n');
            // if (parts.Length == 1) 
            // {
            //    return int.Parse(numbers);
            //}
            int suma = 0;
            for (int i = 0; i<parts.Length; i++)
            {
            suma += int.Parse(parts[i]);
            }
            return suma;

              // return int.Parse(parts[0]) + int.Parse(parts[1]);

        }
    }
}