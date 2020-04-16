import Card from "./card";

// communicates with Deck of Cards API (https://deckofcardsapi.com/)
// to implement some card operations
// TODO: implement

export default class CardService {
    deckId: string | null = null;

    newDeck(): Promise<void> {
        return fetch ('https://deckofcardsapi.com/api/deck/new/')
                .then(res => res.json())
                .then(resOb => { this.deckId = resOb.deck_id; });
    }

    drawCard(): Promise<Card> {
        return fetch (`https://deckofcardsapi.com/api/deck/${this.deckId}/draw/?count=1`)
                .then(res => res.json())
                .then(resOb => resOb.cards[0] as Card);
    }
}
