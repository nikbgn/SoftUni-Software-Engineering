const BASE_URL = "http://localhost:3030/jsonstore/bus/schedule/";
const infoDiv = document.querySelector(".info");
const departButton = document.getElementById("depart");
const arriveButton = document.getElementById("arrive");
const headers = { method: "GET" };
let nextStop = "depot";
let prevStop = "";
function solve() {

  function depart() {
    let data = fetch(`${BASE_URL}${nextStop}`, headers)
      .then((res) => res.json())
      .then((info) => {
        let { name, next } = info;
        prevStop = nextStop;
        nextStop = next;
        infoDiv.textContent = `Next stop ${name}`;
        departButton.disabled = true;
        arriveButton.disabled = false;
      })
      .catch((err) => {
        infoDiv.textContent = `Error`;
        departButton.disabled = true;
        arriveButton.disabled = true;
      });
  }

  async function arrive() {
    arriveButton.disabled = true;
    departButton.disabled = false;
    let data = await fetch(`${BASE_URL}${prevStop}`, headers);
    let response = await data.json();
    infoDiv.textContent = `Arriving at ${response.name}`;
  }

  return {
    depart,
    arrive,
  };
}

let result = solve();
