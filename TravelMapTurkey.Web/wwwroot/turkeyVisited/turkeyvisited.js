const HOVER_COLOR = "#47c511";
const MAP_COLOR = "#ffffff";
let cityCount = localStorage.getItem("cities")
  ? JSON.parse(localStorage.getItem("cities")).length
  : 0;
document.getElementById("city_count").innerHTML = cityCount;

d3.json("/js/tr-cities.json").then(function (data) {
    let width = 1200;
    let height = 800;
    let projection = d3.geoEqualEarth();
    projection.fitSize([width, height], data);
    let path = d3.geoPath().projection(projection);
    
    let svg = d3
        .select("#map_container")
        .append("svg")
        .attr("width", width)
        .attr("height", height);

    let g = svg
        .append("g")
        .selectAll("path")
        .data(data.features)
        .join("path")
        .attr("d", path)
        .attr("fill", function (d, i) {
            if (localStorage.getItem("cities")) {
                const cityNames = JSON.parse(localStorage.getItem("cities")).map(obj => obj.cityName)
                if (cityNames.includes(d.properties.name)){
                    d.noFill = true;
                    return HOVER_COLOR;
                } else return MAP_COLOR;
            } else return MAP_COLOR;
        })
        .attr("stroke", "#000")
        .on("mouseover", function (d, i) {
            d3.select(this).attr("fill", HOVER_COLOR);
        })
        .on("mouseout", function (d, i) {
            if (!d.noFill) d3.select(this).attr("fill", MAP_COLOR);
        })
        .on("click", function (d, i) {
            console.log("d", d);

            // �ehir bilgilerini modal ile g�stermek i�in
            document.getElementById('city-name').value = d.properties.name;
            document.getElementById('city-review').value = '';
            document.getElementById('city-type').value = '';

            JSON.parse(localStorage.getItem("cities")).forEach((obj) => {
                if (obj.cityName == d.properties.name) {
                    document.getElementById('city-review').value = obj.review.Review
                    document.getElementById('city-type').value = obj.type
                }
            })

            // Modal'� a�mak i�in
            document.getElementById('openModalBtn').click();
        });

    g = svg.append("g");

    g.selectAll("text")
        .data(data.features)
        .enter()
        .append("text")
        .text(function (d) {
            return d.properties.name;
        })
        .attr("x", function (d) {
            return path.centroid(d)[0];
        })
        .attr("y", function (d) {
            return path.centroid(d)[1];
        })
        .attr("text-anchor", "middle")
        .attr("font-size", "10pt")
        .attr("style", "color: black;")
        .attr("style", "pointer-events: none;");
});


function downloadMap() {
  let div = document.getElementById("map_container");
  html2canvas(div).then(function (canvas) {
    var destCanvas = document.createElement("canvas");
    destCanvas.width = canvas.width;
    destCanvas.height = canvas.height;
    var destCtx = destCanvas.getContext("2d");
    destCtx.drawImage(canvas, 0, 0);

    const ctx = destCanvas.getContext("2d");
    ctx.textBaseline = "top";
    ctx.font = "2em Calibri";
    ctx.fillStyle = "black";
    ctx.textAlign = "start";
      var textWidth = ctx.measureText("https://github.com/otpz");
      ctx.fillText("https://github.com/otpz", 10, canvas.height - 25);
    ctx.fillText(cityCount + "/81", 10, 5);

    destCanvas.toBlob(function (blob) {
      saveAs(blob, "turkeyvisited.png");
    });
  });
}
