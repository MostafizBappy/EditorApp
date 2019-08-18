import { StorySearchListComponent } from './Story/story-search-list/story-search-list.component';
import { StorySearchListResolver } from './_resolver/story-search-list.resolver.';
import { AuthGuard } from './_guards/auth.guard';
import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AddStoryComponent } from './Story/add-story/add-story.component';
import { StorySearchListAuthorResolver } from './_resolver/story-search-list-author.resolver.ts';
import { PreventUnsavedChanges } from './_guards/story-unsavedChanges.guard';
import { UploadPhotoComponent } from './photo/upload-photo/upload-photo.component';

export const appRoute: Routes = [
    { path: 'home', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children:
            [
                {
                    path: 'storySearch', component: StorySearchListComponent, resolve:
                    {
                        stories: StorySearchListResolver,
                        authors: StorySearchListAuthorResolver
                    }
                },
                {path: 'addStory', component: AddStoryComponent, canDeactivate: [PreventUnsavedChanges]},
                {path: 'uploadPhoto', component: UploadPhotoComponent}
            ]
    },
    { path: '**', redirectTo: 'home', pathMatch: 'full' }
];
