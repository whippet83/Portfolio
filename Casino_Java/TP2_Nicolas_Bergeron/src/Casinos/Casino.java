package Casinos;

import Jeux.Jeu;
import Jeux.PileOuFace;
import Jeux.Roulette;
import Joueurs.Joueur;
import Joueurs.JoueurPauvre;
import Joueurs.JoueurRiche;

public abstract class Casino implements ImpotsFonciers, Comparable {

    //Les attributs pour les constructeurs.
    private String nom;
    private int joueursPresent;
    private Joueur joueurs[];
    private int capital;
    private Jeu pileFace;
    private Jeu roulette;


    //Constructeur sans argument pour créer un casino.
    public Casino() {
        this("Nom à venir", 5);
        this.capital = 100000;
    }

    //Constructeur avec 2 argument pour créer un casino.
    public Casino(String nom, int joueurmax) {
        this.nom = nom;
        this.capital = 100000;
        joueursPresent = 0;
        joueurs = new Joueur[joueurmax];
        pileFace = new PileOuFace();
        roulette = new Roulette();
    }

    //Constructeur par copie
    public Casino(Casino autre) {
        this(autre.nom, autre.joueurs.length);
        this.capital = 100000;
        pileFace = new PileOuFace();
        roulette = new Roulette();

    }

    //Methode equals
    public boolean equals(Casino autre) {
        if (!this.nom.equals(autre.nom)) {
            return false;
        }
        if (!this.pileFace.equals(autre.pileFace)) {
            return false;
        }
        if (!this.roulette.equals(autre.roulette)) {
            return false;
        }
        if (this.joueurs.length != autre.joueurs.length) {
            return false;
        }
        return true;
    }

    //Getter/Setter
    public String getNom() {
        return nom;
    }

    public void setNom(String nom) {
        this.nom = nom;
    }

    public void setCapital(int capital) {
        this.capital = capital;
    }

    public int getCapital() {
        return capital;
    }

    public int getJoueurPresent() {
        return joueursPresent;
    }

    public Joueur[] getJoueurs() {
        return joueurs;
    }

    public Jeu getJeuPileouFace() {
        return pileFace;
    }

    public Jeu getJeuRoulette() {
        return roulette;
    }

    //Methde toString
    public String toString() {
        String chaine;
        chaine = "";
        if (joueursPresent > 0) {
            chaine += nom + "\nIl y a " + joueursPresent + " joueurs dans le casino.\nVoici le capital du Casino:" + capital + "\nVoici la liste des joueurs présents:";
            for (int i = 0; i < joueursPresent; i++) {
                chaine += "\n\nJoueur" + (i + 1) + "\n" + joueurs[i];
            }
            chaine += "\nVoici les règles du jeu#1 " + pileFace.getJeuNom() + pileFace;
            chaine += "\nVoici les règles du jeu#2 " + ((Roulette) roulette).getNomRoulette() + roulette;
        } else {
            chaine += nom + " a aucun joueurs présentement.";
        }

        return chaine;
    }

    //Methode jouerPileFace (pour le jeu pile ou face)
    public int jouerPileFace(int mise) {
        int total;

        setCapital(getCapital() + mise);

        total = pileFace.calculerGain(mise);

        if (total > mise) {
            setCapital(getCapital() - total);
        }
        return total;
    }

    //methode jouerRoulette (pour le jeu roulette)
    public int jouerRoulette(int mise, String couleur, int num) {
        int total;
        setCapital(getCapital() + mise);

        ((Roulette) roulette).setNum(num);
        ((Roulette) roulette).setCouleur(couleur);
        total = roulette.calculerGain(mise);

        if (total > mise) {
            setCapital(getCapital() - total);
        }
        return total;
    }

    //Cette méthode rajoute un joueur dans le tableau joueurs et donne un message d'erreur si le casino est plein
    //et elle est appeler par joindreCasino  dans la classe Joueur seulement.
    public boolean ajouterJoueur(Joueur joueur) {

        if (joueursPresent >= joueurs.length) {
            System.out.println("Désolé " + joueur.getNom() + " le casino est plein");
            return false;
        } else if (joueur.getCapital() < 10 && joueur instanceof JoueurPauvre) {
            System.out.println("Ta pas assez de capital le pauvre");
            return false;
        } else if (joueur.getCapital() < 1000 && joueur instanceof JoueurRiche) {
            System.out.println("Vous avez pas asser de capital pour rentrer dans le casino");
            return false;
        } else {
            joueurs[joueursPresent] = joueur;
            joueursPresent++;
            return true;
        }

    }

    //Methode enleverJoueur (enleve joueur du tableau joueurs du casino)
    public void enleverJoueur(Joueur joueur) {
        int indice;
        indice = chercherJoueur(joueur);

        if (indice > -1) {
            joueurs[indice] = null;

            for (int i = indice; i < joueurs.length - 1; i++) {
                joueurs[i] = joueurs[i + 1];
            }
            joueurs[joueursPresent - 1] = null;
            joueursPresent--;
            System.out.println(joueur.getNom() + " est parti du casino.");
        } else {
            System.out.println(joueur.getNom() + " ne peut pas quitter le casino car il n'est pas dans le casino");
        }
    }

    //Methode chercherJoueur (cherche le joueur dans le tableau joueur elle est appeler dans enleverjoueur)
    public int chercherJoueur(Joueur joueur) {
        int indice = -1;
        for (int i = 0; i < joueursPresent; i++) {
            if (joueurs[i].equals(joueur)) {
                indice = i;
                break;
            }
        }
        return indice;
    }

    //Methode tableauJoueur
    public void tableauJoueur() {
        for (int i = 0; i < joueurs.length; i++) {
            System.out.println(joueurs[i]);
        }
    }

    //Methode sumPlayerCasino
    public int sumPLayerCasino() {
        int total = 0;

        for (int i = 0; i < joueursPresent; i++) {
            if (joueurs[i] == null) {
                break;
            }
            total = total + joueurs[i].getCapital();
        }
        return total;
    }

    //Methode compareTo (interface Comparable)
    public int compareTo(Object o) {
        Casino autre = (Casino) o;

        if (this.sumPLayerCasino() < autre.sumPLayerCasino()) {
            return -1;
        } else if (this.sumPLayerCasino() > autre.sumPLayerCasino()) {
            return 1;
        }
        return 0;
    }

}
