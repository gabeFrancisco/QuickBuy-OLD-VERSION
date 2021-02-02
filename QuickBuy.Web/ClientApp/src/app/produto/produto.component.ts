
//Component é um Decorator. É usado para decorar a classe como Component
import { Component } from "@angular/core"

@Component({
  selector: "produto",
  template: "",
  templateUrl: ""
})

export class ProdutoComponent {
  public nome: string;
  public liberadoParaVenda: boolean;

  public obterNome(): string {
    return this.nome;
  }
}
