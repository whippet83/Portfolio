package Jeux;

import java.util.Random;

public class PileOuFace extends Jeu {

    //Constructeur sans argument
    public PileOuFace() {
        super();
    }

    //Constructeur par copie
    public PileOuFace(PileOuFace autre) {
        super(autre);
    }

    //Methode equals
    public boolean equals(PileOuFace autre) {
        if (!super.equals(autre)) {
            return false;
        }
        return true;
    }

    //Methode toString
    public String toString() {
        String chaine;
        chaine = super.toString();
        chaine += "\nLes règles du jeu sont simple, deux joueurs s'affrontent. Notre A.I qui est à la fine point de la technologie nommé ";
        chaine += "\nS.Y.L.V.A.I.N, génère une simulation d'une pièce de monnaie qui est lancer dans les airs et qui retombe au sol donnant ";
        chaine += "\nle résultat pile ou face et peut importe du choix assigner à vous, vous avez 50 % de gagner. Se qui rend ce jeu juste.\n";
        return chaine;
    }

    //Methode calculerGain
    public int calculerGain(int mise) {
        Random random = new Random();
        double resultat;

        int cpuBet = random.nextInt(1000) + 1;

        resultat = Math.random();
        System.out.println("Vous avez miser: " + mise + "$\nVotre adversaire à miser: " + cpuBet + "$");

        if (resultat < 0.5) {
            System.out.println("Vous avez gagner au pile ou face!");
            return mise + cpuBet;
        } else {
            System.out.println("Vous avez perdu au pile ou face!");
            return 0;
        }
    }
}
