import { AfterContentChecked, Component, Input } from '@angular/core';
import { geoAlbersUsa } from "d3-geo";
import { select, geoPath } from "d3";

@Component({
  selector: 'map',
  template: `<div id="{{anchorId}}" style="margin-left:20%;"></div>`
})
export class MapComponent implements AfterContentChecked {
  @Input() geoJson: Object | undefined
  @Input() anchorId: string = "bind-map-here"
  @Input() statesColorisation: StatesColorisation = {}

  ngAfterContentChecked(): void {
    console.log("Map initialized")

    const usaProjection = geoAlbersUsa()
      .scale(600)
      .translate([250, 150])

    const pathGenerator = geoPath().projection(usaProjection)

    const width = 700;
    const height = 400;

    const selector = `#${this.anchorId}`;
    const anchor = select(selector);

    const mapId = "___us-map"

    document.getElementById(mapId)?.remove();

    const svg = anchor.append("svg")
      .attr("id", mapId)
      .attr("width", width)
      .attr("height", height);

    const geojson = this.geoJson as any;
    const pathgen = pathGenerator as any;

    const paths = svg.selectAll("path");

    paths.data(geojson.features)
      .enter()
      .append("path")
      .attr("d", pathgen) // This is where the magic happens
      .attr("stroke", "grey") // Color of the lines themselves
      .attr("fill", state => {
        const id = (state as any).id as string;
        const color = this.statesColorisation[id];
        return color || "grey";
      })
  }


}

export type StatesColorisation = {
  [key: string]: string
};
