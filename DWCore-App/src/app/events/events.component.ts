import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent implements OnInit {

  // events: any = [
  //   {
  //     EventId: 1,
  //     Theme: 'Angular',
  //     Local: 'Belo Horizonte',
  //   },
  //   {
  //     EventId: 2,
  //     Theme: '.Net Core',
  //     Local: 'São Paulo',
  //   },
  //   {
  //     EventId: 1,
  //     Theme: 'React',
  //     Local: 'Rio de Janeiro',
  //   },
  // ];
  events: any;
  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

  

}
