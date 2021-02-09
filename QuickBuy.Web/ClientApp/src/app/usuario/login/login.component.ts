import { Component } from '@angular/core'
import { Usuario } from "../../models/usuario";

@Component({
  selector: 'app-login',
  templateUrl: 'login.component.html',
  styleUrls: ['login.component.css']
})

export class LoginComponent {
  public usuario;


  constructor() {
    this.usuario = new Usuario();
  }
}

