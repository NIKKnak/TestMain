using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace WinFormsDB
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = new List<string>
                        {
                "Первое",
                "Второе",
                "Третье",
                "Четвертое",

            };

            /*var newList = new List<string>();
            foreach (var item in list)
                if (item.Contains("Ч"))
                    newList.Add(item);*/
            

            var newList = list.Where(x => x.Contains("т"));

            

            label1.Text = string.Join(Environment.NewLine, newList);

        }
    }
}
