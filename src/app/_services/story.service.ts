import { Center } from './../_models/Center';
import { Story } from './../_models/Story';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import { PaginatedResult } from '../_models/pagination';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Author } from '../_models/Author';

@Injectable()
export class StoryService {

    baseUrl = environment.apiUrl;
    constructor(private authHttp: HttpClient) { }

    getStories(page?, itemsPerPage?, userParams?: any) {
        const paginatedResult: PaginatedResult<Story[]> = new PaginatedResult<Story[]>();
        let params = new HttpParams();

        if (page != null && itemsPerPage != null) {
            params = params.append('pageNumber', page);
            params = params.append('pageSize', itemsPerPage);
        }

        if (userParams != null) {
            params = params.append('author', userParams.author);
            params = params.append('storyDesk', userParams.storyDesk);
            params = params.append('orderBy', userParams.orderBy);
            params = params.append('fromDate', userParams.fromDate);
            params = params.append('toDate', userParams.toDate);
            params = params.append('center', userParams.center);
            params = params.append('heading', userParams.heading);
        }
        return this.authHttp.get<Story[]>(this.baseUrl + 'story', { observe: 'response', params })
            .map(response => {
                paginatedResult.result = response.body;
                if (response.headers.get('pagination') != null) {
                    paginatedResult.pagination = JSON.parse(response.headers.get('pagination'));
                    return paginatedResult;
                }
            });
    }

    getAuthors(): Observable<Author[]> {
        return this.authHttp.get<Author[]>(this.baseUrl + 'story/GetAuthors');
    }

    getCenters(): Observable<Center[]> {
        return this.authHttp.get<Center[]>(this.baseUrl + 'story/GetCenterNames');
    }

    saveStory(story: Story) {
        return this.authHttp.post(this.baseUrl + 'story', story);
    }
}
