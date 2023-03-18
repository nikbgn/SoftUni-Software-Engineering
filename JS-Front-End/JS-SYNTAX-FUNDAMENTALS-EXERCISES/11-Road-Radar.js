function solve(speed, area) {
  let motorway_limit = 130;
  let interstate_limit = 90;
  let city_limit = 50;
  let residential_limit = 20;

  const getSpeedingMessage = function (difference, limit) {
    if (difference <= 20)
      return `The speed is ${difference} km/h faster than the allowed speed of ${limit} - speeding`;
    else if (difference <= 40)
      return `The speed is ${difference} km/h faster than the allowed speed of ${limit} - excessive speeding`;
    else
      return `The speed is ${difference} km/h faster than the allowed speed of ${limit} - reckless driving`;
  };

  const returnSpeedingStatus = function (speed, limit) {
    let difference = Math.abs(speed - limit);
    return getSpeedingMessage(difference, limit);
  };

  switch (area) {
    case "city":
      if (speed <= city_limit)
        return `Driving ${speed} km/h in a ${city_limit} zone`;
      else return returnSpeedingStatus(speed, city_limit);
      break;
    case "motorway":
      if (speed <= motorway_limit)
        return `Driving ${speed} km/h in a ${motorway_limit} zone`;
      else return returnSpeedingStatus(speed, motorway_limit);
      break;
    case "interstate":
      if (speed <= interstate_limit)
        return `Driving ${speed} km/h in a ${interstate_limit} zone`;
      else return returnSpeedingStatus(speed, interstate_limit);
      break;
    case "residential":
      if (speed <= residential_limit)
        return `Driving ${speed} km/h in a ${residential_limit} zone`;
      else return returnSpeedingStatus(speed, residential_limit);
      break;
    default:
      break;
  }
}
