using System;
using System.IO;
using System.Collections.Generic;

public class Persoana{
	String nume;
	String prenume;
	int an_nastere;
	int luna_nastere;
	int zi_nastere;
	bool sexul;//0-masculin, 1-feminin
	String adresa;
	String email;
	String telefon;
public Persoana(String nume,String prenume,int an_nastere,int luna_nastere,int zi_nastere,bool sexul,String adresa,String email,String telefon){
		this.nume=nume;
		this.prenume=prenume;
		this.an_nastere=an_nastere;
		this.luna_nastere=luna_nastere;
		this.zi_nastere=zi_nastere;
		this.sexul=sexul;
		this.adresa=adresa;
		this.telefon=telefon;
		this.email=email;
}

public String Nume{
		get{return nume;}
		set{nume=value;}
	}

public String Prenume{
		get{return prenume;}
		 set{prenume=value;}
	}

public int AnNastere{
		get{return an_nastere;}
		set{an_nastere=value;}
	}

public int LunaNastere{
		get{return luna_nastere;}
		set{luna_nastere=value;}
	}

public int ZiNastere{
		get{return zi_nastere;}
		set{zi_nastere=value;}
	}

public bool Sexul{
		get{return sexul;}
		set{sexul=value;}
	}

public String Adresa{
		get{return adresa;}
		set{adresa=value;}
	}

public String Email{
		get{return email;}
		set{email=value;}
	}

public String Telefon{
		get{return telefon;}
		set{telefon=value;}
	}

public static bool operator<(Persoana P1,Persoana P2){
		return String.Compare(P1.nume,P2.nume)<0||(String.Compare(P1.nume,P2.nume)==0&&String.Compare(P1.prenume,P2.prenume)<0);
	}

public static bool operator >(Persoana P1, Persoana P2){
    return String.Compare(P1.nume, P2.nume) > 0 || (String.Compare(P1.nume, P2.nume) == 0 && String.Compare(P1.prenume, P2.prenume) > 0);
    }

public void scrie(BinaryWriter bw){
		bw.Write(nume);
		bw.Write(prenume);
		bw.Write(an_nastere);
		bw.Write(luna_nastere);
		bw.Write(zi_nastere);
		bw.Write(sexul);
		bw.Write(adresa);
		bw.Write(telefon);
		bw.Write(email);
	}

}


public class ListaPersoane{
	List<Persoana> persoane;

public ListaPersoane(){
		persoane=new List<Persoana>();
	}

public Persoana daPersoana(int pozitie){
		try{
			return persoane[pozitie];
		}
		catch(Exception){
			return null;
		}
	}

public int NumarPersoane{
		get{return persoane.Count;}
	}
public void adaugaPersoana(Persoana P){//pastram ordinea lexicografica
		for(int i=0;i<persoane.Count;i++)
			if(P<daPersoana(i)){
				persoane.Insert(i,P);
				return;
			}
		persoane.Add(P);
	}

public void stergePersoana(int pozitie){
		if(pozitie>=0&&pozitie<persoane.Count)
			persoane.RemoveAt(pozitie);
	}

public void modificaPersoana(int pozitie,Persoana P){
		stergePersoana(pozitie);
		adaugaPersoana(P);
	}

    public void scrie(string cale)
    {
        FileStream fs = new FileStream(cale, FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);
        bw.BaseStream.Seek(0, SeekOrigin.End);
        for (int i = 0; i < NumarPersoane; i++)
            persoane[i].scrie(bw);
        bw.Close();
        fs.Close();
    }

    public void citeste(string cale)
    {
        FileStream fs = new FileStream(cale, FileMode.Open, FileAccess.Read);
        BinaryReader br = new BinaryReader(fs);
        br.BaseStream.Seek(0, SeekOrigin.Begin);
        while (br.PeekChar() != -1)
        {
            Persoana P;
            P = new Persoana(br.ReadString(), br.ReadString(), br.ReadInt32(), br.ReadInt32(), br.ReadInt32(), br.ReadBoolean(), br.ReadString(), br.ReadString(), br.ReadString());
            persoane.Add(P);
        }
        br.Close();
        fs.Close();
    }

}