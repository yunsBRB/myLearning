const nombres = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

for (let i = 0; i < nombres.length; i++) {
    console.log(nombres[i]);
}

let somme = 0;

for (let i = 0; i < nombres.length; i++) {
    somme = somme + nombres[i];
}

console.log("somme =", somme);

const tableau = [];

for (let i = 0; i < 10; i++) {
  tableau.push (Math.pow(i, 2));

}
console.log (tableau);