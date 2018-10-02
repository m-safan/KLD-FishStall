import { TestBed } from '@angular/core/testing';

import { TruncateStringService } from './truncate-string.service';

describe('TruncateStringService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: TruncateStringService = TestBed.get(TruncateStringService);
    expect(service).toBeTruthy();
  });
});
