let secondes = 0;
let lancement = false;

document.getElementById("lancer").addEventListener("click", () => {
    lancement = true;
    setTimeout(function chrono() {
        if (!lancement) return;
        secondes++;
        const date = new Date(secondes * 1000);
        document.getElementById("timer").textContent = date.toISOString().slice(11, 19);
        setTimeout(chrono, 1000);
    }, 1000);
});

document.getElementById("arret").addEventListener("click", () => {
    lancement = false;
});

document.getElementById("champ").addEventListener("input", () => {
    console.log(document.getElementById("champ").value);
});

function survoler() {
    document.body.classList.add("rouge");
}

function quitter() {
    document.body.classList.remove("rouge");
}

document.getElementById("cacher").addEventListener("click", () => {
    document.getElementById("cacher").style.display = "none";
});

document.getElementById("heure").addEventListener("click", () => {
    const maintenant = new Date();
    alert(maintenant.toLocaleTimeString());
});

const btnHide = document.getElementById ("hideIn");
let isActivated = true;
btnHide.addEventListener ('click', () =>(
 