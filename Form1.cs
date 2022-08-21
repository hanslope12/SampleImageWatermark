using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
namespace SampleImageWatermark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string imageLocation = "";
        string waterMark = " ";
        Image img, img2;
        Graphics graphic;
        private void Disable_Buttons()
        {
            if (pictureBox1 != null)
            {
                TopLeftButton.Enabled = true;
                TopMiddleButton.Enabled = true;
                TopRightButton.Enabled = true;
                BottomLeftButton.Enabled = true;
                BottomMiddleButton.Enabled = true;
                BottomRightButton.Enabled = true;
                Save.Enabled = true;
            }
        }

        private void Write_WaterMark(float x, float y, int g)
        {
            img = Image.FromStream(new MemoryStream(File.ReadAllBytes(imageLocation)));
            Bitmap indexedImage = new Bitmap(img);

            graphic = Graphics.FromImage(indexedImage);
            graphic.DrawImage(img, 0, 0, img.Width, img.Height);
            img = indexedImage;
            img2 = img;
            pictureBox2.Image = img2;
            graphic.SmoothingMode = SmoothingMode.AntiAlias & SmoothingMode.HighQuality;
            //This is the font for your watermark
            int countOfChar = waterMark.Length;
            int size = (img.Width / 2 + img.Height / 2) / countOfChar;
            Font myFont = new Font("Arial", size, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.White);

            //This gets the size of the graphic
            SizeF textSize = graphic.MeasureString(waterMark, myFont);
            StringFormat format = new StringFormat();
            if(g == 1)
            {
                format.Alignment = StringAlignment.Near;
            }
            else if(g==2)
            {
                format.Alignment = StringAlignment.Center;
            }
            else if(g==3)
            {
                format.Alignment = StringAlignment.Far;
            }

            // Code for writing text on the image and showing its postion on images.
            PointF pointF = new PointF(x, y);
            pictureBox2.Image = img2;
            graphic.DrawString(waterMark, myFont, brush, pointF,format);
        }
        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| Png files(*.png)|*.png| All Files(*.*)|*.*";

                WaterMarkText.Text = waterMark;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    img =Image.FromStream(new MemoryStream(File.ReadAllBytes(imageLocation)));
                   // img = Image.FromFile(imageLocation);
                    Bitmap indexedImage = new Bitmap(img);

                    graphic = Graphics.FromImage(indexedImage);
                    graphic.DrawImage(img, 0, 0, img.Width, img.Height);
                    img = indexedImage;
                    pictureBox1.Image = img;
                    img2 = img;
                    pictureBox2.Image = img2;
                    graphic.SmoothingMode = SmoothingMode.AntiAlias & SmoothingMode.HighQuality;
                    Disable_Buttons();
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
              File.Delete(imageLocation);
              img2.Save(imageLocation, ImageFormat.Jpeg);
              img2.Dispose();
              img.Dispose();
        }

        private void TopLeftButton_Click(object sender, EventArgs e)
        {
            Write_WaterMark(0, 0,1);
        }

        private void TopMiddleButton_Click(object sender, EventArgs e)
        {

            var x = (img.Width/2);
            Write_WaterMark(x, 0,2);
        }

        private void TopRightButton_Click(object sender, EventArgs e)
        {

            var x = (img.Width);
            Write_WaterMark(x, 0,3);
        }

        private void BottomLeftButton_Click(object sender, EventArgs e)
        {
           
            //This is the font for your watermark
            int countOfChar = waterMark.Length;
            int size = (img.Width / 2 + img.Height / 2) / countOfChar;
            Font myFont = new Font("Arial", size, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.White);

            //This gets the size of the graphic

            SizeF textSize = graphic.MeasureString(waterMark, myFont);
            // Code for writing text on the image and showing its postion on images.
            var y = (img.Height - textSize.Height);
            Write_WaterMark(0, y,1);
        }

        private void BottomMiddleButton_Click(object sender, EventArgs e)
        {
            
            //This is the font for your watermark
            int countOfChar = waterMark.Length;
            int size = (img.Width / 2 + img.Height / 2) / countOfChar;
            Font myFont = new Font("Arial", size, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.White);

            //This gets the size of the graphic

            SizeF textSize = graphic.MeasureString(waterMark, myFont);
            // Code for writing text on the image and showing its postion on images.
            var x = (img.Width/2);
            var y = (img.Height - textSize.Height);
            Write_WaterMark(x, y,2);
        }

        private void WaterMarkText_TextChanged(object sender, EventArgs e)
        {
            waterMark = WaterMarkText.Text;
        }

        private void BottomRightButton_Click(object sender, EventArgs e)
        {
            //This is the font for your watermark
            int countOfChar = waterMark.Length;
            int size = (img.Width / 2 + img.Height / 2) / countOfChar;
            Font myFont = new Font("Arial", size, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.White);

            //This gets the size of the graphic

            SizeF textSize = graphic.MeasureString(waterMark, myFont);
            // Code for writing text on the image and showing its postion on images.
            var x = (img.Width);
            var y = (img.Height - textSize.Height);
            Write_WaterMark(x, y, 3);
        }


    }

}