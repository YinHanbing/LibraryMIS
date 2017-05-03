using System.Windows.Forms;

namespace LibraryMIS
{
    public partial class FormBookInsert : Form
    {
        Common.DataBase dataBase = new Common.DataBase();
        public string op = "Add";
        public string BookID = "";

        public FormBookInsert()
        {
            InitializeComponent();
        }
    }
}
