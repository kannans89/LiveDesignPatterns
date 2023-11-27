using System.Collections.Generic;

namespace QuickEntryFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> words = MakeWords();


            listBox1.Items.AddRange(words.ToArray());
            // listBox1.Dock = DockStyle.Fill;

            QuickEntryMediator mediator = new QuickEntryMediator(textBox1, listBox1);



        }

        private List<string> MakeWords()
        {
            List<string> words = new List<string>();
            try
            {
                string path = @"C:\KannanWorks\KOENIG6_Nov\DesignPatterns\word_dictionary\words.txt"; // Replace with the actual path to your dictionary file
                words = File.ReadAllLines(path).ToList();
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while reading the dictionary file: " + ex.Message);
            }

            return words;
        }
    }
}