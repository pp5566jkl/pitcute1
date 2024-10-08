namespace pitcute1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "圖像文件(JPeg, Gif, Bmp, etc.)|.jpg;*jpeg;*.gif;*.bmp;*.tif;*.tiff;*.png|所有文件(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Bitmap MyBitmap = new Bitmap(openFileDialog1.FileName);
                    this.pictureBox1.Image = MyBitmap;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "訊息顯示");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Height = this.pictureBox1.Image.Height;
                int Width = this.pictureBox1.Image.Width;
                Bitmap newBitmap2 = new Bitmap(Width, Height);
                Bitmap newBitmap3 = new Bitmap(Width, Height);
                Bitmap newBitmap4 = new Bitmap(Width, Height);
                Bitmap oldBitmap = (Bitmap)this.pictureBox1.Image;
                Color pixel;
                for (int x = 0; x < Width; x++)
                    for (int y = 0; y < Height; y++)
                    {
                        pixel = oldBitmap.GetPixel(x, y);
                        int r, g, b;
                        r = pixel.R;
                        g = pixel.G;
                        b = pixel.B;
                        
                        newBitmap2.SetPixel(x, y, Color.FromArgb(r, 0, 0));
                        newBitmap3.SetPixel(x, y, Color.FromArgb(0, g, 0));
                        newBitmap4.SetPixel(x, y, Color.FromArgb(0, 0, b));
                    }
                this.pictureBox2.Image = newBitmap2;
                this.pictureBox3.Image = newBitmap3;
                this.pictureBox4.Image = newBitmap4;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "訊息顯示");
            }
        }
    }
}