using CrashBot.Model;
using CrashBot.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrashBot.WinUI
{
    public partial class frmProfil : Form
    {
        private readonly APIService _korisnik = new APIService("Korisnik");
        public frmProfil()
        {
            InitializeComponent();
        }

        private async void frmProfil_Load(object sender, EventArgs e)
        {
            var korisnik = await _korisnik.GetById<Model.Korisnik>(Global.prijavljeniKorisnik.KorisnikId);

            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtAdresa.Text = korisnik.Adresa;
            txtKorisnickoIme.Text = korisnik.KorisnickoIme;
            txtMail.Text = korisnik.Mail;
            txtTelefon.Text = korisnik.Telefon;
            txtLozinka.Text = korisnik.Lozinka;
            

        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {

            if (Validacija())
            {
                MessageBox.Show("Enter valid data.", "Info", MessageBoxButtons.OK);
            }
            else
            {

                if (txtNovaLozinka.Text != "")
                {
                    txtLozinka.Text = txtNovaLozinka.Text;
                }
                KorisnikUpsertRequest model = new KorisnikUpsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Adresa = txtAdresa.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Mail = txtMail.Text,
                    Telefon = txtTelefon.Text,
                    Lozinka = txtLozinka.Text,                   
                };

                var nesto = await _korisnik.Update<Model.Korisnik>(Global.prijavljeniKorisnik.KorisnikId, model);
                MessageBox.Show("Succeseful change of data.", "Info", MessageBoxButtons.OK);
            }
            

            
        }

        private bool Validacija()
        {
            if (txtIme.Text == "" || txtPrezime.Text == "")
            {
                errorProvider1.SetError(txtIme, "Name is a required field");
                errorProvider1.SetError(txtPrezime, "Surname is a required field");

                return true;
            }
            if (txtKorisnickoIme.Text == "")
            {
                errorProvider1.SetError(txtKorisnickoIme, "Username is a required field");
                return true;
            }
            if (txtNovaLozinka.Text != txtPonovljenaLozinka.Text)
            {
                errorProvider1.SetError(txtNovaLozinka, "Wrong password!");
                errorProvider1.SetError(txtPonovljenaLozinka, "Wrong password!");
                return true;
            }

            return false;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
