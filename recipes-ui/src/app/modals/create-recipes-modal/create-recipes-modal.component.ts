import { RecipesContextService } from './../../services/recipes-context.service';
import { Component, OnInit, ViewChild } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-create-recipes-modal',
  templateUrl: './create-recipes-modal.component.html',
  styleUrls: ['./create-recipes-modal.component.scss']
})
export class CreateRecipesModalComponent implements OnInit {
  @ViewChild('modal') modal: any;
  model: any = {}
  constructor(public modalService: NgbModal, private context: RecipesContextService) { }

  ngOnInit(): void {
  }

  open() {
    this.modalService.open(this.modal, { ariaLabelledBy: 'create-recipes-modal' }).result.then((res) => {
      console.log(res)
    }, (res) => {
      console.log(res)
    });
  }

  create(){
    this.context.createRecipes(this.model).subscribe(id => {
      console.log(id);
    })
  }

}
