package Joueurs;

import Casinos.Casino;

public class JoueurRiche extends Joueur {

    //Les attributs pour les Constructeurs
    private Casino casino;

    //Constructeur sans argument
    public JoueurRiche() {
        super();
        casino = null;
    }

    //Constructeur avec 2 arguments
    public JoueurRiche(String nom, int capital) {
        super(nom, capital);
        this.casino = null;
    }

    //Constructeur copie, il créer une copie d'un Joueur existant
    public JoueurRiche(JoueurRiche autre) {
        super(autre);
    }

    //Methode equals
    public boolean equals(JoueurRiche autre) {
        if (!super.equals(autre)) {
            return false;
        }
        return true;
    }

    //Methode toString
    public String toString() {
        String chaine;
        chaine = super.getNom() + " est un joueur riche!\n";
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

    //Methode banqueRoute
    public void banqueRoute() {
        super.setCapital(0);
        System.out.println("Vos investissement on été saisie par le gouvernement et vos comptes dans les paradis fiscaux on été fermé!");

        if (super.getCasino() != null) {

            System.out.println("On vous escorte à la porte!");
            this.quitterCasino();
        }

    }
}
