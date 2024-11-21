using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picturehouse
{
    public partial class Form1 : Form
    {
        List<Film> films; // declaration of class variable to hold List of films

        public Form1()
        {
            InitializeComponent();

            this.films = new List<Film>(); // initialisation of class variable to hold List of films
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            lblAgeRating.Text = "";
            lblRunningTime.Text = "";
            lblDate.Text = "";

            listBoxTitles.DisplayMember = "Title";
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Film> films = new List<Film>();

            FormAddNewFilm addNewFilmForm = new FormAddNewFilm(films);
            addNewFilmForm.ShowDialog();

            

            
        }



        private void RefreshTitles()
        {
            foreach (Film f in this.films)
            {
                listBoxTitles.Items.Add(f);
            }
        }


    }
}
