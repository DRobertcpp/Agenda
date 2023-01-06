using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		ListaPersoane persoane;
		String operatie;

		 void afiseazaButoaneSalveazaRenunta(){
			 toolStripSeparator3.Visible=true;
			 butonSalveaza.Visible=true;
			 toolStripSeparator4.Visible=true;
			 butonRenunta.Visible=true;
			 toolStripSeparator5.Visible=true;
		 }
		 void ascundeButoaneSalveazaRenunta(){
			 toolStripSeparator3.Visible=false;
			 butonSalveaza.Visible=false;
			 toolStripSeparator4.Visible=false;
			 butonRenunta.Visible=false;
			 toolStripSeparator5.Visible=false;
		 }
		 Persoana daPersoanaDinFormular(){
			int zi=0,luna=0,an=0;
			try{
				zi=Convert.ToInt32(data_n.Text.Substring(0,data_n.Text.IndexOf("/")));
				data_n.Text=data_n.Text.Substring(data_n.Text.IndexOf("/")+1);
				try{
					luna=Convert.ToInt32(data_n.Text.Substring(0,data_n.Text.IndexOf("/")));
					data_n.Text=data_n.Text.Substring(data_n.Text.IndexOf("/")+1);
					try{
						an=Convert.ToInt32(data_n.Text);
					}
					catch{}
				}
				catch{}
			}
			catch{}
			return 	new Persoana(nume.Text,prenume.Text,an,luna,zi,sexul.Text=="M",adresa.Text,mail.Text,telefon.Text);
		 }
		 void scriePersoanaInFormular(Persoana P){
			nume.Text=P.Nume;
			prenume.Text=P.Prenume;
			data_n.Text=String.Concat(P.ZiNastere,"/",P.LunaNastere,"/",P.AnNastere);
			sexul.Text=P.Sexul?"M":"F";
			adresa.Text=P.Adresa;
			mail.Text=P.Email;
			telefon.Text=P.Telefon;
		 }
		
		 bool adaugaPersoana(){
			if(nume.Text!="")
				if(prenume.Text!="")
					if(telefon.Text!=""){
						persoane.adaugaPersoana(daPersoanaDinFormular());
						return true;
					}
					else
						MessageBox.Show("Campul Telefon este gol!","Atentie",System.Windows.Forms.MessageBoxButtons.OK);
				else
					MessageBox.Show("Campul Prenume este gol!","Atentie",System.Windows.Forms.MessageBoxButtons.OK);
			else
				MessageBox.Show("Campul Nume este gol!","Atentie",System.Windows.Forms.MessageBoxButtons.OK);
			return false;
		 }
		
		 bool salveazaPersoana(int pozitie){
			if(nume.Text!="")
				if(prenume.Text!="")
					if(telefon.Text!=""){
						persoane.modificaPersoana(pozitie,daPersoanaDinFormular());
						return true;
					}
					else
						MessageBox.Show("Campul Telefon este gol!","Atentie",System.Windows.Forms.MessageBoxButtons.OK);
				else
					MessageBox.Show("Campul Prenume este gol!","Atentie",System.Windows.Forms.MessageBoxButtons.OK);
			else
				MessageBox.Show("Campul Nume este gol!","Atentie",System.Windows.Forms.MessageBoxButtons.OK);
			return false;
		 }

		 void stergeCampuri(){
			nume.Text="";
			prenume.Text="";
			data_n.Text="  /  /  ";
			sexul.Text="M";
			adresa.Text="";
			mail.Text="";
			telefon.Text="";
		 }

		 void campuriDoarPentruCitire(bool valoare){
			nume.ReadOnly=valoare;
			prenume.ReadOnly=valoare;
			data_n.ReadOnly=valoare;
			sexul.Enabled=!valoare;
			adresa.ReadOnly=valoare;
			mail.ReadOnly=valoare;
			telefon.ReadOnly=valoare;
		 }

		 void afiseazaListaPersoane(){
			lista.Items.Clear();
			for(int i=0;i<persoane.NumarPersoane;i++)
				lista.Items.Add(String.Concat(persoane.daPersoana(i).Nume," ",persoane.daPersoana(i).Prenume));
			butonModifica.Enabled=false;
			butonSterge.Enabled=false;
		}

		void scriePersoane(){
            persoane.scrie("persoane.io");
		}
		
		void citestePersoane()
        {
           persoane.citeste("persoane.io");
		}
	
        private void Form1_Load(object sender, EventArgs e)
        {
			 persoane=new ListaPersoane();
			 citestePersoane();
			 operatie="";
			 stergeCampuri();
			 campuriDoarPentruCitire(true);
			 afiseazaListaPersoane();
        }

        private void butonAdauga_Click(object sender, EventArgs e)
        {
			afiseazaButoaneSalveazaRenunta();
			stergeCampuri();
			campuriDoarPentruCitire(false);
			operatie="adauga";
        }

        private void butonSalveaza_Click(object sender, EventArgs e)
        {
			 if(operatie=="adauga"){
				 if(adaugaPersoana()){
					 ascundeButoaneSalveazaRenunta();
					 operatie="";
					 stergeCampuri();
					 afiseazaListaPersoane();
				 }
			 }
			 else if(operatie=="modifica"){
				 if(salveazaPersoana(lista.SelectedIndex)){
					 ascundeButoaneSalveazaRenunta();
					 operatie="";
					 stergeCampuri();
					 afiseazaListaPersoane();
				 }
			 }
        }

        private void butonRenunta_Click(object sender, EventArgs e)
        {
            stergeCampuri();
            afiseazaListaPersoane();
            campuriDoarPentruCitire(true);
            ascundeButoaneSalveazaRenunta();
        }

        private void butonModifica_Click(object sender, EventArgs e)
        {
			 afiseazaButoaneSalveazaRenunta();
			 campuriDoarPentruCitire(false);
			 operatie="modifica";
        }

        private void butonSterge_Click(object sender, EventArgs e)
        {
			 if(MessageBox.Show(String.Concat("Stergeti persoana:\n",lista.Text,"?"),"Stergere persoana",MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
				 persoane.stergePersoana(lista.SelectedIndex);
			 stergeCampuri();
			 afiseazaListaPersoane();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            scriePersoane();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lista.SelectedIndex >= 0)
            {
                butonModifica.Enabled = true;
                butonSterge.Enabled = true;
                scriePersoanaInFormular(persoane.daPersoana(lista.SelectedIndex));
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
