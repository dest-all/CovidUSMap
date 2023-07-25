import { Component } from '@angular/core';

@Component({
  selector: 'colors-range',
  template: `<div class='colors-range'>

    <span class="inscription">
      <span style="font-weight:800">
        Low
      </span>
        <span class="faint">
          risk
        </span>
    </span>

    <span class="padder" style="background-color:greenyellow; color:greenyellow;border-radius:30px 0 0 30px; margin-left:2px;">{{padding}}</span>
    <span class="padder" style="background-color:#ffc107; color:#ffc107;">{{padding}}</span>
    <span class="padder" style="background-color:#fd7e14; color:#fd7e14;">{{padding}}</span>
    <span class="padder" style="background-color:red; color:red;">{{padding}}</span>
    <span class="padder" style="background-color:maroon; color:maroon; border-radius:0 30px 30px 0; margin-right; 2px;">{{padding}}</span>

    <span class="inscription" style="margin-left:5px;"> <span style="font-weight:800">Severe  </span> <span class="faint">risk</span> </span>
  </div>`
})
export class ColorsRange {
  padding = "00000000";
}
