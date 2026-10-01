const message = "Hello World!";
console.log(message);
console.log('Message log');
console.debug('Message de debug');
console.warn('Message d\'avertissement');
console.error('Message d\'erreur');
// alert('Hello World ♥'); 
// prompt('Veuillez entrer un message');
// confirm('C\est bon pour vous ?');
const displayMessage = document.getElementById('display-message');
console.log(displayMessage);

const inputName = document.getElementById('input-name');     // input est toujours de type string
const btnDemo = document.getElementById('btn-demo');

btnDemo.addEventListener('click', function() {
    const name = inputName.value;
    console.log('Bonjour ' + name);
});


const chien = {
    nom: 'Rex',
    race: 'Berger Allemand',
};


chien['nom'] = 'Rex';
chien['race'] = 'Berger Allemand';

const identité = chien['nom'] + ' le ' + chien['race'];
console.log(identité);

// ex 1

const inputAge = document.getElementById('input-age');
const btnDemo2 = document.getElementById('btn-demo2');

btnDemo2.addEventListener('click', function() {
    const age = parseInt(inputAge.value);
    if (age >= 18) 
    {
        console.log('L\'âge est super ou égal à 18, vous êtes majeur.');
    } else 
    {
        console.log('L\'âge est inférieur à 18, vous n\'êtes pas majeur.');
    }
});


// ex 2

const inputjour = document.getElementById('input-jour');
const btnDemo3 = document.getElementById('btn-demo3');

btnDemo3.addEventListener('click', function() 
{
    const jour = inputjour.value.toLowerCase();

if (jour === 'lundi' || jour === 'mardi' || jour === 'mercredi' || jour === 'jeudi' || jour === 'vendredi') 
    {
    console.log('C\'est un jour de la semaine');
    
    } 
else if (jour === 'samedi' || jour === 'dimanche') 
    {
    console.log('C\'est un jour du week-end');
    }
});

// ex 3 

const inputNb = document.getElementById('input-nb');
const btnDemo4 = document.getElementById('btn-demo4');

btnDemo4.addEventListener('click', function() 
{
    const nb = parseInt(inputNb.value);
    if (nb % 2 === 0) 
    {
        console.log('Le nombre ' + nb + ' est pair.');
    } 
    else
    {
        console.log('Le nombre ' + nb + ' est impair.');
    }
});

// ex 4

const inputChoix = document.getElementById('input-choix').value.toLowerCase();
const btnDemo5 = document.getElementById('btn-demo5');

btnDemo5.addEventListener('click', function() 
{
    const choix = document.getElementById('input-choix').value.toLowerCase();

switch (choix) 
    {
        case 'a':
            console.log('Vous avez choisi l\'option A');
        break;
        case 'b':
            console.log('Vous avez choisi l\'option B');
        break;
        case 'c':
            console.log('Vous avez choisi l\'option C');
        break;
        default:
            console.log('Option invalide');
        break;
    }

});

// const cardimg = document.createElement('img');
// cardimg.src = "image.jpg";

// const cardtext = document.createElement('p');
// cardtext.textContent = "J'ai passé un super week-end à Fort-Mahon-PLage.";

// const cardtitle = document.createElement('h1');
// cardtitle.textContent = "Mon week-end à la mer";

// const cards = document.createElement('div');
// cards.appendChild(cardtitle);
// cards.appendChild(cardtext);
// cards.appendChild(cardimg);

cards.removeChild(cardtext); // permet de retirer un élément du DOM

document.body.appendChild(cards);


// Ex boucles

// Ex 1
let nb2 = [];

for (let i = 0; i < 10; i++)
{
    nb2.push(i);
}
console.log(nb2);
