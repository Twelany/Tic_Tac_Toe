using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int player = 2;
        public int turn = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X"; 
                    player++;
                    turn++;
                }
                else
                {
                    button.Text = "O";
                    player++;
                    turn++;
                }
                if(CheckDraw() == true)
                {
                    MessageBox.Show("Its A Draw!");
                    NewGame();
                }
                if(CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("Congradulation, X Wins");
                        s1++;
                       
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("Congradulation, O Wins");
                        s2++;
                       
                        NewGame();
                        
                    }
                }
               
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void NewGame()
        {
            player = 2;
            turn = 0;
            lblXWin.Text = "X: " + s1;
            lblOWin.Text = "0: " + s2;
            lblDraw.Text = "Draw: " + sd;

            A00.Text = A01.Text = A02.Text = A10.Text = A11.Text = A12.Text = A20.Text = A21.Text = A22.Text = "";

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblXWin.Text = "X: " + s1;
            lblOWin.Text = "0: " + s2;
            lblDraw.Text = "Draw: " + sd;

        }
        bool CheckDraw()
        {
            if ((turn == 9) && CheckWinner() == false)
            {
                sd++;
                return true;
                
            }
            else
                return false;

        }
        
        bool CheckWinner()
        {
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && A00.Text != "")
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && A10.Text != "")
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && A20.Text != "")
                return true;

            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && A00.Text != "")
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && A02.Text != "")
                return true;

            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && A00.Text != "")
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && A01.Text != "")
                return true;
            else
                return false;



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void SendMail( string email)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("twelanymudaka@gmail.com", "password");

                MailMessage msg = new MailMessage();
                client.UseDefaultCredentials = false;

                msg.From = new MailAddress("twelanymudaka@gmail.com");
                msg.To.Add(email);

                msg.Subject = "Tic Tac Toe Winner!!";
                msg.Body = "Congradulations!! you the Winner";

                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(msg);
            }
            catch(Exception e)
            {
                MessageBox.Show("Error", e.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
