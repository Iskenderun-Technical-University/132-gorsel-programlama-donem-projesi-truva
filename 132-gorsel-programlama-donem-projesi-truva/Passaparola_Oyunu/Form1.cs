using System;

namespace Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CEVAP_Enter(object sender, EventArgs e)
        {

        }
        //
        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {   
            //
            if(e.KeyCode == Keys.Enter)
            {
                switch(soruno)
                {
                    // if k�sm�nda cevab�n kar��la�t�rmas� yap�l�r ve cevab�n dogru olmas� durumunda if bloguna girilir,  dogru say�s� 1 artt�r�l�r ve kutucuk ye�ile boyan�r
                    // olmas� durumunda kutucuk ye�ile d�ner ve dogru say�s� 1 artt�r�l�r
                    //cevab�n yanl�� olmas� durumunda else bloguna girilir ,kutucuk k�rm�z�ya boyan�r ve yanl�� say�s� 1 arttt�r�l�r
                    case 1:
                        if (textBox1.Text == "Avanos")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;

                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "Buse")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 3:
                        if (textBox1.Text == "Chp")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "Dut")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "Egoizm")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "Fare")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "Ganyan")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "Hayat�m")

                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "Isl�k")

                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label9.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "�ris")

                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label10.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox11.Text == "Jandarma")

                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "Kurallar")

                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "Lahmacun")

                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "Maa�")

                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "Nefes")

                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "Oru�")

                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "Periskop")

                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "Ruj")

                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "S harfi")

                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "Talim")

                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "U�urtma")

                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "Vakit")

                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "Yumurta")

                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "Z�rafa")

                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;



                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //Bir sonraki  soruya ge�mek i�in soru say�s� artt�r�l�r
            linkLabel1.Text = "Sonraki";
            soruno++;
            //Soru ekrana bast�r�l�r
            this.Text = soruno.ToString();

            //Sorular S�ras�yla ekrana getirilir ve sonraki butonuna t�kland�g�nda diger soruya ge�ilir
            if (soruno == 1)
            {
                richTextBox1.Text = "Nev�ehir'in ��mlek yap�m�yla �nl� il�esi?";
                //
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Eski dilde �p�c�k manas�na gelen isim?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "1923'de Mustafa Kemal taraf�ndan kurulan siyasi parti?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Serilir has�r gibi, s�r�l�r esir gibi.?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Bireysel ��karlar�n, ba�kalar�n�n ��karlar�ndan �st�n tutulmas�?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Kanalizasyonda ya�ayan b�y�k kulakl� hayvan?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "At yar��lar�nda kazanan at.";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Yolunda gitmeyen tek �ey ?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "�al�nd��� halde g�r�lmeyen �ey nedir?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "G�z�m renkli k�sm�? ";
                button10.BackColor = Color.Yellow;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "K�ydeki emniyet kuvveti b�l�m� ?";
                button11.BackColor = Color.Yellow;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "�i�nenen ama yutulmayan �ey nedir??";
                button12.BackColor = Color.Yellow;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Hangi macunla di� f�r�alanmaz ? ";
                button13.BackColor = Color.Yellow;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "En h�zl� yenilen �ey nedir?";
                button14.BackColor = Color.Yellow;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "T�yden daha hafiftir ama d�nyan�n en g��l� insan� bile uzun s�re tutamaz";
                button15.BackColor = Color.Yellow;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Dokunmadan tutulan �ey nedir?";
                button16.BackColor = Color.Yellow;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Denizalt�larda su y�zeyini g�rmeye yarayan metal boru?";
                button17.BackColor = Color.Yellow;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Bilmece bildirmece dudak �st�nde kayd�rmaca.";
                button18.BackColor = Color.Yellow;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Sende var, bende yok. Sabahta var, ak�amda yok";
                button19.BackColor = Color.Yellow;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Uygulamal� olarak yap�lan askerlik e�itimi";
                button20.BackColor = Color.Yellow;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "�p ba�lad�m sopaya u�tu gitti havaya.";
                button21.BackColor = Color.Yellow;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Hi� ceza al�nmadan �ld�r�len �ey nedir?";
                button22.BackColor = Color.Yellow;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "K�r�ld��� zaman kullan�labilen �ey nedir?";
                button23.BackColor = Color.Yellow;
            }
          
            if (soruno == 24)
            {
                richTextBox1.Text = "Siyah beyaz benekli, y�r�yen merdiven sanki";
                button24.BackColor = Color.Yellow;
            }


        }
    }
}