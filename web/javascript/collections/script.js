const fruits = ["pomme", "banane", "fraise", ];

console.table(fruits);

console.table(fruits.indexOf("fraise"));

const cinq = fruits.filter(function(nom) {
    return nom.length === 5;
});

const majuscule = fruits.map(fruit => fruit.toUpperCase());
console.table(majuscule);


const personnes = [
    { nom: "Berebia", prenom: "Younes", age: 27 },
    { nom: "Cena", prenom: "John", age: 25 },
    { nom: "Mandela", prenom: "Nelson", age: 125 }
];

personnes.shift();

personnes.unshift({ nom: "smith", prenom: "Will", age: 22 });

personnes.sort((a, b) => a.age - b.age);
console.table(personnes);

personnes.push({ nom: "uzumaki", prenom: "naruto", age: 40 });

personnes.splice(1, personnes.length - 2);
console.table(personnes);
