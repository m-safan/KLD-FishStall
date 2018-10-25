import { TestBed } from '@angular/core/testing';

import { User } from './models.service';

describe('User', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: User = TestBed.get(User);
    expect(service).toBeTruthy();
  });
});
