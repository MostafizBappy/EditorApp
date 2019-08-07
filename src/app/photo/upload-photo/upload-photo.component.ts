import { Title } from '@angular/platform-browser';
import { AlertifyService } from './../../_services/alertify.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Component, OnInit } from '@angular/core';
import { FileUploader } from 'ng2-file-upload';
import { Photo } from '../../_models/Photo';
import { environment } from '../../../environments/environment';
import { StoryService } from '../../_services/story.service';
import { AuthService } from '../../_services/auth.service';

@Component({
  selector: 'app-upload-photo',
  templateUrl: './upload-photo.component.html',
  styleUrls: ['./upload-photo.component.css']
})
export class UploadPhotoComponent implements OnInit {

  baseUrl = environment.apiUrl;
  photos: Photo[];
  photoForm: FormGroup;
  uploader: FileUploader;
  hasBaseDropZoneOver = false;
  constructor(private fb: FormBuilder,
    private alertifyService: AlertifyService,
    private storyService: StoryService,
    private authService: AuthService,
    private titleService: Title) { }

  ngOnInit() {
    this.initializeUploader();
    this.createForm();
    this.titleService.setTitle('Upload Photo');
  }

  createForm() {
    this.photoForm = this.fb.group({
      photoDesk: ['', Validators.required],
      description: ['', [Validators.required, Validators.maxLength(4000)]]
    });
  }

  public fileOverBase(e: any): void {
    this.hasBaseDropZoneOver = e;
  }

  initializeUploader() {
    this.uploader = new FileUploader({
      url: this.baseUrl + 'photo' + this.authService.decodedToken.nameid,
      authToken: 'Bearer ' + localStorage.getItem('token'),
      isHTML5: true,
      allowedFileType: ['image'],
      removeAfterUpload: true,
      autoUpload: false,
      maxFileSize: 10 * 1024 * 1024
    });
    // this.uploader.options.additionalParameter = {
    //   description: this.photoForm['description'].value,
    //   photoDesk: this.photoForm['photoDesk'].value
    // };
    this.uploader.onBuildItemForm = (item, form) => {
      form.append('description', this.photoForm['description'].value);
      form.append('photoDesk', this.photoForm['photoDesk'].value);
    };

    this.uploader.onSuccessItem = (item, response, status, headers) => {
      if (response) {
        const res: Photo = JSON.parse(response);
        // console.log(res);
        const photo = {
          id: res.id,
          description: res.description,
          photoDesk: res.photoDesk,
          userCode: res.userCode,
          photoDate: res.photoDate
        };
        this.photos.push(photo);
        // if (photo.isMain) {
        //   this.authService.changeMemberPhoto(photo.url);
        //   this.authService.currentUser.photoUrl = photo.url;
        //   localStorage.setItem('user', JSON.stringify(this.authService.currentUser));
        // }
      }
    };
  }
}
