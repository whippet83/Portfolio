package Joueurs;

import Casinos.Casino;
import Casinos.CasinoClandestin;
import Casinos.CasinoLegal;

import java.util.Arrays;
import java.util.Objects;

public abstract class Joueur implements Comparable {

    //Les attributs pour les Constructeurs
    private String nom;
    private int capital;
    private Casino casino;

    //Constructeur sans argument
    public Joueur() {
        this("bob", 500);
    }

    //Constructeur avec 2 arguments
    public Joueur(String nom, int capital) {
        this.nom = nom;
        this.capital = capital;
        this.casino = null;
    }

    //Constructeur copie, il créer une copie d'un Joueur existant
    public Joueur(Joueur autre) {
        this(autre.nom, autre.capital);

    }

    //Getter/Setter
    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public int getCapital() {
        return capital;
    }

    public void setCapital(int capital) {
        this.capital = capital;
    }

    public void setCasino(Casino casino) {
        this.casino = casino;
    }

    public Casino getCasino() {
        return casino;
    }

    //Cette méthode print les informations du Joueur (nom, capital, casino)
    public String toString() {
        String chaine = "";
        if (this.casino == null) {
            chaine += "Nom: " + this.nom + "\nCapital: " + this.capital + "$\nCasino: Inconnu" + "\n";
        } else {
            chaine = "Nom: " + this.nom + "\nCapital: " + this.capital + "$\nCasino: " + this.casino.getNom() + "\n";
        }
        return chaine;
    }

    /**
     * Cette méthode regarde si un joueur est égal à un autre joueur
     *
     * @param autre (L'autre joueur)
     * @return Retourne FALSE si un des attributs n'est pas égal à l'attribut de l'autre joueur et
     * un TRUE si toute est pareil.
     */
    public boolean equals(Joueur autre) {
        if (!this.nom.equals(autre.nom)) {
            return false;
        }
        if (this.capital != autre.capital) {
            return false;
        }
        return true;
    }

    /**
     * Cette méthode regarde si le casino du player est null, si oui, elle assigne le casino qu'il rejoint et regarde aussi
     * si le joueur à asser de capital, si oui, on appel la méthode ajouterJoueur de la classe Casino pour ajouter le joueur
     * dans la casino sinon un message d'erreur est donner.
     *
     * @param casino (Un casino déja créer)
     */
    public void joindreCasino(Casino casino) {
        if (capital <= 0) {
            System.out.println("Vous n'avez pas asser d'argent, " + nom);
        } else if (this.casino != null) {
            System.out.println("Vous êtes déjà dans un casino, vous devez quitter votre casino avant de rejoindre un nouveau casino");
        } else {
            if (casino.ajouterJoueur(this)) {
                this.casino = casino;
            }
        }
    }

    /**
     * Cette méthode appel la méthode enleverJoueur de la classe Casino
     */
    public void quitterCasino() {
        if (this.casino == null) {
            System.out.println("Vous n'êtes pas dans un casino!");
        } else {
            this.casino.enleverJoueur(this);
            this.casino = null;
        }
    }

    //methode jouerPileouFace
    public void jouerPileouFace(int mise) {

        if (this.casino == null) {
            System.out.println(nom + " doit être dans le casino pour jouer");
        } else if (capital < mise) {

            System.out.println(nom + " n'a pas assez de capital pour miser " + mise);
        } else if (this.casino instanceof CasinoClandestin) {
            capital -= mise;
            capital += casino.jouerPileFace(mise) - mise;
            System.out.println("Voici votre nouveau capital: " + capital + "$");
        } else if (!((CasinoLegal)this.casino).getPeutJouer());

        else {
            capital -= mise;
            capital += casino.jouerPileFace(mise);
            System.out.println("Voici votre nouveau capital: " + capital + "$");

        }
    }

    //Methode jouerRoulette
    public void jouerRoulette(int mise, String couleur, int num) {
        if (this.casino == null) {
            System.out.println(nom + " doit être dans le casino pour jouer");
        } else if (capital < mise) {

            System.out.println(nom + " n'a pas assez de capital pour miser " + mise);
        } else if (this.casino instanceof CasinoClandestin) {
            capital -= mise;
            capital += casino.jouerRoulette(mise, couleur, num);
            System.out.println("Voici votre nouveau capital: " + capital + "$");
        } else if (!((CasinoLegal) this.casino).getPeutJouer()) ;

        else {
            capital -= mise;
            capital += casino.jouerRoulette(mise, couleur, num);
            System.out.println("Voici votre nouveau capital: " + capital + "$");

        }
    }

    //Methode compareTo (interface Comparable)
    public int compareTo(Object o) {
        Joueur autre = (Joueur) o;
        if (this.capital < autre.capital) {
            return -1;
        } else if (this.capital > autre.capital) {
            return 1;
        }
        return this.getNom().compareTo(autre.getNom());
    }

}
