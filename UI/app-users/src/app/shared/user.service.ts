import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class UserService {
  private readonly API_URL =
    'https://localhost:7072/api/UserDetails/GetAllUserDetailsAsync';

  constructor(private httpClient: HttpClient) {}

  getAllUsers(): Observable<any> {
    return this.httpClient.get(this.API_URL);
  }
}
