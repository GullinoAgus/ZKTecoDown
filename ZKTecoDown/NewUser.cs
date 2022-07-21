namespace ZKTecoDown
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();

            UserID.Controls[0].Hide();
            UserID.Width = UserID.Width + 16;
        }

        public void GetData(ref string ID, ref string Name)
        {
            ID = UserID.Value.ToString();
            Name = NameTextBox.Text;
        }
    }
}
