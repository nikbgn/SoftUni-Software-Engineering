function odd_and_even_sum(number) {

    let oddSum = 0;
    let evenSum = 0;

    while(number > 0){
        let currentLastDigit = number % 10;

        if(currentLastDigit % 2 === 0) evenSum += currentLastDigit;
        else oddSum += currentLastDigit;

        number = Math.floor(number/10);

    }


    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}
