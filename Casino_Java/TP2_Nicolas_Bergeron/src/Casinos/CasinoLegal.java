package Casinos;

import Jeux.Jeu;
import Jeux.PileOuFace;
import Jeux.Roulette;

public class CasinoLegal extends Casino {

    //Les attributs pour les Constructeurs
    private int capital;
    private boolean peutJouer = true;


    //Constructeur sans argument
    public CasinoLegal() {
        super();
        this.capital = 100000;
    }

    //Constructeur avec 2 arguments
    public CasinoLegal(String nom, int joueurmax) {

        super(nom, joueurmax);
        this.capital = 100000;


    }

    //Constructeur par copie
    public CasinoLegal(CasinoLegal autre) {
        super(autre);
        this.capital = 100000;
    }

    //methode equals
    public boolean equals(CasinoLegal autre) {
        if (!super.equals(autre)) {
            return false;
        }
        return true;
    }

    //methode toString
    public String toString() {
        String chaine;
        chaine = "Ceci est un Casino Légal\n";
        chaine += super.toString();
        return chaine;
    }

    //Getter/Setter
    public int getCapital() {
        return capital;
    }


    public boolean getPeutJouer() {
        return peutJouer;
    }

    public void setCapital(int capital) {
        this.capital = capital;
    }

    //methode debutSpectacle
    public void debutSpectacle() {
        peutJouer = false;
        System.out.println("Gregory Charles a commencer son spectacle les jeux ne sont pas disponmible!");

    }

    //methode finSpectacle
    public void finSpectacle() {
        peutJouer = true;
        System.out.println("Gregory Charles a terminer son spectable les jeux sont de nouveaux ouvert!");
    }


    //methode payerImpots (vien de l'interface impotFonciers qui est implements dans abstract Casino)
    public void playerImpots() {

        double total;
        total = (getCapital() * .15);
        int aroundie = (int) total;

        setCapital(getCapital() - aroundie);

        System.out.println("Le casino légal à payer 15% de leur capital\nVoici le nouveau capital du casino:" + getCapital());


    }
}
