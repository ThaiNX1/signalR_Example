import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { CoinsModel, CoinsRequest } from './app.model';
import { SignalRService } from './app.services';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  coinSearch: CoinsRequest = new CoinsRequest();
  data: CoinsModel[] = [];
  constructor(
    private http: HttpClient
  ) {
  }
  ngOnInit(): void {
    SignalRService.startConnection();
    this.search();
  }
  search(): void {
    SignalRService.closeConenction();
    SignalRService.startConnection();
    this.http.post<any>('https://localhost:44394/api/BinanceApi',this.coinSearch).subscribe(res =>{
      if (!res) {
        console.log("Lỗi lấy dữa liệu");
        return;
      }
      this.getInfoCoins();
      console.log(res.message);
    });
  }
  getInfoCoins() {
    SignalRService.hubConnection.on('transferdata', (data) => {
          this.data = data;
      });
  }
}
