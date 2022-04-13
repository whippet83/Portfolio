function calculer(formulaire) {

var montant = formulaire.montant.value;
var taux = formulaire.taux.value;
var terme = formulaire.terme.value;

var payeMensuel = trouvePaiement(montant, taux / 12, terme * 12);

//todo try to fix this shit before giving it to prof !!!!!!
//$('#paiement').val(payeMensuel.toLocaleString('en-US', { minimumFractionDigits: 2 }));

alert("Montant de l'emprunt: $" + montant + "\nTaux d'intérêt annuel: " + taux + "%" +
"\nAmortissement: " + terme + " années" + "\n\nPaiement mensuel: $" + payeMensuel)
}

function trouvePaiement(pr, ini, pe) {
    var paye = (pr * ini) / (1 - Math.pow(1 + ini, -pe));
    return paye;
}