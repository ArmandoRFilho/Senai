import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ProdutoService } from './servico/produto.service'

@Component({
  selector: 'app-inicio',
  templateUrl: './inicio.component.html',
  styleUrls: ['./inicio.component.css']
})

export class InicioComponent {
  produtos: any[] = [];
  constructor(private produtoService: ProdutoService, private router: Router) {} ngOnInit(): void { this.listarProdutos()};

  listarProdutos() {
    this.produtoService.obterProdutos().subscribe((dados) => { this.produtos = dados; });
  }

  excluirProduto(id: number) {
    if (confirm("Deseja realmente excluir este produto?"))
      { this.produtoService.deletarProduto(id).subscribe(() => { alert("Produto excluído com sucesso!"); this.listarPrsodutos(); }); }
  }

  editarProduto(id: number) { this.router.navigate(['/cadastro-produto', id]); } }


}
