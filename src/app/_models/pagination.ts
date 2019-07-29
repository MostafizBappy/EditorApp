export interface Pagination {
    currentPage: number;
    itemsPerPage: number;
    totalPages: number;
    totalItems: number;
    length: number;
}

export class PaginatedResult<T> {
    result: T;
    pagination: Pagination;
}
