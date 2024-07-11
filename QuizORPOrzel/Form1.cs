using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace QuizORPOrzel
{
    public partial class Form1 : Form
    {
        private int _ticks;
        public Form1()
        {
            InitializeComponent();
        }
        static string minuty = "";
        static string nick = "";
        int randomowa = 0;
        static int punkty = 0;
        bool wylosowano = false;
        int[] wylosowane = new int[20];
        int y = 0;
        int z = 0;
        bool stop = false;
        void losuj()
        {
            if (wylosowano == false)
            {
                bool jeszcze_raz = false;
                
                for (int i = 0; i < 20; i++)
                {
                    do
                    {
                        jeszcze_raz = false;
                        Random rd = new Random();
                        int rand_num = rd.Next(1, 21);
                        randomowa = rand_num;
                        for (int x = 0; x < 20; x++)
                        {
                            if (rand_num == wylosowane[x])
                            {
                                jeszcze_raz = true;
                            }
                        }
                    }
                    while (jeszcze_raz == true);
                    wylosowane[i] = randomowa;

                }
                wylosowano = true;
                z = wylosowane[y];
                y++;
            }
            else
            {
                z = wylosowane[y];
                y++;
            }
            if (y == 8)
            {
                stop = true;
                button3.Text = "Zakończ";
            }
        }
        void pytanko()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            losuj();
            switch (z)
            {
                case 1:
                    tytul.Text = y+". Ile wyrzutni torped miał ORP Orzeł";
                    radioButton1.Text = "a) 17";
                    radioButton2.Text = "b) 13";
                    radioButton3.Text = "c) 46";
                    radioButton4.Text = "d) 14";
                    break;
                case 2:
                    tytul.Text = y + ". Jaką maksymalną prędkość mógł osiągnąc ORP Orzeł?";
                    radioButton1.Text = "a) 19 węzłów";
                    radioButton2.Text = "b) 20 węzłów";
                    radioButton3.Text = "c) 21 węzłów";
                    radioButton4.Text = "d) 22 węzłów";
                    break;
                case 3:
                    tytul.Text = y + ". We współpracy z jakim krajem powstał okręt?";
                    radioButton1.Text = "a) Francja";
                    radioButton2.Text = "b) Holandia";
                    radioButton3.Text = "c) Niemcy";
                    radioButton4.Text = "d) Rosja";
                    break;
                case 4:
                    tytul.Text = y + ". W ktorym roku podpisano umowę zwodowania statku ORP Orzeł?";
                    radioButton1.Text = "a) 1924";
                    radioButton2.Text = "b) 1935";
                    radioButton3.Text = "c) 1942";
                    radioButton4.Text = "d) 1936";
                    break;
                case 5:
                    tytul.Text = y + ". Kiedy \"Orzeł\" pojawił się w Gdyni? ";
                    radioButton1.Text = "a) 10 lutego 1939";
                    radioButton2.Text = "b) 17 września 1937";
                    radioButton3.Text = "c) 21 listopada 1937";
                    radioButton4.Text = "d) 30 września 1942";
                    break;
                case 6:
                    tytul.Text = y + ". Jak nazywał się plan w którym wziął udział ORP Orzeł?";
                    radioButton1.Text = "a) Korek";
                    radioButton2.Text = "b) Borek";
                    radioButton3.Text = "c) Worek";
                    radioButton4.Text = "d) Norek";
                    break;
                case 7:
                    tytul.Text = y + ". Dlaczego ORP Orzeł nie storpedował pancernika \"Schelswig-Holstein\"?";
                    radioButton1.Text = "a) Nie otrzymał takiego rozkazu";
                    radioButton2.Text = "b) Zabrakło im torped";
                    radioButton3.Text = "c) Rozkaz nie dotarł do załogi";
                    radioButton4.Text = "d) Wyrzutnia torped zostala zniszczona przez przeciwnika";
                    break;
                case 8:
                    tytul.Text = y + ". Gdzie znalazł się \"Orzeł\" 3 wrzesnia?";
                    radioButton1.Text = "a) W Gdańsku";
                    radioButton2.Text = "b) W Szczecinie";
                    radioButton3.Text = "c) Na Helu";
                    radioButton4.Text = "d) W Kołobrzegu";
                    break;
                case 9:
                    tytul.Text = y + ". Co stało sie okrętowi podczas ataku samolotu na Helu?";
                    radioButton1.Text = "a) Bomba głębinowa tylko uszkodziła okręt";
                    radioButton2.Text = "b) Nic";
                    radioButton3.Text = "c) Okręt został całkowicie zniszczony ale nie zatonąl";
                    radioButton4.Text = "d) Przez bombę głębinową okręt zatonął";
                    break;
                case 10:
                    tytul.Text = y + ". Na co zachorował komandor Kłoczkowski?";
                    radioButton1.Text = "a) Na grypę";
                    radioButton2.Text = "b) Na raka";
                    radioButton3.Text = "c) Na tyfus";
                    radioButton4.Text = "d) Na ospę";
                    break;
                case 11:
                    tytul.Text = y + ". W jakiej stoczni zbudowano okręt?";
                    radioButton1.Text = "a) Stocznia Gdańska";
                    radioButton2.Text = "b) De Schelde we Vlissingen";
                    radioButton3.Text = "c) STS Rotterdam";
                    radioButton4.Text = "d) Howaldtswerke";
                    break;
                case 12:
                    tytul.Text = y + ". Gdzie podpisano umowę budowy statku z Holandią?";
                    radioButton1.Text = "a) W Hadze";
                    radioButton2.Text = "b) W Gdańsku";
                    radioButton3.Text = "c) W Rotterdamie";
                    radioButton4.Text = "d) W Amsterdamie";
                    break;
                case 13:
                    tytul.Text = y + ". Kiedy miała miejsce uroczystość wodowania okrętu?";
                    radioButton1.Text = "a) 17 stycznia 1938";
                    radioButton2.Text = "b) 15 grudnia 1937";
                    radioButton3.Text = "c) 17 grudnia 1937";
                    radioButton4.Text = "d) 15 stycznia 1938 ";
                    break;
                case 14:
                    tytul.Text = y + ". Jak nazywa się film o okręcie wydany w 2022 roku?";
                    radioButton1.Text = "a) Ostatni rejs";
                    radioButton2.Text = "b) Ostatnia bitwa";
                    radioButton3.Text = "c) Ostatni patrol";
                    radioButton4.Text = "d) Ostatnia walka";
                    break;
                case 15:
                    tytul.Text = y + ". Kto zastąpił Kłoczkowskiego w akcji ucieczki z Tallina?";
                    radioButton1.Text = "a) Andrzej Piasecki";
                    radioButton2.Text = "b) Marian Mokrski";
                    radioButton3.Text = "c) Jerzy Sonsnowski";
                    radioButton4.Text = "d) Jan Grudziński";
                    break;
                case 16:
                    tytul.Text = y + ". Co było największym wrogiem okrętu na początku ucieczki z Tallina";
                    radioButton1.Text = "a) Ogień ze strony Estończyków";
                    radioButton2.Text = "b) Podwodne skały";
                    radioButton3.Text = "c) Awaria na statku";
                    radioButton4.Text = "d) Brak widoczności";
                    break;
                case 17:
                    tytul.Text = y + ". Kiedy okręt znalazł się w rejonie Gotlandii";
                    radioButton1.Text = "a) 21 września 1939";
                    radioButton2.Text = "b) 20 września 1939";
                    radioButton3.Text = "c) 22 września 1939";
                    radioButton4.Text = "d) 23 września 1939";
                    break;
                case 18:
                    tytul.Text = y + ". Ilu wartowników estońskich załoga porwała w Tallinie?";
                    radioButton1.Text = "a) Żadnego";
                    radioButton2.Text = "b) Jednego";
                    radioButton3.Text = "c) Dwóch";
                    radioButton4.Text = "d) Trzech";
                    break;
                case 19:
                    tytul.Text = y + ". Gdzie załoga chciała przedostać się po ucieczce z Tallina?";
                    radioButton1.Text = "a) Do Wielkiej Brytanii";
                    radioButton2.Text = "b) Do Szwecji";
                    radioButton3.Text = "c) Do Francji";
                    radioButton4.Text = "d) Do Norwegii";
                    break;
                case 20:
                    tytul.Text = y + ". Kiedy załoga zawinęła się do bazy Firth of Forth?";
                    radioButton1.Text = "a) 18 października";
                    radioButton2.Text = "b) 20 października";
                    radioButton3.Text = "c) 21 października";
                    radioButton4.Text = "d) 14 października";
                    break;

            }
        }
        void sprawdz()
        {
            switch (z)
            {
                case 1:
                    if (radioButton3.Checked == true)
                    {
                        punkty++;
                    }
                break;
                case 2:
                    if (radioButton1.Checked == true)
                    {
                        punkty++;
                    }
                break;
                case 3:
                    if (radioButton2.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 4:
                    if (radioButton4.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 5:
                    if (radioButton1.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 6:
                    if (radioButton3.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 7:
                    if (radioButton3.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 8:
                    if (radioButton3.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 9:
                    if (radioButton1.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 10:
                    if (radioButton3.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 11:
                    if (radioButton2.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 12:
                    if (radioButton1.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 13:
                    if (radioButton4.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 14:
                    if (radioButton3.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 15:
                    if (radioButton4.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 16:
                    if (radioButton3.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 17:
                    if (radioButton1.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 18:
                    if (radioButton3.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 19:
                    if (radioButton1.Checked == true)
                    {
                        punkty++;
                    }
                    break;
                case 20:
                    if (radioButton4.Checked == true)
                    {
                        punkty++;
                    }
                    break;

            }
        }
        void podsumowanie()
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            timer1.Stop();
            tytul.Font = new Font("Pacifico", 35, FontStyle.Bold);
            tytul.TextAlign = ContentAlignment.TopCenter;
            switch (punkty)
            {
                case 0:
                    tytul.Text = "Totalna porażka 😔";
                    break;
                case <= 3:
                    tytul.Text = "Mogło być lepiej 😕";
                    break;
                case > 3 and <= 6:
                    tytul.Text = "Dobrze poszło 👍";
                    break;
                case > 6 and < 8:
                    tytul.Text = "Świetnie!";
                    break;
                case 8:
                    tytul.Text = "Geniusz!";
                    break;
            }
            ilepkt.Visible = true;
            ilepkt.Text = punkty.ToString()+"/8";
            minuty = czas.Text;
            czas.Text = "Twój czas: "+minuty;
            czas.Location = new Point(285, 190);
            czas.Size = new Size(230, 60);
            czas.Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
            button3.Visible = false;
            button4.Visible = true;
            StreamWriter StrW = File.AppendText(@"Wyniki.txt");
            StrW.Close();
            StreamReader sr = new StreamReader(@"Wyniki.txt");
            string line1 = sr.ReadLine();
            string[] linia1 = new string[2];
            string[] linia2 = new string[2];
            string[] linia3 = new string[2];
            if (line1 != null)
            {
                linia1 = line1.Split(',');
                label4.Text = linia1[0];
                label7.Text = linia1[1];
                label8.Text = linia1[2];
            }
            string line2 = sr.ReadLine();
            if (line2 != null)
            {
                linia2 = line2.Split(',');
                label5.Text = linia2[0];
                label9.Text = linia2[1];
                label10.Text = linia2[2];
            }
            string line3 = sr.ReadLine();
            if (line3 != null)
            {
                linia3 = line3.Split(',');
                label6.Text = linia3[0];
                label11.Text = linia3[1];
                label12.Text = linia3[2];
            }
            sr.Close();
            
            
            
        }
        public string podajnick()
        {
            return nick;
        }
        public string podajczas()
        {
            return minuty;
        }
        public string podajpunkty()
        {
            return punkty.ToString();
        }
        string losowynick = "";
        void generujnick()
        {
            Random losowanko = new Random();
            int losowy_num1 = losowanko.Next(1, 9);
            switch (losowy_num1)
            {
                case 1:
                    losowynick = "Czerwony";
                    break;
                case 2:
                    losowynick = "Pomarańczowy";
                    break;
                case 3:
                    losowynick = "Żółty";
                    break;
                case 4:
                    losowynick = "Zielony";
                    break;
                case 5:
                    losowynick = "Niebieski";
                    break;
                case 6:
                    losowynick = "Fioletowy";
                    break;
                case 7:
                    losowynick = "Biały";
                    break;
                case 8:
                    losowynick = "Czarny";
                    break;
            }
            int losowy_num2 = losowanko.Next(1, 9);
            switch (losowy_num2)
            {
                case 1:
                    losowynick += "Lew";
                    break;
                case 2:
                    losowynick += "Wieloryb";
                    break;
                case 3:
                    losowynick += "Lis";
                    break;
                case 4:
                    losowynick += "Tygrys";
                    break;
                case 5:
                    losowynick += "Goryl";
                    break;
                case 6:
                    losowynick += "Krokodyl";
                    break;
                case 7:
                    losowynick += "Kangur";
                    break;
                case 8:
                    losowynick += "Słoń";
                    break;
            }
            int losowy_num3 = losowanko.Next(1, 9999);
            losowynick += losowy_num3;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tytul.Text = "Podaj nickname:";
            tekst.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            refresh.Visible = true;
        }

        private void tekst_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tekst.Text == "")
            {
                generujnick();
                nick = losowynick;
            }
            else
            {
                nick = tekst.Text;
            }
            gracz.Text += " " + nick;
            gracz.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
            button3.Text = "Pomiń";
            tekst.Visible = false;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            tytul.Font = new Font("Pacifico", 20, FontStyle.Bold);
            tytul.Size = new Size(800, 200);
            tytul.TextAlign = ContentAlignment.TopLeft;
            pytanko();
            timer1.Start();
            czas.Visible = true;
            refresh.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "Pomiń";
            if (y == 8)
            {
                podsumowanie();
            }
            if (!stop)
            {
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true)
                {
                    sprawdz();
                    pytanko();
                }
                else
                {
                    pytanko();
                }
            }
            else 
            {
                button3.Text = "Zakończ";
                sprawdz();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button3.Text = "Potwierdź";
            }
            if (y == 8)
            {
                button3.Text = "Zakończ";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                button3.Text = "Potwierdź";
            }
            if (y == 8)
            {
                button3.Text = "Zakończ";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                button3.Text = "Potwierdź";
            }
            if (y == 8)
            {
                button3.Text = "Zakończ";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button3.Text = "Potwierdź";
            }
            if (y == 8)
            {
                button3.Text = "Zakończ";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks < 60)
            {
                if (_ticks < 10)
                {
                    czas.Text = "0:0" + _ticks.ToString();
                }
                else
                {
                    czas.Text = "0:" + _ticks.ToString();
                }
            }
            else
            {
                decimal minutnik = _ticks / 60;
                if (_ticks % 60 < 10)
                {
                    czas.Text = Math.Floor(minutnik) + ":0" + (_ticks % 60).ToString();
                }
                else
                {
                    czas.Text = Math.Floor(minutnik) + ":" + (_ticks % 60).ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
            button4.Visible = false;
            tytul.Font = new Font("Pacifico", 25, FontStyle.Bold);
            tytul.Text = "Zapisz wynik lub spróbuj ponownie";
            button5.Visible = true;
            button6.Visible = true;
            tableLayoutPanel1.BringToFront();
            button5.BringToFront();
            button6.BringToFront();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.SteelBlue;
            button6.Enabled = false;
            var mc = new Form1();
            mc.podajnick();
            mc.podajczas();
            int lineCount = File.ReadLines(@"Wyniki.txt").Count();
            if (lineCount == 3)
            {
                var lines = System.IO.File.ReadAllLines(@"C:\Wyniki.txt");
                System.IO.File.WriteAllLines(@"Wyniki.txt", lines.Take(lines.Length - 1).ToArray());
            }
            StreamWriter SW;
            SW = File.AppendText(@"Wyniki.txt");
            SW.WriteLine(mc.podajnick() + ", " + mc.podajczas() + ", " + mc.podajpunkty() + "/8");

            SW.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            generujnick();
            tekst.Text = losowynick;
        }
    }
}