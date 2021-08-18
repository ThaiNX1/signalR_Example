export class CoinsModel {
    symbol: string;
    priceChange: string;
    priceChangePercent: string;
    weightedAvgPrice: string;
    prevClosePrice: string;
    lastPrice: string;
    lastQty: string;
    highPrice: string;
    lowPrice: string;
    volume: string;
    quoteVolume: string;
}
export class CoinsRequest {
    constructor(){
        this.Name = 'DOGE,XRP,AXS,SOL,BNB'
    }
    Name: string;
}