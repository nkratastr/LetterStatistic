using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterStatistic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public char charecter;
        public int[] charactercount=new int[31];
        public string stra ="a";
        public string strb = "b";
        public string strc = "c";
        public string strc2 = "ç";
        public string strd = "d";
        public string stre = "e";
        public string strf = "f";
        public string strg = "g";

        public string strg2 = "ğ";
        public string strh = "h";
        public string str2i = "ı";
        public string stri = "i";
        public string strj = "j";
        public string strk = "k";
        public string strl = "l";
        public string strm = "m";

        public string strn = "n";
        public string stro = "o";
        public string stro2 = "ö";
        public string strp = "p";
        public string strr = "r";
        public string strs = "s";
        public string strs2 = "ş";
        public string strt = "t";

        public string stru = "u";
        public string stru2 = "ü";
        public string strv = "v";
        public string stry = "y";
        public string strz = "z";
        public string strspace = " ";
        public string strother;

        public float percentagea;
        public float[] turkishAlphabetPercentage = { 11.92F, 2.84F, 0.96F, 1.16F, 4.71F, 8.91F, 0.46F, 1.25F, 1.13F, 1.21F, 5.11F, 8.60F, 0.03F, 4.68F, 5.92F, 3.75F, 4.49F, 2.48F, 0.78F, 0.89F, 6.72F, 3.01F, 1.78F, 3.01F, 3.24F, 1.85F, 0.96F, 3.34F, 1.50F };
        public float[] germanAlphabetPercentage = { 5.58F, 1.96F, 3.16F, 0F, 4.98F, 16.93F, 1.49F, 3.02F, 0F, 4.98F, 8.02F,0F, 0.24F, 1.32F, 3.60F, 2.55F, 10.53F, 2.24F, 0.30F, 0.67F, 6.89F, 6.42F, 0.37F, 5.79F, 3.83F, 0.65F, 0.84F, 0.05F, 1.21F };

        public int alllettercount = 0;
        public int allcharactercount = 0;
        
        public string alphabet = "abcçdefgğhıijklmnoöprsştuüvyz";
        public string alphabet2;
        public char[] letterStatistic;


        public void TexttoLetter() 

        {

            string strAnalyzer = tbxText.Text.ToLower();


            char[] strAnalyzerChar = strAnalyzer.ToCharArray();
            

            foreach (var chars in strAnalyzerChar)
            {
                //tbxLetters.AppendText(chars + "\r\n");

               

                if (chars.ToString() == stra)
                {
                    charactercount[0]++;

                }

                else if (chars.ToString() == strb)
                {
                    charactercount[1]++;
                }
                else if (chars.ToString() == strc)
                {

                    charactercount[2]++;
                }
                else if (chars.ToString() == strc2)
                {
                    charactercount[3]++;
                }
                else if (chars.ToString() == strd)
                {

                    charactercount[4]++;
                }
                else if (chars.ToString() == stre)
                {

                    charactercount[5]++;
                }
                else if (chars.ToString() == strf)
                {
                    charactercount[6]++;
                }
                else if (chars.ToString() == strg)
                {

                    charactercount[7]++;
                }
                else if (chars.ToString() == strg2)
                {

                    charactercount[8]++;
                }
                else if (chars.ToString() == strh)
                {

                    charactercount[9]++;
                }
                else if (chars.ToString() == str2i)
                {
                    charactercount[10]++;
                }
                else if (chars.ToString() == stri)
                {

                    charactercount[11]++;
                }
                else if (chars.ToString() == strj)
                {

                    charactercount[12]++;
                }
                else if (chars.ToString() == strk)
                {

                    charactercount[13]++;
                }
                else if (chars.ToString() == strl)
                {
                    charactercount[14]++;
                }
                else if (chars.ToString() == strm)
                {

                    charactercount[15]++;
                }

                else if (chars.ToString() == strn)
                {

                    charactercount[16]++;
                }
                else if (chars.ToString() == stro)
                {

                    charactercount[17]++;
                }
                else if (chars.ToString() == stro2)
                {
                    charactercount[18]++;
                }
                else if (chars.ToString() == strp)
                {

                    charactercount[19]++;
                }

                else if (chars.ToString() == strr)
                {

                    charactercount[20]++;
                }
                else if (chars.ToString() == strs)
                {

                    charactercount[21]++;
                }
                else if (chars.ToString() == strs2)
                {
                    charactercount[22]++;
                }
                else if (chars.ToString() == strt)
                {

                    charactercount[23]++;
                }
                else if (chars.ToString() == stru)
                {

                    charactercount[24]++;
                }
                else if (chars.ToString() == stru2)
                {

                    charactercount[25]++;
                }
                else if (chars.ToString() == strv)
                {
                    charactercount[26]++;
                }
                else if (chars.ToString() == stry)
                {

                    charactercount[27]++;
                }
                else if (chars.ToString() == strz)
                {

                    charactercount[28]++;
                }
                else if (chars.ToString() == strspace)
                {

                    charactercount[29]++;
                }
                else
                {
                    charactercount[30]++;
                }

            }
                tbxLetters.AppendText("A Karakteri: " + charactercount[0] + "\r\n");
                tbxLetters.AppendText("B Karakteri: " + charactercount[1] + "\r\n");
                tbxLetters.AppendText("C Karakteri: " + charactercount[2] + "\r\n");
                tbxLetters.AppendText("Ç Karakteri: " + charactercount[3] + "\r\n");
                tbxLetters.AppendText("D Karakteri: " + charactercount[4] + "\r\n"); 
                tbxLetters.AppendText("E Karakteri: " + charactercount[5] + "\r\n");
                tbxLetters.AppendText("F Karakteri: " + charactercount[6] + "\r\n");
                tbxLetters.AppendText("G Karakteri: " + charactercount[7] + "\r\n");


                tbxLetters.AppendText("Ğ Karakteri: " + charactercount[8] + "\r\n");
                tbxLetters.AppendText("H Karakteri: " + charactercount[9] + "\r\n");
                tbxLetters.AppendText("I Karakteri: " + charactercount[10] + "\r\n");
                tbxLetters.AppendText("İ Karakteri: " + charactercount[11] + "\r\n");
                tbxLetters.AppendText("J Karakteri: " + charactercount[12] + "\r\n");
                tbxLetters.AppendText("K Karakteri: " + charactercount[13] + "\r\n");
                tbxLetters.AppendText("L Karakteri: " + charactercount[14] + "\r\n");
                tbxLetters.AppendText("M Karakteri: " + charactercount[15] + "\r\n");

                tbxLetters.AppendText("N Karakteri: " + charactercount[16] + "\r\n");
                tbxLetters.AppendText("O Karakteri: " + charactercount[17] + "\r\n");
                tbxLetters.AppendText("Ö Karakteri: " + charactercount[18] + "\r\n");
                tbxLetters.AppendText("P Karakteri: " + charactercount[19] + "\r\n");
                tbxLetters.AppendText("R Karakteri: " + charactercount[20] + "\r\n");
                tbxLetters.AppendText("S Karakteri: " + charactercount[21] + "\r\n");
                tbxLetters.AppendText("Ş Karakteri: " + charactercount[22] + "\r\n");
                tbxLetters.AppendText("T Karakteri: " + charactercount[23] + "\r\n");

                tbxLetters.AppendText("U Karakteri: " + charactercount[24] + "\r\n");
                tbxLetters.AppendText("Ü Karakteri: " + charactercount[25] + "\r\n");
                tbxLetters.AppendText("V Karakteri: " + charactercount[26] + "\r\n");
                tbxLetters.AppendText("Y Karakteri: " + charactercount[27] + "\r\n");
                tbxLetters.AppendText("Z Karakteri: " + charactercount[28] + "\r\n");
                tbxLetters.AppendText("Boşluk: " + charactercount[29] + "\r\n");
                tbxLetters.AppendText("Diğer Karakter: " + charactercount[30] + "\r\n");

            for (int i = 0; i <= 28; i++)
            {

                alllettercount += charactercount[i];

            }

            allcharactercount = alllettercount + charactercount[29] + charactercount[30];

                tbxLetters.AppendText("Tüm Harfler: " + alllettercount + "\r\n");
                tbxLetters.AppendText("Tüm Karakterler: " + allcharactercount + "\r\n");

        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {

            TexttoLetter();
            ShowStatistic();
            DrawGraphic();
            
        }

        public void ShowStatistic()
        {

            alphabet = alphabet.ToUpper();
            letterStatistic = alphabet.ToCharArray();
            float colordeciderforcoloration;

            dtgwStatisticShower.ColumnCount = 5;
            dtgwStatisticShower.Columns[0].Name = "Harf";
            dtgwStatisticShower.Columns[1].Name = "Metindeki Oran";
            dtgwStatisticShower.Columns[2].Name = "Türkçe Oran";
            dtgwStatisticShower.Columns[3].Name = "Almanca Oran";
            dtgwStatisticShower.Columns[4].Name = "Korelasyon";

           for (int a=0;a<=28;a++)
            {
                percentagea = ((Convert.ToSingle(charactercount[a])) / Convert.ToSingle(alllettercount));
                dtgwStatisticShower.Rows.Add(letterStatistic[a], percentagea.ToString("0.00%"), turkishAlphabetPercentage[a]+"%",germanAlphabetPercentage[a]+"%", ((percentagea/turkishAlphabetPercentage[a])*100).ToString("0.00%"));

                colordeciderforcoloration = (percentagea*100 / turkishAlphabetPercentage[a]) * 100;
                if (colordeciderforcoloration >= 90 && colordeciderforcoloration <= 110)
                {
                    dtgwStatisticShower.Rows[a].Cells[4].Style.BackColor = Color.Green;
                }
                else
                {
                    dtgwStatisticShower.Rows[a].Cells[4].Style.BackColor = Color.Red;
                }

            }
            dtgwStatisticShower.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

        }


        public void DrawGraphic() 
        {
            

            for (int i = 0; i <=28; i++)
            {
                //alphabet2 = letterStatistic[i].ToString();
                percentagea = ((Convert.ToSingle(charactercount[i])) / Convert.ToSingle(alllettercount));
                chrLetterStatistic.Series["Metin"].Points.Add(percentagea*100);
                chrLetterStatistic.Series["Metin"].Points[i].Label =letterStatistic[i].ToString();
                chrLetterStatistic.Series["Metin"].Points[i].Color = System.Drawing.Color.GreenYellow;

                chrLetterStatistic.Series["Türkçe Genel"].Points.Add(turkishAlphabetPercentage[i]);
                chrLetterStatistic.Series["Türkçe Genel"].Points[i].Label = letterStatistic[i].ToString();
                chrLetterStatistic.Series["Türkçe Genel"].Points[i].Color = System.Drawing.Color.Red;

            }

        }




    }
}
