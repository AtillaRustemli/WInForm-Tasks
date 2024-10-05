using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Task_2
{
    public partial class Form1 : Form
    {
        private const string FieldEmptyMessage = "Fill all textboxes";
        private const string SuccessMessage = "Succesfully bought ticket";
        private const string ItemDeletedMessage = "Item was deleted from database";
        private const string NotAnEmailError = "Correct your email!!";
        public Form1()
        {
            InitializeComponent();
        }

        private void buy_Click(object sender, EventArgs e)
        {

           
            if (phoneNumber.Text is not "" &&
                email.Text is not "" &&
                seria.Text is not "" &&
                from.Text is not "" &&
                to.Text is not "" &&
                date.Text is not "" &&
                time.Text is not "" &&
                nameSurname.Text is not "" &&
                place.Text is not "") MessageBox.Show(SuccessMessage);
            else if (!CheckEmail(email.Text))
                MessageBox.Show(NotAnEmailError);
            else MessageBox.Show(FieldEmptyMessage);

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteFromList_Click(object sender, EventArgs e)
        {
            from.Items.Remove(from.Text);
            to.Items.Remove(to.Text);
            MessageBox.Show(ItemDeletedMessage);
        }

        public static bool CheckEmail(string email)
        {
            return email.Contains("@")  &&
                   email.Length > 2 && email.IndexOf("@")<email.Length-1 && email[email.IndexOf("@") - 1] != '.' && email[email.IndexOf("@") + 1] != '.';
        }
    }
}
