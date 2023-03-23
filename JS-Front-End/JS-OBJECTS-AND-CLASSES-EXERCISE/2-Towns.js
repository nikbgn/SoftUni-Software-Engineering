function towns(input) {
  let towns = [];
  input.forEach((i) => {
    let town, latitude, longitude;
    [town, latitude, longitude] = i.split(" | ");
    let current_town = {
      town,
      latitude: Number(latitude).toFixed(2),
      longitude: Number(longitude).toFixed(2),
    };
    towns.push(current_town);
  });

  towns.forEach((t) => {
    console.log(t);
  });
}
