import { Injectable, inject, Inject } from "@angular/core"
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Usuario } from "src/app/models/usuario";

@Injectable({
  providedIn: "root"
})

export class UsuarioServico{

  private _baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string){
    this._baseUrl = baseUrl;
  }

  public verificarUsuario(usuario: Usuario): Observable<Usuario>{
    const headers = new HttpHeaders().set('content-type', 'application/json');
    var body = {
      email: usuario.email,
      senha: usuario.senha
    }

    return this.http.post<Usuario>(this._baseUrl + "api/usuario/verificarUsuario", body, { headers });
  }
}
