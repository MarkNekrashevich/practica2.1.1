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
            int N = int.Parse(NTextBox.Text); // �������� �������� N �� ���������� ����
            int M = int.Parse(MTextBox.Text); // �������� �������� M �� ���������� ����

            List<int> primesTable = CalculateFirstNPrimes(N); // ��������� ������ N ������� �����
            int maxPrime = primesTable.Last(); // �������� ���������� ������� ����� �� �������

            // ��������� ������� ����� � ��������� [M+1, M*M]
            List<int> primesInRange = CalculatePrimesInRange(M + 1, M * M, primesTable);

            // ������� ���������� � ��������� ����
            ResultTextBox.Text = "������� ����� � ��������� [" + (M + 1) + ", " + (M * M) + "]:\n";
            foreach (int prime in primesInRange)
            {
                ResultTextBox.Text += prime + "\n";
            }
        }

        // ����� ��� ���������� ������ N ������� �����
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

        // ����� ��� ��������, �������� �� ����� �������
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

        // ����� ��� ���������� ������� ����� � �������� ��������� � �������������� ������� ������� �����
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
