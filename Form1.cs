using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
namespace SampleImageWatermark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        string imageLocation = "";
        string waterMark = " G";
        Image img, img2;
        Graphics graphic;
        
        private void Disable_Buttons()
        {
           if(pictureBox1 != null)
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
        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| Png files(*.png)|*.png| All Files(*.*)|*.*";

                WaterMarkText.Text = waterMark;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation  = dialog.FileName;
                    img = Image.FromFile(imageLocation);

                    
                    Bitmap indexedImage = new Bitmap(img);

                    graphic = Graphics.FromImage(indexedImage);

                    // Draw the contents of the original bitmap onto the new bitmap.
                    graphic.DrawImage(img, 0, 0, img.Width, img.Height);
                    img = indexedImage;
                    pictureBox1.Image = img;
                    img2 = img;
                    pictureBox2.Image = img2;
                    Disable_Buttons();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error occurred","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(imageLocation, ImageFormat.Jpeg);
        }

        private void TopLeftButton_Click(object sender, EventArgs e)
        {
            img = Image.FromFile(imageLocation);


            Bitmap indexedImage = new Bitmap(img);

            graphic = Graphics.FromImage(indexedImage);
            graphic.DrawImage(img, 0, 0, img.Width, img.Height);
            img = indexedImage;
            img2 = img;
            pictureBox2.Image = img2;
            //This is the font for your watermark
            int countOfChar = waterMark.Length;
            int size = (img.Width / 2 + img.Height / 2) / countOfChar;
            Font myFont = new Font("Arial", size, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.White);

            //This gets the size of the graphic

            SizeF textSize = graphic.MeasureString(waterMark, myFont);

            // Code for writing text on the image and showing its postion on images.
            PointF pointF = new PointF(0, 0);
            pictureBox2.Image = img2;
            graphic.DrawString(waterMark, myFont, brush, pointF);
        }

        private void TopMiddleButton_Click(object sender, EventArgs e)
        {

            img = Image.FromFile(imageLocation);


            Bitmap indexedImage = new Bitmap(img);

            graphic = Graphics.FromImage(indexedImage);
            graphic.DrawImage(img, 0, 0, img.Width, img.Height);
            img = indexedImage;
            img2 = img;
            pictureBox2.Image = img2;

            //This is the font for your watermark
            int countOfChar = waterMark.Length;
            int size = (img.Width / 2 + img.Height / 2) / countOfChar;
            Font myFont = new Font("Arial", size, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.White);

            //This gets the size of the graphic

            SizeF textSize = graphic.MeasureString(waterMark, myFont);

            // Code for writing text on the image and showing its postion on images.
            var x = ((img.Width / 2) - (textSize.Width / 2));
            PointF pointF = new PointF(x, 0);
            pictureBox2.Image = img2;
            graphic.DrawString(waterMark, myFont, brush, pointF);
        }

        private void TopRightButton_Click(object sender, EventArgs e)
        {
            img = Image.FromFile(imageLocation);


            Bitmap indexedImage = new Bitmap(img);

            graphic = Graphics.FromImage(indexedImage);
            graphic.DrawImage(img, 0, 0, img.Width, img.Height);
            img = indexedImage;
            img2 = img;
            pictureBox2.Image = img2;

            //This is the font for your watermark
            int countOfChar = waterMark.Length;
            int size = (img.Width / 2 + img.Height / 2) / countOfChar;
            Font myFont = new Font("Arial", size, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.White);

            //This gets the size of the graphic

            SizeF textSize = graphic.MeasureString(waterMark, myFont);
            var x = (img.Width - textSize.Width);
            // Code for writing text on the image and showing its postion on images.
            PointF pointF = new PointF(x, 0);
            pictureBox2.Image = img2;
            graphic.DrawString(waterMark, myFont, brush, pointF);
        }

        private void BottomLeftButton_Click(object sender, EventArgs e)
        {
            img = Image.FromFile(imageLocation);


            Bitmap indexedImage = new Bitmap(img);

            graphic = Graphics.FromImage(indexedImage);
            graphic.DrawImage(img, 0, 0, img.Width, img.Height);
            img = indexedImage;
            img2 = img; ;
            pictureBox2.Image = img2;

            //This is the font for your watermark
            int countOfChar = waterMark.Length;
            int size = (img.Width / 2 + img.Height / 2) / countOfChar;
            Font myFont = new Font("Arial", size, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.White);

            //This gets the size of the graphic

            SizeF textSize = graphic.MeasureString(waterMark, myFont);
            // Code for writing text on the image and showing its postion on images.
            var y = (img.Height - textSize.Height);
            PointF pointF = new PointF(0, y);
            pictureBox2.Image = img2;
            graphic.DrawString(waterMark, myFont, brush, pointF);
        }

        private void BottomMiddleButton_Click(object sender, EventArgs e)
        {
            img = Image.FromFile(imageLocation);
            Bitmap indexedImage = new Bitmap(img);

            graphic = Graphics.FromImage(indexedImage);
            graphic.DrawImage(img, 0, 0, img.Width, img.Height);
            img = indexedImage;
            img2 = img;
            pictureBox2.Image = img2;
            //This is the font for your watermark
            int countOfChar = waterMark.Length;
            int size = (img.Width / 2 + img.Height / 2) / countOfChar;
            Font myFont = new Font("Arial", size, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.White);

            //This gets the size of the graphic

            SizeF textSize = graphic.MeasureString(waterMark, myFont);
            // Code for writing text on the image and showing its postion on images.
            var x = ((img.Width / 2) - (textSize.Width / 2));
            var y = (img.Height - textSize.Height);
            PointF pointF = new PointF(x, y);
            pictureBox2.Image = img2;
            graphic.DrawString(waterMark, myFont, brush, pointF);
        }

        private void WaterMarkText_TextChanged(object sender, EventArgs e)
        {
            waterMark = WaterMarkText.Text;
        }

        private void BottomRightButton_Click(object sender, EventArgs e)
        {
            img = Image.FromFile(imageLocation);


            Bitmap indexedImage = new Bitmap(img);

            graphic = Graphics.FromImage(indexedImage);
            graphic.DrawImage(img, 0, 0, img.Width, img.Height);
            img = indexedImage;
            img2 = img;
            pictureBox2.Image = img2;

            //This is the font for your watermark
            int countOfChar = waterMark.Length;
            int size = (img.Width / 2 + img.Height / 2) / countOfChar;
            Font myFont = new Font("Arial", size, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush brush = new SolidBrush(Color.White);

            //This gets the size of the graphic

            SizeF textSize = graphic.MeasureString(waterMark, myFont);
            // Code for writing text on the image and showing its postion on images.
            var x = (img.Width - textSize.Width);
            var y = (img.Height - textSize.Height);
            PointF pointF = new PointF(x, y);
            pictureBox2.Image = img2;
            graphic.DrawString(waterMark, myFont, brush, pointF);
        }

      
    }

}