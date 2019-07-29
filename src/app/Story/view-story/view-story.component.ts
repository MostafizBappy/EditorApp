import { Story } from './../../_models/Story';
import { Component, OnInit } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap';

@Component({
  selector: 'app-view-story',
  templateUrl: './view-story.component.html',
  styleUrls: ['./view-story.component.css']
})
export class ViewStoryComponent {

  title: string;
  list: Story[] = [];
  constructor(public bsModalRef: BsModalRef) {}

}
