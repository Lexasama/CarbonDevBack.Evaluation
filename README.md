# Digital Factory - Commercialité Fnac

## Instructions

* Traitez les exos dans l'ordre que vous souhaitez
* Renseignez le fichier *DEVNOTES.md* avec vos questions, remarques, suggestions (Facultatif)
* Bon courage !


## Livrable
* Soit un zip de la solution sans les dossiers *bin* et *obj* (par mail, modifiez l'extension en .zip.txt)
* Soit un lien vers votre repo (github par exemple)



## Evaluation


### 1. Leap

Langage : C# - Durée estimée : 5-10 min

> Enoncé : 
> Votre programme doit déterminer si l'année passée en paramètre est bissextile.
>
> Dans le calendrier grégorien une année bissextile respecte les conditions suivantes : 
> Toutes les années qui sont divisibles par 4,
> à l'exception des années qui sont divisibles par 100
> sauf si l'année est ausi divisible par 400.
>
> Par exemple, 1997 n'est pas une année bissextile,
> mais 1996 l'est, 1900 ne l'est pas mais 2000 l'est.



### 2. Refacto

Langage : C# - Durée estimée : 15-20 min

> Enoncé :
> Vous devez refactoriser la méthode *CalculateDiscount*.



### 3. Calcul

Langage : C# - Durée estimée : 5-10 min

> Enoncé : 
> - Vérifier si les tests unitaires sont ok
> - Corriger les tests unitaires en erreur
> - Décommenter le test *Test_Factorial* et corriger le test
> - Implémenter les tests associés à la méthode Fraction de *ICalculusServices*
> - Exécuter le programme et faites en sorte qu'il n'y'ait pas de soucis à l'exécution

### 4. Customer

Language : TSQL - Durée estimée : 15-20 min

> Enoncé :
> A l'aide du fichier *Schema.jpg*, renseignez les scripts suivants :
> - *Script1.sql* : Creation d'une procédure stockée qui renvoie l'ID, le prénom et nom du client
>   ainsi que toutes les informations de commandes. En paramètres facultatifs, l'ID du client
>   et l'ID de la commande.
> - *Script2.sql* : Création d'une procédure stockée permettant de sélectionner les 5 clients
>   ayant effectué le plus de commandes un jour donné (valeur passée en paramètre) puis d'insérer
>   dans une table de stats, l'ID des clients, le jour spécifié et le nombre de commandes effectuées.
>   Si la table de stats n'existe pas, il faudra la créer.
>   Attention : Pour le mois d'août, aucune stats ne devra être enregistrée.