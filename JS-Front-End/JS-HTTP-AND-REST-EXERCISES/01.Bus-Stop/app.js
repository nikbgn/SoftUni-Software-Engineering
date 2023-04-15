const BASE_URL = "http://localhost:3030/jsonstore/bus/businfo/";
const stopNameDiv = document.getElementById("stopName");
const idLabel = document.getElementById("stopId");
const busesDiv = document.getElementById("buses");
async function getInfo() {
  try {
    const headers = {
      method: "GET",
    };
    const resposne = await fetch(`${BASE_URL}${idLabel.value}`, headers);
    const stopsInfo = await resposne.json();

    let { name, buses } = stopsInfo;

    idLabel.value = "";
    stopNameDiv.textContent = "";
    busesDiv.innerHTML = "";
    for (const busId in buses) {
      const li = document.createElement("li");
      li.textContent = `Bus ${busId} arrives in ${buses[busId]} minutes`;
      busesDiv.appendChild(li);
    }

    stopNameDiv.textContent = name;
  } catch (error) {
    idLabel.value = "";
    stopNameDiv.textContent = "Error";
    busesDiv.innerHTML = "";
  }
}
