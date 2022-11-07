using System;
using System.Windows.Forms;

namespace hafta4
{
    public partial class Form1 : Form
    {

        public uint IDsayac=0;
        public Form1()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void İsimTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IDsayac += 1;
            if (comboBox2.SelectedItem.ToString() == "Öğretmen")
            {
                Ogretmen ogretmen = new Ogretmen(IDsayac, comboBox3.SelectedItem.ToString(),
                    Convert.ToUInt32(BoyTextBox.Text),
                    Convert.ToUInt32(KiloTextBox.Text), comboBox1.SelectedItem.ToString(),
                    Convert.ToUInt32(YasTextBox.Text)
                    );

             
            }
           
            else if (comboBox3.SelectedIndex == 1)
            {
                Ogrenci ogrenci = new Ogrenci(IDsayac, comboBox3.SelectedItem.ToString(),
                    Convert.ToUInt32(BoyTextBox.Text),
                    Convert.ToUInt32(KiloTextBox.Text), comboBox1.SelectedItem.ToString(),
                    Convert.ToUInt32(YasTextBox.Text)
                    );



            }
             
            else
            {
                Muhendis muhendis = new Muhendis (IDsayac, comboBox3.SelectedItem.ToString(),
                    Convert.ToUInt32(BoyTextBox.Text),
                    Convert.ToUInt32(KiloTextBox.Text), comboBox1.SelectedItem.ToString(),
                    Convert.ToUInt32(YasTextBox.Text)
                    );
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox'ın içindeki itemları temizle if bloğuna her girmeden önce
            comboBox3.Items.Clear();

            //comboBox2'de ogretmeni seçince comboBox3'e matematik branşını ekle
            if(comboBox2.SelectedItem.ToString()=="Öğretmen") 
            {
                comboBox3.Items.Add("Matematik");
                comboBox3.Items.Add("Türkçe");
                comboBox3.Items.Add("Kimya");
 //Öğretmen, öğrenci, mühendis olma durumuna göre label7'deki ifadeyi değiştirmek için
                label7.Text = "Branş";
            }
            //eğer 0. indexteki değilse 1.indextekiyse 1.sınıf ekle
            else if(comboBox2.SelectedItem.ToString() == "Öğrenci")
            {
                comboBox3.Items.Add("1.sınıf");
                comboBox3.Items.Add("2.sınıf");
                comboBox3.Items.Add("3.sınıf");
                label7.Text = "Sınıf";

            }
            //eğer bunlardan ikisi de değilse bilgisayar ekle
            else 
            {
                comboBox3.Items.Add("Bilgisayar");
                comboBox3.Items.Add("Elektirik");
                comboBox3.Items.Add("Harita");
                label7.Text = "Ne Mühendisi?";
            }
           
        }
    }
}
