import { ViewStoryComponent } from './Story/view-story/view-story.component';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {NoopAnimationsModule} from '@angular/platform-browser/animations';
import { NgModule, NO_ERRORS_SCHEMA  } from '@angular/core';
import { BsDropdownModule, TabsModule, BsDatepickerModule, PaginationModule, ButtonsModule } from 'ngx-bootstrap';
import { AppComponent } from './app.component';
import { StorySearchListComponent } from './Story/story-search-list/story-search-list.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AddStoryComponent } from './Story/add-story/add-story.component';
import { UploadPhotoComponent } from './photo/upload-photo/upload-photo.component';
import { RouterModule } from '@angular/router';
import { appRoute } from './route';
import { HomeComponent } from './home/home.component';
import { AuthService } from './_services/auth.service';
import { AuthGuard } from './_guards/auth.guard';
import { HttpClientModule } from '@angular/common/http';
import { NgHttpLoaderModule } from 'ng-http-loader/ng-http-loader.module';
import { JwtModule } from '@auth0/angular-jwt';
import { NavComponent } from './nav/nav.component';
import { AlertifyService } from './_services/alertify.service';
import { Ng2TableModule } from 'ngx-datatable/ng2-table';
import { NgSelectModule } from '@ng-select/ng-select';
import { StorySearchListResolver } from './_resolver/story-search-list.resolver.';
import { StoryService } from './_services/story.service';
import { TruncateTextPipe } from './truncate-text.pipe';
import { StorySearchListAuthorResolver } from './_resolver/story-search-list-author.resolver.ts';
import { PreventUnsavedChanges } from './_guards/story-unsavedChanges.guard';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { ModalModule } from 'ngx-bootstrap';

export function getAccessToken(): string {
   return localStorage.getItem('token');
}

export const jwtConfig = {
   tokenGetter: getAccessToken,
   whitelistedDomains: ['localhost:5000']
};

@NgModule({
   declarations: [
      AppComponent,
      StorySearchListComponent,
      AddStoryComponent,
      UploadPhotoComponent,
      HomeComponent,
      NavComponent,
      TruncateTextPipe,
      ViewStoryComponent
   ],
   imports: [
      BrowserModule,
      BrowserAnimationsModule,
      FormsModule,
      ReactiveFormsModule,
      RouterModule.forRoot(appRoute),
      HttpClientModule,
      JwtModule.forRoot({
         config: jwtConfig
      }),
      PaginationModule.forRoot(),
      Ng2TableModule,
      BsDropdownModule.forRoot(),
      BsDatepickerModule.forRoot(),
      ButtonsModule.forRoot(),
      NgSelectModule,
      NgHttpLoaderModule,
      ModalModule.forRoot()
   ],
   providers: [
      AuthService,
      AlertifyService,
      StoryService,
      AuthGuard,
      StorySearchListResolver,
      StorySearchListAuthorResolver,
      PreventUnsavedChanges,
      ErrorInterceptorProvider
   ],
   bootstrap: [
      AppComponent
   ],
   entryComponents: [
      ViewStoryComponent
   ]
})
export class AppModule { }
