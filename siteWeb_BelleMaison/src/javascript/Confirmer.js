function confirmer(formulaire)
{
    //var nom = document.getElementById("txtNom").value;
    var nom = formulaire.txtNom.value;
    var prenom = formulaire.txtPrenom.value;
    var email = formulaire.txtEmail.value;
    var adresse = formulaire.txtAdresse.value;
    var dateNaissance = formulaire.txtDate.value;

    //var prenom = document.getElementById("txtPrenom").value;
    //var email = document.getElementById("txtEmail").value;
    //var adresse = document.getElementById("txtAdresse").value;
    //var dateNaissance = document.getElementById("txtDate").value;

   confirm("Nom:" + nom + "\nPrénom:" + prenom + "\nEmail:" + email + "\nAdresse:" + adresse +
    "\nDate de naissance:" + dateNaissance + "\nConfirmer Client enregistré !");


}