using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5
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
        public interface IOperation
        {
            string GetOperationName();
            string GetOperationSign();
            int Operation(int a, int b);
        }

        public class Plus : IOperation
        {
            public string GetOperationName() => "��������";
            public string GetOperationSign() => "+";
            public int Operation(int a, int b)
            {
                return a + b;
            }
        }

        public class Minus : IOperation
        {
            public string GetOperationName() => "���������";

            public string GetOperationSign() => "-";

            public int Operation(int a, int b)
            {
                return a - b;
            }
        }

        public class Multiplication : IOperation
        {
            public string GetOperationName() => "���������";

            public string GetOperationSign() => "*";

            public int Operation(int a, int b)
            {
                return a * b;
            }
        }
        public class Div : IOperation
        {
            public string GetOperationName() => "�������";

            public string GetOperationSign() => "/";

            public int Operation(int a, int b)
            {
                if (b == 0)
                    throw new DivideByZeroException("������� �� ���� �����������");
                return a / b;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = (int)numericUpDown1.Value;
            int b = (int)numericUpDown2.Value;
            string operation = comboBox1.Text;
            try
            {
                if (operation == "+")
                {
                    Plus result = new Plus();
                    textBox1.Text = $"�������� ��������: {result.GetOperationName()}\r\n" +
                        $"���� ��������: {result.GetOperationSign()}\r\n" +
                        $"��������� ��������: {result.Operation(a, b)}";
                }
                else if (operation == "-")
                {
                    Minus result = new Minus();
                    textBox1.Text = $"�������� ��������: {result.GetOperationName()}\r\n" +
                        $"���� ��������: {result.GetOperationSign()}\r\n" +
                        $"��������� ��������: {result.Operation(a, b)}";
                }
                else if (operation == "*")
                {
                    Multiplication result = new Multiplication();
                    textBox1.Text = $"�������� ��������: {result.GetOperationName()}\r\n" +
                        $"���� ��������: {result.GetOperationSign()}\r\n" +
                        $"��������� ��������: {result.Operation(a, b)}";
                }
                else if (operation == "/")
                {
                    Div result = new Div();
                    textBox1.Text = $"�������� ��������: {result.GetOperationName()}\r\n" +
                        $"���� ��������: {result.GetOperationSign()}\r\n" +
                        $"��������� ��������: {result.Operation(a, b)}\r\n";
                }
                else
                {
                    Console.WriteLine("������� �������� ��������, ��������� �������.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

