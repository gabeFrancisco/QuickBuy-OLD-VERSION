import { Component, OnInit } from '@angular/core'
import { Usuario } from "../../models/usuario";
import { ActivatedRoute, Router } from "@angular/router";
import { UsuarioServico } from 'src/app/servicos/usuario/usuario.servico';

@Component({
  selector: 'app-login',
  templateUrl: 'login.component.html',
  styleUrls: ['login.component.css']
})

export class LoginComponent implements OnInit{
  public usuario;
  public returnUrl: string;

  constructor(private router: Router, private activatedRouter: ActivatedRoute, private usuarioServico: UsuarioServico) { }

  ngOnInit(): void {
    this.returnUrl = this.activatedRouter.snapshot.queryParams['returnUrl'];
    this.usuario = new Usuario();
  }

  entrar() {
    // if (this.usuario.email == "gabeasmprogrammer@gmail.com" && this.usuario.senha == "12345678") {
    //   sessionStorage.setItem("usuario-autenticado", "1");
    //   this.router.navigate([this.returnUrl])
    // }

    this.usuarioServico.verificarUsuario(this.usuario).subscribe(
      data => {
        
      },
      err => {

      }
    );
  }
}

