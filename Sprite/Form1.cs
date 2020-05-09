using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprite
{
    public partial class SpriteNDS : Form
    {
        public SpriteNDS()
        {
            InitializeComponent();
            /*
            //UPDATER
            WebClient webClient = new WebClient();
            try
            {
                if (!webClient.DownloadString("https://pastebin.com/raw/7PZd8stk").Contains("1.0"))
                {
                    if (MessageBox.Show("Update available", "SpriteNDSUpdater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://github.com/Asiern/Sprite/releases");
                    }
                    else
                    {

                    }
                }
            }
            finally { }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Path = null;
        }

        //LOAD IMAGE 
        public Bitmap loadimage(String Path)
        {
            if (Path == null) 
            {
                throw new ImageNotSelected();
            }

            Bitmap image = new Bitmap(Path, true);

            if ((image.Width != 16 || image.Height != 16) && (image.Width != 32 || image.Height != 32) )
            {
                throw new FileNotSupported();
            }
            Console.WriteLine(image.Size);
            return image;
        }

        //LOAD PIXELS 16
        public List<pixel> loadpixels16()
        {
            Bitmap image = loadimage(Properties.Settings.Default.Path);
            
            List<pixel> pixellist = new List<pixel>();
            List<pixel> c1 = new List<pixel>();
            List<pixel> c2 = new List<pixel>();
            List<pixel> c3 = new List<pixel>();
            List<pixel> c4 = new List<pixel>();

            //LOAD PIXEL LIST
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {                   
                    pixellist.Add(new pixel(j, i, image.GetPixel(j, i)));
                    printpixel(new pixel(j, i, image.GetPixel(j, i)));
                }
            }

            //SPLIT PIXEL LIST INTO C's
            foreach (pixel p in pixellist)
            {
                //C1
                if (p.getX() < 8 && p.getY() < 8)
                {
                    c1.Add(p);
                }
                //C2
                if (p.getX() > 7 && p.getY() < 8)
                {
                    c2.Add(p);
                }
                //C3
                if (p.getX() < 8 && p.getY() > 7)
                {
                    c3.Add(p);
                }
                //C4
                if (p.getX() > 7 && p.getY() > 7)
                {
                    c4.Add(p);
                }
                
            }
           
            //CLEAN PIXEL LIST
            pixellist.Clear();

            //LOAD C1
            foreach(pixel p in c1)
            {
                pixellist.Add(p);
            }
            //LOAD C2
            foreach (pixel p in c2)
            {
                pixellist.Add(p);
            }
            //LOAD C3
            foreach (pixel p in c3)
            {
                pixellist.Add(p);
            }
            //LOAD C4
            foreach (pixel p in c4)
            {
                pixellist.Add(p);
            }


            
            
            return pixellist;
        }

        //LOAD PIXELS 32
        public List<pixel> loadpixels32()
        {
            Bitmap image = loadimage(Properties.Settings.Default.Path);

            List<pixel> pixellist = new List<pixel>();
            List<pixel> c1 = new List<pixel>();
            List<pixel> c2 = new List<pixel>();
            List<pixel> c3 = new List<pixel>();
            List<pixel> c4 = new List<pixel>();
            List<pixel> c5 = new List<pixel>();
            List<pixel> c6 = new List<pixel>();
            List<pixel> c7 = new List<pixel>();
            List<pixel> c8 = new List<pixel>();
            List<pixel> c9 = new List<pixel>();
            List<pixel> c10 = new List<pixel>();
            List<pixel> c11 = new List<pixel>();
            List<pixel> c12 = new List<pixel>();
            List<pixel> c13 = new List<pixel>();
            List<pixel> c14 = new List<pixel>();
            List<pixel> c15 = new List<pixel>();
            List<pixel> c16 = new List<pixel>();

            //LOAD PIXEL LIST
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    pixellist.Add(new pixel(j, i, image.GetPixel(j, i)));
                    
                }
            }

            //SPLIT PIXEL LIST INTO C's
            foreach (pixel p in pixellist)
            {
                //C1
                if (p.getX() < 8 && p.getY() < 8)
                {
                    c1.Add(p);
                }
                //C2
                if (p.getX() > 7 && p.getX() < 16 && p.getY() < 8)
                {
                    c2.Add(p);
                }
                //C3
                if (p.getX() > 15 && p.getX() < 24 && p.getY() < 8)
                {
                    c3.Add(p);
                }
                //C4
                if (p.getX() > 23 && p.getX() < 32 && p.getY() < 8 )
                {
                    c4.Add(p);
                }

                //C5
                if (p.getX() < 8 && p.getY() > 7 && p.getY() < 16)
                {
                    c5.Add(p);
                }
                //C6
                if (p.getX() > 7 && p.getX() < 16 && p.getY() > 7 && p.getY() < 16)
                {
                    c6.Add(p);
                }
                //C7
                if (p.getX() > 15 && p.getX() < 24 && p.getY() > 7 && p.getY() < 16)
                {
                    c7.Add(p);
                }
                //C8
                if (p.getX() > 23 && p.getX() < 32 && p.getY() > 7 && p.getY() < 16)
                {
                    c8.Add(p);
                }


                //C9
                if (p.getX() < 8 && p.getY() > 15 && p.getY() < 24)
                {
                    c9.Add(p);
                }
                //C10
                if (p.getX() > 7 && p.getX() < 16 && p.getY() > 15 && p.getY() < 24)
                {
                    c10.Add(p);
                }
                //C11
                if (p.getX() > 15 && p.getX() < 24 && p.getY() > 15 && p.getY() < 24)
                {
                    c11.Add(p);
                }
                //C12
                if (p.getX() > 23 && p.getX() < 32 && p.getY() > 15 && p.getY() < 24)
                {
                    c12.Add(p);
                }



                //C13
                if (p.getX() < 8 && p.getY() > 23 && p.getY() < 32)
                {
                    c13.Add(p);
                }
                //C14
                if (p.getX() > 7 && p.getX() < 16 && p.getY() > 23 && p.getY() < 32)
                {
                    c14.Add(p);
                }
                //C15
                if (p.getX() > 15 && p.getX() < 24 && p.getY() > 23 && p.getY() < 32)
                {
                    c15.Add(p);
                }
                //C16
                if (p.getX() > 23 && p.getX() < 32 && p.getY() > 23 && p.getY() < 32)
                {
                    c16.Add(p);
                }



            }

            //CLEAN PIXEL LIST
            pixellist.Clear();

            //LOAD C1
            Console.WriteLine("C1");
            foreach (pixel p in c1)
            {
                pixellist.Add(p);
                printpixel(p);
            }
            //LOAD C2
            Console.WriteLine("C2");
            foreach (pixel p in c2)
            {
                pixellist.Add(p);
                printpixel(p);
            }
            //LOAD C3
            Console.WriteLine("C3");
            foreach (pixel p in c3)
            {
                pixellist.Add(p);
                printpixel(p);
            }
            //LOAD C4
            Console.WriteLine("C4");
            foreach (pixel p in c4)
            {
                pixellist.Add(p);
                printpixel(p);
            }
            //LOAD C5
            Console.WriteLine("C5");
            foreach (pixel p in c5)
            {
                pixellist.Add(p);
                printpixel(p);
            }
            //LOAD C6
            Console.WriteLine("C6");
            foreach (pixel p in c6)
            {
                pixellist.Add(p);
                printpixel(p);
            }
            //LOAD C7
            Console.WriteLine("C7");
            foreach (pixel p in c7)
            {
                pixellist.Add(p);
                printpixel(p);
            }
            //LOAD C8
            Console.WriteLine("C8");
            foreach (pixel p in c8)
            {
                pixellist.Add(p);
                printpixel(p);
            }
            //LOAD C9
            foreach (pixel p in c9)
            {
                pixellist.Add(p);
            }
            //LOAD C10
            foreach (pixel p in c10)
            {
                pixellist.Add(p);
            }
            //LOAD C11
            foreach (pixel p in c11)
            {
                pixellist.Add(p);
            }
            //LOAD C12
            foreach (pixel p in c12)
            {
                pixellist.Add(p);
            }
            //LOAD C13
            foreach (pixel p in c13)
            {
                pixellist.Add(p);
            }
            //LOAD C14
            foreach (pixel p in c14)
            {
                pixellist.Add(p);
            }
            //LOAD C15
            foreach (pixel p in c15)
            {
                pixellist.Add(p);

            }
            //LOAD C16
            foreach (pixel p in c16)
            {
                pixellist.Add(p);
            }

            return pixellist;
        }

        //PRINT PIXEL COORDINATES
        public void printpixel(pixel p)
        {
            Console.WriteLine(p.getX()+","+p.getY() + " ");
        }

        //PRINT LIST<PIXEL>
        public void printlist(List<pixel> l)
        {
            String s ="";
            foreach(pixel p in l){
                s += p.getPalleteindex().ToString() + ",";
            }
            textBox1.Text = s;
        }
       
        //PRINT PALLETE
        public void printPallete(List<Color> Pallete)
        {
            String s = "";
            foreach (Color c in Pallete)
            {
                s += "SPRITE_PALETTE["+ Pallete.IndexOf(c).ToString()+ "] = RGB15("+(c.R*31/255).ToString()+","+(c.G * 31 / 255).ToString()+","+(c.B * 31 / 255).ToString()+");@";
            }
            textBox2.Text = s.Replace("@", System.Environment.NewLine);
        }
        
        //LOAD PALLETE
        public List<Color> loadPallete(List<pixel> pixellist)
        {
            List<Color> Pallete = new List<Color>();
            foreach (pixel p in pixellist)
            {
                if (Pallete.Contains(p.getColor()))
                {
                    p.setPalleteindex(Pallete.IndexOf(p.getColor()));
                }
                else
                {
                    Pallete.Add(p.getColor());
                    p.setPalleteindex(Pallete.IndexOf(p.getColor()));
                }
            }
            return Pallete;
        }

        //MAIN
        public void main()
        {
            try
            {
                List<pixel> pixellist;
                if (loadimage(Properties.Settings.Default.Path).Width == 16)
                {
                    pixellist = loadpixels32();
                }
                else
                {
                    pixellist = loadpixels16();
                }
                
                List<Color> Pallete = new List<Color>();
                Pallete = loadPallete(pixellist);
                printlist(pixellist);
                printPallete(Pallete);
            }
            catch(FileNotSupported ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ImageNotSelected ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //LOAD BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Path = openFileDialog.FileName.ToString();
                Properties.Settings.Default.Save();
                pictureBox1.Image = new Bitmap(Properties.Settings.Default.Path);
            }
        }

        //RUN BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            main();
        }

        
    }
}
