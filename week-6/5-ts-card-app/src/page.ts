import CardService from "./card-service";
import Card from "./card";

export default class Page {
    cardContainer: HTMLElement | null = null;
    newDeck: HTMLElement | null = null;
    drawCard: HTMLElement | null = null;
    cardService: CardService;

    constructor(cardService: CardService) {
        this.cardService = cardService;

        document.addEventListener('DOMContentLoaded', () => {
            this.cardContainer = document.getElementById('card-container');
            this.newDeck = document.getElementById('new-deck');
            this.drawCard = document.getElementById('draw-card');
        });
    }

    run() {
        document.addEventListener('DOMContentLoaded', () => {
            // set up new deck action
            this.newDeck?.addEventListener('click', () => {
                this.cardService.newDeck().then(() => {
                    // TODO: empty the card container of any existing cards
                    if(this.cardContainer != null)
                        this.cardContainer.innerHTML = "<p>Empty</p>";
                }, (error: Error) => {
                    // TODO: display error
                    console.log("There was an error getting a new deck.")
                });
            });

            // set up draw card action
            this.drawCard?.addEventListener('click', () => {
                this.cardService.drawCard().then((card: Card) => {
                    // TODO: add the card to the card container
                    if(this.cardContainer != null)
                        this.cardContainer.innerHTML += card;
                }, (error: Error) => {
                    // TODO: display error
                    console.log("There was an error drawing a card. Hello from page.");
                });
            });
        });
    }
}
