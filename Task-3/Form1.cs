namespace Task_3
{
    public partial class Form1 : Form
    {
        private const string Erase = "C";
        private const string EraseEntry = "CE";
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    control.Click += Label_Click;
                }
            }
        }
        private void Label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

          

            if (clickedLabel != null )
            { 
                switch(clickedLabel.Name)
                {
                    case Erase: screen.Items.Clear();
                        break;
                    case EraseEntry:
                        screen.Items[^1] = "";
                        break;
                    default:
                        screen.Items[^1] += clickedLabel.Text;
                        break;


                }

               
               
            }

           
           
        }
      
        private void label2_Click(object sender, EventArgs e)
        {
           
        }
    //public static string EnumToString(MathSymbols value)
    //{
    //    return value.ToString();
    //}
    }

    //public enum MathSymbols:byte
    //{
    //  plus,
    //  minus,
    //  divide,
    //  multiple,
    //  percentDivide,
    //  sqrt,
    //  reverse,

    // } 
}
