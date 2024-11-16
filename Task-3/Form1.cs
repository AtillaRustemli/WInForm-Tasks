using Microsoft.Win32;

namespace Task_3
{
    public partial class Form1 : Form
    {
        private const string WrongInputMessage = "Daxil edilen melumatda yanlishliq var";
        private const string ExceedOperationLimit = "1 setirde yalniz 1 riyazi emel yerine yetirmek olar!!";
        private const string CommonErrorMessage = "Xeta bash verdi";
        private const string ImpossibleMathEquationError = "Bu ifadenin heqiqi cavabi yoxdur!";

        private const string Erase = "C";
        private const string EraseEntry = "CE";
        private const string Backspace = "<--";


        private const string Equal = "=";
        private const char Plus = '+';
        private const char Minus = '-';
        private const char Divide = '/';
        private const char Multiple = 'x';
        private const char PercentDivide = '%';
        private const string Sqrt = "V";
        private const string Reverse = "1/x";
        private const string Power = "^2";


        private static readonly char[] Characters = { Plus, Minus, Divide, Multiple, PercentDivide };

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls) if (control is Label) control.Click += Label_Click;
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                try
                {

                    switch (clickedLabel.Text)
                    {
                        case Erase:
                            screen.Items.Clear();
                            break;
                        case EraseEntry:
                            screen.Items[0] = "";
                            break;
                        case Sqrt:
                            CorrectOrder(screen);
                            if (!screen.Text.Any(s => Characters.Contains(s)))
                            {
                                if (screen.Items[^1] is string)
                                    screen.Items.Add(Math.Sqrt(double.Parse((string)screen.Items[^1])));
                                else screen.Items.Add(Math.Sqrt((double)screen.Items[^1]));
                            }

                            else MessageBox.Show(WrongInputMessage);

                            CorrectOrder(screen);
                            break;
                        case Power:
                            CorrectOrder(screen);
                            if (!screen.Text.Any(s => Characters.Contains(s)))
                            {
                                if (screen.Items[^1] is string)
                                    screen.Items.Add(Math.Pow(double.Parse((string)screen.Items[^1]), 2));
                                else screen.Items.Add(Math.Pow((double)screen.Items[^1], 2));
                            }

                            else MessageBox.Show(WrongInputMessage);

                            CorrectOrder(screen);
                            break;
                        case Reverse:
                            CorrectOrder(screen);
                            if (!clickedLabel.Name.Any(s => Characters.Contains(s)))
                            {
                                if (screen.Items[^1] is string)
                                    screen.Items.Add(1 / double.Parse((string)screen.Items[^1]));
                                else screen.Items.Add(1 / (double)screen.Items[^1]);
                            }

                            else MessageBox.Show(WrongInputMessage);

                            CorrectOrder(screen);
                            break;
                        case Equal:
                            CorrectOrder(screen);
                            if (double.TryParse(Calculate((string)screen.Items[^1]), out double result))
                                screen.Items.Add(result);
                            else MessageBox.Show(Calculate((string)screen.Items[^1]));
                            CorrectOrder(screen);
                            break;
                        case Backspace:
                            CorrectOrder(screen);
                            if (screen.Items[^1] != string.Empty)
                            {
                                if (screen.Items[^1].ToString().Length == 1)
                                {
                                    screen.Items[^1] = "";
                                }
                                else
                                    screen.Items[^1] = screen.Items[^1].ToString()
                                        .Substring(0, screen.Items[^1].ToString().Length - 1);
                            }

                            CorrectOrder(screen);
                            break;
                        default:
                            CorrectOrder(screen);
                            if (screen.Items.Count >= 1 && screen.Items[^1].ToString().ToLower().Contains("ok"))
                                screen.Items[^1] = "";

                            if (screen.Items.Count > 0) screen.Items[^1] += clickedLabel.Text;
                            else screen.Items.Add(clickedLabel.Text);
                            CorrectOrder(screen);

                            break;
                    }

                }
                catch
                {
                    MessageBox.Show(ImpossibleMathEquationError);
                }

            }
        }
        public static void CorrectOrder(ListBox listBox)
        {
            List<object> items = listBox.Items.Cast<object>().ToList();
            items.Reverse();
            listBox.Items.Clear();
            listBox.Items.AddRange(items.ToArray());
        }
        public static string Calculate(string example)
        {
            var operation = example.FirstOrDefault(s => Characters.Contains(s));
            var problem = example.Split(Characters);
            string result = "";
            if (problem.Length != 2||problem.Any(s=>s == string.Empty)) return ExceedOperationLimit;
            try
            {
                switch (operation)
                {
                    case Plus:
                        result = (double.Parse(problem[0]) + double.Parse(problem[1])).ToString();
                        break;
                    case Minus:
                        result = (double.Parse(problem[0]) - double.Parse(problem[1])).ToString();
                        break;
                    case Divide:
                        result = (double.Parse(problem[0]) / double.Parse(problem[1])).ToString();
                        break;
                    case Multiple:
                        result = (double.Parse(problem[0]) * double.Parse(problem[1])).ToString();
                        break;
                    case PercentDivide:
                        result = (double.Parse(problem[0]) % double.Parse(problem[1])).ToString();
                        break;
                }
            }
            catch
            {
                MessageBox.Show(ImpossibleMathEquationError);
            }

            return result ==  string.Empty ? CommonErrorMessage: result;
        }

    }
}
