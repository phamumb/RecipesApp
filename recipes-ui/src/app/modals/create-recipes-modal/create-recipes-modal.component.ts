import { Component, OnInit, ViewChild } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-create-recipes-modal',
  templateUrl: './create-recipes-modal.component.html',
  styleUrls: ['./create-recipes-modal.component.scss']
})
export class CreateRecipesModalComponent implements OnInit {
  @ViewChild('modal') modal: any;
  constructor(public modalService: NgbModal) { }

  ngOnInit(): void {
  }

  open() {
    this.modalService.open(this.modal, { ariaLabelledBy: 'create-recipes-modal' }).result.then((res) => {
      console.log(res)
    }, (res) => {
      console.log(res)
    });
  }

}
