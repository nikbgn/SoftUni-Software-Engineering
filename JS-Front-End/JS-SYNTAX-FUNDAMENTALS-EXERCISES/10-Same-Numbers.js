function solve(number){
    let sum = 0;
    let targetNumber = number % 10;
    let result = true;
    while(number > 0){
        let currentLastDigit = number % 10;
        if(currentLastDigit !== targetNumber){
            result = false;
        }
        sum += currentLastDigit
        number = Math.floor(number / 10);
    }
    console.log(result);
    console.log(sum);
}
