import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ProdutoService } from 'src/app/servicos/produto.service';

@Component({
  selector: 'app-inicio',
  templateUrl: './inicio.component.html',
  styleUrls: ['./inicio.component.css']
})
export class InicioComponent implements OnInit{
  produtos: any[] = [];

  constructor(private produtoService: ProdutoService, private router: Router) { }

  ngOnInit(): void {
      this.listarProdutos();
  }
  listarProdutos() {
    this.produtoService.obterProdutos().subscribe((dados) => {
      this.produtos = dados;
    });
  }

  deletarProduto(id: number) {
    if (confirm("Deseja excluir o produto?")) {
      this.produtoService.deletarProduto(id, this.produtos).subscribe(() => {
        alert("Produto excluído com sucesso!");
        this.listarProdutos();
      });
  }
}
editarProduto(id:number) {
  this.router.navigate(['/cadastro', id]);
}

}
