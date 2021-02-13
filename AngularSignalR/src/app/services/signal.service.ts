import { Inject, Injectable } from '@angular/core';
import { HubConnection, HubConnectionBuilder, LogLevel } from '@aspnet/signalr';
import { NotificacionesService } from './notificaciones.service';

@Injectable({
  providedIn: 'root'
})
export class SignalService {

  private connection:HubConnection;
  private connectionId:string;
  private baseUrl:string;

  constructor(@Inject('BASE_URL') baseUrl: string, private  notificaciones:NotificacionesService) {
    console.log('websocket inicado...');
    
     this.baseUrl = baseUrl;
    this.connection =  new HubConnectionBuilder().withUrl(this.baseUrl + 'pqrnotificacion?userId=' + 10)
    .withAutomaticReconnect()
    .configureLogging(LogLevel.Information)  
    .build();
    this.connection.on('send',data => {
      this.notificaciones.setNotificacion(data);  
    })

    this.connection.on('event',data => {
      console.log(data);
    })
    this.connection.start().then(() => {     
      this.connection.invoke('GetConnectionId').then((connectionId) => {        
        this.connectionId = connectionId;
      });
    });

    this.connection.onreconnected((connectionId) => {
      this.connection.invoke('GetConnectionId').then((connectionId) => {        
        this.connectionId = connectionId;
      });
    });
   }
}
