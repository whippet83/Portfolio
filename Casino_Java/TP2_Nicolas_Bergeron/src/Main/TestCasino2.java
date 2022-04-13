package Main;

import Casinos.Casino;
import Casinos.CasinoClandestin;
import Casinos.CasinoLegal;
import Jeux.Jeu;
import Jeux.PileOuFace;
import Jeux.Roulette;
import Joueurs.Joueur;
import Joueurs.JoueurPauvre;
import Joueurs.JoueurRiche;


public class TestCasino2 {
    public static void main(String[] args) {

        CasinoLegal casino1 = new CasinoLegal("Casino de Montreal", 2);
        CasinoClandestin casino2 = new CasinoClandestin("Casino de Tremblant", 2);
        CasinoLegal copieLegal = new CasinoLegal(casino1);
        CasinoClandestin copieIlegal = new CasinoClandestin(casino2);

        JoueurPauvre player = new JoueurPauvre("Steeve", 1000);
        JoueurPauvre player2 = new JoueurPauvre("Ti-Bob", 1);
        JoueurRiche player3 = new JoueurRiche("Jean", 10000);
        JoueurRiche player4 = new JoueurRiche("Alex", 500);
        JoueurRiche player5 = new JoueurRiche("Alain", 1000);

        JoueurPauvre copiePauvre = new JoueurPauvre(player);
        JoueurRiche copieRiche = new JoueurRiche(player3);


        separation();
        System.out.println("FAIT APPARAITRE UN MESSAGE QUAND IL Y A AUCUN JOUEURS DANS LE CASINO\n");
        System.out.println(casino1);
        System.out.println(casino2);
        separation();

        System.out.println("MESSAGE POUR COPIE DU CASINO ET CHECK AUSSI SI COPIE EST ÉGAL À CASINO1\n");
        System.out.println(copieLegal);
        System.out.println(copieLegal.equals(casino1));
        separation();

        System.out.println("MESSAGE POUR COPIE DU CASINO ET CHECK AUSSI SI COPIE EST ÉGAL À CASINO2\n");
        System.out.println(copieIlegal);
        System.out.println(copieIlegal.equals(casino2));
        separation();

        System.out.println("SETTER GETTER CASINO LEGAL\n");
        System.out.println("Nom CopiLegal: " + copieLegal.getNom());
        copieLegal.setNom("Casino de Vegas");
        System.out.println("Nouveau Nom CopiLegal: " + copieLegal.getNom());
        System.out.println("Captal du casino:" + copieLegal.getCapital());
        separation();

        System.out.println("SETTER GETTER CASINO CLANDESTIN\n");
        System.out.println("Nom CopieIlegal: " + copieIlegal.getNom());
        copieIlegal.setNom("Casino de Vegas");
        System.out.println("Nouveau Nom CopieIlegal: " + copieIlegal.getNom());
        System.out.println("Captal du casino:" + copieIlegal.getCapital());
        separation();

        System.out.println("INFORMATION SUR TOUTE LES JOUEURS CRÉÉS AVANT DE JOINDRE UN CASINO\n");
        System.out.println(player);
        System.out.println(player2);
        System.out.println(player3);
        System.out.println(player4);
        System.out.println(copiePauvre);
        System.out.println(copieRiche);
        separation();

        System.out.println("CHECK SI copiePauvre EST ÉGAL À PLAYER\n");
        System.out.println("PLayer:\n" + player);
        System.out.println("copiePauvre:\n" + copiePauvre);
        System.out.println(copiePauvre.equals(player));
        separation();

        System.out.println("CHECK SI copieRiche EST ÉGAL À PLAYER3\n");
        System.out.println("PLayer:\n" + player3);
        System.out.println("copieRiche:\n" + copieRiche);
        System.out.println(copieRiche.equals(player3));
        separation();

        System.out.println("GETTER SETTER JOUEURS\n");
        System.out.println("Nom player2: " + player2.getNom());
        copieRiche.setNom("Steve");
        System.out.println("Nouveau Nom player2: " + player2.getNom());

        System.out.println("Nom copieRiche: " + copieRiche.getNom());
        copieRiche.setNom("Steve");
        System.out.println("Nouveau Nom copieRiche: " + copieRiche.getNom());
        separation();

        System.out.println("CRÉATION DE JEU PileOuFace ET COPIE ET REGARDE SI LES 2 SONT ÉGAL\n");
        PileOuFace gamePileFace = new PileOuFace();
        PileOuFace gameCopie = new PileOuFace(gamePileFace);
        System.out.println(gamePileFace.equals(gameCopie));
        separation();

        System.out.println("CRÉATION DE JEU roulette ET COPIE ET REGARDE SI LES 2 SONT ÉGAL\n");
        Roulette gameRoulette = new Roulette();
        Roulette rouletteCopie = new Roulette(gameRoulette);
        System.out.println(gameRoulette.equals(rouletteCopie));
        separation();

        System.out.println("SETTER GETTER JEU\n");
        System.out.println("Nom game: " + gamePileFace.getJeuNom());
        gamePileFace.setNom("bob");
        System.out.println("Nouveau Nom game: " + gamePileFace.getJeuNom());

        System.out.println("Nom game: " + gameRoulette.getNomRoulette());
        gameRoulette.setNom("bobette");
        System.out.println("Nouveau Nom game: " + gameRoulette.getNomRoulette());
        separation();

        System.out.println("MESSAGE D'ERREUR SI LE CASINO EST PLEIN ET SI LE JOUEUR N'A PAS ASSER D'ARGENT\n");
        player.joindreCasino(casino1);
        player3.joindreCasino(casino1);
        copiePauvre.joindreCasino(casino1);
        player2.joindreCasino(casino2);
        player4.joindreCasino(casino2);
        separation();

        System.out.println("PREUVE QU'IL A UN SEUL TABLEAU AVEC UN JOUEUR PAUVRE ET JOUEUR RICHE");
        casino1.tableauJoueur();
        separation();

        System.out.println("INTERFACE IMPOTFONCIERS MÉTHODE#1 PAYERIMPOT() POUR UN CASINO LEGAL");
        casino1.playerImpots();
        separation();

        System.out.println("INTERFACE IMPOTFONCIERS MÉTHODE#1 PAYERIMPOT() POUR UN CASINO CLANDESTIN");
        for (int i = 0; i < 50; i++) {
            casino2.playerImpots();
        }
        separation();

        System.out.println("INTERFACE IMPOTFONCIERS MÉTHODE#2 EVALUATIONMUNICIAPLE() POUR UN CASINO LEGAL ET CLANDESTIN");
        System.out.println("Capital Casino1:"+casino1.getCapital());
        casino1.evaluationMunicipale(casino1);
        System.out.println("Capital Casino1:"+casino1.getCapital());
        System.out.println("Capital Casino2:"+casino1.getCapital());
        casino2.evaluationMunicipale(casino2);
        System.out.println("Capital Casino2:"+casino1.getCapital());
        separation();

        System.out.println("INTERFACE COMPARABLE POUR CASINO");
        System.out.println(casino1.compareTo(casino2));
        separation();

        System.out.println("CLASSE CASINOLEGAL");
        System.out.println();
        separation();

        System.out.println("MÉTHODE DEBUTSPECTABLE ET FIN SPECTABLE ET VOIR AUSSI QUE LE CAPITAL DU CASINO MODIFIER QUAND PLAYER GAGNE OU PERD");
        System.out.println("capital Casino:" + casino1.getCapital());
        player3.jouerPileouFace(200);
        System.out.println("capital Casino:" + casino1.getCapital());
        separation();
        casino1.debutSpectacle();
        player3.jouerPileouFace(500);
        casino1.finSpectacle();
        separation();
        player3.jouerPileouFace(500);
        separation();

        System.out.println("CASINO CLADESTIN MÉTHODE DESCENTEDEPOLICE() ET VOIR AUSSI QUE LE CAPITAL DU CASINO MODIFIER QUAND PLAYER GAGNE OU PERD");

        copiePauvre.joindreCasino(casino2);
        copieRiche.joindreCasino(casino2);

        System.out.println();
        System.out.println(casino2);
        separation();
        System.out.println("capital Casino:" + casino2.getCapital());
        copieRiche.jouerPileouFace(500);
        System.out.println("capital Casino:" + casino2.getCapital());
        separation();
        casino2.descenteDePolice();
        System.out.println(casino2);
        separation();

        System.out.println("INTERFACE COMPARABLE POUR JOUEUR");
        System.out.println(player.compareTo(player5));
        System.out.println(player.compareTo(player3));
        separation();

        System.out.println("CLASSE JOUEUR PAUVRE");
        separation();
        System.out.println("MÉTHODE COLLECTERCHEQUE()");
        player.collecterCheque();
        separation();

        System.out.println("CLASSSE JOUEUR RICHE");
        separation();
        System.out.println("MÉTHODE BANQUEROUTE()");
        player3.banqueRoute();
        separation();
        System.out.println("MESSAGE SI PLAYER EST PAS DANS LE CASINO QUAND LA MÉTHODE BANQUEROUTE() EST APPELER");
        player5.banqueRoute();
        separation();

        System.out.println("JEU PILE OU FACE");
        player.jouerPileouFace(100);
        separation();

        System.out.println("JEU DE ROULETTE");
        player.jouerRoulette(200, "Rouge", 10);
        separation();


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
