using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace czerwiec23_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                pictureBox1.Image = Properties.Resources.pocztowka;

                labelCena.Text = "Cena: 1 zł";
            }
            else if (radioButton2.Checked) 
            {
                pictureBox1.Image = Properties.Resources.list;

                labelCena.Text = "Cena: 1.5 zł";
            }
            else if (radioButton3.Checked) 
            {
                pictureBox1.Image = Properties.Resources.paczka;

                labelCena.Text = "Cena: 2 zł";
            }
            else
            {
                MessageBox.Show("Wybierz rodzaj przesyłki");
            }
        }
        /*******************************************************
         nazwa funkcji: button1_Click
         parametry wejściowe: object sender - źródło zdarzenia (przycisk "Sprawdź cenę"), EventArgs e - argumenty zdarzenia
         wartość zwracana: void
         informacje: Funkcja obsługuje kliknięcie przycisku "Sprawdź cenę". 
                      Sprawdza, który radio button jest zaznaczony i w zależności od tego ustawia odpowiedni obrazek oraz cenę na etykiecie.
                      Jeśli żaden radio button nie jest zaznaczony, wyświetla komunikat o błędzie.
         autor: kamil Szat
         *******************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            string nrUlicy = textBox1.Text.Trim();
            string kodPocztowy = textBox2.Text.Trim();
            string miasto = textBox3.Text.Trim();

            if (string.IsNullOrWhiteSpace(nrUlicy))
            {
                MessageBox.Show("Proszę podać numer ulicy lub numer domu.");
                return;
            }

            if (kodPocztowy.Length != 5 || !kodPocztowy.All(char.IsDigit))
            {
                MessageBox.Show("Kod pocztowy powinien się składać z samych cyfr i mieć dokładnie 5 znaków.");
                return;
            }

            if (string.IsNullOrWhiteSpace(miasto))
            {
                MessageBox.Show("Proszę wpisać miasto.");
                return;
            }
            MessageBox.Show("Dane przesyłki zostały wprowadzone:\n" +
                            $"Numer ulicy: {nrUlicy}\n" +
                            $"Kod pocztowy: {kodPocztowy}\n" +
                            $"Miasto: {miasto}");
        }
        /*******************************************************
         nazwa funkcji: button2_Click
         parametry wejściowe: object sender - źródło zdarzenia (przycisk "Zatwierdź"), EventArgs e - argumenty zdarzenia
         wartość zwracana: void
         informacje: Funkcja obsługuje kliknięcie przycisku "Zatwierdź".
                      Pobiera dane z pól tekstowych: numer ulicy, kod pocztowy i miasto.
                      Sprawdza poprawność kodu pocztowego (musi mieć 5 cyfr) oraz czy pola numer ulicy i miasta nie są puste.
                      Wyświetla odpowiednie komunikaty w przypadku błędów lub potwierdzenie poprawnego wprowadzenia danych.
         autor: Kamil Szat
        *******************************************************/
        private void labelCena_Click(object sender, EventArgs e)
        {

        }

        
    }
}
