using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamAsmacaOdev
{
    public partial class Form1 : Form
    {
#region Variables
        List<string> words = new List<string>
        {
         "Adana",
        "Adıyaman",
        "Afyonkarahisar",
        "Ağrı",
        "Aksaray",
        "Amasya",
        "Ankara",
        "Antalya",
        "Ardahan",
        "Artvin",
        "Aydın",
        "Balıkesir",
        "Bartın",
        "Batman",
        "Bayburt",
        "Bilecik",
        "Bingöl",
        "Bitlis",
        "Bolu",
        "Burdur",
        "Bursa",
        "Çanakkale",
        "Çankırı",
        "Çorum",
        "Denizli",
        "Diyarbakır",
        "Düzce",
        "Edirne",
        "Elazığ",
        "Erzincan",
        "Erzurum",
        "Eskişehir",
        "Gaziantep",
        "Giresun",
        "Gümüşhane",
        "Hakkari",
        "Hatay",
        "Iğdır",
        "Isparta",
        "İstanbul",
        "İzmir",
        "Kahramanmaraş",
        "Karabük",
        "Karaman",
        "Kars",
        "Kastamonu",
        "Kayseri",
        "Kırıkkale",
        "Kırklareli",
        "Kırşehir",
        "Kilis",
        "Kocaeli",
        "Konya",
        "Kütahya",
        "Malatya",
        "Manisa",
        "Mardin",
        "Mersin",
        "Muğla",
        "Muş",
        "Nevşehir",
        "Niğde",
        "Ordu",
        "Osmaniye",
        "Rize",
        "Sakarya",
        "Samsun",
        "Siirt",
        "Sinop",
        "Sivas",
        "Şanlıurfa",
        "Şırnak",
        "Tekirdağ",
        "Tokat",
        "Trabzon",
        "Tunceli",
        "Uşak",
        "Van",
        "Yalova",
        "Yozgat",
        "Zonguldak"
       
        };
        int incorrectGuess;
        Random random;
        string selectedWord;
        char[] displayWord;
#endregion
        public Form1()
        {
            InitializeComponent();
        }

        public string formattedDisplayWord { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            incorrectGuess=0;
            random = new Random();
            selectedWord = words[random.Next(words.Count)];
            displayWord = new string('_', selectedWord.Length).ToCharArray();
            string formattedDisplay = string.Join(" ", displayWord);
            lblWorldDisplay.Text = formattedDisplay;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            char guess = tbGuess.Text.ToLower()[0];
            bool correctGuess = false;
            for(int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == guess)
                {
                    displayWord[i] = guess;
                    correctGuess = true;
                }
            }
            lblWorldDisplay.Text = string.Join(" ", displayWord);
            if (!correctGuess)
            {
                UpdateHangmanImage();
            }
            if (!lblWorldDisplay.Text.Contains('_'))
            {
                MessageBox.Show("Tebrikler! siz kazandınız");
                Application.Restart();  
 
            }
        }
        private void UpdateHangmanImage()
        {
            incorrectGuess++;
            switch (incorrectGuess)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.ip;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.adam1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.adam2;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.adam3;
                    MessageBox.Show("Kaybettiniz:( kelime: " + selectedWord);
                    Application.Restart();
                    break;
                default:
                    break;
            }
        }
    }
}
