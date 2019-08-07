import { Title } from '@angular/platform-browser';
import { ViewStoryComponent } from './../view-story/view-story.component';
import { Author } from './../../_models/Author';
import { AlertifyService } from './../../_services/alertify.service';
import { User } from './../../_models/User';
import { Pagination } from './../../_models/pagination';
import { Component, OnInit } from '@angular/core';
import { PaginatedResult } from '../../_models/pagination';
import { Story } from '../../_models/Story';
import { StoryService } from '../../_services/story.service';
import { ActivatedRoute } from '@angular/router';
import { BsDatepickerConfig, BsModalRef, BsModalService } from 'ngx-bootstrap';
import { Center } from '../../_models/Center';

@Component({
  selector: 'app-story-search-list',
  templateUrl: './story-search-list.component.html',
  styleUrls: ['./story-search-list.component.css']
})
export class StorySearchListComponent implements OnInit {

  bsModalRef: BsModalRef;
  pagination: Pagination;
  serialNumber: number;
  users: User[];
  fromDate: Date;
  toDate: Date;
  stories: Story[];
  authors: Author[];
  centers: Center[];
  _listAuthors: any[];
  userParams: any = {};
  user: User = JSON.parse(localStorage.getItem('user'));
  bsConfig: Partial<BsDatepickerConfig>;
  deskOptions: Array<String> = ['Print', 'Online', 'Both'];

  constructor(private storyService: StoryService,
    private alertify: AlertifyService,
    private route: ActivatedRoute,
    private modalService: BsModalService,
    private titleService: Title) { }

  ngOnInit() {
    this.titleService.setTitle('Story Search');
    this.route.data.subscribe(data => {
      this.stories = data['stories'].result;
      this.pagination = data['stories'].pagination;
      this.authors = data['authors'];
      this.bsConfig = Object.assign({}, { containerClass: 'theme-dark-blue', dateInputFormat: 'DD/MM/YYYY' });
      this.serialNumber = 1;
    });

    this.storyService.getCenters().subscribe((data) => {
      this.centers = data;
    }, error => {
      this.alertify.error('Failed to retrieve centers');
    });

    this.userParams.orderBy = 'latest';
    this.fromDate = new Date();
    this.toDate = new Date();
    this.toDate.setDate(this.toDate.getDate() + 1);
  }


  loadStories() {
    if (this.fromDate != null) {
      this.userParams.fromDate = this.fromDate.toISOString();
    }
    if (this.toDate != null) {
      this.userParams.toDate = this.toDate.toISOString();
    }
    this.storyService.getStories(this.pagination.currentPage, this.pagination.itemsPerPage, this.userParams)
      .subscribe((res: PaginatedResult<Story[]>) => {
        this.stories = res.result;
        this.pagination = res.pagination;
      }, error => {
        this.alertify.error(error);
      });
    // this.spinner.hide();
  }

  pageChanged(event: any): void {
    this.pagination.currentPage = event.page;
    this.loadStories();
    this.serialNumber = ((event.page * this.pagination.itemsPerPage) + 1) - this.pagination.itemsPerPage;
    // console.log(this.serialNumber);
  }

  resetFiltes() {
    this.userParams.author = null;
    this.userParams.storyDesk = null;
    this.userParams.orderBy = 'latest';

    this.userParams.fromDate = '';
    this.fromDate = new Date();

    this.userParams.toDate = '';
    this.toDate = new Date();
    this.toDate.setDate(this.toDate.getDate() + 1);

    this.userParams.center = null;
    this.userParams.heading = '';
    this.loadStories();
  }

  private selected(value: any) {
    this.userParams.storyDesk = value.text;
  }

  openModalWithComponent(story: Story) {
    const list: Story[] = [];
    list.push(story);
    this.bsModalRef = this.modalService.show(ViewStoryComponent);
    this.bsModalRef.content.title = story.storyHeading;
    this.bsModalRef.content.list = list;
  }

}
