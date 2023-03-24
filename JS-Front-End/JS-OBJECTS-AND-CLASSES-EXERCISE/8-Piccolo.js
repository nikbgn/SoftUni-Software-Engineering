function piccolo(input) {
  let numberPlates = [];
  for (const line of input) {
    let [command, carPlate] = line.split(", ");
    if (command === "IN" && !numberPlates.includes(carPlate)) {
      numberPlates.push(carPlate);
    } else if (command === "OUT" && numberPlates.includes(carPlate)) {
      let idx = numberPlates.indexOf(carPlate);
      numberPlates.splice(idx, 1);
    }
  }

  if (numberPlates.length === 0) {
    console.log("Parking Lot is Empty");
  } else {
    numberPlates = numberPlates.sort();
    numberPlates.forEach((np) => {
      console.log(np);
    });
  }
}


