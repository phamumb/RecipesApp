import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-recipes-detail-icon',
  templateUrl: './recipes-detail-icon.component.html',
  styleUrls: ['./recipes-detail-icon.component.scss']
})
export class RecipesDetailIconComponent implements OnInit {
  @Input() backgroundColor: string | null = '';
  @Input() icon: string | null = '';
  @Input() size: string | null = 'fa-4x';
  @Input() iconColor: string | null = '';
  constructor() { }

  ngOnInit(): void {
  }

}
