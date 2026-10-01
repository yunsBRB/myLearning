const valeurAdditionner = [1, 5, 32, 54];

function sommeTableau(array) {
    let somme = 0;
array.forEach(element => {
        somme += element;
    });
    return somme;
}
console.log(sommeTableau(valeurAdditionner));


const motLong = ["anticonstitutionnellement", "cafeine", "nicotine", "bonjour"];

function trouverMotLePlusLong(array) {
    let motLePlusLong = array.reduce((max, actuel) => {
        return actuel.length > max.length ? actuel : max;
    },"")
    return motLePlusLong
}
console.log(trouverMotLePlusLong(motLong));


const annéeBixestile =  3154;

function trouverAnnéeBixestile(ann) {

        if ((ann % 4 == 0 && ann % 100 !== 0 ) || ann % 400 == 0) {
            return true;
        }else{
            return false;
        }
};
console.log(trouverAnnéeBixestile(annéeBixestile));

const txt = ["Je", "s'appelle", "Yuns"];

function creationListe(array) 
{
const listeNonOrdonnee = document.createElement('ul');
    array.forEach(element => 
    {
        const listItem = document.createElement('li');
        listItem.innerText = element;
        listeNonOrdonnee.appendChild(listItem);
    });

    document.body.appendChild(listeNonOrdonnee);
}

creationListe(txt);
