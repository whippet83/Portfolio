package Casinos;

public interface ImpotsFonciers {

    //Methodde payerImpots pour les casino
    public abstract void playerImpots();

    //Methode evaluationMunicipale pour les casinos
    public default void evaluationMunicipale(Casino casino) {

        int total;
        total = 1000 * casino.getJoueurPresent();
        casino.setCapital(casino.getCapital() - total);
        System.out.println("La valeur du casino selon l'inspecteur municipale est de " + total + "$");


    }

}
