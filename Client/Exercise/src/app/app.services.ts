import { CoinsModel } from "./app.model";
import * as signalR from "@aspnet/signalr";
import { Injectable } from "@angular/core";
@Injectable({
    providedIn: 'root'
})
export class SignalRService {
    public static data: CoinsModel[];
    public static hubConnection: signalR.HubConnection;
    public static startConnection(): void {
        this.hubConnection = new signalR.HubConnectionBuilder()
            .withUrl('https://localhost:44394/hub')
            .build();
        this.hubConnection
            .start()
            .then(() => console.log('Connection started'))
            .catch(err => console.log('Error while starting connection: ' + err));
    }
    public static closeConenction():void{
        this.hubConnection.stop();
    }
}