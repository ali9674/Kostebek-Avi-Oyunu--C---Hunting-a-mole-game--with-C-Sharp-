using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics.Eventing.Reader;

public enum game_state { Null,Kolay,Zor,Orta}
namespace Game
{
    
    public partial class Form1 : Form
    {game_state state;
       PictureBox düzey;
        int high_score = 00;
        int puan=00;
        string mainpicture_path;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        SqlConnection conn = new SqlConnection("Data Source=PC\\Alı;Initial Catalog=Şirket Kayıt;Integrated Security=True");

        private void Set(int id)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); openFileDialog.Filter = "JPEG |*.jpg|PNG |*.png|GIF |*.gif"; openFileDialog.Title = "Resim Seç";
            if (openFileDialog.ShowDialog() == DialogResult.OK) mainpicture_path = openFileDialog.FileName.ToString();
            // MessageBox.Show(mainpicture_path);


            FileStream flm = new FileStream(mainpicture_path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(flm);
            byte[] resim = br.ReadBytes((int)flm.Length);
            br.Close(); flm.Close();
            // veri tabanını açılımı                  

            SqlCommand cmd = new SqlCommand("insert into game(resim,id) values (@resim,@ıd)", conn);
            cmd.Parameters.Add("@resim", SqlDbType.Image, resim.Length).Value = resim;
            cmd.Parameters.AddWithValue("@ıd", id.ToString());  // 1 Toprak 2 kolaymod    

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        private void GET(PictureBox pic, string id)
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("Select *from game where id= '" + int.Parse(id) + "'", conn);
            SqlDataReader read = sql.ExecuteReader();

            if (read.Read())
            {
                if (read["resim"] != null)
                {
                    byte[] resim = new byte[0];
                    resim = (byte[])read["resim"];
                    MemoryStream mestro = new MemoryStream(resim);
                    pic.Image = Image.FromStream(mestro);
                    read.Close();
                    conn.Close(); sql.Dispose();


                }
               
            }
            conn.Close ();      
        }

        private void main_Fonk(PictureBox box)
        {
            Random rnd = new Random();
            PictureBox[] pic = new PictureBox[9] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9 };
            //  for (int i = 0; i < pic.Length; i++)
            // {
            //    foreach (Control p in panel2.Controls)
            //    {
            //        if (p is PictureBox)
            //        {
            //            PictureBox x = p as PictureBox;
            //            pic[i] = x;
            //            break;
            //       }

            //    }


            //   }

