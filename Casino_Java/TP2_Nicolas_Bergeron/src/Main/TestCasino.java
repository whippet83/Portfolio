package Main;

import Casinos.Casino;
import Jeux.Jeu;
import Joueurs.Joueur;

public class TestCasino {
    public static void main(String[] args) {

        /*//Création des Casino
        Casino casino1 = new Casino("Casino de Montreal",1);
        Casino casino2 = new Casino("Casino de Tremblant",2);
        Casino casino3 = new Casino("Casino de BOB",10);

        //Création des Joueurs
        Joueur player = new Joueur("bob", 10);
        Joueur player2 = new Joueur("Arnaud", 200);
        Joueur player3 = new Joueur("bobette", 500);
        Joueur player4 = new Joueur("Alain", 69);
        Joueur player5 = new Joueur("Terry", 0);

        //Création du Casino copie
        Casino copie = new Casino(casino1);

        separation();
        System.out.println("FAIT APPARAITRE UN MESSAGE QUAND IL Y A AUCUN JOUEURS DANS LE CASINO\n");
        System.out.println(casino1);
        System.out.println(casino2);
        separation();

        System.out.println("MESSAGE POUR COPIE DU CASINO ET CHECK AUSSI SI COPIE EST ÉGAL À CASINO1\n");
        System.out.println(copie);
        System.out.println(copie.equals(casino1));
        separation();

        System.out.println("SETTER GETTER CASINO\n");
        System.out.println("Nom Casino1: " + casino1.getNom());
        System.out.println("Joueur Max Casino2: " + casino2.getJoueurPresent());
        System.out.println("Nom Casino3: " + casino3.getNom());
        casino3.setNom("Casino de Vegas");
        System.out.println("Nouveau Nom Casino3: " + casino3.getNom());
        separation();

        System.out.println("INFORMATION SUR TOUTE LES JOUEURS CRÉÉS AVANT DE JOINDRE UN CASINO\n");
        System.out.println(player);
        System.out.println(player2);
        System.out.println(player3);
        System.out.println(player4);
        System.out.println(player5);
        separation();

        System.out.println("CRÉATION DE PLAYERCOPIE ET CHECK SI PLAYERCOPIE EST ÉGAL À PLAYER\n");
        Joueur playerCopie = new Joueur(player);
        System.out.println("PLayer:\n" + player);
        System.out.println("PlayerCopie:\n" + playerCopie);
        System.out.println(playerCopie.equals(player));
        separation();


        System.out.println("GETTER SETTER JOUEURS\n");
        System.out.println("Nom player2: " + player2.getNom());
        System.out.println("Nom player5: " + player5.getNom());
        player5.setNom("Steve");
        System.out.println("Nouveau Nom player5: " + player5.getNom());
        System.out.println("Capital player3: " + player3.getCapital());
        separation();

        System.out.println("CRÉATION DE JEU ET COPIE ET REGARDE SI LES 2 SONT ÉGAL\n");
        Jeu game = new Jeu();
        Jeu gameCopie = new Jeu(game);
        System.out.println(game.equals(gameCopie));
        separation();

        System.out.println("SETTER GETTER JEU\n");
        System.out.println("Nom game: " + game.getJeuNom());
        game.setNom("bob");
        System.out.println("Nouveau Nom game: " + game.getJeuNom());
        separation();

        System.out.println("MESSAGE D'ERREUR SI LE CASINO EST PLEIN ET SI LE JOUEUR N'A PAS D'ARGENT\n");
        player.joindreCasino(casino1);
        player2.joindreCasino(casino1);
        player2.joindreCasino(casino2);
        player3.joindreCasino(casino2);
        player4.joindreCasino(casino2);
        player5.joindreCasino(casino2);
        separation();

        System.out.println("LA LISTE DES JOUEURS DANS CASINO DE MONTREAL (CASINO1) ET CASINO DE TREMBLANT (CASINO2)\n");
        System.out.println(casino1);
        separation();
        System.out.println("VOICI L'INTERIEUR DU TABLEAU JOUEURS POUR CASINO1\n");
        casino1.tableauJoueur();
        separation();

        System.out.println(casino2);
        separation();
        System.out.println("VOICI L'INTERIEUR DU TABLEAU JOUEURS POUR CASINO2\n");
        casino2.tableauJoueur();
        separation();

        System.out.println("VOICI LES JOUEURS APRÈS AVOIR REJOINT UN CASINO\n");
        System.out.println(player);
        System.out.println(player2);
        System.out.println(player3);
        System.out.println(player4);
        System.out.println(player5);
        separation();

        System.out.println("MESSAGE D'ERREUR SI LE JOUEUR ESSAYE DE QUITTER UN CASINO MAIS IL N'EST PAS SUR LA LISTE\n");
        player5.quitterCasino();
        separation();

        System.out.println("MESSAGE QUE ARNAUD EST PARTIT DU CASINO\n");
        player2.quitterCasino();
        separation();

        System.out.println("UPDATE SUR LES JOUEURS DANS CASINO2, BOBETTE DEVIEN LA SEULE JOUEURE\n");
        System.out.println(casino2);
        separation();

        System.out.println("VOICI L'INTERIEUR DU TABLEAU JOUEURS POUR CASINO2\n");
        casino2.tableauJoueur();
        separation();

        System.out.println("MESSAGE QUE BOBETTE EST PARTIT DU CASINO\n");
        player3.quitterCasino();
        separation();

        System.out.println("MESSAGE QUAND UN CASINO N'A PLUS DE JOUEURS\n");
        System.out.println(casino2);
        separation();

        System.out.println("VOICI L'INTERIEUR DU TABLEAU JOUEURS POUR CASINO\n");
        casino2.tableauJoueur();
        separation();

        System.out.println("UPDATE SUR LES INFORMATIONS À ARNAUD ET BOBETTE\n");
        System.out.println(player2);
        System.out.println(player3);
        separation();

        System.out.println("MESSAGE D'ERREUR SI JOUEUR QUI N'EST PAS DANS CASINO ESSAYE DE JOUER AU JEU\n");
        player5.jouer( 10);
        separation();

        System.out.println("MESSAGE D'ERREUR SI JOUEUR N'A PAS ASSEZ DE CAPITAL POUR MISER LA MISE DONNÉ\n");
        player.jouer(15);
        separation();

        System.out.println("LE JOUEUR JOUE AU JEU ET OPTIENT UN NOUVEAU CAPITAL A LA FIN\n");
        player.jouer(10);
        separation();

        System.out.println("VOICI LES NOUVELLES INFORMATIONS DE BOB\n");
        System.out.println(player);
        separation();*/

    }

    /**
     * Cette méthode print 120 fois "_" pour faire une séparation entre les informations donné dans la console.
     */
    private static void separation() {
        for (int ligne = 0; ligne <= 120; ligne++) {
            System.out.print("_");
        }
        System.out.println();
    }
}
