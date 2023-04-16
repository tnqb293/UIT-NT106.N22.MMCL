using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_21521865_Tran_Nguyen_Quoc_Bao
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void ReadAndCalculator_Click(object sender, EventArgs e)
        {
            try
            {
                string inputFilePath = "input3.txt";
                string outputFilePath = "output3.txt";

                if (!File.Exists(inputFilePath))
                {
                    MessageBox.Show("Input file does not exist");
                    return;
                }

                List<string> lines = new List<string>();
                using (StreamReader sr = new StreamReader(inputFilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }

                List<string> results = new List<string>();
                foreach (string line in lines)
                {
                    double result = Calculate(line);
                    string outputLine = line + " = " + result;
                    results.Add(outputLine);
                }

                using (StreamWriter sw = new StreamWriter(outputFilePath))
                {
                    foreach (string line in results)
                    {
                        sw.WriteLine(line);
                    }
                }

                MessageBox.Show("Calculation completed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private double Calculate(string expression)
        {
            Stack<string> stack = new Stack<string>();
            Stack<string> operators = new Stack<string>();
            Stack<double> operands = new Stack<double>();

            string[] tokens = expression.Split(' ');
            foreach (string token in tokens)
            {
                if (token == "(")
                {
                    operators.Push(token);
                }
                else if (token == ")")
                {
                    while (operators.Peek() != "(")
                    {
                        string op = operators.Pop();
                        double operand2 = operands.Pop();
                        double operand1 = operands.Pop();

                        double result = 0;

                        switch (op)
                        {
                            case "+":
                                result = operand1 + operand2;
                                break;
                            case "-":
                                result = operand1 - operand2;
                                break;
                            case "*":
                                result = operand1 * operand2;
                                break;
                            case "/":
                                result = operand1 / operand2;
                                break;
                        }

                        operands.Push(result);
                    }

                    operators.Pop(); // loại bỏ dấu "("
                }
                else if (IsOperator(token))
                {
                    while (operators.Count > 0 && Priority(operators.Peek()) >= Priority(token))
                    {
                        string op = operators.Pop();
                        double operand2 = operands.Pop();
                        double operand1 = operands.Pop();

                        double result = 0;

                        switch (op)
                        {
                            case "+":
                                result = operand1 + operand2;
                                break;
                            case "-":
                                result = operand1 - operand2;
                                break;
                            case "*":
                                result = operand1 * operand2;
                                break;
                            case "/":
                                result = operand1 / operand2;
                                break;
                        }

                        operands.Push(result);
                    }

                    operators.Push(token);
                }
                else
                {
                    operands.Push(double.Parse(token));
                }
            }

            while (operators.Count > 0)
            {
                string op = operators.Pop();
                double operand2 = operands.Pop();
                double operand1 = operands.Pop();

                double result = 0;

                switch (op)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        result = operand1 / operand2;
                        break;
                }

                operands.Push(result);
            }

            return operands.Pop();
        }

        private bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/";
        }

        private int Priority(string op)
        {
            switch (op)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                default:
                    return 0;
            }
        }
    }
}


