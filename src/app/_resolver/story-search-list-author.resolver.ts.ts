import { Author } from './../_models/Author';
import { StoryService } from './../_services/story.service';
import { AlertifyService } from '../_services/alertify.service';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { Observable } from 'rxjs/rx';
import 'rxjs/add/operator/catch';
import { Injectable } from '@angular/core';

@Injectable()
export class StorySearchListAuthorResolver implements Resolve<Author[]> {

    constructor(private storyService: StoryService,
        private route: Router, private alertify: AlertifyService) {}

    resolve(route: ActivatedRouteSnapshot): Observable<Author[]> {
        return this.storyService.getAuthors().catch(error => {
            this.alertify.error('Problem retrieving Author list.');
            return Observable.of(null);
        });
    }
}
