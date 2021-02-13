import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class NotificacionesService {
  private notificaciones:any[] = [];
  private notificaciones$ = new BehaviorSubject<any[]>(this.notificaciones);

  constructor() { }

  setNotificacion(n:any){
    this.notificaciones.push(n);
    this.notificaciones.reverse();
    this.notificaciones$.next(this.notificaciones);
  }

  getNotificaciones$(): Observable<any> {
    return this.notificaciones$.asObservable();
  }
}
