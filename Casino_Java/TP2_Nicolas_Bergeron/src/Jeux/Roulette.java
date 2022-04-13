package Jeux;

import java.util.Random;

public class Roulette extends Jeu {

    //Les attributs pour les Constructeurs
    private String nom;
    private String couleur;
    private int num;


    //Constructeur sans argument
    public Roulette() {
        this.nom = "Roulette";
    }

    //Constructeur par copie
    public Roulette(Roulette autre) {
        super(autre);
    }

    //Methode equals
    public boolean equals(Roulette autre) {
        if (!super.equals(autre)) {
            return false;
        }
        return true;
    }

    //Methode toString
    public String toString() {
        String chaine;
        chaine = super.toString();
        chaine += "\nLes règles du jeu sont simple, vous choisissez une couleur entre Rouge ou Noir et vous miser sur un nombre entre 0 et 36, si la couleur tiré";
        chaine += "\nest Rouge ou Noir, vous doublez votre capital et si le nombre tiré entre 1 à 36 est le votre vous remporter 36 fois votre mise. Si le ";
        chaine += "\n0 est tiré vous rempotez aucun capital.\n";
        return chaine;
    }

    //Getter/Setter
    public String getNomRoulette() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public String getCouleur() {
        return couleur;
    }

    public void setCouleur(String couleur) {
        this.couleur = couleur;
    }

    public int getNum() {
        return num;
    }

    public void setNum(int num) {
        this.num = num;
    }

    //Methode calculerGain
    public int calculerGain(int mise) {
        Random random = new Random();
        int total = 0;
        double resultat;

        resultat = (int) (Math.random() * 36);
        System.out.println("Vous avez miser: " + mise + "$\nVotre nombre est " + num + "\nVotre couleur est " + couleur + "\nLe nombre tiré est " + resultat);

        if (num < 36 && num > 1) {
            if (num == resultat) {
                System.out.println("Vous avez gagner le jackpot à la roulette!");
                total += (mise * 36);
            }

            if (resultat == 0) {
                System.out.println("Vous avez perdu à la roulette!");
                total = 0;
                return total;
            }
            if (couleur.equals("Rouge") || couleur.equals("Noir")) {
                System.out.println("Vous avez gagner avec la couleur " + couleur);
                total += (mise * 2);
            }
        } else {
            System.out.println("Veuillez prendre un nombre entre 1 et 36");
            total += mise;
        }
        return total;
    }
}
