using PdfSharp.Drawing;
using SimpleTCP;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CColor = System.Drawing.Color;
//using XColor = Microsoft.Xna.Framework.Graphics.Color;

namespace TCPIPDemo
{
    public partial class Server : Form
    {
        
        //private Socket socket;
        // private BackgroundWorker MessageReceiver = new BackgroundWorker();
        //private Socket sock;
        //Client clientds = new Client();
        SimpleTcpServer server;
        public Point current = new Point();
        public Point old = new Point();
        public Graphics g;
        public Pen p = new Pen(Color.Black, 5);
        int xCurrent, yCurrent , xOld , yOld;
        string colorString;
        string taille , Clear;
        string PanelClientClicked;
        Point locationCurrent;
        Point locationOld;

        public Server()
        {
            InitializeComponent();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13;
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;  // pour recevoir les messages 
           // server.DataReceived += Server_SenderDraw;
        }

        private void Server_SenderDraw(object sender, SimpleTCP.Message DrawMsg)
        {
            txtStatusServer.Invoke((MethodInvoker)delegate ()
            {
                txtStatusServer.Text += DrawMsg.MessageString;

            });
        }

   
        
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtStatusServer.Invoke((MethodInvoker)delegate () //  invoquer une zone de texte à partir d'un autre fil
            {
                txtStatusServer.Text += e.MessageString;
               // PanelDrawingServer.
                e.ReplyLine(string.Format("You said :{0}", e.MessageString));

                string phrase = e.MessageString;
                string[] words = phrase.Split(' ');
               

                //System.Console.WriteLine("ici c'est : " + words[0] + "  ;  " + words[1] + "  ;  " + words[2]);


                string colorStr = words[3];

                char spearator = ']';
                String[] strlist = colorStr.ToString().Split(spearator);
                

                string colorStr2 = strlist[0];
                char spearator2 = '[';
                String[] strlist2 = colorStr2.ToString().Split(spearator2);

                     //<<--------
              
                xCurrent = int.Parse(words[0]);     //<<--------  Les paramètres à envoyer 
                yCurrent = int.Parse(words[1]);
                xOld = int.Parse(words[6]);
                yOld = int.Parse(words[7]);
                colorString = strlist2[1];   //<<--------
                taille = words[4];           //<<--------

                //   Clear = words[5];

                #region Split Region
                /*       // Taking a string 

                       char spearator = ':';
                         // Int32 count = 2;
                        // using the method 
                         String[] strlist = e.MessageString.ToString().Split(spearator); 


                         foreach (String s in strlist)
                         {
                             Console.WriteLine(s);
                         }

                        x = int.Parse(strlist[0]);  // Pour avoir que les X
                       //int exw = int.Parse(strlist[1]);
                       //int t = int.Parse(strlist[1]);
                       string st = strlist[1];
                       //char separateur = '';
                       char separateur = '+';

                       String[] srtlist2 = st.ToString().Split(separateur); //Split pour avoir Y seulement 

                       foreach (String ss in srtlist2)
                       {
                           Console.WriteLine(ss);
                       }
                            y = int.Parse(srtlist2[0]);

                       char separateurColor = ']';
                       String[] srtlistColor = st.ToString().Split(separateurColor); //Split pour avoir Y seulement 
                       foreach (String colr in srtlistColor)
                       {
                           Console.WriteLine(colr);
                       }
                        colorString = srtlistColor[0];

           */
                #endregion

                //Console.WriteLine("x=  "+x);
                // Console.WriteLine("y=  "+y);

                //  DrawInServer(x,y,colorString,taille);

                PanelClientClicked = words[5];
              
                 
                 locationCurrent = new Point(xCurrent, yCurrent);
                 locationOld = new Point(xOld, yOld);


               
                g = PanelDrawingServer.CreateGraphics();
                current = locationCurrent;
                old = locationOld;
                g.DrawLine(p, current, old);
                current = old;
                








                //old = current;

                CColor clrColor = CColor.FromName(colorString);  // Couleur
                p.Color = clrColor;
                p.Width = float.Parse(taille);
                
   
            });

        }
        public void DrawInServer(int x, int y, string colorString, string taille)
        {
            

            g = PanelDrawingServer.CreateGraphics();
            Point location = new Point(x, y);
            current = location;
            g.DrawLine(p, old, current);
            old = current;

            CColor clrColor = CColor.FromName(colorString);  // Couleur
            p.Color = clrColor;
            p.Width = float.Parse(taille);

            //  if(Clear == "clear") { PanelDrawingServer.Invalidate(); }


        }

        private void btnStar_Click(object sender, EventArgs e)
        {    
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
            server.Start(ip, Convert.ToInt32(txtPort.Text));
            txtStatusServer.Text += "Server starting...";
            // System.Net.IPAddress ip = System.Net.IPAddress.Any;
            // System.Net.IPAddress ip = new System.Net.IPAddress(long.Parse(txtHost.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
        }


    }
}
