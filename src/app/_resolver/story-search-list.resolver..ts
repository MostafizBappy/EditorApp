import { Story } from './../_models/Story';
import { StoryService } from './../_services/story.service';
import { AlertifyService } from '../_services/alertify.service';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { Observable } from 'rxjs/rx';
import 'rxjs/add/operator/catch';
import { Injectable } from '@angular/core';

@Injectable()
export class StorySearchListResolver implements Resolve<Story[]> {
    pageSize = 10;
    pageNumber = 1;
    userParams: any;

    constructor(private storyService: StoryService,
        private route: Router, private alertify: AlertifyService) {}

    resolve(route: ActivatedRouteSnapshot): Observable<Story[]> {
        return this.storyService.getStories(this.pageNumber, this.pageSize).catch(error => {
            this.alertify.error('Problem retrieving data.');
            this.route.navigate(['/home']);
            return Observable.of(null);
        });
    }
}
