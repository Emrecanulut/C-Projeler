using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace İngilizcekelimeProje5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//silme butonunu eklemdim.
        {
            int vote = NotBook.SelectedIndex;//listbox'tan eleman seçilmesini istiyorum.
            if (vote != -1)//burda eleman seçilip seçilmediğini kontrol ediyorum.
            {
                NotBook.Items.RemoveAt(vote);
            }
            else
            {
                MessageBox.Show("make a choice!");// eğer eleman seçilmemiş ise seçilmesi için uyarı veriyorum.
            }

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            NotBook.Items.Add(textBox1.Text);//list boxa ekleme yapıyorum.
            textBox1.Clear();//ekleme yaptıktan sonra textboxun temizliyorum.
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotBook.Items.Clear();// temizle butonu ekleyerek istboxun tamamının temizlenmesini sağlıyorum.
        }
    }
}
