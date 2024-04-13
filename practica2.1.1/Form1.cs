namespace practica2._1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = int.Parse(NTextBox.Text); // ѕолучаем значение N из текстового пол€
            int M = int.Parse(MTextBox.Text); // ѕолучаем значение M из текстового пол€

            List<int> primesTable = CalculateFirstNPrimes(N); // ¬ычисл€ем первые N простых чисел
            int maxPrime = primesTable.Last(); // ѕолучаем наибольшее простое число из таблицы

            // ¬ычисл€ем простые числа в диапазоне [M+1, M*M]
            List<int> primesInRange = CalculatePrimesInRange(M + 1, M * M, primesTable);

            // ¬ыводим результаты в текстовое поле
            ResultTextBox.Text = "ѕростые числа в диапазоне [" + (M + 1) + ", " + (M * M) + "]:\n";
            foreach (int prime in primesInRange)
            {
                ResultTextBox.Text += prime + "\n";
            }
        }

        // ћетод дл€ вычислени€ первых N простых чисел
        private List<int> CalculateFirstNPrimes(int N)
        {
            List<int> primes = new List<int>();
            int num = 2;
            while (primes.Count < N)
            {
                if (IsPrime(num))
                {
                    primes.Add(num);
                }
                num++;
            }
            return primes;
        }

        // ћетод дл€ проверки, €вл€етс€ ли число простым
        private bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // ћетод дл€ вычислени€ простых чисел в заданном диапазоне с использованием таблицы простых чисел
        private List<int> CalculatePrimesInRange(int start, int end, List<int> primesTable)
        {
            List<int> primesInRange = new List<int>();
            foreach (int num in primesTable)
            {
                if (num >= start && num <= end)
                {
                    primesInRange.Add(num);
                }
                else if (num > end)
                {
                    break;
                }
            }
            return primesInRange;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
