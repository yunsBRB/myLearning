const readme = document.getElementById('lisez-moi');
const bjr = document.getElementById('Bonjour-HTML');
const liste = document.getElementById('liste-animaux');

bjr.addEventListener('click', () => {
    bjr.textContent = 'Bonjour Javascript';
    bjr.classList.add('red');
readme.classList.add('color-red');


const chien = document.createElement('li');
chien.textContent = 'Chien';
liste.appendChild (chien);

const chat = document.createElement('li');
chat.textContent = 'Chat';
liste.appendChild (chat);

chat.addEventListener('click', () => {
    alert('Miaouw');
});


    console.log(bjr.textContent);
});
