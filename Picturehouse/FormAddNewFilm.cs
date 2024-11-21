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
    public partial class FormAddNewFilm : Form
    {
        List<Film> films;

        public FormAddNewFilm(List<Film> films)
        {
            InitializeComponent();

            this.films = films;
        }

        private void FormAddNewFilm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string ageRating = txtAgeRating.Text;
            int runningTime = int.Parse(txtRunningTime.Text);
            DateTime releaseDate = dateTimePickerRelease.Value;

            Film f = new Film(title, ageRating, runningTime, releaseDate);

            this.films.Add(f);

            this.Close();

        }
    }
}
