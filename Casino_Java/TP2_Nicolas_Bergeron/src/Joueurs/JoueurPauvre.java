package Joueurs;

import Casinos.Casino;

import java.text.SimpleDateFormat;
import java.util.Date;

public class JoueurPauvre extends Joueur {

    //Les attributs pour les Constructeurs
    private Casino casino;

    //Constructeur sans argument
    public JoueurPauvre() {
        super();
        casino = null;
    }

    //Constructeur avec 2 arguments
    public JoueurPauvre(String nom, int capital) {
        super(nom, capital);
        this.casino = null;
    }

    //Constructeur copie, il créer une copie d'un Joueur existant
    public JoueurPauvre(JoueurPauvre autre) {
        super(autre);
    }

    //Methode equals
    public boolean equals(JoueurPauvre autre) {
        if (!super.equals(autre)) {
            return false;
        }
        return true;
    }

    //Methode toString
    public String toString() {
        String chaine;
        chaine = super.getNom() + " est un joueur pauvre!\n";
        chaine += super.toString();
        return chaine;
    }


    //Getter/Setter
    public Casino getCasino() {
        return casino;
    }

    public void setCasino(Casino casino) {
        this.casino = casino;
    }

    //Methode collecterCheque
    public void collecterCheque() {
        Date date = new Date();
        SimpleDateFormat format = new SimpleDateFormat("dd");
        String premierDuMois = format.format(date);

        if (!premierDuMois.equals("01")) {
            System.out.println("Votre chèque peut seulement être collecter le premier de chaque mois, " + super.getNom() + " !");
        } else {
            super.setCapital(super.getCapital() + 700);
            System.out.println(super.getNom() + " à collecter son chèque!");
            System.out.println("Nouveau Capital:" + getCapital());
        }

    }


}
