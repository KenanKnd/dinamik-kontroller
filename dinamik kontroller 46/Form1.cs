

namespace dinamik_kontroller_46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int k,l,m = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
            string a = comboBox1.Text;
            if (a == "Label")
            {
              
                k += 1;
                label8.Text = k.ToString();

                Label lbl = new Label();

                lbl.Text = "Ahmet Ğ";

                flowLayoutPanel1.Controls.Add(lbl);

            }
            else if (a == "Checkbox")
            {

                l += 1;
                label9.Text = l.ToString();


                CheckBox lis = new CheckBox();
                lis.Text = "Yunus";
                flowLayoutPanel2.Controls.Add(lis);
            }
            else if (a == "Button")
            {

                m+= 1;
                label10.Text = m.ToString();

                Button btn = new Button();
                btn.Text = "Eray";
                btn.Width = 80;
                btn.Height = 40;
                btn.BackColor = Color.SaddleBrown;
                btn.ForeColor= Color.Bisque;
                //btn.Font.Size = ;
                flowLayoutPanel3.Controls.Add(btn);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
