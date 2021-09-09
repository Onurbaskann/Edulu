var cards = document.querySelectorAll('.memory-card');

cards.forEach(x => x.addEventListener('click', flipcard, { passive: true }));

var hasFlippedCard = false;
var firstCard, secondCard;
var lockBoard = false; //if first and second card are clicked,the third card cannot clicked

function flipcard() {

    if (lockBoard) return;
    if (this === firstCard) return; //card double click

    this.classList.toggle("flip"); //added 'flip' class next to 'memory-card' class

    if (!hasFlippedCard) {
        //fisrt card
        hasFlippedCard = true;
        firstCard = this;
    } else {
        //second card
        hasFlippedCard = false;
        secondCard = this;

        //do cards match?
        checkForMatch();
    }
}

function checkForMatch() {
    var isMatch = firstCard.dataset.spells === secondCard.dataset.spells; //The syntax 'element.dataset.keyname' is used because we are using the 'data-*' attribute.   
    isMatch ? disableCard() : unFlipCard(); //condition ? expr1(true) : expr2(false)
}
//remove flipcard function
function disableCard() {
    firstCard.removeEventListener('click', flipcard);
    secondCard.removeEventListener('click', flipcard);

    resetBoard();
}
//remove flip class
function unFlipCard() {
    lockBoard = true;
    setTimeout(() => { //time between first click and second click 
        if (firstCard.classList.contains("flip") /*contains=>check 'flip' class*/) {
            firstCard.classList.remove("flip");
        }
        if (secondCard.classList.contains("flip")) {
            secondCard.classList.remove("flip");
        }
        resetBoard();
    }, 1000 /*delay time*/);
}

function resetBoard() {
    /*es6 destructuring assignment=> [var1,var2]=[value1,value2];*/
    //var1='value1'
    //var2='value2'
    [hasFlippedCard, lockBoard] = [false, false];
    [firstCard, secondCard] = [null, null];
}
/*flexbox properly*/
(function shuffle() {
    cards.forEach(x => {
        var randomPos = Math.floor(Math.random() * 12);
        x.style.order = randomPos;
    });
})();

function updateDiv() {
    window.location.reload(false);
}