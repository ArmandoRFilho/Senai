import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProdutoService } from 'src/app/servicos/produto.service';

@Component({
  selector: 'app-cadastro',
  templateUrl: './cadastro.component.html',
  styleUrls: ['./cadastro.component.css']
})
export class CadastroComponent implements OnInit{
  produto: any = {
    produto: '',
    descricao: '',
    foto: '',
    preco: null,
  };

  constructor(
    private produtoService: ProdutoService,
    private route: ActivatedRoute,
    private router: Router
  ){}

  ngOnInit(): void {
      const id = this.route.snapshot.paramMap.get('id');
      if (id) {
        this.produtoService.obterProdutoPorId(Number(id)).subscribe((dados) => {
          this.produto = dados;
        });
      }}

      salvarProduto(): void{

        if (this.produto.id){
          this.produtoService.atualizarProduto(this.produto.id, this.produto).subscribe(() =>{
            alert('Produto atualizado com sucesso!');
            this.router.navigate(['/inicio']);
          });
        }
        else {
            this.produtoService.adiconarProduto(this.produto).subscribe(() =>{
              alert('Produto cadastrado com sucesso!');
              this.router.navigate(['/inicio']);
          });
        }
      }
  }

