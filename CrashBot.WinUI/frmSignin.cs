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
    public partial class frmSignin : Form
    {
        private readonly APIService _korisnik = new APIService("Korisnik");
        public frmSignin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (Validacija())
            {
                MessageBox.Show("Enter valid data.", "Info", MessageBoxButtons.OK);
            }
            else
            {
                KorisnikUpsertRequest model = new KorisnikUpsertRequest();
              
                    model.Ime = txtIme.Text;
                    model.Prezime = txtPrezime.Text;
                    model.Mail = txtMail.Text;
                    model.KorisnickoIme = txtKorisnickoIme.Text;
                    model.Adresa = txtAdresa.Text;
                    model.Telefon = txtTelefon.Text;
                    model.Lozinka = txtLozinka.Text;

                    var nesto = await _korisnik.Insert<Model.Korisnik>(model);

                    MessageBox.Show("Sign up is successful", "Info", MessageBoxButtons.OK);
                    Close();
               
            }
            
           
            

            
            
        }

        private bool Validacija()
        {
            if (txtIme.Text == "" || txtPrezime.Text =="")
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
            if (txtLozinka.Text != txtPonovljenaLozinka.Text)
            {
                errorProvider1.SetError(txtLozinka, "Wrong password!");
                return true;
            }

            return false;
        }
    }
}
