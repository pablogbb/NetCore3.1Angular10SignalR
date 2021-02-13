import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { NotificacionesService } from './services/notificaciones.service';
import {SignalService} from './services/signal.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AngularSignalR';
  notificaciones$:Observable<any[]>;
  notificaciones:any[];
  porver:number = 0;

  constructor(private signalservice:SignalService, private notificacionesService:NotificacionesService){}

  ngOnInit(){
    this.notificaciones$ = this.notificacionesService.getNotificaciones$();
    this.notificaciones$.subscribe(n => {
      console.log(n);
      this.notificaciones = n;   
      this.porver = 0; 
      this.notificaciones.forEach(x => {
        if(!x.visto)
          this.porver+=1;
      });
    });
  }
}
