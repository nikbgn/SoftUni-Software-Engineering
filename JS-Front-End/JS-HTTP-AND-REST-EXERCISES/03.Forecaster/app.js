function attachEvents() {
  const BASE_URL = "http://localhost:3030/jsonstore/forecaster/";
  const LOCATIONS_URL = BASE_URL + "locations/";
  const TODAY_URL = BASE_URL + "today/";
  const UPCOMING_URL = BASE_URL + "upcoming/";
  const location = document.getElementById("location");
  const getWeatherInput = document.getElementById("submit");
  const divForecast = document.getElementById("forecast");
  const divCurrent = document.getElementById("current");
  const divUpcoming = document.getElementById("upcoming");
  const symbolsMap = {
    Sunny: "&#x2600",
    "Partly sunny": "&#x26C5",
    Overcast: "&#x2601",
    Rain: "&#x2614",
    Degrees: "&#176",
  };

  getWeatherInput.addEventListener("click", locationsHandler);

  async function locationsHandler() {
    divCurrent.innerHTML = `<div class="label">Current conditions</div>`;
    divUpcoming.innerHTML = `<div class="label">Three-day forecast</div>`;
    let forecastsDiv = document.createElement("div");

    //Fetch locations and save them into an array.
    let fetchLocations = await fetch(LOCATIONS_URL);
    let allLocations = Array.from(await fetchLocations.json());

    //Get search query and find location.
    let searchQuery = location.value;
    let searchedLocation = allLocations.find((loc) => loc.name === searchQuery);

    divForecast.style.display = "block";

    if (searchedLocation === undefined) {
      let errorSpan = document.createElement("span");
      errorSpan.classList.add("condition");
      errorSpan.textContent = "Error";
      forecastsDiv.appendChild(errorSpan);
      divCurrent.appendChild(forecastsDiv);
      return;
    }

    let fetchCurrentConditions = await fetch(TODAY_URL + searchedLocation.code);
    let currentConditionsOfLocation = await fetchCurrentConditions.json();
    let low = currentConditionsOfLocation.forecast.low;
    let high = currentConditionsOfLocation.forecast.high;

    //Forecasts div

    forecastsDiv.classList.add("forecasts");
    let conditionDivForecasts = document.createElement("div");
    conditionDivForecasts.classList.add("condition");
    let forecastsSymbolSpan = symbolSpanBuilder(
      currentConditionsOfLocation.forecast.condition
    );
    let forecastsCitySpan = spanBuilder(
      "forecast-data",
      currentConditionsOfLocation.name
    );
    let forecastsDegreesSpan = spanBuilder(
      "forecast-data",
      `${low}${symbolsMap.Degrees}/${high}${symbolsMap.Degrees}`
    );
    let forecastsWeatherSpan = spanBuilder(
      "forecast-data",
      currentConditionsOfLocation.forecast.condition
    );

    forecastsDiv.appendChild(forecastsSymbolSpan);
    conditionDivForecasts.appendChild(forecastsCitySpan);
    conditionDivForecasts.appendChild(forecastsDegreesSpan);
    conditionDivForecasts.appendChild(forecastsWeatherSpan);
    forecastsDiv.appendChild(conditionDivForecasts);
    divCurrent.appendChild(forecastsDiv);

    //Upcoming
    let fetchUpcoming = await fetch(UPCOMING_URL + searchedLocation.code);
    let upcomingConditionsOfLocation = await fetchUpcoming.json();

    let forecastsUpcomingArray = upcomingConditionsOfLocation.forecast;
    let forecastInfoDiv = document.createElement("div");
    forecastInfoDiv.classList.add("forecast-info");

    forecastsUpcomingArray.forEach((obj) => {
      let newChild = upcomingSpanBuilder(
        symbolsMap[obj.condition],
        obj.low,
        obj.high,
        obj.condition
      );
      forecastInfoDiv.appendChild(newChild);
    });

    divUpcoming.appendChild(forecastInfoDiv);
  }

  function spanBuilder(spanClass, spanData) {
    let newSpan = document.createElement("span");
    newSpan.classList.add(spanClass);
    newSpan.innerHTML = spanData;
    return newSpan;
  }

  function symbolSpanBuilder(weatherCondition) {
    let newSpan = document.createElement("span");
    newSpan.classList.add("condition");
    newSpan.classList.add("symbol");
    newSpan.innerHTML = symbolsMap[weatherCondition];
    return newSpan;
  }

  function upcomingSpanBuilder(symbol, low, high, condition) {
    let newSpan = document.createElement("span");
    newSpan.classList.add("upcoming");
    let child1 = spanBuilder("symbol", symbol);
    let child2 = spanBuilder(
      "forecast-data",
      `${low}${symbolsMap.Degrees}/${high}${symbolsMap.Degrees}`
    );
    let child3 = spanBuilder("forecast-data", `${condition}`);
    newSpan.appendChild(child1);
    newSpan.appendChild(child2);
    newSpan.appendChild(child3);
    return newSpan;
  }
}

attachEvents();
