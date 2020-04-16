const guesses = document.querySelector('.guesses');
const lastResult = document.querySelector('.lastResult');
const lowOrHigh = document.querySelector('.lowOrHigh');
const guessSubmit = document.querySelector('.guessSubmit');
const guessField = document.querySelector('.guessField');
const header1 = document.querySelector('.header1');

guessSubmit.addEventListener('click', checkGuess);

let randomNumber = Math.floor(Math.random()*100) + 1;

let guessCount = 1;

function checkGuess(){
	if(guessCount < 11){
		let userGuess = Number(guessField.value);
		if(guessCount === 1){
			guesses.textContent = 'Previous guess:';
		}
		guesses.textContent += ' ' + userGuess;
		
		if(userGuess === randomNumber){
			lastResult.style.backgroundColor = 'green';
			lastResult.textContent = 'You win!';
			header1.textContent = 'You guessed the number.';
			guessCount = 10;
		}
		else if(guessCount === 10){
			lastResult.style.backgroundColor = 'red';
			lastResult.textContent = 'Game over!';
			header1.textContent = 'Refresh to try again.';
		}
		else{
			lastResult.textContent = 'Wrong number';
			if(userGuess < randomNumber){
				lowOrHigh.textContent = 'Too low';
			}
			else{
				lowOrHigh.textContent = 'Too high';
			}
		}
		guessCount++;
		guessField.value = '';
	}
}