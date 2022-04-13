package Jeux;

public abstract class Jeu {
    private String nom;

    //Constructeur sans argument
    public Jeu() {
        this.nom = "Pile ou Face";
    }

    //Constructeur avec 1 argument
    public Jeu(String nom) {
        this.nom = nom;
    }

    //Constructeur copie, il créer une copie d'un jeu existant
    public Jeu(Jeu autre) {
        this.nom = autre.nom;
    }

    //Getter pour avoir le nom du jeu
    public String getJeuNom() {
        return nom;
    }

    //Setter pour assigner un nom à un jeu
    public void setNom(String nom) {
        this.nom = nom;
    }

    /**
     * Cette méthode regarde si le jeu est égal à un autre jeu
     *
     * @param autre
     * @return Retourne FALSE si un des attributs n'est pas égal à l'attribut de l'autre jeu
     * sinon retourne TRUE si toute est pareil
     */
    public boolean equals(Jeu autre) {
        if (!this.nom.equals(autre.nom)) {
            return false;
        }
        return true;
    }

    //Cette méthode print les règles du jeu
    public String toString() {
        String chaine = "";

        return chaine;

    }

    //Methode calculerGain elle est abstract alors PileOuFace et Roulette son oubliger d'avoir cette methode
    //car ils extends la clase Jeu
    public abstract int calculerGain(int mise);
}
