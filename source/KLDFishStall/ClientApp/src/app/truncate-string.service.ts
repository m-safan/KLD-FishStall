import { PipeTransform, Pipe } from '@angular/core';

@Pipe({ name: 'truncateString' })
export class TruncateString implements PipeTransform {
  returnString: string;
  transform(originalString: string, maximumCharacters: number): string {
    this.returnString = originalString.substring(0, maximumCharacters);
    if (originalString.length > maximumCharacters) {
      this.returnString = this.returnString.concat(this.returnString, '...');
    }
    return this.returnString;
  }
}
