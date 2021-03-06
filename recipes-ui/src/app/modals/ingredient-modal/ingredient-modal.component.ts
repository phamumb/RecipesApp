import { IngredientContextService } from '../../services/ingredient-context.service';
import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-ingredient-modal',
  templateUrl: './ingredient-modal.component.html',
  styleUrls: ['./ingredient-modal.component.scss']
})
export class IngredientModalComponent implements OnInit {
  @Input() model: any = {};
  @ViewChild('modal') modal: any;

  units = [
    'Bottle',
    'Lbs',
    'Bag',
    'Other'
  ]
  constructor(private context: IngredientContextService,public modalService: NgbModal) { }

  ngOnInit(): void {
  }

  open() {
    this.modalService.open(this.modal, { ariaLabelledBy: 'create-ingredient-modal' }).result.then((res) => {
      console.log(res)
    }, (res) => {
      console.log(res)
    });
  }

  createUpdate(){
    this.context.createUpdateIngredient(this.model).subscribe(res => {
      if(res){
        // close and reset model.
        this.modalService.dismissAll();
        this.model = {};
        // refresh list
        this.context.getAllIngredients();
      }
    });
  }
}
