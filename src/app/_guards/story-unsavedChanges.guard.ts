import { AddStoryComponent } from './../Story/add-story/add-story.component';
import { Injectable } from '@angular/core';
import { CanDeactivate } from '@angular/router';


@Injectable()
export class PreventUnsavedChanges implements CanDeactivate <AddStoryComponent> {
    canDeactivate(component: AddStoryComponent) {
        if (component.storyCreateForm.dirty) {
            return confirm('Are you sure you want to continue? Any unsaved changes will be lost.');
        }
        return true;
    }
}
