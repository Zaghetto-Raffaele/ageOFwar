// See https://aka.ms/new-console-template for more information

using ageOFwar.Personaggi;

Cavaliere cav1 = new Cavaliere(1000);

Cavaliere[] squadraRossa = new Cavaliere[100];

for (int i = 1;i<=100;i++)
{
    squadraRossa[i] = new Cavaliere(1000);
    squadraRossa[i].Squadra = "Squadra Rossa";
}






