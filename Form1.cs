namespace cofeeShop
{
    public partial class Form1 : Form
    {
        public static string customerName = "";
        public static string date = "";
        public static string item = "";
        int qty = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // To Get System date and time
            date = DateTime.Now.ToString();
            label5.Text = date;

            // To assign values to drop down list
            // comboBox1.Item.Add("TEST ITEM")

            string[] myItems =
                {
                 "Tea -> Rs.160.00",
                 "Milk Tea -> Rs. 240.00",
                 "Cofee -> Rs.200.00",
                 "Furit Drink -> Rs.420.00",
                 "Soda -> Rs.150.00",
             
            };

            comboBox1.Items.AddRange(myItems);
            comboBox1.SelectedItem = myItems [0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerName = textBox1.Text;
            item = comboBox1.SelectedItem.ToString();
            qty = Convert.ToInt32(numericUpDown1.Value);

            // MessageBox.Show(item + qty .ToString(),"Selected item");

            Form2 abc = new Form2();
            abc.Show();

        }
    }
}
