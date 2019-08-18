import { Title } from '@angular/platform-browser';
import { AlertifyService } from './../../_services/alertify.service';
import { Component, OnInit } from '@angular/core';
import { Story } from '../../_models/Story';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { StoryService } from '../../_services/story.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-story',
  templateUrl: './add-story.component.html',
  styleUrls: ['./add-story.component.css']
})
export class AddStoryComponent implements OnInit {
  story: Story;
  storyCreateForm: FormGroup;

  constructor(private storyService: StoryService,
    private alertify: AlertifyService,
    private fb: FormBuilder,
    private router: Router,
    private titleService: Title) { }

  ngOnInit() {
    this.storyForm();
    this.titleService.setTitle('Create Story');
  }
  // storyHeading: string;
  // storyBody: string;
  // keyword: string;
  // storyType: string;
  // storyDesk: string;
  storyForm() {
    this.storyCreateForm = this.fb.group({
      storyHeading: ['', [Validators.required, Validators.maxLength(500)]],
      storyBody: ['', Validators.required],
      storyType: ['', Validators.required],
      storyDesk: ['', Validators.required],
      keyword: ['', Validators.required]
    });
  }

  createStory() {
    if (this.storyCreateForm.valid) {
      this.story = Object.assign({}, this.storyCreateForm.value);
      this.storyService.saveStory(this.story).subscribe(() => {
        this.alertify.success('Saved successfully');
      }, error => {
        this.alertify.error(error);
      });
      this.reset();
    }
  }

  reset() {
    this.storyCreateForm.reset();
  }

}
