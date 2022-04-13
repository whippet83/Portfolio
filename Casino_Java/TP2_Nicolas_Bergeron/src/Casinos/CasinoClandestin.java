package Casinos;

import Jeux.Jeu;
import Jeux.PileOuFace;
import Jeux.Roulette;
import Joueurs.Joueur;

public class CasinoClandestin extends Casino {

    //Attribut pour Constructeur
    private int capital;

    //Constructeur sans argument
    public CasinoClandestin() {
        super();
        this.capital = 100000;
    }

    //Constructeur avec 2 arguments
    public CasinoClandestin(String nom, int joueurmax) {
        super(nom, joueurmax);
        this.capital = 100000;
    }

    //Constructeur par copie
    public CasinoClandestin(CasinoClandestin autre) {
        super(autre);
        this.capital = 100000;
    }

    //Methode equals
    public boolean equals(CasinoClandestin autre) {
        if (!super.equals(autre)) {
            return false;
        }
        return true;
    }

    //methode toString()
    public String toString() {
        String chaine;
        chaine = "Ceci est un Casino Clandestin\n";
        chaine += super.toString();
        return chaine;
    }

    //Getter/Setter
    public int getCapital() {
        return capital;
    }

    public void setCapital(int capital) {
        this.capital = capital;
    }


    //methodde descenteDePolice
    public void descenteDePolice() {
        System.out.println("Il a une descente de police toute les joueurs sont partit!");

        Joueur[] players = getJoueurs();

        for (int i = players.length - 1; i >= 0; i--) {

            if (players[i] != null) {
                players[i].quitterCasino();
            }
        }
    }

    //methode payerImpots (vien de l'interface impotFonciers qui est implements dans abstract Casino)
    public void playerImpots() {

        double total;

        if (Math.random() > 0.99) {
            total = getCapital() * .5;
            int arondie = (int) total;
            setCapital(getCapital() - arondie);
            System.out.println("Le casino clandestin doit payer 50% de sont capital à Revenu Québec :(\nVoici le nouveau capital du casino" + getCapital());
        } else {
            System.out.println("OOF! Le casino clandestin n'a pas besoin de rien payer! :)");
            System.out.println("Capital:" + getCapital());
        }

    }
}