            pic[rnd.Next(0, pic.Length)].Image = box.Image;//zor mod;    
            pic[rnd.Next(0, pic.Length)].Image = box.Image;
            pic[rnd.Next(0, pic.Length)].Image = box.Image;

        }
        public void picbox_lock()
        { //tüm pic boxları kilidini aç ;
            foreach (Control ctr in panel2.Controls)
            {
                if (ctr is PictureBox)
                {
PictureBox box = ctr as PictureBox;
                box.Enabled = true;

                }
                
            }

        }


        //manibox2 png olmalı


        private void Form1_Load(object sender, EventArgs e)
        {                    //mainbox3 orta seviye mainbox4 = zor seviye
            

            GET(mainbox1, "1");
            GET(mainbox2, "2");
            GET(mainbox4, "4");
            GET(mainbox3, "3");
            //restart_Fonk();
            //   main_Fonk();            
            // veri tabanından çekilen imageler ^
            //mainbox1 = topprak  mainbox2 = kolay mode
            /*



             yuvarlakbuton yb = new yuvarlakbuton();
             yb.Size = new Size(160, 90);
             yb.Location =new Point(40, 240); yb.FlatAppearance.BorderSize = 0;//kalınıl
             yb.Text = "PLAY";
             yb.FlatAppearance.BorderColor = Color.White;
             yb.BackColor = Color.White;
             yb.FlatStyle = FlatStyle.Flat;
             this.Controls.Add(yb);       
             */
            yuvarlakbuton2.Hide();yuvarlakbuton3.Hide();yuvarlakbuton4.Hide();
            restart_Fonk();

        }

        private void yuvarlakbuton2_Click(object sender, EventArgs e)
        {
            MainGame mng = new MainGame();
            mng.MdiParent = this;
            mng.Show();
        }
        private void restart_Fonk() // toprak ile doldur
        {
            foreach (Control verb in panel2.Controls)
            {
                if (verb is PictureBox)
                {
                    PictureBox a = (PictureBox)verb;
                    a.Image = mainbox1.Image;
                  
                }

            }
            Zor.Interval = 1000;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //  Application.Exit();
        }

        private void yuvarlakbuton1_Click(object sender, EventArgs e)
        {

        }

        private void yuvarlakbuton1_Click_1(object sender, EventArgs e)
        {
            yuvarlakbuton2.Show();
            yuvarlakbuton3.Show();
            yuvarlakbuton4.Show();

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            rules_function(pictureBox3);
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rules_function(pictureBox2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rules_function(pictureBox1);
        }
        private void rules_function(PictureBox current)
        {
            if (current.Enabled == false)
            {
                picbox_lock();
            }
            if (current.Enabled == true)
            {
                Control_Fonk(current);
                picbox_lock();
            }

            current.Enabled = false;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            rules_function(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            rules_function(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            rules_function(pictureBox6);
        }
        private void Control_Fonk(PictureBox b)
        {
            if (b.Image == düzey.Image)
            {
                puan += 10;
            }
            
            
          //  timer1.Start();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            rules_function(pictureBox9);

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            rules_function(pictureBox8);

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            rules_function(pictureBox7);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            restart_Fonk();
                      main_Fonk(mainbox4);


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          
            label2.Text = puan.ToString();
        }

        private void zaman_Tick(object sender, EventArgs e)
        {
            

            int temp = int.Parse(label3.Text); temp--;
            label3.Text = temp.ToString();
            if (label3.Text == "0")
            {
                zaman.Stop(); Zor.Stop(); restart_Fonk(); DialogResult answer = MessageBox.Show("Süre Bitti !! Toplam Puan : " + label2.Text + "\n \n" + "Yeniden Oynamak İstermisin","Bilgi",MessageBoxButtons.YesNoCancel);

                if (answer == DialogResult.Yes)
                {
                    if (state == game_state.Zor)
                        Zor.Start();
                    else if (state == game_state.Kolay)
                        Kolay.Start();
                    else if (state == game_state.Orta)
                        Orta.Start();


                   
                    if (puan > high_score)
                    {
                        high_score = puan; label6.Text = high_score.ToString(); 
                    }
                        puan = 0;
                    puan_update.Start(); label3.Text = "60";
                    zaman.Start();
                }
                else if (answer == DialogResult.No)
                {
                    zaman.Stop(); // GO main menu
                    panel1.Show();
                    label3.Text = "60";
                    puan = 0;
                    panel1.BringToFront();
                }
                else if (answer == DialogResult.Cancel)
                {
                    Application.Exit();     
                }

            }

        }

        private void yuvarlakbuton3_Click(object sender, EventArgs e)
        {
            düzey = mainbox4;
            Zor.Start();
            panel1.Hide();
            state = game_state.Zor;
            MessageBox.Show(" Köstebek Toprağa Tamamen Girene Kadar Yakalanabilir", "Uyarı");
            puan_update.Start();
            zaman.Start();
        }

        private void Orta_Tick(object sender, EventArgs e)
        {
            restart_Fonk();
            main_Fonk(mainbox3);
        }

        private void Kolay_Tick(object sender, EventArgs e)
        {
            
            restart_Fonk();
            main_Fonk(mainbox2);
        }

        private void yuvarlakbuton2_Click_1(object sender, EventArgs e)
        {
            düzey = mainbox2;
            Kolay.Start();
            state = game_state.Kolay;
            panel1.Hide();
            MessageBox.Show(" Köstebek Toprağa Tamamen Girene Kadar Yakalanabilir", "Uyarı");
            puan_update.Start();
            zaman.Start();
        }

        private void yuvarlakbuton4_Click(object sender, EventArgs e)
        {
            düzey = mainbox3;
            Orta.Start();
            state = game_state.Orta;
            panel1.Hide();
            MessageBox.Show(" Köstebek Toprağa Tamamen Girene Kadar Yakalanabilir", "Uyarı");
            puan_update.Start();
            zaman.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Set(2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Set(2);
        }
    }
    public class yuvarlakbuton : Button
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(new Rectangle(Point.Empty,this.Size));
            Region  = new Region(path);   
            
        }


    }
}
