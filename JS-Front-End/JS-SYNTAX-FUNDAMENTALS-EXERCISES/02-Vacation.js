function solve(studentsNum, groupType, weekday) {
  let moneyIn = 0;
  let weekDayLowerCase = weekday.toLowerCase();
  let groupTypeToLowerCase = groupType.toLowerCase();

  let output = (price) => {
    console.log(`Total price: ${price.toFixed(2)}`);
  };

  switch (groupTypeToLowerCase) {
    case "students":
      //Calculate money
      if (weekDayLowerCase == "friday") {
        moneyIn = studentsNum * 8.45;
      } else if (weekDayLowerCase == "saturday") {
        moneyIn = studentsNum * 9.8;
      } else if (weekDayLowerCase == "sunday") {
        moneyIn = studentsNum * 10.46;
      }
      //Calculate possible discounts
      if (studentsNum >= 30) moneyIn -= moneyIn * 0.15;
      output(moneyIn);
      break;
    case "business":
      //Calculate possible discounts
      if (studentsNum >= 100) studentsNum -= 10; //10 people can stay for free.
      //Calculate money
      if (weekDayLowerCase == "friday") {
        moneyIn = studentsNum * 10.9;
      } else if (weekDayLowerCase == "saturday") {
        moneyIn = studentsNum * 15.6;
      } else if (weekDayLowerCase == "sunday") {
        moneyIn = studentsNum * 16;
      }
      output(moneyIn);
      break;
    case "regular":
      //Calculate money
      if (weekDayLowerCase == "friday") {
        moneyIn = studentsNum * 15;
      } else if (weekDayLowerCase == "saturday") {
        moneyIn = studentsNum * 20;
      } else if (weekDayLowerCase == "sunday") {
        moneyIn = studentsNum * 22.50;
      }
      //Calculate possible discounts
      if (studentsNum >= 10 && studentsNum <= 20) moneyIn -= moneyIn * 0.05;
      output(moneyIn);
      break;
    default:
      break;
  }
}
