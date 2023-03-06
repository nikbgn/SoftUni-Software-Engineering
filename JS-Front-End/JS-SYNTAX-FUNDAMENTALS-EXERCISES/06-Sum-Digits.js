function solve(number){
    let sum = 0;
    while(number > 0){
        let currentLastDigit = number % 10;
        sum += currentLastDigit;
        number = Math.floor(number / 10);
    }
    console.log(sum);
}
