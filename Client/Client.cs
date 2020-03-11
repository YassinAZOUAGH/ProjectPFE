using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;




namespace Client
{
    public partial class Client : Form 
    {

        public Point current = new Point();
        public Point old = new Point();
        public Graphics g;
        public Pen p = new Pen(Color.Black, 5);
        SimpleTcpClient client;
        String msg;
        private bool butnErasser = false;
        private bool butnPen = false;
        string ClearClicked = null;
        Boolean PanelDrawingClicked;
        int xCurrent, yCurrent, xOld, yOld;
        List<string> ListXcurrent , ListYcurrent, ListXold, ListYold;


        //private Socket socket;
        public Client()
        {
            InitializeComponent();
            g = PanelDrawingClient.CreateGraphics();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            


        }
        

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new SimpleTcpClient();
                //client.StringEncoder = Encoding.UTF8;
                string ip = Convert.ToString(txtHostClient.Text);
                int port = Convert.ToInt32(txtPortClient.Text);
                client.Connect(ip, port);
                client.DataReceived += Client_DataSender;
               // client.DataReceived += Client_DataReceivedDraw;
            }
            catch (Exception ex)
            {
              // Console.WriteLine("Listen thread exception!! " + ex.Message);
            }

        }

       /* private void Client_DataReceivedDraw(object sender, SimpleTCP.Message DrawMsg)
        {
            txtMessageClient.Invoke((MethodInvoker)delegate () //  invoquer une zone de texte à partir d'un autre fil
            {
                txtMessageClient.Text += DrawMsg.MessageString;
    
                //e.ReplyLine(string.Format("You said :{0}", e.MessageString));
                Console.WriteLine("Listen thread exception! " + DrawMsg.MessageString);
                //azouagh

            });
        }*/

        private void Client_DataSender(object sender, SimpleTCP.Message e)
        {
            txtStatusClient.Invoke((MethodInvoker)delegate () 
             {
                 txtStatusClient.Text += e.MessageString;

             });


        }

        private void btnSend_Click(object sender, EventArgs ee)
        {
            /*try {
                // client.WriteLineAndGetReply(txtMessage.Text, TimeSpan.FromSeconds(0));
                /////client.WriteLineAndGetReply(msg, TimeSpan.FromSeconds(0));
               client.WriteLineAndGetReply(msg, TimeSpan.FromSeconds(0));
                // txtMessage.Text = "";
            }

            catch (Exception ex)
            {
                Console.WriteLine("Listen thread exception! " + ex.Message);
            }*/
        }

        /* --------------------------------------------------- Paint ---------------------------------------------  */
        private void enregistrerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(PanelDrawingClient.Width, PanelDrawingClient.Height); // prendre les dimension de zonz de dessin 
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rec = PanelDrawingClient.RectangleToScreen(PanelDrawingClient.ClientRectangle);
            g.CopyFromScreen(rec.Location, Point.Empty, PanelDrawingClient.Size); // faire screen de zone de dessin
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Png files|*.png |jpeg files|*.jpg|bitmaps|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                bmp.Save(s.FileName);
            }
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Png files|*.png |jpeg files|*jpg|bitmaps|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                PanelDrawingClient.BackgroundImage = (Image)Image.FromFile(o.FileName).Clone();
            }
        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                p.Color = cd.Color;
            }

             
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PanelDrawingClient.Invalidate();
            ClearClicked = "clear";
           
        }

        private void PanelDrawing_MouseDown(object sender, MouseEventArgs e)
        {
          
            old = e.Location;
 
            //Console.WriteLine("ddddd");

            if (radioButton1.Checked) { p.Width = 1; }
            else if (radioButton2.Checked) { p.Width = 4; }
            else if (radioButton3.Checked) { p.Width = 10; }
            else if (radioButton4.Checked) { p.Width = 15; }
            else if (radioButton5.Checked) { p.Width = 20; }
   }

   
        public void PanelDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
          {

                
                
                current = e.Location;
               // Console.WriteLine("currentClient " + current);
                String point = current.X.ToString();
                point = point + " ";
                point =point+current.Y.ToString();
                point = point + " ";
                point += p.Color.ToString();
                point += " ";
                point = point + p.Width;
                point += " ";
                point += PanelDrawingClicked;
                point += " ";
 
                g.DrawLine(p, old, current);    
                point += old.X.ToString();
                point += " ";
                point += old.Y.ToString();
                point += " ";        
                msg = point;   //  <<------------------------- Message envoyer au serveur
                //Console.WriteLine("cuuurrent" + current);
                old = current;


                // les coordonnées 
                ListXcurrent = new List<string>();
                ListYcurrent = new List<string>();
                ListXold = new List<string>();
                ListYold = new List<string>();
                String LesXcurrent = current.X.ToString();
                String LesYcurrent = current.Y.ToString();
                String LesXold = old.X.ToString();
                String LesYold = old.X.ToString();
                ListXcurrent.Add((LesXcurrent));
                ListYcurrent.Add((LesYcurrent));
                ListXold.Add((LesXold));
                ListYold.Add((LesYold));

                /*
                 ListXcurrent.ForEach(Print);
                 void Print(string s)
                  {
                     // Console.WriteLine(s);
                  }
                  */
                txtMessageClient.Text = msg;
               
                try
                {
                    client.WriteLineAndGetReply(msg , TimeSpan.FromSeconds(0));
                    //client.WriteLine(msg);
                    
                }

                catch (Exception ex)
                {
                   //Console.WriteLine("Listen thread exception! " + ex.Message);
                }


               

                Client Objet = new Client();
              //  Objet.Coordinates(); // Affiche 



            }

        }
        public void Coordinates()
        {
            Console.WriteLine("mon objetvvvvvvvvv");
        }

        public Client(byte[] Data) { }


        public void PenDraw_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                p.Color = cd.Color;
            }

        }

        public void Eraser_Click(object sender, EventArgs e)
        {
           
            p.Color = Color.White;
        }


    }
}
