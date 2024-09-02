using System;
using System.Drawing;
using System.Windows.Forms;

namespace 期中專題
{
    public partial class UserControlFish : UserControl
    {
        public int Fish_count = 0;
        public int fishID = 0;
        public int stock = 0;
        private string fish_name;
        private Image productImage;
        public event EventHandler InfoButtonClicked;
        public event EventHandler AddButtonClicked;
        public event EventHandler MinusButtonClicked;
        public event EventHandler TbxChanged;
        

        public UserControlFish()
        {
            InitializeComponent();
            btnAdd.Image = Properties.Resources.Add;
            btnMinus.Image = Properties.Resources.Minus;
            btnInfo.Image = Properties.Resources.Info1;
        }

        public string Fish_name
        {
            get { return fish_name; }
            set
            {
                fish_name = value;
                lblName.Text = fish_name;
            }
        }

        public Image ProductImage
        {
            get { return productImage; }
            set
            {
                productImage = value;
                pbxFish.Image = productImage;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            InfoButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Fish_count <= stock)
            {
                Fish_count += 1;
                tbxCount.Text = Fish_count.ToString();
            }
            AddButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Fish_count > 0)
            {
                Fish_count -= 1;
                tbxCount.Text = Fish_count.ToString();
            }
            MinusButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void tbxCount_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(tbxCount.Text, out int count);
            Fish_count = count;
            if (count > stock)
            {
                Fish_count = stock;
                tbxCount.Text = stock.ToString();
            }
            TbxChanged?.Invoke(this, EventArgs.Empty);
        }
    }


}

