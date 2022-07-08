namespace ZKTecoDown
{

    public partial class MachineDL : System.Windows.Forms.Form
    {
        public MachineDL()
        {

            InitializeComponent();
            
        }

        private void Form_Load(object sender, EventArgs e)
        {
            Config.Initialize("./conf.ini");
            this.Text += " (" + Config.initconf.Company + ")";
        }
    }
}